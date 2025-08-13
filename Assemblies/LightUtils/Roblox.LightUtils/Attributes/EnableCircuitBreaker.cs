using System;

namespace Roblox.LightUtils
{
	[AttributeUsage(AttributeTargets.Class)]
	public class EnableCircuitBreaker : Attribute
	{
		public int FailureThreshold { get; set; }
		public int OpenTimeoutSeconds { get; set; }
		public int CheckTimeWindowSeconds { get; set; }

		public EnableCircuitBreaker(int failureFailureThreshold = 3, int openTimeoutSecondsSeconds = 60, int checkTimeWindowSecondsSeconds = 60)
		{
			FailureThreshold = failureFailureThreshold;
			OpenTimeoutSeconds = openTimeoutSecondsSeconds;
			CheckTimeWindowSeconds = checkTimeWindowSecondsSeconds;
		}
	}
}
