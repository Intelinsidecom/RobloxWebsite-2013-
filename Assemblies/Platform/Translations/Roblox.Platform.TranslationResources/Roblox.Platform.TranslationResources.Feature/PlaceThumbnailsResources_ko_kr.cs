namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PlaceThumbnailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlaceThumbnailsResources_ko_kr : PlaceThumbnailsResources_en_us, IPlaceThumbnailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueToVideo"
	/// The button text that user confirm for leaving to Youtube
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueToVideo => "ë¹„ë””ì˜¤ ê³„ì† ë³´ê¸°";

	/// <summary>
	/// Key: "Description.LeaveRobloxForYouTube"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "You are about to leave Roblox to view a video on YouTube."
	/// </summary>
	public override string DescriptionLeaveRobloxForYouTube => "Robloxë¥¼ ë‚˜ê°€ YouTube ë¹„ë””ì˜¤ë¥¼ ì‹œì²­í•˜ë ¤ í•˜ì‹œëŠ”êµ°ìš”.";

	/// <summary>
	/// Key: "Description.YouTubeIsNotRoblox"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "YouTube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionYouTubeIsNotRoblox => "YouTubeëŠ” Roblox.comê³¼ëŠ” ë³„ê°œì˜ ì½˜í…ì¸ ë¡œ ë³„ë„ì˜ ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨ì´ ì ìš©ë©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// The title of the dialog that will show up when user is leaving Roblox to Youtube
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "Robloxë¥¼ ë– ë‚˜ê²Œ ë¼ìš”";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "ë‹¤ìŒ";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "ì´ì „";

	public PlaceThumbnailsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueToVideo()
	{
		return "ë¹„ë””ì˜¤ ê³„ì† ë³´ê¸°";
	}

	protected override string _GetTemplateForDescriptionLeaveRobloxForYouTube()
	{
		return "Robloxë¥¼ ë‚˜ê°€ YouTube ë¹„ë””ì˜¤ë¥¼ ì‹œì²­í•˜ë ¤ í•˜ì‹œëŠ”êµ°ìš”.";
	}

	protected override string _GetTemplateForDescriptionYouTubeIsNotRoblox()
	{
		return "YouTubeëŠ” Roblox.comê³¼ëŠ” ë³„ê°œì˜ ì½˜í…ì¸ ë¡œ ë³„ë„ì˜ ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨ì´ ì ìš©ë©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "Robloxë¥¼ ë– ë‚˜ê²Œ ë¼ìš”";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "ë‹¤ìŒ";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "ì´ì „";
	}
}


}
