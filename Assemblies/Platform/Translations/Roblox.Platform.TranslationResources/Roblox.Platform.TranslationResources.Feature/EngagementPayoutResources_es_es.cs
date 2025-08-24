namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides EngagementPayoutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class EngagementPayoutResources_es_es : EngagementPayoutResources_en_us, IEngagementPayoutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.EngagementPayoutSubtitle"
	/// English String: "Engagement score and payout based on engagement of monetized users."
	/// </summary>
	public override string DescriptionEngagementPayoutSubtitle => "El puntaje de compromiso y los pagos se basan en participación de los usuarios que monetizan.";

	/// <summary>
	/// Key: "Description.EngagementRobuxEarned"
	/// English String: "Engagement Robux Earned"
	/// </summary>
	public override string DescriptionEngagementRobuxEarned => "Robux ganados por el compromiso";

	/// <summary>
	/// Key: "Description.EngagementScore"
	/// English String: "Engagement Score"
	/// </summary>
	public override string DescriptionEngagementScore => "Puntaje de compromiso";

	/// <summary>
	/// Key: "Heading.EngagementPayout"
	/// English String: "Engagement and Payout"
	/// </summary>
	public override string HeadingEngagementPayout => "Compromiso y pagos";

	/// <summary>
	/// Key: "Label.Custom"
	/// English String: "Custom"
	/// </summary>
	public override string LabelCustom => "Personalizado";

	/// <summary>
	/// Key: "Label.EngagementBasedPayout"
	/// English String: "Engagement based payout"
	/// </summary>
	public override string LabelEngagementBasedPayout => "Pagos basados en el compromiso";

	/// <summary>
	/// Key: "Label.EngagementScore"
	/// English String: "Engagement score"
	/// </summary>
	public override string LabelEngagementScore => "Puntaje de compromiso";

	/// <summary>
	/// Key: "Label.Monthly"
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "Mensual";

	/// <summary>
	/// Key: "Label.Weekly"
	/// English String: "Weekly"
	/// </summary>
	public override string LabelWeekly => "Semanal";

	public EngagementPayoutResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionEngagementPayoutSubtitle()
	{
		return "El puntaje de compromiso y los pagos se basan en participación de los usuarios que monetizan.";
	}

	protected override string _GetTemplateForDescriptionEngagementRobuxEarned()
	{
		return "Robux ganados por el compromiso";
	}

	protected override string _GetTemplateForDescriptionEngagementScore()
	{
		return "Puntaje de compromiso";
	}

	protected override string _GetTemplateForHeadingEngagementPayout()
	{
		return "Compromiso y pagos";
	}

	protected override string _GetTemplateForLabelCustom()
	{
		return "Personalizado";
	}

	protected override string _GetTemplateForLabelEngagementBasedPayout()
	{
		return "Pagos basados en el compromiso";
	}

	protected override string _GetTemplateForLabelEngagementScore()
	{
		return "Puntaje de compromiso";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "Mensual";
	}

	protected override string _GetTemplateForLabelWeekly()
	{
		return "Semanal";
	}
}
