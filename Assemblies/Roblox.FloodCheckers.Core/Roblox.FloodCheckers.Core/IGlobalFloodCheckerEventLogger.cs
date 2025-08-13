namespace Roblox.FloodCheckers.Core;

/// <summary>
/// Event logger for to log when a category of floodcheckers is accessed while the floodchecker is flooded.
/// </summary>
public interface IGlobalFloodCheckerEventLogger
{
	void RecordFloodCheckerIsFlooded(string category);
}
