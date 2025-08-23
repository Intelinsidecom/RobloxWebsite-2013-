using Roblox.Web.RequestValidator;

namespace Roblox.Web;

internal interface IGameServerRequestValidationPerformanceCounters
{
	void IncrementCounter(GameServerRequestValidationMetricsCounter counterType);
}
