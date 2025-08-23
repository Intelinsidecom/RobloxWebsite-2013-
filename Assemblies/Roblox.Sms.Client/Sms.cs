namespace Roblox.Sms.Client
{
    public class Sms
    {
        public string PhoneNumber { get; }
        public string Message { get; }

        public Sms(string phoneNumber, string message)
        {
            PhoneNumber = phoneNumber;
            Message = message;
        }
    }
}
