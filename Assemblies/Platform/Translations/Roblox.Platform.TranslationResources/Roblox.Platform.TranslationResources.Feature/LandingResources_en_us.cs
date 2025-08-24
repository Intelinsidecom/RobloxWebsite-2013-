using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class LandingResources_en_us : TranslationResourcesBase, ILandingResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphOne"
	/// first paragraph under Roblox on your device heading on landing page
	/// English String: "You can access Roblox on all modern smartphones, desktops, Xbox One, Oculus Rift, and soon on Daydream and Cardboard. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public virtual string DescriptionRobloxOnDeviceParagraphOne => "You can access Roblox on all modern smartphones, desktops, Xbox One, Oculus Rift, and soon on Daydream and Cardboard. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are.";

	/// <summary>
	/// Key: "Description.RobloxOnDeviceParagraphTwo"
	/// second paragraph under Roblox on Your Device on landing page
	/// English String: "You can access Roblox on PC, Mac, iOS, Android, Amazon Devices, and Xbox One. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are."
	/// </summary>
	public virtual string DescriptionRobloxOnDeviceParagraphTwo => "You can access Roblox on PC, Mac, iOS, Android, Amazon Devices, and Xbox One. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are.";

	/// <summary>
	/// Key: "Description.WhatIsRobloxParagraphOne"
	/// first paragraph under what's Roblox heading on landing page
	/// English String: "Roblox helps power the imagination of people around the world. As the largest growing social platform for play, over 44 million players come to Roblox every month to create adventures, play games, roleplay, and learn with friends. We call it the ‘Imagination Platform’ and believe everyone should have the right to play on it."
	/// </summary>
	public virtual string DescriptionWhatIsRobloxParagraphOne => "Roblox helps power the imagination of people around the world. As the largest growing social platform for play, over 44 million players come to Roblox every month to create adventures, play games, roleplay, and learn with friends. We call it the ‘Imagination Platform’ and believe everyone should have the right to play on it.";

	/// <summary>
	/// Key: "Heading.RobloxOnDevice"
	/// heading Roblox on your device
	/// English String: "Roblox on your Device"
	/// </summary>
	public virtual string HeadingRobloxOnDevice => "Roblox on your Device";

	/// <summary>
	/// Key: "Heading.WhatIsRoblox"
	/// heading for what is Roblox section on the landing page
	/// English String: "What is Roblox?"
	/// </summary>
	public virtual string HeadingWhatIsRoblox => "What is Roblox?";

	/// <summary>
	/// Key: "Heading.WhatIsRobloxParagraphTwo"
	/// second paragraph under what's Roblox on the landing page
	/// English String: "Roblox is the best place to Imagine with Friends. With the largest user-generated online gaming platform, and over 15 million games created by users, Roblox is the #1 gaming site for kids and teens (comScore). Every day, virtual explorers come to Roblox to create adventures, play games, role play, and learn with their friends in a family-friendly, immersive, 3D environment."
	/// </summary>
	public virtual string HeadingWhatIsRobloxParagraphTwo => "Roblox is the best place to Imagine with Friends. With the largest user-generated online gaming platform, and over 15 million games created by users, Roblox is the #1 gaming site for kids and teens (comScore). Every day, virtual explorers come to Roblox to create adventures, play games, role play, and learn with their friends in a family-friendly, immersive, 3D environment.";

	/// <summary>
	/// Key: "Label.About"
	/// about link on top left
	/// English String: "About"
	/// </summary>
	public virtual string LabelAbout => "About";

	/// <summary>
	/// Key: "Label.GetOnGooglePlay"
	/// Google play icon title
	/// English String: "Get it on Google Play"
	/// </summary>
	public virtual string LabelGetOnGooglePlay => "Get it on Google Play";

	/// <summary>
	/// Key: "Label.Platforms"
	/// platform link on top left
	/// English String: "Platforms"
	/// </summary>
	public virtual string LabelPlatforms => "Platforms";

	/// <summary>
	/// Key: "Label.Play"
	/// play link on top left
	/// English String: "Play"
	/// </summary>
	public virtual string LabelPlay => "Play";

	/// <summary>
	/// Key: "Label.RobloxAmazonStore"
	/// title for Amazon store icon
	/// English String: "Roblox on Amazon Store"
	/// </summary>
	public virtual string LabelRobloxAmazonStore => "Roblox on Amazon Store";

	/// <summary>
	/// Key: "Label.RobloxAppStore"
	/// the title for app store icon
	/// English String: "Roblox on App Store"
	/// </summary>
	public virtual string LabelRobloxAppStore => "Roblox on App Store";

	/// <summary>
	/// Key: "Label.RobloxOnXbox"
	/// title for Xbox icon
	/// English String: "Roblox on Xbox Store"
	/// </summary>
	public virtual string LabelRobloxOnXbox => "Roblox on Xbox Store";

	/// <summary>
	/// Key: "Label.RobloxWindowsStore"
	/// title for windows store icon
	/// English String: "Roblox on Windows Store"
	/// </summary>
	public virtual string LabelRobloxWindowsStore => "Roblox on Windows Store";

	public LandingResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Description.RobloxOnDeviceParagraphOne",
				_GetTemplateForDescriptionRobloxOnDeviceParagraphOne()
			},
			{
				"Description.RobloxOnDeviceParagraphTwo",
				_GetTemplateForDescriptionRobloxOnDeviceParagraphTwo()
			},
			{
				"Description.WhatIsRobloxParagraphOne",
				_GetTemplateForDescriptionWhatIsRobloxParagraphOne()
			},
			{
				"Heading.RobloxOnDevice",
				_GetTemplateForHeadingRobloxOnDevice()
			},
			{
				"Heading.WhatIsRoblox",
				_GetTemplateForHeadingWhatIsRoblox()
			},
			{
				"Heading.WhatIsRobloxParagraphTwo",
				_GetTemplateForHeadingWhatIsRobloxParagraphTwo()
			},
			{
				"Label.About",
				_GetTemplateForLabelAbout()
			},
			{
				"Label.GetOnGooglePlay",
				_GetTemplateForLabelGetOnGooglePlay()
			},
			{
				"Label.Platforms",
				_GetTemplateForLabelPlatforms()
			},
			{
				"Label.Play",
				_GetTemplateForLabelPlay()
			},
			{
				"Label.RobloxAmazonStore",
				_GetTemplateForLabelRobloxAmazonStore()
			},
			{
				"Label.RobloxAppStore",
				_GetTemplateForLabelRobloxAppStore()
			},
			{
				"Label.RobloxOnXbox",
				_GetTemplateForLabelRobloxOnXbox()
			},
			{
				"Label.RobloxWindowsStore",
				_GetTemplateForLabelRobloxWindowsStore()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Landing";
	}

	protected virtual string _GetTemplateForDescriptionRobloxOnDeviceParagraphOne()
	{
		return "You can access Roblox on all modern smartphones, desktops, Xbox One, Oculus Rift, and soon on Daydream and Cardboard. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are.";
	}

	protected virtual string _GetTemplateForDescriptionRobloxOnDeviceParagraphTwo()
	{
		return "You can access Roblox on PC, Mac, iOS, Android, Amazon Devices, and Xbox One. Roblox adventures are accessible from any device, so players can imagine with their friends regardless of where they are.";
	}

	protected virtual string _GetTemplateForDescriptionWhatIsRobloxParagraphOne()
	{
		return "Roblox helps power the imagination of people around the world. As the largest growing social platform for play, over 44 million players come to Roblox every month to create adventures, play games, roleplay, and learn with friends. We call it the ‘Imagination Platform’ and believe everyone should have the right to play on it.";
	}

	protected virtual string _GetTemplateForHeadingRobloxOnDevice()
	{
		return "Roblox on your Device";
	}

	protected virtual string _GetTemplateForHeadingWhatIsRoblox()
	{
		return "What is Roblox?";
	}

	protected virtual string _GetTemplateForHeadingWhatIsRobloxParagraphTwo()
	{
		return "Roblox is the best place to Imagine with Friends. With the largest user-generated online gaming platform, and over 15 million games created by users, Roblox is the #1 gaming site for kids and teens (comScore). Every day, virtual explorers come to Roblox to create adventures, play games, role play, and learn with their friends in a family-friendly, immersive, 3D environment.";
	}

	protected virtual string _GetTemplateForLabelAbout()
	{
		return "About";
	}

	protected virtual string _GetTemplateForLabelGetOnGooglePlay()
	{
		return "Get it on Google Play";
	}

	protected virtual string _GetTemplateForLabelPlatforms()
	{
		return "Platforms";
	}

	protected virtual string _GetTemplateForLabelPlay()
	{
		return "Play";
	}

	protected virtual string _GetTemplateForLabelRobloxAmazonStore()
	{
		return "Roblox on Amazon Store";
	}

	protected virtual string _GetTemplateForLabelRobloxAppStore()
	{
		return "Roblox on App Store";
	}

	protected virtual string _GetTemplateForLabelRobloxOnXbox()
	{
		return "Roblox on Xbox Store";
	}

	protected virtual string _GetTemplateForLabelRobloxWindowsStore()
	{
		return "Roblox on Windows Store";
	}
}
