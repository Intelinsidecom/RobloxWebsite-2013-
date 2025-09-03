using System;
namespace Roblox.Platform.RealTimeNotifications
{
    public class PubSubSubcriptionException : Exception
    {
        public PubSubSubcriptionException(string message)
            : base(message)
        {
        }
    }
}
