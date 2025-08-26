namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PlaceThumbnailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlaceThumbnailsResources_zh_cjv : PlaceThumbnailsResources_en_us, IPlaceThumbnailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueToVideo"
	/// The button text that user confirm for leaving to Youtube
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueToVideo => "ç»§ç»­å‰å¾€è§†é¢‘";

	/// <summary>
	/// Key: "Description.LeaveRobloxForYouTube"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "You are about to leave Roblox to view a video on YouTube."
	/// </summary>
	public override string DescriptionLeaveRobloxForYouTube => "ä½ å³å°†ç¦»å¼€ Robloxï¼Œå‰å¾€ Youtube è§‚çœ‹è§†é¢‘ã€‚";

	/// <summary>
	/// Key: "Description.YouTubeIsNotRoblox"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "YouTube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionYouTubeIsNotRoblox => "Youtube ä¸å±žäºŽ Roblox.comï¼Œå—å•ç‹¬éšç§æ”¿ç­–çš„ç›‘ç®¡ã€‚";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// The title of the dialog that will show up when user is leaving Roblox to Youtube
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "ä½ å³å°†ç¦»å¼€ Roblox";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "ä¸‹ä¸€æ­¥";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "ä¸Šä¸€æ­¥";

	public PlaceThumbnailsResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueToVideo()
	{
		return "ç»§ç»­å‰å¾€è§†é¢‘";
	}

	protected override string _GetTemplateForDescriptionLeaveRobloxForYouTube()
	{
		return "ä½ å³å°†ç¦»å¼€ Robloxï¼Œå‰å¾€ Youtube è§‚çœ‹è§†é¢‘ã€‚";
	}

	protected override string _GetTemplateForDescriptionYouTubeIsNotRoblox()
	{
		return "Youtube ä¸å±žäºŽ Roblox.comï¼Œå—å•ç‹¬éšç§æ”¿ç­–çš„ç›‘ç®¡ã€‚";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "ä½ å³å°†ç¦»å¼€ Roblox";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "ä¸‹ä¸€æ­¥";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "ä¸Šä¸€æ­¥";
	}
}


}
