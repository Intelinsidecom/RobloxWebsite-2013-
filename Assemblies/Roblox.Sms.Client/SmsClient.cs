using System.Diagnostics;

namespace Roblox.Sms.Client
{
    // Minimal stub implementation to satisfy compile-time dependency.
    public class SmsClient : ISmsClient
    {
        public void Send(Sms sms)
        {
            // No-op stub; in production this would call an SMS provider.
            Debug.WriteLine($"Stub SmsClient sending to {sms.PhoneNumber}: {sms.Message}");
        }
    }
}
