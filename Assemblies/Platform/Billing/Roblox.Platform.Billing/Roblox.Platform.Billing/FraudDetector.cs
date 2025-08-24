using System;
using System.Linq;
using Roblox.Billing;
using Roblox.Platform.Billing.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Billing;

public class FraudDetector : IFraudDetector
{
	private ITransactionsProvider _TransactionsProvider;

	protected virtual int _MinAccountAgeInDays => Settings.Default.FraudDetectorMinAccountAgeInDays;

	protected virtual byte _FraudDetectorVelocityRuleMaxAllowedTransactions => Settings.Default.FraudDetectorVelocityRuleMaxAllowedTransactions;

	protected virtual byte _FraudDetectorMaxAllowedDeclinedTransactionsByAccountID => Settings.Default.FraudDetectorMaxAllowedDeclinedTransactionsByAccountID;

	protected virtual double _FraudDetectorMaxAllowedRatioOfRefundedTransactionsByAccountID => Settings.Default.FraudDetectorMaxAllowedRatioOfRefundedTransactionsByAccountID;

	protected virtual byte _FraudDetectorMaxAllowedCreditCardsPerAccountIDInLast6Months => Settings.Default.FraudDetectorMaxAllowedCreditCardsPerAccountIDInLast6Months;

	public static event Action<FraudDetectorType, FraudDetectorActionType, PaymentType> OnFraudDetectorActionCompleted;

	public static event Action<FraudDetectorType, FraudDetectorActionType, PaymentType> OnFraudDetectorActionStarted;

	public FraudDetector(ITransactionsProvider transactionsProvider = null)
	{
		_TransactionsProvider = transactionsProvider ?? new TransactionsProvider();
	}

	private void FraudDetectorActionCompleted(FraudDetectorType fraudDetectorType, FraudDetectorActionType fraudDetectorActionType, PaymentType paymentType)
	{
		if (FraudDetector.OnFraudDetectorActionCompleted != null)
		{
			FraudDetector.OnFraudDetectorActionCompleted(fraudDetectorType, fraudDetectorActionType, paymentType);
		}
	}

	private void FraudDetectorActionStarted(FraudDetectorType fraudDetectorType, FraudDetectorActionType fraudDetectorActionType, PaymentType paymentType)
	{
		if (FraudDetector.OnFraudDetectorActionStarted != null)
		{
			FraudDetector.OnFraudDetectorActionStarted(fraudDetectorType, fraudDetectorActionType, paymentType);
		}
	}

	public IFraudDetectorResult IsTransactionFraudulent(IUser user, decimal transactionValue, string maskedCreditCardNumber, string email, string addressLine1, string city, string zipPostal, string country, PaymentType paymentType)
	{
		FraudDetectorActionStarted(FraudDetectorType.Inhouse, FraudDetectorActionType.DetectionRequest, paymentType);
		RobloxFraudDetectorResult result = new RobloxFraudDetectorResult
		{
			FraudDetectorResultType = FraudDetectorResultType.NoRulesChecked
		};
		if (!Settings.Default.FraudDetectorEnabled || string.IsNullOrEmpty(maskedCreditCardNumber) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(addressLine1) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(zipPostal) || string.IsNullOrEmpty(country))
		{
			return result;
		}
		user.VerifyIsNotNull();
		decimal totalPurchasesInTheLastMonth = (from x in _TransactionsProvider.GetCompletedTransactionsInTheLastMonthExcludingStoreCreditByAccountId(Convert.ToInt32(user.AccountId))
			where x.Amount.HasValue
			select x).Sum((ITransactionLog x) => x.Amount).Value;
		result = VerifyAmountIsLargeEnoughToBeFraudChecked(totalPurchasesInTheLastMonth + transactionValue);
		if (result.FraudDetectorResultType == FraudDetectorResultType.AmountTooSmall)
		{
			return result;
		}
		result = VerifyAmountIsNotLargeEnoughToWarrantAutomaticRejection(totalPurchasesInTheLastMonth + transactionValue);
		if (result.IsFraudulent)
		{
			return result;
		}
		result = CheckIfAccountIsOldEnough(user);
		if (result.IsFraudulent)
		{
			return result;
		}
		result = CheckIfEmailIsAssociatedWithDisputedTransactions(email);
		if (result.IsFraudulent)
		{
			return result;
		}
		result = CheckIfAddressIsAssociatedWithDisputedTransactions(addressLine1, city, zipPostal, country);
		if (result.IsFraudulent)
		{
			return result;
		}
		result = CheckIfThisCreditCardAndAccountAreTrustworthy(maskedCreditCardNumber, Convert.ToInt32(user.AccountId));
		if (result.FraudDetectorResultType == FraudDetectorResultType.AccountAndCardAssociatedWithGoodPayments)
		{
			return result;
		}
		result = CheckIfVelocityByAccountIdExceedsThreshold(Convert.ToInt32(user.AccountId));
		if (result.IsFraudulent)
		{
			return result;
		}
		result = CheckIfVelocityByEmailExceedsThreshold(email);
		if (result.IsFraudulent)
		{
			return result;
		}
		result = CheckIfAccountHasTooManyTransactionErrors(Convert.ToInt32(user.AccountId));
		if (result.IsFraudulent)
		{
			return result;
		}
		result = CheckIfRefundRatioExceedsThreshold(Convert.ToInt32(user.AccountId));
		if (result.IsFraudulent)
		{
			return result;
		}
		result = CheckIfNumberOfCreditCardsUsedInLastSixMonthsExceedsThreshold(Convert.ToInt32(user.AccountId));
		if (result.IsFraudulent)
		{
			return result;
		}
		result.FraudDetectorResultType = FraudDetectorResultType.NoFraudDetected;
		if (result.IsFraudulent)
		{
			FraudDetectorActionCompleted(FraudDetectorType.Inhouse, FraudDetectorActionType.DetectionFraud, paymentType);
		}
		return result;
	}

