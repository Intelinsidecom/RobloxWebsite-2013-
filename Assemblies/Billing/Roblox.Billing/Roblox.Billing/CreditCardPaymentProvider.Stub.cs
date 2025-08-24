using System;

namespace Roblox.Billing
{
    // Minimal stub to satisfy references from PaymentHelper
    public static class CreditCardPaymentProvider
    {
        // Returns a masked version of the credit card number (all but last 4 obscured)
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
