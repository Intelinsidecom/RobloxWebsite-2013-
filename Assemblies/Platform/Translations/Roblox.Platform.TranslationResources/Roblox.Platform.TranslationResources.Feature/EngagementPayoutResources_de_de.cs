namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides EngagementPayoutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class EngagementPayoutResources_de_de : EngagementPayoutResources_en_us, IEngagementPayoutResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.EngagementPayout"
	/// English String: "Engagement and Payout"
	/// </summary>
	public override string HeadingEngagementPayout => "Engagement und Auszahlung";

	/// <summary>
	/// Key: "Label.Custom"
	/// English String: "Custom"
	/// </summary>
	public override string LabelCustom => "Benutzerdefiniert";

	/// <summary>
	/// Key: "Label.Monthly"
	/// English String: "Monthly"
	/// </summary>
	public override string LabelMonthly => "Monatlich";

	/// <summary>
	/// Key: "Label.Weekly"
	/// English String: "Weekly"
	/// </summary>
	public override string LabelWeekly => "Wöchentlich";

	public EngagementPayoutResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingEngagementPayout()
	{
		return "Engagement und Auszahlung";
	}

	protected override string _GetTemplateForLabelCustom()
	{
		return "Benutzerdefiniert";
	}

	protected override string _GetTemplateForLabelMonthly()
	{
		return "Monatlich";
	}

	protected override string _GetTemplateForLabelWeekly()
	{
		return "Wöchentlich";
	}
}
