namespace Roblox.PremiumFeatures.Interfaces;

/// <summary>
/// PremiumFeature Model
/// </summary>
public interface IPremiumFeatureModel
{
	/// <summary>
	/// PremiumFeature id
	/// </summary>
	int Id { get; }

	/// <summary>
	/// Name
	/// </summary>
	string Name { get; }

	/// <summary>
	/// AccountAddOn type id
	/// </summary>
	byte AccountAddOnTypeId { get; }

	/// <summary>
	/// Duration type id
	/// </summary>
	byte DurationTypeId { get; }

	/// <summary>
	/// Is renewal
	/// </summary>
	bool IsRenewal { get; }

	/// <summary>
	/// Robux credit quantity type id
	/// </summary>
	byte RobuxCreditQuantityTypeId { get; }

	/// <summary>
	/// Robux stipend quantity type id
	/// </summary>
	byte RobuxStipendQuantityTypeId { get; }

	/// <summary>
	/// Robux stipend frequency type id
	/// </summary>
	byte? RobuxStipendFrequencyTypeId { get; }

	/// <summary>
	/// Showcase allotment type id
	/// </summary>
	byte ShowcaseAllotmentTypeId { get; }

	/// <summary>
	/// Content privilege type id
	/// </summary>
	byte ContentPrivilegeTypeId { get; }

	/// <summary>
	/// Advertising suppression type id
	/// </summary>
	byte AdvertisingSuppressionTypeId { get; }

	/// <summary>
	/// Granted asset list id
	/// </summary>
	int GrantedAssetListId { get; }

	/// <summary>
	/// Granted badge list id
	/// </summary>
	byte GrantedBadgeListId { get; }

	/// <summary>
	/// Is any Builders Club
	/// </summary>
	bool IsAnyBuildersClub { get; }

	/// <summary>
	/// Is Premium member
	/// </summary>
	bool IsPremium { get; }

	/// <summary>
	/// Is classic Builders Club
	/// </summary>
	bool IsBuildersClub { get; }

	/// <summary>
	/// Is turbo Builders Club
	/// </summary>
	bool IsTurboBuildersClub { get; }

	/// <summary>
	/// Is outrageous Builders Club
	/// </summary>
	bool IsOutrageousBuildersClub { get; }
}
