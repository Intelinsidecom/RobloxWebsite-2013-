namespace Roblox.FloodCheckers.Core;

public class FloodCheckerStatus : IFloodCheckerStatus
{
	public bool IsFlooded { get; }

	public int Limit { get; }

	public int Count { get; }

	public int CountOverLimit
	{
		get
		{
			if (Count <= Limit)
			{
				return 0;
			}
			return Count - Limit;
		}
	}

	public string FloodcheckerName { get; }

	public FloodCheckerStatus(bool isFlooded, int limit, int count, string floodCheckerName)
	{
		IsFlooded = isFlooded;
		Limit = limit;
		Count = count;
		FloodcheckerName = floodCheckerName;
	}
}
