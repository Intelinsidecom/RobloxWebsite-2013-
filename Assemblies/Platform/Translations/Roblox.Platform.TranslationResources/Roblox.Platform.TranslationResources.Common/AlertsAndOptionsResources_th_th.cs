namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides AlertsAndOptionsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AlertsAndOptionsResources_th_th : AlertsAndOptionsResources_en_us, IAlertsAndOptionsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.sBuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelsBuyRobux => "à¸‹\u0e37\u0e49à¸­ Robux";

	/// <summary>
	/// Key: "Label.sHelp"
	/// English String: "Help"
	/// </summary>
	public override string LabelsHelp => "à¸Š\u0e48à¸§à¸¢à¹€à¸«à¸¥\u0e37à¸­";

	/// <summary>
	/// Key: "Label.sLogout"
	/// English String: "Logout"
	/// </summary>
	public override string LabelsLogout => "à¸­à¸­à¸à¸ˆà¸²à¸à¸£à¸°à¸šà¸š";

	/// <summary>
	/// Key: "Label.sRobux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelsRobux => "Robux";

	/// <summary>
	/// Key: "Label.sSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelsSettings => "à¸à¸²à¸£à¸•\u0e31\u0e49à¸‡à¸„\u0e48à¸²";

	public AlertsAndOptionsResources_th_th(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelsBuyRobux()
	{
		return "à¸‹\u0e37\u0e49à¸­ Robux";
	}

	protected override string _GetTemplateForLabelsHelp()
	{
		return "à¸Š\u0e48à¸§à¸¢à¹€à¸«à¸¥\u0e37à¸­";
	}

	protected override string _GetTemplateForLabelsLogout()
	{
		return "à¸­à¸­à¸à¸ˆà¸²à¸à¸£à¸°à¸šà¸š";
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
		return "à¸à¸²à¸£à¸•\u0e31\u0e49à¸‡à¸„\u0e48à¸²";
	}
}


}
