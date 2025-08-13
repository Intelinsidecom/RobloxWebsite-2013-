using Roblox.Platform.Assets;

namespace Roblox.Platform.Universes;

public class UniverseNamespace : INamespace
{
	public long TargetId { get; private set; }

	public string Type => "UniverseRelative";

	public UniverseNamespace(IUniverse universe)
	{
		TargetId = universe.Id;
	}

	public UniverseNamespace(long universeId)
	{
		TargetId = universeId;
	}
}
