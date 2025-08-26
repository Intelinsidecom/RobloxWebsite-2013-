namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides AlertsAndOptionsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class AlertsAndOptionsResources_vi_vn : AlertsAndOptionsResources_en_us, IAlertsAndOptionsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Label.sBuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public override string LabelsBuyRobux => "Mua Robux";

	/// <summary>
	/// Key: "Label.sHelp"
	/// English String: "Help"
	/// </summary>
	public override string LabelsHelp => "Trá»£ giÃºp";

	/// <summary>
	/// Key: "Label.sLogout"
	/// English String: "Logout"
	/// </summary>
	public override string LabelsLogout => "ÄÄƒng xuáº¥t";

	/// <summary>
	/// Key: "Label.sRobux"
	/// English String: "Robux"
	/// </summary>
	public override string LabelsRobux => "Robux";

	/// <summary>
	/// Key: "Label.sSettings"
	/// English String: "Settings"
	/// </summary>
	public override string LabelsSettings => "CÃ i Ä‘áº·t";

	public AlertsAndOptionsResources_vi_vn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLabelsBuyRobux()
	{
		return "Mua Robux";
	}

	protected override string _GetTemplateForLabelsHelp()
	{
		return "Trá»£ giÃºp";
	}

	protected override string _GetTemplateForLabelsLogout()
	{
		return "ÄÄƒng xuáº¥t";
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
		return "CÃ i Ä‘áº·t";
	}
}


}
