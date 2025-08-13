using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Exceptions;
using Roblox.Billing.Properties;
using Roblox.Common;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.Locking;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.PremiumFeatures;

namespace Roblox.Billing;

public class InCommPaymentProvider : PaymentProviderBase
{
	private const string _ReversalRequest = "InCommReversalRequest";

	private const string _ReversalFailure = "InCommReversalFailure";

	private bool _NetSuccessOrFailure;

	private string _UserName = string.Empty;

	private Payment _InitialCharge;

	private Sale _Sale;

	private PrepaidCardInfo _CardInfo;

	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	private readonly IAssetOwnershipAuthority _AssetOwnershipAuthority;

	private readonly ILogger _Logger;

	public PrepaidCardInfo CardInfo => _CardInfo;

	public static PaymentProviderType Type => PaymentProviderType.InComm;

	internal static TimeSpan LeaseLockTimespan => Settings.Default.IncommPinLeaseLockTimeSpan;

	public InCommPaymentProvider(PrepaidCardInfo info, ILogger logger, CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSale, IAssetOwnershipAuthority assetOwnershipAuthority)
		: base(cancelExistingActiveMembershipSale, logger)
	{
		_CardInfo = info;
		_AssetOwnershipAuthority = assetOwnershipAuthority ?? throw new ArgumentNullException("assetOwnershipAuthority");
		_Logger = logger;
	}

	public InCommPaymentProvider(PrepaidCardInfo info, IEphemeralCounterFactory counterFactory, ILogger logger, CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSale, IAssetOwnershipAuthority assetOwnershipAuthority)
		: base(cancelExistingActiveMembershipSale, logger, counterFactory)
	{
		_CardInfo = info;
		_EphemeralCounterFactory = counterFactory;
		_AssetOwnershipAuthority = assetOwnershipAuthority ?? throw new ArgumentNullException("assetOwnershipAuthority");
		_Logger = logger;
	}

	public InCommPaymentProvider(string pin, bool useDebugMode, ILogger logger, CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSale, IAssetOwnershipAuthority assetOwnershipAuthority)
		: base(cancelExistingActiveMembershipSale, logger)
	{
		if (useDebugMode)
		{
			_CardInfo = new PrepaidCardInfo();
			_CardInfo.Pin = pin;
			_CardInfo.RawResponse = GetCardDebugString(pin);
		}
		else
		{
			_CardInfo = GetCardInfo(pin, null);
		}
		_AssetOwnershipAuthority = assetOwnershipAuthority ?? throw new ArgumentNullException("assetOwnershipAuthority");
		_Logger = logger;
	}

	public static string GetErrorMessageFromResultCode(InCommResultCode resultCode)
	{
		return resultCode switch
		{
			InCommResultCode.Success => "", 
			InCommResultCode.UnrecognizedMerchant => "We currently do not support the merchant you purchased this card from, please contact Customer Service.", 
			InCommResultCode.CardAlreadyRedeemed => "This card has already been redeemed.", 
			InCommResultCode.InvalidCard => "This card is invalid.", 
			InCommResultCode.CardDeactivated => "This card is not active.", 
			InCommResultCode.InCommSystemError => "The payment gateway is down. Please try the transaction again later and contact Customer Service if the problem persists.", 
			InCommResultCode.CardActionsSuspended => "This card is suspended.", 
			_ => "An unexpected error has occured. Please try the transaction again later and contact Customer Service if the problem persists.", 
		};
	}

	public InCommResultCode ProcessCardRedemption(User user, byte platformTypeId)
	{
		if (BillingHelper.UseTestMode)
		{
			PerformReversal();
		}
		if (user == null)
		{
			throw new ApplicationException("Authenticated user required to redeem inComm Card");
		}
		try
		{
			decimal amountRedeemed;
			string inCommRefNumber;
			InCommResultCode resultCode = _PerformPurchase(InCommMessageType.PurchaseRequest, out amountRedeemed, out inCommRefNumber);
			_NetSuccessOrFailure = resultCode == InCommResultCode.Success;
			long accountId = user.AccountID;
			if (_NetSuccessOrFailure)
			{
				Merchant merchant = Merchant.GetFromInCommMerchantKey(_CardInfo.Merchant);
				if (merchant != null)
				{
					resultCode = _RedeemCard(accountId, merchant, inCommRefNumber, amountRedeemed, platformTypeId);
					_GrantAssetAwards(accountId, merchant);
				}
				else
				{
					resultCode = InCommResultCode.UnrecognizedMerchant;
				}
			}
			return resultCode;
		}
		catch (InCommLeaseLockException)
		{
			throw;
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			throw new InCommPaymentException("An unexpected error occured when trying to process card redemption.");
		}
	}

