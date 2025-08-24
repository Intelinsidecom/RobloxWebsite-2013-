using System;

namespace Roblox.Billing.Providers;

/// <summary>
/// This class is responsible for executing fraud detection func.
/// </summary>
internal class FraudDetectionProvider
{
	private Func<FraudDetectionData, IFraudDetectorResult> _FraudDetectionAction;

	public FraudDetectionProvider(Func<FraudDetectionData, IFraudDetectorResult> fraudDetectionAction)
	{
		_FraudDetectionAction = fraudDetectionAction;
	}

	public IFraudDetectorResult GetFraudDetectionResult(string userName, Sale sale, string sessionId, PaymentInfo paymentInfo)
	{
		if (_FraudDetectionAction != null)
		{
			FraudDetectionDataParam fraudDetectionDataParam = new FraudDetectionDataParam
			{
				UserName = userName,
				Sale = sale,
				SessionId = sessionId,
				PaymentInfo = paymentInfo
			};
			FraudDetectionData eventArgs = GetFraudDetectionData(fraudDetectionDataParam);
			return _FraudDetectionAction(eventArgs);
		}
		return new FraudDetectionResult
		{
			IsFraudulent = false
		};
	}

	internal FraudDetectionData GetFraudDetectionData(FraudDetectionDataParam fraudDetectionDataParam)
	{
		PaymentInfo paymentInfo = fraudDetectionDataParam.PaymentInfo;
		string userName = fraudDetectionDataParam.UserName;
		Sale sale = fraudDetectionDataParam.Sale;
		string sessionId = fraudDetectionDataParam.SessionId;
		string transactionId = fraudDetectionDataParam.TransactionId;
		decimal transactionAmount = fraudDetectionDataParam.TransactionAmount;
		TransactionStatus tranactionStatus = fraudDetectionDataParam.TranactionStatus;
		bool isFirstTimePurchase = fraudDetectionDataParam.Sale == null || !fraudDetectionDataParam.Sale.PurchaserAccountID.HasValue || Sale.GetSalesByPurchaser(fraudDetectionDataParam.Sale.PurchaserAccountID.Value).Count <= 1;
		User user = User.Get(userName);
		FraudDetectionData fraudDetectionData = new FraudDetectionData
		{
			FirstName = paymentInfo.FirstName,
			LastName = paymentInfo.LastName,
			Email = paymentInfo.Email,
			Phone = paymentInfo.Phone,
			IpAddress = paymentInfo.ClientIP,
			User = user,
			Sale = sale,
			SessionId = sessionId,
			TranactionStatus = tranactionStatus,
			TransactionId = transactionId,
			TransactionAmount = transactionAmount,
			IsFirstTimePurchase = isFirstTimePurchase
		};
		Type paymentInfoType = paymentInfo.GetType();
		if (paymentInfoType == typeof(CreditCardPaymentInfo))
		{
			SetCreditCardPaymentInfoFields(fraudDetectionData, (CreditCardPaymentInfo)paymentInfo);
		}
		else if (paymentInfoType == typeof(PayPalPaymentInfo))
		{
			SetPayPalPaymentInfoFields(fraudDetectionData, (PayPalPaymentInfo)paymentInfo);
		}
		return fraudDetectionData;
	}

	private void SetCreditCardPaymentInfoFields(FraudDetectionData fraudDetectionData, CreditCardPaymentInfo ccPaymentInfo)
	{
		fraudDetectionData.PaymentType = PaymentType.CreditCard;
		fraudDetectionData.AccountNumber = ccPaymentInfo.AccountNumber;
		fraudDetectionData.SecurityCode = ccPaymentInfo.SecurityCode;
		fraudDetectionData.AddressLine1 = ccPaymentInfo.AddressLine1;
		fraudDetectionData.AddressLine2 = ccPaymentInfo.AddressLine2;
		fraudDetectionData.City = ccPaymentInfo.City;
		fraudDetectionData.Country = ccPaymentInfo.Country;
		fraudDetectionData.State = ccPaymentInfo.State;
		fraudDetectionData.PostalCode = ccPaymentInfo.PostalCode;
	}

	private void SetPayPalPaymentInfoFields(FraudDetectionData fraudDetectionData, PayPalPaymentInfo ppPaymentInfo)
	{
		fraudDetectionData.PaymentType = PaymentType.PayPal;
		fraudDetectionData.PayerId = ppPaymentInfo.PayerId;
	}
}
