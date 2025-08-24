using System.Collections.Generic;

namespace Roblox.PremiumFeatures.Interfaces;

/// <summary>
/// Interface for PremiumFeature factory
/// </summary>
public interface IPremiumFeatureFactory
{
	/// <summary>
	/// Get NonRenewal feature list
	/// </summary>
	/// <returns>Collection of <see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	ICollection<IPremiumFeatureModel> GetNonRenewalFeatureList();

	/// <summary>
	/// PremiumFeature for BuildersClub monthly
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel BCMonthly();

	/// <summary>
	/// PremiumFeature for BuildersClub 1 month
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel BC1Month();

	/// <summary>
	/// PremiumFeature for BuildersClub 30 days
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel BC30Days();

	/// <summary>
	/// PremiumFeature for BuildersClub 90 days
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel BC90Days();

	/// <summary>
	/// PremiumFeature for BuildersClub 45 days
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel BC45Days();

	/// <summary>
	/// PremiumFeature for BuildersClub 6 months
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel BC6Months();

	/// <summary>
	/// PremiumFeature for BuildersClub 6 months renewing
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel BC6MonthsRenewing();

	/// <summary>
	/// PremiumFeature for BuildersClub 12 months
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel BC12Months();

	/// <summary>
	/// PremiumFeature for BuildersClub 12 months renewing
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel BC12MonthsRenewing();

	/// <summary>
	/// PremiumFeature for BuildersClub lifetime
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel BCLifetime();

	/// <summary>
	/// PremiumFeature for Turbo BuildersClub monthly
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel TBCMonthly();

	/// <summary>
	/// PremiumFeature for Turbo BuildersClub 1 month
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel TBC1Month();

	/// <summary>
	/// PremiumFeature for Turbo BuildersClub 6 months
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel TBC6Months();

	/// <summary>
	/// PremiumFeature for Turbo BuildersClub 6 months renewing
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel TBC6MonthsRenewing();

	/// <summary>
	/// PremiumFeature for Turbo BuildersClub 12 months
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel TBC12Months();

	/// <summary>
	/// PremiumFeature for Turbo BuildersClub 12 months renewing
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel TBC12MonthsRenewing();

	/// <summary>
	/// PremiumFeature for Turbo BuildersClub lifetime
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel TBCLifetime();

	/// <summary>
	/// PremiumFeature for Outrageous BuildersClub monthly
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel OBCMonthly();

	/// <summary>
	/// PremiumFeature for Outrageous BuildersClub 1 month
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel OBC1Month();

	/// <summary>
	/// PremiumFeature for Outrageous BuildersClub 6 months
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel OBC6Months();

	/// <summary>
	/// PremiumFeature for Outrageous BuildersClub 6 months renewing
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel OBC6MonthsRenewing();

	/// <summary>
	/// PremiumFeature for Outrageous BuildersClub 12 months
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel OBC12Months();

	/// <summary>
	/// PremiumFeature for Outrageous BuildersClub 12 months renewing
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel OBC12MonthsRenewing();

	/// <summary>
	/// PremiumFeature for Outrageous BuildersClub lifetime
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel OBCLifetime();

	/// <summary>
	/// PremiumFeature for 450 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux450();

	/// <summary>
	/// PremiumFeature for 731 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux731();

	/// <summary>
	/// PremiumFeature for 1000 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux1000();

	/// <summary>
	/// PremiumFeature for 1005 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux1005();

	/// <summary>
	/// PremiumFeature for 2000 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux2000();

	/// <summary>
	/// PremiumFeature for 2004 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux2004();

	/// <summary>
	/// PremiumFeature for 2750 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux2750();

	/// <summary>
	/// PremiumFeature for 2755 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux2755();

	/// <summary>
	/// PremiumFeature for 4500 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux4500();

	/// <summary>
	/// PremiumFeature for 6000 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux6000();

	/// <summary>
	/// PremiumFeature for 10000 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux10000();

	/// <summary>
	/// PremiumFeature for 15000 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux15000();

	/// <summary>
	/// PremiumFeature for 22500 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux22500();

	/// <summary>
	/// PremiumFeature for 35000 Robux
	/// </summary>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Robux35000();

	/// <summary>
	/// Get premiumFeatures by AccountAddOnType
	/// </summary>
	/// <param name="accountAddOnTypeId">AccountAddOn type id</param>
	/// <param name="startRowIndex">Start row index</param>
	/// <param name="maximumRows">Max rows</param>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	ICollection<IPremiumFeatureModel> GetPremiumFeaturesByAccountAddOnTypeIdPaged(int accountAddOnTypeId, int startRowIndex, int maximumRows);

	/// <summary>
	/// Get premiumFeature by id
	/// </summary>
	/// <param name="id">PremiumFeature id</param>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel Get(int id);

	/// <summary>
	/// Get premiumFeature by name
	/// </summary>
	/// <param name="name">Name</param>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel GetByName(string name);

	/// <summary>
	/// Get premiumFeature by id
	/// </summary>
	/// <param name="id">PremiumFeature id</param>
	/// <returns><see cref="T:Roblox.PremiumFeatures.Interfaces.IPremiumFeatureModel" /></returns>
	IPremiumFeatureModel MustGet(int id);
}
