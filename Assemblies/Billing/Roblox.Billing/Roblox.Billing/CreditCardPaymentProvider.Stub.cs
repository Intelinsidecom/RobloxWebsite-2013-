using System;

namespace Roblox.Billing
{
    // Minimal, SDK-free stub to satisfy references from Roblox.Platform.Billing
    // This does NOT perform any real payment processing.
    public class CreditCardPaymentProvider
    {
        private readonly Roblox.EventLog.ILogger _logger;

        public bool NetSuccessOrFailure { get; private set; }

        // Expose a Sale instance with at least an ID to satisfy callers that fetch by Sale.ID
        public Roblox.Billing.Sale Sale { get; private set; }

        public CreditCardPaymentProvider(Roblox.EventLog.ILogger logger,
            Roblox.Billing.CreditCardPaymentInfo paymentInfo,
            Func<Roblox.Billing.FraudDetectionData, Roblox.Billing.IFraudDetectorResult> fraudDetectionAction,
            Roblox.Billing.CancelExistingActiveMembershipSaleHandler cancelExistingRecurringMembershipSale,
            string sessionId = null)
        {
            _logger = logger;
            // No-op in stub
            Sale = new Roblox.Billing.Sale();
            NetSuccessOrFailure = true;
        }

        // Overload used for non-renewable purchases
        public void CheckOut(ShoppingCart shoppingCart, string creditCardFullName, bool adminOverride, byte countryId, int currencyTypeId, byte platformTypeId)
        {
            // Simulate success and ensure Sale exists
            if (Sale == null)
            {
                Sale = new Roblox.Billing.Sale();
            }
            NetSuccessOrFailure = true;
        }

        // Overload used for renewable purchases
        public void CheckOut(ShoppingCart shoppingCart, DateTime renewalStartDate, string name, byte countryId, int currencyTypeId, byte platformTypeId)
        {
            if (Sale == null)
            {
                Sale = new Roblox.Billing.Sale();
            }
            NetSuccessOrFailure = true;
        }

        // Utility kept for compatibility with callers that may use it
        public static string MaskCreditCardNumber(string creditCardNumber)
        {
            if (string.IsNullOrWhiteSpace(creditCardNumber))
                return string.Empty;

            string digits = creditCardNumber.Replace(" ", string.Empty).Replace("-", string.Empty);
            if (digits.Length <= 4)
                return digits;

            int maskLength = Math.Max(0, digits.Length - 4);
            return new string('X', maskLength) + digits.Substring(digits.Length - 4);
        }
    }
}
