namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides BuildersClubResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubResources_ja_jp : BuildersClubResources_en_us, IBuildersClubResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.BuildersClub"
	/// Premium Membership - this should be translated with the consent of product managers who owns the BC feature. Direct word to word translation might not be accurate.
	/// English String: "Builders Club"
	/// </summary>
	public override string LabelBuildersClub => "Builders Club";

	/// <summary>
	/// Key: "Label.BuildersClubMembership"
	/// membership type name
	/// English String: "Builders Club Membership"
	/// </summary>
	public override string LabelBuildersClubMembership => "Builders Club メンバーシップ";

	/// <summary>
	/// Key: "Label.BuildersClubMembershipOutrageous"
	/// membership type
	/// English String: "Outrageous Builders Club Membership"
	/// </summary>
	public override string LabelBuildersClubMembershipOutrageous => "Outrageous Builders Club メンバーシップ";

	/// <summary>
	/// Key: "Label.BuildersClubMembershipTurbo"
	/// membership type
	/// English String: "Turbo Builders Club Membership"
	/// </summary>
	public override string LabelBuildersClubMembershipTurbo => "Turbo Builders Club メンバーシップ";

	/// <summary>
	/// Key: "Label.ClassicBuildersClub"
	/// label
	/// English String: "Classic Builders Club"
	/// </summary>
	public override string LabelClassicBuildersClub => "クラシック Builders Club";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// This signifies a lifetime subscription to builders club or some other product.
	/// English String: "Lifetime"
	/// </summary>
	public override string LabelLifetime => "永久";

	/// <summary>
	/// Key: "Label.Membership"
	/// use Feature.Support namespace instead
	/// English String: "Membership"
	/// </summary>
	public override string LabelMembership => "メンバーシップ";

	/// <summary>
	/// Key: "Label.NeverUppercase"
	/// label - if language supports capitalization, please keep it uppercase
	/// English String: "NEVER"
	/// </summary>
	public override string LabelNeverUppercase => "しない";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "いいえ";

	/// <summary>
	/// Key: "Label.OutrageousBuildersClub"
	/// label
	/// English String: "Outrageous Builders Club"
	/// </summary>
	public override string LabelOutrageousBuildersClub => "Outrageous Builders Club";

	/// <summary>
	/// Key: "Label.PlanClassic"
	/// Builders club membership type
	/// English String: "Classic"
	/// </summary>
	public override string LabelPlanClassic => "クラシック";

	/// <summary>
	/// Key: "Label.PlanFree"
	/// Builders club membership type
	/// English String: "Free"
	/// </summary>
	public override string LabelPlanFree => "無料";

	/// <summary>
	/// Key: "Label.PlanOutrageous"
	/// Builders club membership type
	/// English String: "Outrageous"
	/// </summary>
	public override string LabelPlanOutrageous => "Outrageous";

	/// <summary>
	/// Key: "Label.PlanTurbo"
	/// Builders club membership type
	/// English String: "Turbo"
	/// </summary>
	public override string LabelPlanTurbo => "Turbo";

	/// <summary>
	/// Key: "Label.Robux"
	/// label
	/// English String: "Robux"
	/// </summary>
	public override string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TurboBuildersClub"
	/// label
	/// English String: "Turbo Builders Club"
	/// </summary>
	public override string LabelTurboBuildersClub => "Turbo Builders Club";

	/// <summary>
	/// Key: "Label.Yes"
	/// label
	/// English String: "Yes"
	/// </summary>
	public override string LabelYes => "はい";

	public BuildersClubResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelBuildersClub()
	{
		return "Builders Club";
	}

	protected override string _GetTemplateForLabelBuildersClubMembership()
	{
		return "Builders Club メンバーシップ";
	}

	protected override string _GetTemplateForLabelBuildersClubMembershipOutrageous()
	{
		return "Outrageous Builders Club メンバーシップ";
	}

	protected override string _GetTemplateForLabelBuildersClubMembershipTurbo()
	{
		return "Turbo Builders Club メンバーシップ";
	}

	protected override string _GetTemplateForLabelClassicBuildersClub()
	{
		return "クラシック Builders Club";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "永久";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "メンバーシップ";
	}

	protected override string _GetTemplateForLabelNeverUppercase()
	{
		return "しない";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "いいえ";
	}

	protected override string _GetTemplateForLabelOutrageousBuildersClub()
	{
		return "Outrageous Builders Club";
	}

	protected override string _GetTemplateForLabelPlanClassic()
	{
		return "クラシック";
	}

	protected override string _GetTemplateForLabelPlanFree()
	{
		return "無料";
	}

	protected override string _GetTemplateForLabelPlanOutrageous()
	{
		return "Outrageous";
	}

	protected override string _GetTemplateForLabelPlanTurbo()
	{
		return "Turbo";
	}

	protected override string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForLabelTurboBuildersClub()
	{
		return "Turbo Builders Club";
	}

	protected override string _GetTemplateForLabelYes()
	{
		return "はい";
	}
}
