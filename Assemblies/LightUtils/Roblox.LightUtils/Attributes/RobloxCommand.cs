using System;
using System.Reflection;

namespace Roblox.LightUtils
{
	[AttributeUsage(AttributeTargets.Method)]
	public class RobloxCommand : Attribute
	{
		public bool UseCircuitBreaking { get; set; }
		public bool UseTelementry { get; set; }
		public string FallbackMethod { get; set; }
		public MethodInfo FallbackMethodInfo { get; set; }

		public RobloxCommand(bool useCircuitBreaking = true, string fallbackMethod = null, bool useTelemetry = true)
		{
			UseCircuitBreaking = useCircuitBreaking;
			UseTelementry = useTelemetry;
			FallbackMethod = fallbackMethod;
		}
	}
}