	public InCommResultCode ProcessCardRedemption(long accountId, byte platformTypeId)
	{
		if (accountId == 0L)
		{
			throw new ApplicationException("Authenticated user required to redeem inComm Card");
		}
		if (BillingHelper.UseTestMode)
		{
			PerformReversal();
		}
		try
		{
			decimal amountRedeemed;
			string inCommRefNumber;
			InCommResultCode resultCode = _PerformPurchase(InCommMessageType.PurchaseRequest, out amountRedeemed, out inCommRefNumber);
			_NetSuccessOrFailure = resultCode == InCommResultCode.Success;
			if (_NetSuccessOrFailure)
			{
				Merchant merchant = Merchant.GetFromInCommMerchantKey(_CardInfo.Merchant);
				if (merchant != null)
				{
					resultCode = _RedeemCard(accountId, merchant, inCommRefNumber, amountRedeemed, platformTypeId);
					_GrantAssetAwards(accountId, merchant);
				}
				else
				{
					resultCode = InCommResultCode.UnrecognizedMerchant;
				}
			}
			return resultCode;
		}
		catch (InCommLeaseLockException)
		{
			throw;
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			throw new InCommPaymentException("An unexpected error occured when trying to process card redemption.");
		}
	}

	public bool CheckOut(ShoppingCart shoppingCart, User user)
	{
		throw new NotImplementedException("CheckOut function is not implemented for incomm payment provider");
	}

	public bool CheckOut(ShoppingCart shoppingCart)
	{
		throw new NotImplementedException("CheckOut function is not implemented for incomm payment provider");
	}

	public static PrepaidCardInfo GetCardInfo(string pin, User user)
	{
		return _PerformCardBalanceInquiry(pin);
	}

	public static PrepaidCardInfo GetCardInfo(string pin)
	{
		return _PerformCardBalanceInquiry(pin);
	}

	public static string GetCardDebugString(string pin)
	{
		HttpWebResponse httpWebResponse = _SendTransactionToInComm(_GenerateInCommMessage(InCommMessageType.BalanceInquiry, pin), pin);
		StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
		string responseString = streamReader.ReadToEnd();
		streamReader.Close();
		httpWebResponse.Close();
		return responseString;
	}

	/// <summary>
	/// Reverse the card redemption
	/// </summary>
	/// <returns>True if it's success, otherwise false</returns>
	public bool PerformReversal()
	{
		IncrementCounter("InCommReversalRequest");
		try
		{
			if (_PerformPurchase(InCommMessageType.ReversalRequest, out var _, out var _) != 0)
			{
				IncrementCounter("InCommReversalFailure");
				return false;
			}
			return true;
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
			IncrementCounter("InCommReversalFailure");
			return false;
		}
	}

	private static ILeasedLock CreateLeasedLockForPin(string pin)
	{
		return new SqlLeasedLock($"InCommPinLock_{pin}", ParallelTaskWorker.ID, LeaseLockTimespan);
	}

