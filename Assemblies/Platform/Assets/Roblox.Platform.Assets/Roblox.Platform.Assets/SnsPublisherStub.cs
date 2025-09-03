using System;
using Amazon;
using Roblox.Instrumentation;

namespace Roblox.Platform.Assets.Sns
{
    // Minimal no-op stub to satisfy references without pulling in full AWS SNS dependency.
    public class SnsPublisher
    {
        #pragma warning disable 0067
        public event Action<Exception, string> SnsError;
        #pragma warning restore 0067

        public SnsPublisher(string awsAccessKey, string awsSecretKey, RegionEndpoint primaryRegionEndpoint, string snsTopicArn, string perfmonInstanceName, ICounterRegistry counterRegistry)
        {
            // No-op
        }

        public void Publish(object message)
        {
            // No-op
        }
    }
}
