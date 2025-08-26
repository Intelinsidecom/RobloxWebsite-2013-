namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides AlertsAndOptionsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AlertsAndOptionsResources_zh_tw : AlertsAndOptionsResources_en_us, IAlertsAndOptionsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.sBuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelsBuyRobux => "è³¼è²· Robux";

	/// <summary>
	/// Key: "Label.sHelp"
	/// English String: "Help"
	/// </summary>
	public override string LabelsHelp => "å”åŠ©";

	/// <summary>
	/// Key: "Label.sLogout"
	/// English String: "Logout"
	/// </summary>
	public override string LabelsLogout => "ç™»å‡º";

	/// <summary>
	/// Key: "Label.sRobux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelsRobux => "Robux";

	/// <summary>
	/// Key: "Label.sSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelsSettings => "è¨­å®š";

	public AlertsAndOptionsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelsBuyRobux()
	{
		return "è³¼è²· Robux";
	}

	protected override string _GetTemplateForLabelsHelp()
	{
		return "å”åŠ©";
	}

	protected override string _GetTemplateForLabelsLogout()
	{
		return "ç™»å‡º";
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
		return "è¨­å®š";
	}
}


}
