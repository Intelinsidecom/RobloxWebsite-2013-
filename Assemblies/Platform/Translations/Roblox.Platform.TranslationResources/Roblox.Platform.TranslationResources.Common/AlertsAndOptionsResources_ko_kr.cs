namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides AlertsAndOptionsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AlertsAndOptionsResources_ko_kr : AlertsAndOptionsResources_en_us, IAlertsAndOptionsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.sBuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelsBuyRobux => "Robux êµ¬ë§¤";

	/// <summary>
	/// Key: "Label.sHelp"
	/// English String: "Help"
	/// </summary>
	public override string LabelsHelp => "ë„ì›€ë§";

	/// <summary>
	/// Key: "Label.sLogout"
	/// English String: "Logout"
	/// </summary>
	public override string LabelsLogout => "ë¡œê·¸ì•„ì›ƒ";

	/// <summary>
	/// Key: "Label.sRobux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelsRobux => "Robux";

	/// <summary>
	/// Key: "Label.sSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelsSettings => "ì„¤ì •";

	public AlertsAndOptionsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelsBuyRobux()
	{
		return "Robux êµ¬ë§¤";
	}

	protected override string _GetTemplateForLabelsHelp()
	{
		return "ë„ì›€ë§";
	}

	protected override string _GetTemplateForLabelsLogout()
	{
		return "ë¡œê·¸ì•„ì›ƒ";
	}

	protected override string _GetTemplateForLabelsRobux()
	{
		return "Robux";
	}

	/// <summary>
	/// Key: "Label.sRobuxMessage"
	/// English String: "{robuxValue}Â Robux"
	/// </summary>
	public override string LabelsRobuxMessage(string robuxValue)
	{
		return $"{robuxValue}\u00a0Robux";
	}

	protected override string _GetTemplateForLabelsRobuxMessage()
	{
		return "{robuxValue}\u00a0Robux";
	}

	protected override string _GetTemplateForLabelsSettings()
	{
		return "ì„¤ì •";
	}
}


}