	private InCommCardProduct _GetInCommCardProduct(long accountId, InCommCard incommCard)
	{
		if (incommCard != null)
		{
			AccountAddOn accountAddOn = AccountAddOn.GetBuildersClubMembershipAccountAddOn(Convert.ToInt32(accountId));
			byte accountAddonTypeID;
			bool accountAddonIsRenewal;
			if (accountAddOn == null || accountAddOn.Expiration < DateTime.Now)
			{
				accountAddonTypeID = AccountAddOnType.NoneID;
				accountAddonIsRenewal = false;
			}
			else
			{
				User.GetByAccountID(accountId);
				PremiumFeature premiumFeature = accountAddOn.GetPremiumFeature();
				if (premiumFeature != null || accountAddOn.IsLifetime)
				{
					accountAddonTypeID = premiumFeature.AccountAddOnTypeID;
					accountAddonIsRenewal = premiumFeature.IsRenewal || accountAddOn.IsLifetime;
				}
				else
				{
					accountAddonTypeID = AccountAddOnType.NoneID;
					accountAddonIsRenewal = false;
				}
			}
			foreach (InCommCardProduct inCommCardProduct in (List<InCommCardProduct>)InCommCardProduct.GetInCommCardProductsByInCommCardID(incommCard.ID))
			{
				if (inCommCardProduct.AccountAddonIsRenewal == accountAddonIsRenewal && inCommCardProduct.AccountAddonTypeID == accountAddonTypeID)
				{
					return inCommCardProduct;
				}
			}
		}
		return null;
	}

	private bool _GrantAssetAwards(long accountId, Merchant merchant)
	{
		AssetAwardList assetAwardList = AssetAwardList.GetCurrentAssetAwardList(merchant.ID);
		bool grantedAsset = false;
		if (assetAwardList != null)
		{
			foreach (Asset asset in assetAwardList.Assets)
			{
				User user = User.GetByAccountID(accountId);
				if (user != null)
				{
					_AssetOwnershipAuthority.AwardAssets(asset.GetConstituentAssetIds(), user.ID, out var awardedNewAsset);
					grantedAsset = grantedAsset || awardedNewAsset;
				}
			}
		}
		return grantedAsset;
	}

