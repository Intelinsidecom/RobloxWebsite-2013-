namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides BuildersClubResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class BuildersClubResources_pt_br : BuildersClubResources_en_us, IBuildersClubResources, ITranslationResources
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
	public override string LabelBuildersClubMembership => "Assinatura do Builders Club";

	/// <summary>
	/// Key: "Label.BuildersClubMembershipOutrageous"
	/// membership type
	/// English String: "Outrageous Builders Club Membership"
	/// </summary>
	public override string LabelBuildersClubMembershipOutrageous => "Assinatura do Outrageous Builders Club";

	/// <summary>
	/// Key: "Label.BuildersClubMembershipTurbo"
	/// membership type
	/// English String: "Turbo Builders Club Membership"
	/// </summary>
	public override string LabelBuildersClubMembershipTurbo => "Assinatura do Turbo Builders Club";

	/// <summary>
	/// Key: "Label.ClassicBuildersClub"
	/// label
	/// English String: "Classic Builders Club"
	/// </summary>
	public override string LabelClassicBuildersClub => "Classic Builders Club";

	/// <summary>
	/// Key: "Label.Lifetime"
	/// This signifies a lifetime subscription to builders club or some other product.
	/// English String: "Lifetime"
	/// </summary>
	public override string LabelLifetime => "Vitalícia";

	/// <summary>
	/// Key: "Label.Membership"
	/// use Feature.Support namespace instead
	/// English String: "Membership"
	/// </summary>
	public override string LabelMembership => "Assinatura";

	/// <summary>
	/// Key: "Label.NeverUppercase"
	/// label - if language supports capitalization, please keep it uppercase
	/// English String: "NEVER"
	/// </summary>
	public override string LabelNeverUppercase => "NUNCA";

	/// <summary>
	/// Key: "Label.No"
	/// label
	/// English String: "No"
	/// </summary>
	public override string LabelNo => "Não";

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
	public override string LabelPlanClassic => "Clássico";

	/// <summary>
	/// Key: "Label.PlanFree"
	/// Builders club membership type
	/// English String: "Free"
	/// </summary>
	public override string LabelPlanFree => "Grátis";

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
	public override string LabelYes => "Sim";

	public BuildersClubResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelBuildersClub()
	{
		return "Builders Club";
	}

	protected override string _GetTemplateForLabelBuildersClubMembership()
	{
		return "Assinatura do Builders Club";
	}

	protected override string _GetTemplateForLabelBuildersClubMembershipOutrageous()
	{
		return "Assinatura do Outrageous Builders Club";
	}

	protected override string _GetTemplateForLabelBuildersClubMembershipTurbo()
	{
		return "Assinatura do Turbo Builders Club";
	}

	protected override string _GetTemplateForLabelClassicBuildersClub()
	{
		return "Classic Builders Club";
	}

	protected override string _GetTemplateForLabelLifetime()
	{
		return "Vitalícia";
	}

	protected override string _GetTemplateForLabelMembership()
	{
		return "Assinatura";
	}

	protected override string _GetTemplateForLabelNeverUppercase()
	{
		return "NUNCA";
	}

	protected override string _GetTemplateForLabelNo()
	{
		return "Não";
	}

	protected override string _GetTemplateForLabelOutrageousBuildersClub()
	{
		return "Outrageous Builders Club";
	}

	protected override string _GetTemplateForLabelPlanClassic()
	{
		return "Clássico";
	}

	protected override string _GetTemplateForLabelPlanFree()
	{
		return "Grátis";
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
		return "Sim";
	}
}
