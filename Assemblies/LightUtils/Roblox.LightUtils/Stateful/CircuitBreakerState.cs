using Prometheus;

namespace Roblox.LightUtils
{
	internal class CircuitBreakerState
	{
		public string CallerName;
		public int State;
		public long OpenTimestampExpires;
		public long FailCounter;
		public long SuccessCounter;
		public long TimeWindowsEnds;
		public Gauge CurrentStateGauge;
		public Counter CircuitOpenCounter;
	}
}
