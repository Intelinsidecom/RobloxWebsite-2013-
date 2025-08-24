using System.Collections.Generic;
using System.Linq;
using Roblox.PremiumFeatures.Interfaces;

namespace Roblox.PremiumFeatures.Implementation;

/// <inheritdoc />
public class PremiumFeatureFactory : IPremiumFeatureFactory
{
	/// <inheritdoc />
	public ICollection<IPremiumFeatureModel> GetNonRenewalFeatureList()
	{
		return PremiumFeature.GetNonRenewalFeatureList().Select(EntityToModel).ToList();
	}

	/// <inheritdoc />
	public IPremiumFeatureModel BCMonthly()
	{
		PremiumFeature premiumFeature = PremiumFeature.BCMonthly;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel BC1Month()
	{
		PremiumFeature premiumFeature = PremiumFeature.BC1Month;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel BC30Days()
	{
		PremiumFeature premiumFeature = PremiumFeature.BC30Days;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel BC90Days()
	{
		PremiumFeature premiumFeature = PremiumFeature.BC90Days;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel BC45Days()
	{
		PremiumFeature premiumFeature = PremiumFeature.BC45Days;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel BC6Months()
	{
		PremiumFeature premiumFeature = PremiumFeature.BC6Months;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel BC6MonthsRenewing()
	{
		PremiumFeature premiumFeature = PremiumFeature.BC6MonthsRenewing;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel BC12Months()
	{
		PremiumFeature premiumFeature = PremiumFeature.BC12Months;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel BC12MonthsRenewing()
	{
		PremiumFeature premiumFeature = PremiumFeature.BC12MonthsRenewing;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel BCLifetime()
	{
		PremiumFeature premiumFeature = PremiumFeature.BCLifetime;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel TBCMonthly()
	{
		PremiumFeature premiumFeature = PremiumFeature.TBCMonthly;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel TBC1Month()
	{
		PremiumFeature premiumFeature = PremiumFeature.TBC1Month;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel TBC6Months()
	{
		PremiumFeature premiumFeature = PremiumFeature.TBC6Months;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel TBC6MonthsRenewing()
	{
		PremiumFeature premiumFeature = PremiumFeature.TBC6MonthsRenewing;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel TBC12Months()
	{
		PremiumFeature premiumFeature = PremiumFeature.TBC12Months;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel TBC12MonthsRenewing()
	{
		PremiumFeature premiumFeature = PremiumFeature.TBC12MonthsRenewing;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel TBCLifetime()
	{
		PremiumFeature premiumFeature = PremiumFeature.TBCLifetime;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel OBCMonthly()
	{
		PremiumFeature premiumFeature = PremiumFeature.OBCMonthly;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel OBC1Month()
	{
		PremiumFeature premiumFeature = PremiumFeature.OBC1Month;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel OBC6Months()
	{
		PremiumFeature premiumFeature = PremiumFeature.OBC6Months;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel OBC6MonthsRenewing()
	{
		PremiumFeature premiumFeature = PremiumFeature.OBC6MonthsRenewing;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel OBC12Months()
	{
		PremiumFeature premiumFeature = PremiumFeature.OBC12Months;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel OBC12MonthsRenewing()
	{
		PremiumFeature premiumFeature = PremiumFeature.OBC12MonthsRenewing;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel OBCLifetime()
	{
		PremiumFeature premiumFeature = PremiumFeature.OBCLifetime;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux450()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux450;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux731()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux731;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux1000()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux1000;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux1005()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux1005;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux2000()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux2000;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux2004()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux2004;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux2750()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux2750;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux2755()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux2755;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux4500()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux4500;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux6000()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux6000;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux10000()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux10000;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux15000()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux15000;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux22500()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux22500;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Robux35000()
	{
		PremiumFeature premiumFeature = PremiumFeature.Robux35000;
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public ICollection<IPremiumFeatureModel> GetPremiumFeaturesByAccountAddOnTypeIdPaged(int accountAddOnTypeId, int startRowIndex, int maximumRows)
	{
		return PremiumFeature.GetPremiumFeaturesByAccountAddOnTypeIdPaged(accountAddOnTypeId, startRowIndex, maximumRows).Select(EntityToModel).ToList();
	}

	/// <inheritdoc />
	public IPremiumFeatureModel Get(int id)
	{
		PremiumFeature premiumFeature = PremiumFeature.Get(id);
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel GetByName(string name)
	{
		PremiumFeature premiumFeature = PremiumFeature.GetByName(name);
		return EntityToModel(premiumFeature);
	}

	/// <inheritdoc />
	public IPremiumFeatureModel MustGet(int id)
	{
		PremiumFeature premiumFeature = PremiumFeature.MustGet(id);
		return EntityToModel(premiumFeature);
	}

	private IPremiumFeatureModel EntityToModel(PremiumFeature premiumFeature)
	{
		if (premiumFeature != null)
		{
			return new PremiumFeatureModel(premiumFeature.ID, premiumFeature.Name, premiumFeature.AccountAddOnTypeID, premiumFeature.DurationTypeID, premiumFeature.IsRenewal, premiumFeature.RobuxCreditQuantityTypeID, premiumFeature.RobuxStipendQuantityTypeID, premiumFeature.RobuxStipendFrequencyTypeID, premiumFeature.ShowcaseAllotmentTypeID, premiumFeature.ContentPrivilegeTypeID, premiumFeature.AdvertisingSuppressionTypeID, premiumFeature.GrantedAssetListID, premiumFeature.GrantedBadgeListID, premiumFeature.IsAnyBuildersClub, premiumFeature.IsAnySubscription, premiumFeature.IsBuildersClub, premiumFeature.IsTurboBuildersClub, premiumFeature.IsOutrageousBuildersClub);
		}
		return null;
	}
}
