using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PlaceThumbnailsResources_en_us : TranslationResourcesBase, IPlaceThumbnailsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.ContinueToVideo"
	/// The button text that user confirm for leaving to Youtube
	/// English String: "Continue to Video"
	/// </summary>
	public virtual string ActionContinueToVideo => "Continue to Video";

	/// <summary>
	/// Key: "Description.LeaveRobloxForYouTube"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "You are about to leave Roblox to view a video on YouTube."
	/// </summary>
	public virtual string DescriptionLeaveRobloxForYouTube => "You are about to leave Roblox to view a video on YouTube.";

	/// <summary>
	/// Key: "Description.YouTubeIsNotRoblox"
	/// The content of the dialog that will show up when user is leaving Roblox to YouTube
	/// English String: "YouTube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public virtual string DescriptionYouTubeIsNotRoblox => "YouTube is not part of Roblox.com and is governed by a separate privacy policy.";

	/// <summary>
	/// Key: "Heading.LeavingRoblox"
	/// The title of the dialog that will show up when user is leaving Roblox to Youtube
	/// English String: "You are leaving Roblox"
	/// </summary>
	public virtual string HeadingLeavingRoblox => "You are leaving Roblox";

	/// <summary>
	/// Key: "Label.Next"
	/// English String: "Next"
	/// </summary>
	public virtual string LabelNext => "Next";

	/// <summary>
	/// Key: "Label.Previous"
	/// English String: "Previous"
	/// </summary>
	public virtual string LabelPrevious => "Previous";

	public PlaceThumbnailsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.ContinueToVideo",
				_GetTemplateForActionContinueToVideo()
			},
			{
				"Description.LeaveRobloxForYouTube",
				_GetTemplateForDescriptionLeaveRobloxForYouTube()
			},
			{
				"Description.YouTubeIsNotRoblox",
				_GetTemplateForDescriptionYouTubeIsNotRoblox()
			},
			{
				"Heading.LeavingRoblox",
				_GetTemplateForHeadingLeavingRoblox()
			},
			{
				"Label.Next",
				_GetTemplateForLabelNext()
			},
			{
				"Label.Previous",
				_GetTemplateForLabelPrevious()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.PlaceThumbnails";
	}

	protected virtual string _GetTemplateForActionContinueToVideo()
	{
		return "Continue to Video";
	}

	protected virtual string _GetTemplateForDescriptionLeaveRobloxForYouTube()
	{
		return "You are about to leave Roblox to view a video on YouTube.";
	}

	protected virtual string _GetTemplateForDescriptionYouTubeIsNotRoblox()
	{
		return "YouTube is not part of Roblox.com and is governed by a separate privacy policy.";
	}

	protected virtual string _GetTemplateForHeadingLeavingRoblox()
	{
		return "You are leaving Roblox";
	}

	protected virtual string _GetTemplateForLabelNext()
	{
		return "Next";
	}

	protected virtual string _GetTemplateForLabelPrevious()
	{
		return "Previous";
	}
}
