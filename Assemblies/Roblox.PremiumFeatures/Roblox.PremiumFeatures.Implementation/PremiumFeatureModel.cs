using Roblox.PremiumFeatures.Interfaces;

namespace Roblox.PremiumFeatures.Implementation;

/// <inheritdoc />
public class PremiumFeatureModel : IPremiumFeatureModel
{
	/// <inheritdoc />
	public int Id { get; }

	/// <inheritdoc />
	public string Name { get; }

	/// <inheritdoc />
	public byte AccountAddOnTypeId { get; }

	/// <inheritdoc />
	public byte DurationTypeId { get; }

	/// <inheritdoc />
	public bool IsRenewal { get; }

	/// <inheritdoc />
	public byte RobuxCreditQuantityTypeId { get; }

	/// <inheritdoc />
	public byte RobuxStipendQuantityTypeId { get; }

	/// <inheritdoc />
	public byte? RobuxStipendFrequencyTypeId { get; }

	/// <inheritdoc />
	public byte ShowcaseAllotmentTypeId { get; }

	/// <inheritdoc />
	public byte ContentPrivilegeTypeId { get; }

	/// <inheritdoc />
	public byte AdvertisingSuppressionTypeId { get; }

	/// <inheritdoc />
	public int GrantedAssetListId { get; }

	/// <inheritdoc />
	public byte GrantedBadgeListId { get; }

	/// <inheritdoc />
	public bool IsAnyBuildersClub { get; }

	/// <inheritdoc />
	public bool IsPremium { get; }

	/// <inheritdoc />
	public bool IsBuildersClub { get; }

	/// <inheritdoc />
	public bool IsTurboBuildersClub { get; }

	/// <inheritdoc />
	public bool IsOutrageousBuildersClub { get; }

	/// <summary>
	/// Create PremiumFeature model
	/// </summary>
	/// <param name="id">PremiumFeature id</param>
	/// <param name="name">Name</param>
	/// <param name="accountAddOnTypeId">AccountAddOn type id</param>
	/// <param name="durationTypeId">Duration type id</param>
	/// <param name="isRenewal">Is renewal</param>
	/// <param name="robuxCreditQuantityTypeId">Robux credit quantity type id</param>
	/// <param name="robuxStipendQuantityTypeId">Robux stipend quantity type id</param>
	/// <param name="robuxStipendFrequencyTypeId">Robux stipend frequency type id</param>
	/// <param name="showcaseAllotmentTypeId">Showcase allotment type id</param>
	/// <param name="contentPrivilegeTypeId">Content privilege type id</param>
	/// <param name="advertisingSuppressionTypeId">Advertising suppression type id</param>
	/// <param name="grantedAssetListId">Granted asset list id</param>
	/// <param name="grantedBadgeListId">Granted badge list id</param>
	/// <param name="isAnyBuildersClub">Is any Builders Club</param>
	/// <param name="isPremium">Is any Subscription</param>
	/// <param name="isBuildersClub">Is classic Builders Club</param>
	/// <param name="isTurboBuildersClub">Is turbo Builders Club</param>
	/// <param name="isOutrageousBuildersClub">is outrageous Builders Club</param>
	public PremiumFeatureModel(int id, string name, byte accountAddOnTypeId, byte durationTypeId, bool isRenewal, byte robuxCreditQuantityTypeId, byte robuxStipendQuantityTypeId, byte? robuxStipendFrequencyTypeId, byte showcaseAllotmentTypeId, byte contentPrivilegeTypeId, byte advertisingSuppressionTypeId, int grantedAssetListId, byte grantedBadgeListId, bool isAnyBuildersClub, bool isPremium, bool isBuildersClub, bool isTurboBuildersClub, bool isOutrageousBuildersClub)
	{
		Id = id;
		Name = name;
		AccountAddOnTypeId = accountAddOnTypeId;
		DurationTypeId = durationTypeId;
		IsRenewal = isRenewal;
		RobuxCreditQuantityTypeId = robuxCreditQuantityTypeId;
		RobuxStipendQuantityTypeId = robuxStipendQuantityTypeId;
		RobuxStipendFrequencyTypeId = robuxStipendFrequencyTypeId;
		ShowcaseAllotmentTypeId = showcaseAllotmentTypeId;
		ContentPrivilegeTypeId = contentPrivilegeTypeId;
		AdvertisingSuppressionTypeId = advertisingSuppressionTypeId;
		GrantedAssetListId = grantedAssetListId;
		GrantedBadgeListId = grantedBadgeListId;
		IsAnyBuildersClub = isAnyBuildersClub;
		IsBuildersClub = isBuildersClub;
		IsPremium = isPremium;
		IsTurboBuildersClub = isTurboBuildersClub;
		IsOutrageousBuildersClub = isOutrageousBuildersClub;
	}
}
