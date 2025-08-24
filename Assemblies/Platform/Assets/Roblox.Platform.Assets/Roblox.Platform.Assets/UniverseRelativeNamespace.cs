namespace Roblox.Platform.Assets;

internal class UniverseRelativeNamespace : INamespace
{
	public string Type => "UniverseRelative";

	public long TargetId { get; private set; }

	internal UniverseRelativeNamespace(long universeId)
	{
		TargetId = universeId;
	}
}