	protected virtual RobloxFraudDetectorResult VerifyAmountIsLargeEnoughToBeFraudChecked(decimal totalPurchasesInTheLastMonthPlusThisOne)
	{
		RobloxFraudDetectorResult result = new RobloxFraudDetectorResult
		{
			FraudDetectorResultType = FraudDetectorResultType.NoFraudDetected
		};
		if (totalPurchasesInTheLastMonthPlusThisOne < (decimal)Settings.Default.FraudDetectorAllowIfMonthlyPlusCurrentTransactionLessThan)
		{
			result.FraudDetectorResultType = FraudDetectorResultType.AmountTooSmall;
		}
		return result;
	}

	protected virtual RobloxFraudDetectorResult VerifyAmountIsNotLargeEnoughToWarrantAutomaticRejection(decimal totalPurchasesInTheLastMonthPlusThisOne)
	{
		RobloxFraudDetectorResult result = new RobloxFraudDetectorResult
		{
			FraudDetectorResultType = FraudDetectorResultType.NoFraudDetected
		};
		if (totalPurchasesInTheLastMonthPlusThisOne >= (decimal)Settings.Default.FraudDetectorDisallowIfMonthlyPlusCurrentTransactionGreaterOrEqualTo)
		{
			result.FraudDetectorResultType = FraudDetectorResultType.AmountTooLarge;
		}
		return result;
	}

	protected virtual RobloxFraudDetectorResult CheckIfAccountIsOldEnough(IUser user)
	{
		RobloxFraudDetectorResult result = new RobloxFraudDetectorResult();
		if ((DateTime.Now - user.Created).TotalDays < (double)_MinAccountAgeInDays)
		{
			result.FraudDetectorResultType = FraudDetectorResultType.AccountTooNew;
		}
		return result;
	}

	protected virtual RobloxFraudDetectorResult CheckIfEmailIsAssociatedWithDisputedTransactions(string email)
	{
		RobloxFraudDetectorResult result = new RobloxFraudDetectorResult();
		if (_TransactionsProvider.GetTransactionsCountByEmailAndPaymentStatusType(email, PaymentStatusType.ChargedBack) > 0)
		{
			result.FraudDetectorResultType = FraudDetectorResultType.BillingEmailAssociatedWithDisputes;
		}
		return result;
	}

	protected virtual RobloxFraudDetectorResult CheckIfAddressIsAssociatedWithDisputedTransactions(string addressLine1, string city, string zipPostal, string country)
	{
		RobloxFraudDetectorResult result = new RobloxFraudDetectorResult();
		if (_TransactionsProvider.GetTransactionsCountByAddressCityZipPostalCountryAndPaymentStatusType(addressLine1, city, zipPostal, country, PaymentStatusType.ChargedBack) > 0)
		{
			result.FraudDetectorResultType = FraudDetectorResultType.BillingAddressAssociatedWithDisputes;
		}
		return result;
	}

