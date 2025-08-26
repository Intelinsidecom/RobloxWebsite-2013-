namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides AlertsAndOptionsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AlertsAndOptionsResources_ja_jp : AlertsAndOptionsResources_en_us, IAlertsAndOptionsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.sBuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelsBuyRobux => "Robuxã‚’è³¼å…¥ã™ã‚‹";

	/// <summary>
	/// Key: "Label.sHelp"
	/// English String: "Help"
	/// </summary>
	public override string LabelsHelp => "ãƒ˜ãƒ«ãƒ—";

	/// <summary>
	/// Key: "Label.sLogout"
	/// English String: "Logout"
	/// </summary>
	public override string LabelsLogout => "ãƒ­ã‚°ã‚¢ã‚¦ãƒˆ";

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

	public AlertsAndOptionsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelsBuyRobux()
	{
		return "Robuxã‚’è³¼å…¥ã™ã‚‹";
	}

	protected override string _GetTemplateForLabelsHelp()
	{
		return "ãƒ˜ãƒ«ãƒ—";
	}

	protected override string _GetTemplateForLabelsLogout()
	{
		return "ãƒ­ã‚°ã‚¢ã‚¦ãƒˆ";
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
		return $"{robuxValue} Robux";
	}

	protected override string _GetTemplateForLabelsRobuxMessage()
	{
		return "{robuxValue} Robux";
	}

	protected override string _GetTemplateForLabelsSettings()
	{
		return "è¨­å®š";
	}
}


}
