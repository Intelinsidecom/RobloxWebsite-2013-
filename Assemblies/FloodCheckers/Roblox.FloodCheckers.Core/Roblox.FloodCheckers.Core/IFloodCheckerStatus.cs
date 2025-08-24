namespace Roblox.FloodCheckers.Core;

public interface IFloodCheckerStatus
{
	int Count { get; }

	int CountOverLimit { get; }

	string FloodcheckerName { get; }

	bool IsFlooded { get; }

	int Limit { get; }
}
