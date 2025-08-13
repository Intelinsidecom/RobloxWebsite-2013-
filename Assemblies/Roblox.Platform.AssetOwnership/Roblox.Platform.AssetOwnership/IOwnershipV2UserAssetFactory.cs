namespace Roblox.Platform.AssetOwnership;

internal interface IOwnershipV2UserAssetFactory : IDualCompatibleOwnershipFactory
{
	bool AwardAssetSpecifyingUserAssetId(long assetId, long userAssetId, long userId);

	void AwardAssetSpecifyingUserAssetIdAllowingDuplicates(long assetId, long userAssetId, long userId);
}
