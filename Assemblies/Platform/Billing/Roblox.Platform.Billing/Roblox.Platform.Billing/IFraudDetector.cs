using Roblox.Billing;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Billing;

public interface IFraudDetector
{
	IFraudDetectorResult IsTransactionFraudulent(IUser user, decimal transactionValue, string maskedCreditCardNumber, string email, string addressLine1, string city, string zipPostal, string country, PaymentType paymentType);
}
