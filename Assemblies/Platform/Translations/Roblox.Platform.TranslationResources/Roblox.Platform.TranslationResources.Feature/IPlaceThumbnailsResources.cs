namespace Roblox.TranslationResources.Feature;

public interface IPlaceThumbnailsResources : ITranslationResources
{
	/// <summary>
	/// Key: "Action.ContinueToVideo"
	/// The button text that user confirm for leaving to Youtube
	/// English String: "Continue to Video"
	/// </summary>
	string ActionContinueToVideo { get; }

	/// <summary>
	/// Key: "Description.LeaveRobloxForYouTube"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "You are about to leave Roblox to view a video on YouTube."
	/// </summary>
	string DescriptionLeaveRobloxForYouTube { get; }

	/// <summary>
	/// Key: "Description.YouTubeIsNotRoblox"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "YouTube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	string DescriptionYouTubeIsNotRoblox { get; }

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// The title of the dialog that will show up when user is leaving Roblox to Youtube
	/// English String: "You are leaving Roblox"
	/// </summary>
	string HeadingLeavingRoblox { get; }

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	string LabelNext { get; }

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	string LabelPrevious { get; }
}
