namespace Roblox.Platform.Avatar;

public interface IWornAsset
{
	long AssetId { get; }

	bool IsEquippedGear { get; }

	bool IsGear { get; }

	bool IsAnimation { get; }
}