	private InCommResultCode _RedeemCard(long accountId, Merchant merchant, string refNum, decimal amountRedeemed, byte platformTypeId)
	{
		InCommResultCode inCommResultCode = InCommResultCode.UnknownError;
		LeasedLock leasedLock = LeasedLock.GetOrCreate("InComm Payment Processing" + _CardInfo.Pin);
		try
		{
			if (leasedLock.TryAcquire(ParallelTaskWorker.ID, 5000))
			{
				bool RedeemForCredit = Settings.Default.InCommRedeemForCredit;
				bool InCommProductRedemptionEnabled = Settings.Default.InCommProductRedemptionEnabled;
				if (BillingHelper.UseTestMode || !GamecardRedemptionLog.HasPreviousTransactions(_CardInfo.Pin))
				{
					InCommCardProduct inCommCardProduct = null;
					InCommCardCreditValue inCommCardCreditValue = null;
					InCommCard incommCard = _GetInCommCardFromCardInfo();
					if (RedeemForCredit && incommCard != null)
					{
						inCommCardCreditValue = InCommCardCreditValue.GetOrCreate(incommCard.ID);
					}
					if (InCommProductRedemptionEnabled && (inCommCardCreditValue == null || !inCommCardCreditValue.CreditValue.HasValue))
					{
						inCommCardProduct = _GetInCommCardProduct(accountId, incommCard);
					}
					if ((inCommCardCreditValue == null || !inCommCardCreditValue.CreditValue.HasValue) && inCommCardProduct != null)
					{
						_RedeemForProduct(accountId, inCommCardProduct, merchant, refNum, amountRedeemed, platformTypeId);
					}
					else
					{
						_RedeemForCredit(accountId, merchant, refNum, (inCommCardCreditValue == null || !inCommCardCreditValue.CreditValue.HasValue) ? amountRedeemed : inCommCardCreditValue.CreditValue.Value);
					}
					inCommResultCode = InCommResultCode.Success;
				}
				else
				{
					inCommResultCode = InCommResultCode.CardAlreadyRedeemed;
				}
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		finally
		{
			leasedLock.TryRelease(ParallelTaskWorker.ID);
		}
		return inCommResultCode;
	}

	private void _RedeemForCredit(long accountId, Merchant merchant, string refNumber, decimal amountRedeemed)
	{
		CreditBalance.GetOrCreate(accountId).Credit(amountRedeemed);
		GamecardRedemptionLog.CreateNew(accountId, merchant.ID, amountRedeemed, _CardInfo.Pin);
		CreditTransactionHistory.Submit(accountId, CreditTransactionType.CreditID, refNumber, CreditTransactionOriginType.InCommID, amountRedeemed);
	}

	private void _RedeemForProduct(long accountId, InCommCardProduct inCommCardProduct, Merchant merchant, string refNumber, decimal amountRedeemed, byte platformTypeId)
	{
		Product product = Product.Get(inCommCardProduct.ProductID);
		_Sale = Sale.CreateNew(SaleStatusType.Pending.ID, accountId, product.Price, product.Price, null, null, platformTypeId);
		SaleProduct.CreateNew(_Sale.ID, product.ID, product.Price, product.Price, accountId);
		if (Settings.Default.IsBCSigningBonusEnabled && AccountAddOn.GetBuildersClubMembershipAccountAddOn(Convert.ToInt32(accountId)) == null && product.GetPremiumFeature().IsAnyBuildersClub)
		{
			Product signingbonus = Product.GetByPremiumFeatureID(PremiumFeature.GetByName("100 ROBUX").ID);
			SaleProduct.CreateNew(_Sale.ID, signingbonus.ID, signingbonus.Price, 0m, accountId);
		}
		_Pay(User.GetByAccountID(accountId), refNumber);
		_Sale.SaleStatusTypeID = SaleStatusType.Complete.ID;
		_Sale.Save();
		GamecardRedemptionLog.CreateNew(accountId, merchant.ID, amountRedeemed, _CardInfo.Pin);
		_CardInfo.Product = product;
		TryToPublishBillingTransaction(_Sale, _Logger, null);
	}

	private InCommResultCode _PerformPurchase(InCommMessageType messageType, out decimal amountRedeemed, out string refNum)
	{
		HttpWebResponse response;
		try
		{
			response = _SendTransactionToInComm(_GenerateInCommMessage(messageType, _CardInfo.Pin), _CardInfo.Pin);
		}
		catch (InCommLeaseLockException)
		{
			throw;
		}
		catch
		{
			throw new InCommPaymentException("Unexpected error while connecting incomm.");
		}
		if (Settings.Default.EnableIncommResponseLoggingOnException)
		{
			return ParseInCommResult(messageType, response, out amountRedeemed, out refNum);
		}
		InCommResultCode incommResultCode;
		using (XmlReader reader = new XmlTextReader(response.GetResponseStream()))
		{
			reader.Read();
			reader.ReadToFollowing("RespCode");
			int resultCode = reader.ReadElementContentAsInt();
			try
			{
				incommResultCode = (InCommResultCode)resultCode;
			}
			catch (Exception)
			{
				_Logger.Error("Failed to parse ResultCode from Incomm Response. Result Code: " + resultCode);
				incommResultCode = InCommResultCode.UnrecognizedResponse;
			}
			if (incommResultCode == InCommResultCode.Success)
			{
				reader.ReadToFollowing("RespRefNum");
				refNum = reader.ReadElementContentAsString();
			}
			else
			{
				refNum = resultCode.ToString();
			}
			reader.ReadToFollowing("FaceValue");
			amountRedeemed = reader.ReadElementContentAsDecimal();
		}
		response.Close();
		return incommResultCode;
	}

	/// <summary>
	/// Get RespCode, RespRefNum and FaceValue from the Incomm response. If fails, log the xml response.
	/// </summary>
	/// <param name="messageType">The Incomm request type</param>
	/// <param name="response">The Incomm response</param>
	/// <param name="amountRedeemed">The amount of the card</param>
	/// <param name="refNum">The ref number</param>
	/// <returns>InCommResultCode</returns>
	private InCommResultCode ParseInCommResult(InCommMessageType messageType, HttpWebResponse response, out decimal amountRedeemed, out string refNum)
	{
		InCommResultCode incommResultCode = InCommResultCode.UnknownError;
		string respRefNum = "";
		decimal faceValue = default(decimal);
		XDocument xDoc = new XDocument();
		try
		{
			using XmlReader reader = new XmlTextReader(response.GetResponseStream());
			xDoc = XDocument.Load(reader);
			List<XElement> xElements = xDoc.Descendants().ToList();
			string resultCode = xElements.FirstOrDefault((XElement n) => n.Name == "RespCode").Value;
			try
			{
				incommResultCode = (InCommResultCode)int.Parse(resultCode);
			}
			catch (Exception)
			{
				_Logger.Error("Failed to parse ResultCode from Incomm Response. Result Code: " + resultCode);
				incommResultCode = InCommResultCode.UnrecognizedResponse;
			}
			respRefNum = xElements.FirstOrDefault((XElement n) => n.Name == "RespRefNum")?.Value ?? respRefNum;
			XElement faceValueNode = xElements.FirstOrDefault((XElement n) => n.Name == "FaceValue");
			faceValue = ((faceValueNode == null) ? faceValue : decimal.Parse(faceValueNode.Value));
		}
		catch (Exception ex)
		{
			_Logger.Error($"{ex}\nIncomm request type: {messageType}\nIncomm response: {xDoc}");
			if (messageType == InCommMessageType.PurchaseRequest && Settings.Default.EnableIncommReversalOnException && incommResultCode == InCommResultCode.Success)
			{
				PerformReversal();
			}
			incommResultCode = ((messageType == InCommMessageType.ReversalRequest) ? incommResultCode : InCommResultCode.UnknownError);
		}
		response.Close();
		amountRedeemed = faceValue;
		refNum = respRefNum;
		return incommResultCode;
	}

	private InCommCard _GetInCommCardFromCardInfo()
	{
		Merchant merchant = Merchant.GetFromInCommMerchantKey(_CardInfo.Merchant);
		decimal value = _CardInfo.Balance;
		CurrencyType currencyType = CurrencyType.GetByCode(_CardInfo.CurrencyCode);
		if (currencyType == null)
		{
			return InCommCard.GetByMerchantIDAndValue(merchant.ID, value);
		}
		return InCommCard.GetByMerchantIDCurrencyTypeIDAndValue(merchant.ID, currencyType.ID, value);
	}

	private static string _GenerateInCommMessage(InCommMessageType type, string pin)
	{
		XmlTextWriter xmlTextWriter = new XmlTextWriter(new MemoryStream(), new UTF8Encoding(encoderShouldEmitUTF8Identifier: false));
		xmlTextWriter.Formatting = Formatting.Indented;
		xmlTextWriter.WriteStartDocument();
		xmlTextWriter.WriteStartElement("TransferredValueTxn");
		xmlTextWriter.WriteStartElement("TransferredValueTxnReq");
		xmlTextWriter.WriteElementString("ReqCat", "FastCard");
		xmlTextWriter.WriteElementString("ReqAction", type.ToDescription());
		xmlTextWriter.WriteElementString("Date", DateTime.Now.Date.ToString("yyyyMMdd"));
		xmlTextWriter.WriteElementString("Time", DateTime.Now.ToString("HHmmss"));
		xmlTextWriter.WriteElementString("PartnerName", "Roblox");
		xmlTextWriter.WriteStartElement("CardActionInfo");
		xmlTextWriter.WriteElementString("PIN", pin);
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteEndElement();
		xmlTextWriter.WriteFullEndElement();
		xmlTextWriter.WriteEndDocument();
		xmlTextWriter.Flush();
		xmlTextWriter.BaseStream.Position = 0L;
		return StreamUtilities.StreamToString(xmlTextWriter.BaseStream, DecompressionMethods.None);
	}

	private static PrepaidCardInfo _PerformCardBalanceInquiry(string pin)
	{
		PrepaidCardInfo card = new PrepaidCardInfo();
		HttpWebResponse httpWebResponse = _SendTransactionToInComm(_GenerateInCommMessage(InCommMessageType.BalanceInquiry, pin), pin);
		string responseString = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
		httpWebResponse.Close();
		using (XmlReader reader = new XmlTextReader(new StringReader(responseString)))
		{
			reader.Read();
			reader.ReadToFollowing("RespCode");
			int responseCode = reader.ReadElementContentAsInt();
			switch (responseCode)
			{
			case 4001:
				card.Status = InCommResultCode.CardActive.ToString();
				break;
			case 4002:
			case 4003:
				card.Status = InCommResultCode.CardDeactivated.ToString();
				break;
			case 4006:
				throw new ApplicationException("Card not found");
			default:
				throw new ApplicationException("Error in transaction. Response code: " + responseCode);
			}
			reader.ReadToFollowing("Denom");
			card.CurrencyCode = reader.ReadElementContentAsString();
			card.Balance = reader.ReadElementContentAsDecimal();
			reader.ReadToFollowing("MerchantName");
			card.Merchant = reader.ReadElementContentAsString();
			reader.ReadToFollowing("PIN");
			card.Pin = reader.ReadElementContentAsString();
		}
		card.RawResponse = responseString;
		return card;
	}

	private static HttpWebResponse _SendTransactionToInComm(string message, string pin)
	{
		using ILeasedLock pinLock = CreateLeasedLockForPin(pin);
		if (!pinLock.IsLockAcquired)
		{
			throw new InCommLeaseLockException($"Pin {pin}'s lease lock already acquired. Cannot send message to InComm:\n{message}");
		}
		return _SendTransactionToInComm(message);
	}

	private static HttpWebResponse _SendTransactionToInComm(string message)
	{
		WebRequest balanceRequest = WebRequest.Create(Settings.Default.InCommURL);
		balanceRequest.Method = "POST";
		balanceRequest.ContentType = "text/xml";
		byte[] bytes = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false).GetBytes(message);
		using (Stream newStream = balanceRequest.GetRequestStream())
		{
			newStream.Write(bytes, 0, bytes.Length);
		}
		HttpWebResponse response = (HttpWebResponse)balanceRequest.GetResponse();
		if (response.StatusCode != HttpStatusCode.OK)
		{
			throw new ApplicationException($"POST failed. Received HTTP {response.StatusCode}");
		}
		return response;
	}

	private void _LogTransaction(string transactionId, InCommResultCode transactionResult)
	{
		TransactionLog transactionLog = new TransactionLog();
		transactionLog.Amount = _InitialCharge.Amount;
		transactionLog.UserAccountID = _Sale.PurchaserAccountID;
		transactionLog.AccountID = _UserName;
		transactionLog.ClientIP = HttpContext.Current.GetOriginIP();
		transactionLog.TransactionType = "InComm Redemption";
		transactionLog.TransactionID = transactionId;
		transactionLog.SaleID = _Sale.ID;
		transactionLog.PaymentID = _InitialCharge.ID;
		transactionLog.PaymentStatusTypeID = _InitialCharge.PaymentStatusTypeID;
		transactionLog.TransactionDate = DateTime.Now;
		transactionLog.ErrorMessage = transactionResult.ToString();
		transactionLog.Save();
	}

	private void _Pay(User user, string inCommRefNumber)
	{
		SaleProductPremiumFeatureQueue.GrantPremiumFeatures(_Sale.Products);
		_InitialCharge = new Payment();
		_InitialCharge.PaymentDate = DateTime.Now;
		_InitialCharge.PaymentProviderTypeID = PaymentProviderType.InComm.ID;
		_InitialCharge.PaymentStatusTypeID = PaymentStatusType.Complete.ID;
		_InitialCharge.Amount = _Sale.DiscountedPriceTotal;
		_InitialCharge.SaleID = _Sale.ID;
		_InitialCharge.Save();
		if (_Sale.Products.Any((SaleProduct x) => x.Product.ProductGroupID == ProductGroup.BC.ID))
		{
			CancelExistingRecurringMembershipSale(_Sale);
		}
		_LogTransaction(inCommRefNumber, InCommResultCode.Success);
		TryToPublishBillingTransaction(_Sale, _Logger, null);
	}

	private void IncrementCounter(string counterName)
	{
		if (_EphemeralCounterFactory != null)
		{
			ICounter counter = _EphemeralCounterFactory.GetCounter(counterName);
			RobloxThreadPool.QueueUserWorkItem(delegate
			{
				counter.Increment();
			});
		}
	}
}