	protected virtual RobloxFraudDetectorResult CheckIfThisCreditCardAndAccountAreTrustworthy(string maskedCreditCardNumber, int accountId)
	{
		RobloxFraudDetectorResult result = new RobloxFraudDetectorResult
		{
			FraudDetectorResultType = FraudDetectorResultType.NoFraudDetected
		};
		if (_TransactionsProvider.GetTransactionsCountByNumberPaymentStatusTypeAccountIdAndCreatedBeforeDate(maskedCreditCardNumber, PaymentStatusType.Complete, accountId, DateTime.Now.AddMonths(-3)) > 0)
		{
			result.FraudDetectorResultType = FraudDetectorResultType.AccountAndCardAssociatedWithGoodPayments;
		}
		return result;
	}

	protected virtual RobloxFraudDetectorResult CheckIfVelocityByAccountIdExceedsThreshold(int accountId)
	{
		RobloxFraudDetectorResult result = new RobloxFraudDetectorResult();
		byte velocityThreshold = _FraudDetectorVelocityRuleMaxAllowedTransactions;
		if (_TransactionsProvider.GetPendingAndCompletedTransactionsByAccountIdAndCreatedAfterDate(accountId, DateTime.Now.AddDays(-1.0)).Count() > velocityThreshold)
		{
			result.FraudDetectorResultType = FraudDetectorResultType.VelocityByAccountIDExceedsThreshold;
		}
		return result;
	}

	protected virtual RobloxFraudDetectorResult CheckIfVelocityByEmailExceedsThreshold(string email)
	{
		RobloxFraudDetectorResult result = new RobloxFraudDetectorResult();
		byte velocityThreshold = _FraudDetectorVelocityRuleMaxAllowedTransactions;
		if (_TransactionsProvider.GetPendingAndCompletedTransactionsByEmailAndCreatedAfterDate(email, DateTime.Now.AddDays(-1.0)).Count() > velocityThreshold)
		{
			result.FraudDetectorResultType = FraudDetectorResultType.VelocityByBillingEmailExceedsThreshold;
		}
		return result;
	}

	protected virtual RobloxFraudDetectorResult CheckIfAccountHasTooManyTransactionErrors(int accountId)
	{
		RobloxFraudDetectorResult result = new RobloxFraudDetectorResult();
		if (_TransactionsProvider.GetTransactionsCountByAccountIdAndPaymentStatusType(accountId, PaymentStatusType.Error) > _FraudDetectorMaxAllowedDeclinedTransactionsByAccountID)
		{
			result.FraudDetectorResultType = FraudDetectorResultType.NumberOfDeclinesByAccountIDExceedsThreshold;
		}
		return result;
	}

	protected virtual RobloxFraudDetectorResult CheckIfRefundRatioExceedsThreshold(int accountId)
	{
		RobloxFraudDetectorResult result = new RobloxFraudDetectorResult();
		int totalNumberOfTransactionsByAccountId = _TransactionsProvider.GetTransactionsCountByAccountId(accountId);
		if (totalNumberOfTransactionsByAccountId > 0 && (double)_TransactionsProvider.GetTransactionsCountByAccountIdAndPaymentStatusType(accountId, PaymentStatusType.Refunded) / (double)totalNumberOfTransactionsByAccountId > _FraudDetectorMaxAllowedRatioOfRefundedTransactionsByAccountID)
		{
			result.FraudDetectorResultType = FraudDetectorResultType.LifetimeRefundRatioExceedsThreshold;
		}
		return result;
	}

	protected virtual RobloxFraudDetectorResult CheckIfNumberOfCreditCardsUsedInLastSixMonthsExceedsThreshold(int accountId)
	{
		RobloxFraudDetectorResult result = new RobloxFraudDetectorResult();
		if ((from x in _TransactionsProvider.GetTransactionsByAccountIdAndCreatedAfterDate(accountId, DateTime.Now.AddMonths(-6))
			where !string.IsNullOrEmpty(x.Number)
			select x.Number).Distinct().Count() > _FraudDetectorMaxAllowedCreditCardsPerAccountIDInLast6Months)
		{
			result.FraudDetectorResultType = FraudDetectorResultType.NumberOfCCsUsedExceedsThreshold;
		}
		return result;
	}
}
