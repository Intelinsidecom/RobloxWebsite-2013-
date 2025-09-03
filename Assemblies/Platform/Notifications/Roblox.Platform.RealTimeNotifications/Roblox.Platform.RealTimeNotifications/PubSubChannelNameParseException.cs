using System;
namespace Roblox.Platform.RealTimeNotifications
{
    public class PubSubChannelNameParseException : Exception
    {
        public PubSubChannelNameParseException(string message)
            : base(message)
        {
        }
    }
}
