namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PlaceThumbnailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlaceThumbnailsResources_de_de : PlaceThumbnailsResources_en_us, IPlaceThumbnailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueToVideo"
	/// The button text that user confirm for leaving to Youtube
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueToVideo => "Weiter zum Video";

	/// <summary>
	/// Key: "Description.LeaveRobloxForYouTube"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "You are about to leave Roblox to view a video on YouTube."
	/// </summary>
	public override string DescriptionLeaveRobloxForYouTube => "Du verlässt jetzt Roblox, um dir ein Video auf YouTube anzusehen.";

	/// <summary>
	/// Key: "Description.YouTubeIsNotRoblox"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "YouTube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionYouTubeIsNotRoblox => "YouTube gehört nicht zu Roblox.com und unterliegt seinen eigenen Datenschutzrichtlinien.";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// The title of the dialog that will show up when user is leaving Roblox to Youtube
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "Du verlässt jetzt Roblox";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "Weiter";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "Zurück";

	public PlaceThumbnailsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueToVideo()
	{
		return "Weiter zum Video";
	}

	protected override string _GetTemplateForDescriptionLeaveRobloxForYouTube()
	{
		return "Du verlässt jetzt Roblox, um dir ein Video auf YouTube anzusehen.";
	}

	protected override string _GetTemplateForDescriptionYouTubeIsNotRoblox()
	{
		return "YouTube gehört nicht zu Roblox.com und unterliegt seinen eigenen Datenschutzrichtlinien.";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "Du verlässt jetzt Roblox";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "Weiter";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "Zurück";
	}
}
