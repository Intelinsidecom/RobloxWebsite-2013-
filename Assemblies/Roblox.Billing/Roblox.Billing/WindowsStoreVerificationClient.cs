using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;
using Roblox.Billing.Properties;
using Roblox.Billing.WindowsStorePaymentExceptions;
using Roblox.Caching.Shared;
using Roblox.Common;

namespace Roblox.Billing;

public class WindowsStoreVerificationClient : IWindowsStoreVerificationClient
{
	private readonly ISharedCacheClient _SharedCacheClient;

	internal virtual bool IsReceiptAuthenticityValidationEnabled => Settings.Default.IsWindowsStoreReceiptSignatureValidationEnabled;

	internal virtual bool IsReceiptAppIdValidationEnabled => Settings.Default.IsReceiptAppIdValidationEnabled;

	internal virtual string RobloxAppId => Settings.Default.WindowsStoreAppIdForValidation;

	static WindowsStoreVerificationClient()
	{
		CryptoConfig.AddAlgorithm(typeof(RSAPKCS1SHA256SignatureDescription), "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256");
	}

	public WindowsStoreVerificationClient(ISharedCacheClient sharedCacheClient)
	{
		_SharedCacheClient = sharedCacheClient;
	}

	private X509Certificate2 RetrieveCertificate(string certificateId)
	{
		string certificateCacheKey = $"WindowsStorePaymentCertificate_CertificateId:{certificateId}";
		if (_SharedCacheClient.Query(certificateCacheKey, out var cachedCertificate))
		{
			return new X509Certificate2(cachedCertificate.GetBytes());
		}
		string certificateResponse;
		try
		{
			using WebClient wc = new WebClient();
			string certificateUrl = string.Format(Settings.Default.WindowsStoreCertificateLinkFormat, certificateId);
			certificateResponse = wc.DownloadString(certificateUrl);
		}
		catch (WebException ex)
		{
			throw new WindowsStoreCertificateRetrievalException(((HttpWebResponse)ex.Response).StatusCode);
		}
		_SharedCacheClient.Set(certificateCacheKey, certificateResponse, TimeSpan.FromHours(1.0));
		return new X509Certificate2(certificateResponse.GetBytes());
	}

	private void VerifyReceiptSignature(XmlDocument receipt, X509Certificate2 certificate)
	{
		SignedXml sxml = new SignedXml(receipt);
		XmlNode dsig;
		using (XmlNodeList sigNodeList = receipt.GetElementsByTagName("Signature", "http://www.w3.org/2000/09/xmldsig#"))
		{
			dsig = sigNodeList[0];
		}
		if (dsig == null)
		{
			throw new WindowsStoreReceiptSignatureMissingException();
		}
		try
		{
			sxml.LoadXml((XmlElement)dsig);
		}
		catch (XmlException)
		{
			throw new WindowsStoreReceiptSignatureMissingException();
		}
		if (!sxml.CheckSignature(certificate, verifySignatureOnly: true))
		{
			throw new WindowsStoreReceiptValidationFailedException();
		}
	}

	public IEnumerable<WindowsStorePayment> VerifyReceiptAuthenticity(IPurchaser purchaser, string receiptXml, IEnumerable<Guid> transactionIds)
	{
		XmlDocument document = new XmlDocument();
		document.LoadXml(receiptXml);
		XmlNode rootNode = document.DocumentElement;
		string certificateId = rootNode.Attributes["CertificateId"].Value;
		if (IsReceiptAuthenticityValidationEnabled)
		{
			X509Certificate2 verificationCertificate = RetrieveCertificate(certificateId);
			VerifyReceiptSignature(document, verificationCertificate);
		}
		else
		{
			ExceptionHandler.LogException("Windows store: Receipt authenticity verification is disabled. Proceeding without verifying. If this is production, please reenable verification and yell at the person who turned it off.");
		}
		receiptXml = receiptXml.Replace("xmlns=\"http://schemas.microsoft.com/windows/2012/store/receipt\"", "");
		document = new XmlDocument();
		document.LoadXml(receiptXml);
		rootNode = document.DocumentElement;
		List<WindowsStorePayment> returnedPayments = new List<WindowsStorePayment>();
		foreach (Guid transactionId in transactionIds)
		{
			string xPathQuery = $"//ProductReceipt[@Id='{transactionId}']";
			using XmlNodeList productReceiptList = rootNode.SelectNodes(xPathQuery);
			if (productReceiptList == null)
			{
				throw new WindowsStoreReceiptMissingTransactionFailedException();
			}
			IEnumerator enumerator2 = productReceiptList.GetEnumerator();
			if (!enumerator2.MoveNext())
			{
				throw new WindowsStoreReceiptMissingTransactionFailedException();
			}
			XmlNode productNode = (XmlNode)enumerator2.Current;
			if (IsReceiptAppIdValidationEnabled && (productNode.Attributes["AppId"] == null || productNode.Attributes["AppId"].Value != RobloxAppId))
			{
				throw new WindowsStoreAppIdMismatchException();
			}
			WindowsStorePayment newPayment = new WindowsStorePayment
			{
				PurchaseDate = DateTime.Parse(productNode.Attributes["PurchaseDate"].Value),
				TransactionId = transactionId,
				ProductId = productNode.Attributes["ProductId"].Value,
				Receipt = receiptXml
			};
			returnedPayments.Add(newPayment);
		}
		return returnedPayments;
	}
}
