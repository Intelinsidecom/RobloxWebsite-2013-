namespace Roblox.TranslationResources.Feature;

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
	public override string ActionContinueToVideo => "続けてビデオへ";

	/// <summary>
	/// Key: "Description.LeaveRobloxForYouTube"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "You are about to leave Roblox to view a video on YouTube."
	/// </summary>
	public override string DescriptionLeaveRobloxForYouTube => "Robloxを終了してYouTubeで動画を見ようとしています。";

	/// <summary>
	/// Key: "Description.YouTubeIsNotRoblox"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "YouTube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public override string DescriptionYouTubeIsNotRoblox => "YouTubeはRoblox.comのサイトの一部でないため、別のプライバシーポリシーで管理されています。";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// The title of the dialog that will show up when user is leaving Roblox to Youtube
	/// English String: "You are leaving Roblox"
	/// </summary>
	public override string HeadingLeavingRoblox => "Robloxを終了しています";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public override string LabelNext => "次へ";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public override string LabelPrevious => "前へ";

	public PlaceThumbnailsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionContinueToVideo()
	{
		return "続けてビデオへ";
	}

	protected override string _GetTemplateForDescriptionLeaveRobloxForYouTube()
	{
		return "Robloxを終了してYouTubeで動画を見ようとしています。";
	}

	protected override string _GetTemplateForDescriptionYouTubeIsNotRoblox()
	{
		return "YouTubeはRoblox.comのサイトの一部でないため、別のプライバシーポリシーで管理されています。";
	}

	protected override string _GetTemplateForHeadingLeavingRoblox()
	{
		return "Robloxを終了しています";
	}

	protected override string _GetTemplateForLabelNext()
	{
		return "次へ";
	}

	protected override string _GetTemplateForLabelPrevious()
	{
		return "前へ";
	}
}
