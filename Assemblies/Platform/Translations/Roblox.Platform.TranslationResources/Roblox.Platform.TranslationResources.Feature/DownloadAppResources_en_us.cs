using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class DownloadAppResources_en_us : TranslationResourcesBase, IDownloadAppResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.ContinueInApp"
	/// button label
	/// English String: "Continue in App"
	/// </summary>
	public virtual string ActionContinueInApp => "Continue in App";

	/// <summary>
	/// Key: "Action.ContinueInBrowser"
	/// button label
	/// English String: "Continue in browser"
	/// </summary>
	public virtual string ActionContinueInBrowser => "Continue in browser";

	/// <summary>
	/// Key: "Action.Play"
	/// Button that takes the user to the game.
	/// English String: "Play"
	/// </summary>
	public virtual string ActionPlay => "Play";

	/// <summary>
	/// Key: "Heading.RobloxForAndroid"
	/// heading for the page
	/// English String: "Roblox for Android"
	/// </summary>
	public virtual string HeadingRobloxForAndroid => "Roblox for Android";

	/// <summary>
	/// Key: "Heading.RobloxForIos"
	/// heading for page
	/// English String: "Roblox for iOS"
	/// </summary>
	public virtual string HeadingRobloxForIos => "Roblox for iOS";

	/// <summary>
	/// Key: "Label.PlayGamesInMobile"
	/// section title
	/// English String: "Play Roblox in our mobile app!"
	/// </summary>
	public virtual string LabelPlayGamesInMobile => "Play Roblox in our mobile app!";

	/// <summary>
	/// Key: "Message.AppBumpAndroidDevice"
	/// The user is being encouraged to play on the native mobile Android app
	/// English String: "Play Roblox in our Android app!"
	/// </summary>
	public virtual string MessageAppBumpAndroidDevice => "Play Roblox in our Android app!";

	/// <summary>
	/// Key: "Message.AppBumperUpsell"
	/// The user is being encouraged to play through the mobile app.
	/// English String: "Millions of games by players like you"
	/// </summary>
	public virtual string MessageAppBumperUpsell => "Millions of games by players like you";

	/// <summary>
	/// Key: "Message.AppBumpIOSDevice"
	/// The user is being encouraged to play on the native mobile iOS app
	/// English String: "Play Roblox in our iOS app!"
	/// </summary>
	public virtual string MessageAppBumpIOSDevice => "Play Roblox in our iOS app!";

	public DownloadAppResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.ContinueInApp",
				_GetTemplateForActionContinueInApp()
			},
			{
				"Action.ContinueInBrowser",
				_GetTemplateForActionContinueInBrowser()
			},
			{
				"Action.Play",
				_GetTemplateForActionPlay()
			},
			{
				"Heading.RobloxForAndroid",
				_GetTemplateForHeadingRobloxForAndroid()
			},
			{
				"Heading.RobloxForIos",
				_GetTemplateForHeadingRobloxForIos()
			},
			{
				"Label.PlayGamesInMobile",
				_GetTemplateForLabelPlayGamesInMobile()
			},
			{
				"Label.ReviewsCount",
				_GetTemplateForLabelReviewsCount()
			},
			{
				"Message.AppBumpAndroidDevice",
				_GetTemplateForMessageAppBumpAndroidDevice()
			},
			{
				"Message.AppBumperUpsell",
				_GetTemplateForMessageAppBumperUpsell()
			},
			{
				"Message.AppBumpIOSDevice",
				_GetTemplateForMessageAppBumpIOSDevice()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.DownloadApp";
	}

	protected virtual string _GetTemplateForActionContinueInApp()
	{
		return "Continue in App";
	}

	protected virtual string _GetTemplateForActionContinueInBrowser()
	{
		return "Continue in browser";
	}

	protected virtual string _GetTemplateForActionPlay()
	{
		return "Play";
	}

	protected virtual string _GetTemplateForHeadingRobloxForAndroid()
	{
		return "Roblox for Android";
	}

	protected virtual string _GetTemplateForHeadingRobloxForIos()
	{
		return "Roblox for iOS";
	}

	protected virtual string _GetTemplateForLabelPlayGamesInMobile()
	{
		return "Play Roblox in our mobile app!";
	}

	/// <summary>
	/// Key: "Label.ReviewsCount"
	/// label
	/// English String: "{reviewCount} reviews"
	/// </summary>
	public virtual string LabelReviewsCount(string reviewCount)
	{
		return $"{reviewCount} reviews";
	}

	protected virtual string _GetTemplateForLabelReviewsCount()
	{
		return "{reviewCount} reviews";
	}

	protected virtual string _GetTemplateForMessageAppBumpAndroidDevice()
	{
		return "Play Roblox in our Android app!";
	}

	protected virtual string _GetTemplateForMessageAppBumperUpsell()
	{
		return "Millions of games by players like you";
	}

	protected virtual string _GetTemplateForMessageAppBumpIOSDevice()
	{
		return "Play Roblox in our iOS app!";
	}
}
