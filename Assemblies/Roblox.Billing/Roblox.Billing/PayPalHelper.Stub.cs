using System;

namespace Roblox.Billing
{
    // Minimal stub to satisfy references without PayPal SDK
    public static class PayPalHelper
    {
        public static void CancelPreviousRecurringPaymentOnUpgrade(Sale sale)
        {
            // No-op in stub: in full implementation this would cancel old PayPal recurring profiles
            if (sale == null) throw new ArgumentNullException(nameof(sale));
        }
    }
}
