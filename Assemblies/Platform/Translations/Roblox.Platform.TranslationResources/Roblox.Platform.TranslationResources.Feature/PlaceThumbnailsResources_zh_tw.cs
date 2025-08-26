namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PlaceThumbnailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlaceThumbnailsResources_zh_tw : PlaceThumbnailsResources_en_us, IPlaceThumbnailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueToVideo"
	/// The button text that user confirm for leaving to Youtube
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueToVideo => "å‰å¾€å½±ç‰‡";

	/// <summary>
	/// Key: "Description.LeaveRobloxForYouTube"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "You are about to leave Roblox to view a video on YouTube."
	/// </summary>
	public override string DescriptionLeaveRobloxForYouTube => "æ‚¨å³å°‡é›¢é–‹ Robloxï¼Œä¸¦å‰å¾€ YouTube è§€çœ‹å½±ç‰‡ã€‚";

	/// <summary>
	/// Key: "Description.YouTubeIsNotRoblox"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "YouTube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionYouTubeIsNotRoblox => "YouTubeä¸å±¬æ–¼Roblox.comï¼Œå—å–®ç¨çš„éš±ç§æ¬Šæ”¿ç­–ç®¡ç†ã€‚";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// The title of the dialog that will show up when user is leaving Roblox to Youtube
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "æ‚¨å³å°‡é›¢é–‹ Roblox";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "ä¸‹ä¸€å€‹";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "ä¸Šä¸€å€‹";

	public PlaceThumbnailsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueToVideo()
	{
		return "å‰å¾€å½±ç‰‡";
	}

	protected override string _GetTemplateForDescriptionLeaveRobloxForYouTube()
	{
		return "æ‚¨å³å°‡é›¢é–‹ Robloxï¼Œä¸¦å‰å¾€ YouTube è§€çœ‹å½±ç‰‡ã€‚";
	}

	protected override string _GetTemplateForDescriptionYouTubeIsNotRoblox()
	{
		return "YouTubeä¸å±¬æ–¼Roblox.comï¼Œå—å–®ç¨çš„éš±ç§æ¬Šæ”¿ç­–ç®¡ç†ã€‚";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "æ‚¨å³å°‡é›¢é–‹ Roblox";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "ä¸‹ä¸€å€‹";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "ä¸Šä¸€å€‹";
	}
}


}
