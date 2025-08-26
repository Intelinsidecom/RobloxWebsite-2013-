namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PlaceThumbnailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PlaceThumbnailsResources_ja_jp : PlaceThumbnailsResources_en_us, IPlaceThumbnailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueToVideo"
	/// The button text that user confirm for leaving to Youtube
	/// English String: "Continue to Video"
	/// </summary>
	public override string ActionContinueToVideo => "ç¶šã‘ã¦ãƒ“ãƒ‡ã‚ªã¸";

	/// <summary>
	/// Key: "Description.LeaveRobloxForYouTube"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "You are about to leave Roblox to view a video on YouTube."
	/// </summary>
	public override string DescriptionLeaveRobloxForYouTube => "Robloxã‚’çµ‚äº†ã—ã¦YouTubeã§å‹•ç”»ã‚’è¦‹ã‚ˆã†ã¨ã—ã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Description.YouTubeIsNotRoblox"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "YouTube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionYouTubeIsNotRoblox => "YouTubeã¯Roblox.comã®ã‚µã‚¤ãƒˆã®ä¸€éƒ¨ã§ãªã„ãŸã‚ã€åˆ¥ã®ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼ã§ç®¡ç†ã•ã‚Œã¦ã„ã¾ã™ã€‚";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// The title of the dialog that will show up when user is leaving Roblox to Youtube
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "Robloxã‚’çµ‚äº†ã—ã¦ã„ã¾ã™";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "æ¬¡ã¸";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "å‰ã¸";

	public PlaceThumbnailsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueToVideo()
	{
		return "ç¶šã‘ã¦ãƒ“ãƒ‡ã‚ªã¸";
	}

	protected override string _GetTemplateForDescriptionLeaveRobloxForYouTube()
	{
		return "Robloxã‚’çµ‚äº†ã—ã¦YouTubeã§å‹•ç”»ã‚’è¦‹ã‚ˆã†ã¨ã—ã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForDescriptionYouTubeIsNotRoblox()
	{
		return "YouTubeã¯Roblox.comã®ã‚µã‚¤ãƒˆã®ä¸€éƒ¨ã§ãªã„ãŸã‚ã€åˆ¥ã®ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼ã§ç®¡ç†ã•ã‚Œã¦ã„ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "Robloxã‚’çµ‚äº†ã—ã¦ã„ã¾ã™";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "æ¬¡ã¸";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "å‰ã¸";
	}
}


}
