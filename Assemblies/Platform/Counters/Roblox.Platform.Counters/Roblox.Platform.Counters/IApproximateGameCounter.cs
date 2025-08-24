namespace Roblox.Platform.Counters;

public interface IApproximateGameCounter
{
	long AssetId { get; set; }

	string Name { get; set; }

	void Increment();

	int? GetCount();
}
