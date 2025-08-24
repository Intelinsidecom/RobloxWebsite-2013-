using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Common;

internal class BuildersClubResources_en_us : TranslationResourcesBase, IBuildersClubResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Label.BuildersClub"
	/// Premium Membership - this should be translated with the consent of product managers who owns the BC feature. Direct word to word translation might not be accurate.
	/// English String: "Builders Club"
	/// </summary>
	public virtual string LabelBuildersClub => "Builders Club";

	/// <summary>
	/// Key: "Label.BuildersClubMembership"
	/// membership type name
	/// English String: "Builders Club Membership"
	/// </summary>
	public virtual string LabelBuildersClubMembership => "Builders Club Membership";

	/// <summary>
	/// Key: "Label.BuildersClubMembershipOutrageous"
	/// membership type
	/// English String: "Outrageous Builders Club Membership"
	/// </summary>
	public virtual string LabelBuildersClubMembershipOutrageous => "Outrageous Builders Club Membership";

	/// <summary>
	/// Key: "Label.BuildersClubMembershipTurbo"
	/// membership type
	/// English String: "Turbo Builders Club Membership"
	/// </summary>
	public virtual string LabelBuildersClubMembershipTurbo => "Turbo Builders Club Membership";

	/// <summary>
	/// Key: "Label.ClassicBuildersClub"
	/// label
	/// English String: "Classic Builders Club"
	/// </summary>
	public virtual string LabelClassicBuildersClub => "Classic Builders Club";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// This signifies a lifetime subscription to builders club or some other product.
	/// English String: "Lifetime"
	/// </summary>
	public virtual string LabelLifetime => "Lifetime";

	/// <summary>
	/// Key: "Label.Membership"
	/// use Feature.Support namespace instead
	/// English String: "Membership"
	/// </summary>
	public virtual string LabelMembership => "Membership";

	/// <summary>
	/// Key: "Label.NeverUppercase"
	/// label - if language supports capitalization, please keep it uppercase
	/// English String: "NEVER"
	/// </summary>
	public virtual string LabelNeverUppercase => "NEVER";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public virtual string LabelNo => "No";

	/// <summary>
	/// Key: "Label.OutrageousBuildersClub"
	/// label
	/// English String: "Outrageous Builders Club"
	/// </summary>
	public virtual string LabelOutrageousBuildersClub => "Outrageous Builders Club";

	/// <summary>
	/// Key: "Label.PlanClassic"
	/// Builders club membership type
	/// English String: "Classic"
	/// </summary>
	public virtual string LabelPlanClassic => "Classic";

	/// <summary>
	/// Key: "Label.PlanFree"
	/// Builders club membership type
	/// English String: "Free"
	/// </summary>
	public virtual string LabelPlanFree => "Free";

	/// <summary>
	/// Key: "Label.PlanOutrageous"
	/// Builders club membership type
	/// English String: "Outrageous"
	/// </summary>
	public virtual string LabelPlanOutrageous => "Outrageous";

	/// <summary>
	/// Key: "Label.PlanTurbo"
	/// Builders club membership type
	/// English String: "Turbo"
	/// </summary>
	public virtual string LabelPlanTurbo => "Turbo";

	/// <summary>
	/// Key: "Label.Robux"
	/// label
	/// English String: "Robux"
	/// </summary>
	public virtual string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TurboBuildersClub"
	/// label
	/// English String: "Turbo Builders Club"
	/// </summary>
	public virtual string LabelTurboBuildersClub => "Turbo Builders Club";

	/// <summary>
	/// Key: "Label.Yes"
	/// label
	/// English String: "Yes"
	/// </summary>
	public virtual string LabelYes => "Yes";

	public BuildersClubResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Label.BuildersClub",
				_GetTemplateForLabelBuildersClub()
			},
			{
				"Label.BuildersClubMembership",
				_GetTemplateForLabelBuildersClubMembership()
			},
			{
				"Label.BuildersClubMembershipOutrageous",
				_GetTemplateForLabelBuildersClubMembershipOutrageous()
			},
			{
				"Label.BuildersClubMembershipTurbo",
				_GetTemplateForLabelBuildersClubMembershipTurbo()
			},
			{
				"Label.ClassicBuildersClub",
				_GetTemplateForLabelClassicBuildersClub()
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
				"Label.NeverUppercase",
				_GetTemplateForLabelNeverUppercase()
			},
			{
				"Label.No",
				_GetTemplateForLabelNo()
			},
			{
				"Label.OutrageousBuildersClub",
				_GetTemplateForLabelOutrageousBuildersClub()
			},
			{
				"Label.PlanClassic",
				_GetTemplateForLabelPlanClassic()
			},
			{
				"Label.PlanFree",
				_GetTemplateForLabelPlanFree()
			},
			{
				"Label.PlanOutrageous",
				_GetTemplateForLabelPlanOutrageous()
			},
			{
				"Label.PlanTurbo",
				_GetTemplateForLabelPlanTurbo()
			},
			{
				"Label.Robux",
				_GetTemplateForLabelRobux()
			},
			{
				"Label.TurboBuildersClub",
				_GetTemplateForLabelTurboBuildersClub()
			},
			{
				"Label.Yes",
				_GetTemplateForLabelYes()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Common.BuildersClub";
	}

	protected virtual string _GetTemplateForLabelBuildersClub()
	{
		return "Builders Club";
	}

	protected virtual string _GetTemplateForLabelBuildersClubMembership()
	{
		return "Builders Club Membership";
	}

	protected virtual string _GetTemplateForLabelBuildersClubMembershipOutrageous()
	{
		return "Outrageous Builders Club Membership";
	}

	protected virtual string _GetTemplateForLabelBuildersClubMembershipTurbo()
	{
		return "Turbo Builders Club Membership";
	}

	protected virtual string _GetTemplateForLabelClassicBuildersClub()
	{
		return "Classic Builders Club";
	}

	protected virtual string _GetTemplateForLabelLifetime()
	{
		return "Lifetime";
	}

	protected virtual string _GetTemplateForLabelMembership()
	{
		return "Membership";
	}

	protected virtual string _GetTemplateForLabelNeverUppercase()
	{
		return "NEVER";
	}

	protected virtual string _GetTemplateForLabelNo()
	{
		return "No";
	}

	protected virtual string _GetTemplateForLabelOutrageousBuildersClub()
	{
		return "Outrageous Builders Club";
	}

	protected virtual string _GetTemplateForLabelPlanClassic()
	{
		return "Classic";
	}

	protected virtual string _GetTemplateForLabelPlanFree()
	{
		return "Free";
	}

	protected virtual string _GetTemplateForLabelPlanOutrageous()
	{
		return "Outrageous";
	}

	protected virtual string _GetTemplateForLabelPlanTurbo()
	{
		return "Turbo";
	}

	protected virtual string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected virtual string _GetTemplateForLabelTurboBuildersClub()
	{
		return "Turbo Builders Club";
	}

	protected virtual string _GetTemplateForLabelYes()
	{
		return "Yes";
	}
}
