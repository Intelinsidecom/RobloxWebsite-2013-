using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class BuildersClubPageResources_en_us : TranslationResourcesBase, IBuildersClubPageResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Description.SigningBonusDesclaimer"
	/// description in small text about the disclaimer for signing bonus
	/// English String: "* Signing bonus is for first time membership purchase only."
	/// </summary>
	public virtual string DescriptionSigningBonusDesclaimer => "* Signing bonus is for first time membership purchase only.";

	/// <summary>
	/// Key: "Heading.BuildersClubUpgrade"
	/// page heading
	/// English String: "Upgrade to Roblox Builders Club"
	/// </summary>
	public virtual string HeadingBuildersClubUpgrade => "Upgrade to Roblox Builders Club";

	/// <summary>
	/// Key: "Label.Annual"
	/// label
	/// English String: "Annual"
	/// </summary>
	public virtual string LabelAnnual => "Annual";

	/// <summary>
	/// Key: "Label.Annually"
	/// label
	/// English String: "Annually"
	/// </summary>
	public virtual string LabelAnnually => "Annually";

	/// <summary>
	/// Key: "Label.BenefitTypeAdFree"
	/// label
	/// English String: "Ad Free"
	/// </summary>
	public virtual string LabelBenefitTypeAdFree => "Ad Free";

	/// <summary>
	/// Key: "Label.BenefitTypeBCBetaFeatures"
	/// Label. Note: BC is acronym of Builders Club
	/// English String: "BC Beta Features"
	/// </summary>
	public virtual string LabelBenefitTypeBCBetaFeatures => "BC Beta Features";

	/// <summary>
	/// Key: "Label.BenefitTypeBonusGear"
	/// label
	/// English String: "Bonus Gear"
	/// </summary>
	public virtual string LabelBenefitTypeBonusGear => "Bonus Gear";

	/// <summary>
	/// Key: "Label.BenefitTypeCreateGroups"
	/// label
	/// English String: "Create Groups"
	/// </summary>
	public virtual string LabelBenefitTypeCreateGroups => "Create Groups";

	/// <summary>
	/// Key: "Label.BenefitTypeDailyRobux"
	/// label
	/// English String: "Daily Robux"
	/// </summary>
	public virtual string LabelBenefitTypeDailyRobux => "Daily Robux";

	/// <summary>
	/// Key: "Label.BenefitTypeJoinGroups"
	/// label
	/// English String: "Join Groups"
	/// </summary>
	public virtual string LabelBenefitTypeJoinGroups => "Join Groups";

	/// <summary>
	/// Key: "Label.BenefitTypePaidAccess"
	/// label
	/// English String: "Paid Access"
	/// </summary>
	public virtual string LabelBenefitTypePaidAccess => "Paid Access";

	/// <summary>
	/// Key: "Label.BenefitTypeSellStuff"
	/// label
	/// English String: "Sell Stuff"
	/// </summary>
	public virtual string LabelBenefitTypeSellStuff => "Sell Stuff";

	/// <summary>
	/// Key: "Label.BenefitTypeSigningBonus"
	/// label - asterisk is used to show some terms message
	/// English String: "Signing Bonus*"
	/// </summary>
	public virtual string LabelBenefitTypeSigningBonus => "Signing Bonus*";

	/// <summary>
	/// Key: "Label.BenefitTypeTradeSystem"
	/// label
	/// English String: "Trade System"
	/// </summary>
	public virtual string LabelBenefitTypeTradeSystem => "Trade System";

	/// <summary>
	/// Key: "Label.BenefitTypeVirtualHat"
	/// label
	/// English String: "Virtual Hat"
	/// </summary>
	public virtual string LabelBenefitTypeVirtualHat => "Virtual Hat";

	/// <summary>
	/// Key: "Label.EverySixMonths"
	/// label
	/// English String: "Every 6 Months"
	/// </summary>
	public virtual string LabelEverySixMonths => "Every 6 Months";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// label
	/// English String: "Lifetime"
	/// </summary>
	public virtual string LabelLifetime => "Lifetime";

	/// <summary>
	/// Key: "Label.Membership"
	/// label
	/// English String: "Membership:"
	/// </summary>
	public virtual string LabelMembership => "Membership:";

	/// <summary>
	/// Key: "Label.Monthly"
	/// label
	/// English String: "Monthly"
	/// </summary>
	public virtual string LabelMonthly => "Monthly";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public virtual string LabelNo => "No";

	/// <summary>
	/// Key: "Label.None"
	/// label
	/// English String: "None"
	/// </summary>
	public virtual string LabelNone => "None";

	/// <summary>
	/// Key: "Label.YourCurrentPlan"
	/// label
	/// English String: "Your Current Plan"
	/// </summary>
	public virtual string LabelYourCurrentPlan => "Your Current Plan";

	public BuildersClubPageResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Description.DowngradeWarning",
				_GetTemplateForDescriptionDowngradeWarning()
			},
			{
				"Description.SigningBonusDesclaimer",
				_GetTemplateForDescriptionSigningBonusDesclaimer()
			},
			{
				"Heading.BuildersClubUpgrade",
				_GetTemplateForHeadingBuildersClubUpgrade()
			},
			{
				"Label.Annual",
				_GetTemplateForLabelAnnual()
			},
			{
				"Label.Annually",
				_GetTemplateForLabelAnnually()
			},
			{
				"Label.BenefitTypeAdFree",
				_GetTemplateForLabelBenefitTypeAdFree()
			},
			{
				"Label.BenefitTypeBCBetaFeatures",
				_GetTemplateForLabelBenefitTypeBCBetaFeatures()
			},
			{
				"Label.BenefitTypeBonusGear",
				_GetTemplateForLabelBenefitTypeBonusGear()
			},
			{
				"Label.BenefitTypeCreateGroups",
				_GetTemplateForLabelBenefitTypeCreateGroups()
			},
			{
				"Label.BenefitTypeDailyRobux",
				_GetTemplateForLabelBenefitTypeDailyRobux()
			},
			{
				"Label.BenefitTypeJoinGroups",
				_GetTemplateForLabelBenefitTypeJoinGroups()
			},
			{
				"Label.BenefitTypePaidAccess",
				_GetTemplateForLabelBenefitTypePaidAccess()
			},
			{
				"Label.BenefitTypeSellStuff",
				_GetTemplateForLabelBenefitTypeSellStuff()
			},
			{
				"Label.BenefitTypeSigningBonus",
				_GetTemplateForLabelBenefitTypeSigningBonus()
			},
			{
				"Label.BenefitTypeTradeSystem",
				_GetTemplateForLabelBenefitTypeTradeSystem()
			},
			{
				"Label.BenefitTypeVirtualHat",
				_GetTemplateForLabelBenefitTypeVirtualHat()
			},
			{
				"Label.CurrentMembership",
				_GetTemplateForLabelCurrentMembership()
			},
			{
				"Label.EverySixMonths",
				_GetTemplateForLabelEverySixMonths()
			},
			{
				"Label.ExpiresDate",
				_GetTemplateForLabelExpiresDate()
			},
			{
				"Label.Lifetime",
				_GetTemplateForLabelLifetime()
			},
			{
				"Label.Membership",
				_GetTemplateForLabelMembership()
			},
			{
				"Label.Monthly",
				_GetTemplateForLabelMonthly()
			},
			{
				"Label.NewMembership",
				_GetTemplateForLabelNewMembership()
			},
			{
				"Label.No",
				_GetTemplateForLabelNo()
			},
			{
				"Label.None",
				_GetTemplateForLabelNone()
			},
			{
				"Label.RenewsDate",
				_GetTemplateForLabelRenewsDate()
			},
			{
				"Label.YourCurrentPlan",
				_GetTemplateForLabelYourCurrentPlan()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.BuildersClubPage";
	}

	/// <summary>
	/// Key: "Description.DowngradeWarning"
	/// description
	/// English String: "This purchase will convert your remaining {currentRenewalDays} days of current membership to {daysCreditCount} days of new membership. These days will be added to your new membership."
	/// </summary>
	public virtual string DescriptionDowngradeWarning(string currentRenewalDays, string daysCreditCount)
	{
		return $"This purchase will convert your remaining {currentRenewalDays} days of current membership to {daysCreditCount} days of new membership. These days will be added to your new membership.";
	}

	protected virtual string _GetTemplateForDescriptionDowngradeWarning()
	{
		return "This purchase will convert your remaining {currentRenewalDays} days of current membership to {daysCreditCount} days of new membership. These days will be added to your new membership.";
	}

	protected virtual string _GetTemplateForDescriptionSigningBonusDesclaimer()
	{
		return "* Signing bonus is for first time membership purchase only.";
	}

	protected virtual string _GetTemplateForHeadingBuildersClubUpgrade()
	{
		return "Upgrade to Roblox Builders Club";
	}

	protected virtual string _GetTemplateForLabelAnnual()
	{
		return "Annual";
	}

	protected virtual string _GetTemplateForLabelAnnually()
	{
		return "Annually";
	}

	protected virtual string _GetTemplateForLabelBenefitTypeAdFree()
	{
		return "Ad Free";
	}

	protected virtual string _GetTemplateForLabelBenefitTypeBCBetaFeatures()
	{
		return "BC Beta Features";
	}

	protected virtual string _GetTemplateForLabelBenefitTypeBonusGear()
	{
		return "Bonus Gear";
	}

	protected virtual string _GetTemplateForLabelBenefitTypeCreateGroups()
	{
		return "Create Groups";
	}

	protected virtual string _GetTemplateForLabelBenefitTypeDailyRobux()
	{
		return "Daily Robux";
	}

	protected virtual string _GetTemplateForLabelBenefitTypeJoinGroups()
	{
		return "Join Groups";
	}

	protected virtual string _GetTemplateForLabelBenefitTypePaidAccess()
	{
		return "Paid Access";
	}

	protected virtual string _GetTemplateForLabelBenefitTypeSellStuff()
	{
		return "Sell Stuff";
	}

	protected virtual string _GetTemplateForLabelBenefitTypeSigningBonus()
	{
		return "Signing Bonus*";
	}

	protected virtual string _GetTemplateForLabelBenefitTypeTradeSystem()
	{
		return "Trade System";
	}

	protected virtual string _GetTemplateForLabelBenefitTypeVirtualHat()
	{
		return "Virtual Hat";
	}

	/// <summary>
	/// Key: "Label.CurrentMembership"
	/// label
	/// English String: "Current Membership: {currentPremiumFeatureName}"
	/// </summary>
	public virtual string LabelCurrentMembership(string currentPremiumFeatureName)
	{
		return $"Current Membership: {currentPremiumFeatureName}";
	}

	protected virtual string _GetTemplateForLabelCurrentMembership()
	{
		return "Current Membership: {currentPremiumFeatureName}";
	}

	protected virtual string _GetTemplateForLabelEverySixMonths()
	{
		return "Every 6 Months";
	}

	/// <summary>
	/// Key: "Label.ExpiresDate"
	/// label
	/// English String: "Expires: {expirationDate}"
	/// </summary>
	public virtual string LabelExpiresDate(string expirationDate)
	{
		return $"Expires: {expirationDate}";
	}

	protected virtual string _GetTemplateForLabelExpiresDate()
	{
		return "Expires: {expirationDate}";
	}

	protected virtual string _GetTemplateForLabelLifetime()
	{
		return "Lifetime";
	}

	protected virtual string _GetTemplateForLabelMembership()
	{
		return "Membership:";
	}

	protected virtual string _GetTemplateForLabelMonthly()
	{
		return "Monthly";
	}

	/// <summary>
	/// Key: "Label.NewMembership"
	/// label
	/// English String: "New Membership: {newPremiumFeatureName}"
	/// </summary>
	public virtual string LabelNewMembership(string newPremiumFeatureName)
	{
		return $"New Membership: {newPremiumFeatureName}";
	}

	protected virtual string _GetTemplateForLabelNewMembership()
	{
		return "New Membership: {newPremiumFeatureName}";
	}

	protected virtual string _GetTemplateForLabelNo()
	{
		return "No";
	}

	protected virtual string _GetTemplateForLabelNone()
	{
		return "None";
	}

	/// <summary>
	/// Key: "Label.RenewsDate"
	/// label
	/// English String: "Renews: {renewalDate}"
	/// </summary>
	public virtual string LabelRenewsDate(string renewalDate)
	{
		return $"Renews: {renewalDate}";
	}

	protected virtual string _GetTemplateForLabelRenewsDate()
	{
		return "Renews: {renewalDate}";
	}

	protected virtual string _GetTemplateForLabelYourCurrentPlan()
	{
		return "Your Current Plan";
	}
}
