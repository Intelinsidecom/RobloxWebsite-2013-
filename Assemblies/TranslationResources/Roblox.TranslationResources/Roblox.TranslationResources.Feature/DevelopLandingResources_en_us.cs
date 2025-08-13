using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class DevelopLandingResources_en_us : TranslationResourcesBase, IDevelopLandingResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.ManageMyGames"
	/// button label
	/// English String: "Manage my games"
	/// </summary>
	public virtual string ActionManageMyGames => "Manage my games";

	/// <summary>
	/// Key: "Action.RobloxDevHub"
	/// English String: "Continue to the Developer Hub"
	/// </summary>
	public virtual string ActionRobloxDevHub => "Continue to the Developer Hub";

	/// <summary>
	/// Key: "Action.RobloxWiki"
	/// button label
	/// English String: "Continue to Roblox Wiki"
	/// </summary>
	public virtual string ActionRobloxWiki => "Continue to Roblox Wiki";

	/// <summary>
	/// Key: "Action.StartCreating"
	/// button label
	/// English String: "Start Creating"
	/// </summary>
	public virtual string ActionStartCreating => "Start Creating";

	/// <summary>
	/// Key: "Description.EarnSeriousCash"
	/// description
	/// English String: "Creators like you are getting paid for what they love to do. Our top developers are earning over $2M a year by providing in-game purchases"
	/// </summary>
	public virtual string DescriptionEarnSeriousCash => "Creators like you are getting paid for what they love to do. Our top developers are earning over $2M a year by providing in-game purchases";

	/// <summary>
	/// Key: "Description.FreeImmersiveCreationEngine"
	/// subtext
	/// English String: "With our FREE and immersive creation engine"
	/// </summary>
	public virtual string DescriptionFreeImmersiveCreationEngine => "With our FREE and immersive creation engine";

	/// <summary>
	/// Key: "Description.MakeAnything"
	/// text paragraph on page
	/// English String: "Roblox Studio lets you create anything and release with one click to smartphones, tablets, desktops, consoles, and virtual reality devices"
	/// </summary>
	public virtual string DescriptionMakeAnything => "Roblox Studio lets you create anything and release with one click to smartphones, tablets, desktops, consoles, and virtual reality devices";

	/// <summary>
	/// Key: "Description.ReachMillionsPlayers"
	/// description
	/// English String: "Connect with a massive audience by tapping into an incredibly enthusiastic and international community of over 50 million monthly players"
	/// </summary>
	public virtual string DescriptionReachMillionsPlayers => "Connect with a massive audience by tapping into an incredibly enthusiastic and international community of over 50 million monthly players";

	/// <summary>
	/// Key: "Description.RobloxDevHub"
	/// English String: "The Developer Hub is your one-stop shop for publishing on Roblox. Learn from a wide set of tutorials, connect with other developers, get platform updates, browse our API references, and much more."
	/// </summary>
	public virtual string DescriptionRobloxDevHub => "The Developer Hub is your one-stop shop for publishing on Roblox. Learn from a wide set of tutorials, connect with other developers, get platform updates, browse our API references, and much more.";

	/// <summary>
	/// Key: "Description.RobloxWiki"
	/// description
	/// English String: "The Roblox Wiki is the ultimate resource for documentation, tutorials, and samples which will help you learn to make games with Roblox Studio"
	/// </summary>
	public virtual string DescriptionRobloxWiki => "The Roblox Wiki is the ultimate resource for documentation, tutorials, and samples which will help you learn to make games with Roblox Studio";

	/// <summary>
	/// Key: "Description.TestimonialAlexBalfanz"
	/// testimonial
	/// English String: "Roblox was so easy to get into. You can have a whole career on it because it’s such a hot platform and the team there is always providing great resources for developers."
	/// </summary>
	public virtual string DescriptionTestimonialAlexBalfanz => "Roblox was so easy to get into. You can have a whole career on it because it’s such a hot platform and the team there is always providing great resources for developers.";

	/// <summary>
	/// Key: "Description.TestimonialAndrewBereza"
	/// testimonial text
	/// English String: "Roblox allows me to focus on my game development and potential future career without having to worry about the financial hardships of being a college student."
	/// </summary>
	public virtual string DescriptionTestimonialAndrewBereza => "Roblox allows me to focus on my game development and potential future career without having to worry about the financial hardships of being a college student.";

	/// <summary>
	/// Key: "Description.TestimonialJacksonMunsell"
	/// testimonial
	/// English String: "I enjoy creating games on Roblox because it’s social. It takes the socialization of platforms like Facebook to a new level with the games and creativity of the community."
	/// </summary>
	public virtual string DescriptionTestimonialJacksonMunsell => "I enjoy creating games on Roblox because it’s social. It takes the socialization of platforms like Facebook to a new level with the games and creativity of the community.";

	/// <summary>
	/// Key: "Description.TestimonialOne"
	/// testimonial content
	/// English String: "Roblox allows me to focus on my game development and potential future career without having to worry about the financial hardships of being a college student."
	/// </summary>
	public virtual string DescriptionTestimonialOne => "Roblox allows me to focus on my game development and potential future career without having to worry about the financial hardships of being a college student.";

	/// <summary>
	/// Key: "Description.TestimonialThree"
	/// testimonial text
	/// English String: "Roblox was so easy to get into. You can have a whole career on it because it’s such a hot platform and the team there is always providing great resources for developers."
	/// </summary>
	public virtual string DescriptionTestimonialThree => "Roblox was so easy to get into. You can have a whole career on it because it’s such a hot platform and the team there is always providing great resources for developers.";

	/// <summary>
	/// Key: "Description.TestimonialTwo"
	/// description
	/// English String: "I enjoy creating games on Roblox because it’s social. It takes the socialization of platforms like Facebook to a new level with the games and creativity of the community."
	/// </summary>
	public virtual string DescriptionTestimonialTwo => "I enjoy creating games on Roblox because it’s social. It takes the socialization of platforms like Facebook to a new level with the games and creativity of the community.";

	/// <summary>
	/// Key: "Heading.EarnSeriousCash"
	/// heading
	/// English String: "Earn Serious Cash"
	/// </summary>
	public virtual string HeadingEarnSeriousCash => "Earn Serious Cash";

	/// <summary>
	/// Key: "Heading.MakeAnything"
	/// heading
	/// English String: "Make Anything You Can Imagine"
	/// </summary>
	public virtual string HeadingMakeAnything => "Make Anything You Can Imagine";

	/// <summary>
	/// Key: "Heading.MakeAnythingSub"
	/// section heading
	/// English String: "Make Anything"
	/// </summary>
	public virtual string HeadingMakeAnythingSub => "Make Anything";

	/// <summary>
	/// Key: "Heading.ReachMillionsPlayers"
	/// heading
	/// English String: "Reach Millions of Players"
	/// </summary>
	public virtual string HeadingReachMillionsPlayers => "Reach Millions of Players";

	/// <summary>
	/// Key: "Heading.RobloxDevHub"
	/// English String: "Developer Hub"
	/// </summary>
	public virtual string HeadingRobloxDevHub => "Developer Hub";

	/// <summary>
	/// Key: "Heading.RobloxWiki"
	/// heading
	/// English String: "Roblox Wiki"
	/// </summary>
	public virtual string HeadingRobloxWiki => "Roblox Wiki";

	/// <summary>
	/// Key: "Heading.Studio"
	/// heading
	/// English String: "Studio"
	/// </summary>
	public virtual string HeadingStudio => "Studio";

	/// <summary>
	/// Key: "Heading.TryFreeRobloxStudioToday"
	/// heading
	/// English String: "Roblox Studio is FREE! Try it out today!"
	/// </summary>
	public virtual string HeadingTryFreeRobloxStudioToday => "Roblox Studio is FREE! Try it out today!";

	/// <summary>
	/// Key: "Heading.WhatCreatorsSaying"
	/// heading
	/// English String: "What Our Creators Are Saying"
	/// </summary>
	public virtual string HeadingWhatCreatorsSaying => "What Our Creators Are Saying";

	/// <summary>
	/// Key: "Label.CreateWithFriends"
	/// label
	/// English String: "Create With Friends"
	/// </summary>
	public virtual string LabelCreateWithFriends => "Create With Friends";

	/// <summary>
	/// Key: "Label.GetStarted"
	/// label
	/// English String: "Get Started"
	/// </summary>
	public virtual string LabelGetStarted => "Get Started";

	/// <summary>
	/// Key: "Label.GoToTop"
	/// label
	/// English String: "Go to top"
	/// </summary>
	public virtual string LabelGoToTop => "Go to top";

	/// <summary>
	/// Key: "Label.QuotationMark"
	/// image alt text for accessibility
	/// English String: "Quotation Mark"
	/// </summary>
	public virtual string LabelQuotationMark => "Quotation Mark";

	/// <summary>
	/// Key: "Label.RobloxStudioOnWindowsAndMac"
	/// label
	/// English String: "Roblox Studio is available on Windows and Mac"
	/// </summary>
	public virtual string LabelRobloxStudioOnWindowsAndMac => "Roblox Studio is available on Windows and Mac";

	/// <summary>
	/// Key: "Label.TestimonialOneName"
	/// label - no need to translate this
	/// English String: "Andrew Bereza"
	/// </summary>
	public virtual string LabelTestimonialOneName => "Andrew Bereza";

	/// <summary>
	/// Key: "Label.TestimonialThreeName"
	/// name - please do not translate this
	/// English String: "Alex Balfanz"
	/// </summary>
	public virtual string LabelTestimonialThreeName => "Alex Balfanz";

	/// <summary>
	/// Key: "Label.TestimonialTwoName"
	/// name - please do not translate this
	/// English String: "Jackson Munsell"
	/// </summary>
	public virtual string LabelTestimonialTwoName => "Jackson Munsell";

	public DevelopLandingResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.ManageMyGames",
				_GetTemplateForActionManageMyGames()
			},
			{
				"Action.RobloxDevHub",
				_GetTemplateForActionRobloxDevHub()
			},
			{
				"Action.RobloxWiki",
				_GetTemplateForActionRobloxWiki()
			},
			{
				"Action.StartCreating",
				_GetTemplateForActionStartCreating()
			},
			{
				"Description.EarnSeriousCash",
				_GetTemplateForDescriptionEarnSeriousCash()
			},
			{
				"Description.FreeImmersiveCreationEngine",
				_GetTemplateForDescriptionFreeImmersiveCreationEngine()
			},
			{
				"Description.MakeAnything",
				_GetTemplateForDescriptionMakeAnything()
			},
			{
				"Description.ReachMillionsPlayers",
				_GetTemplateForDescriptionReachMillionsPlayers()
			},
			{
				"Description.RobloxDevHub",
				_GetTemplateForDescriptionRobloxDevHub()
			},
			{
				"Description.RobloxWiki",
				_GetTemplateForDescriptionRobloxWiki()
			},
			{
				"Description.TestimonialAlexBalfanz",
				_GetTemplateForDescriptionTestimonialAlexBalfanz()
			},
			{
				"Description.TestimonialAndrewBereza",
				_GetTemplateForDescriptionTestimonialAndrewBereza()
			},
			{
				"Description.TestimonialJacksonMunsell",
				_GetTemplateForDescriptionTestimonialJacksonMunsell()
			},
			{
				"Description.TestimonialOne",
				_GetTemplateForDescriptionTestimonialOne()
			},
			{
				"Description.TestimonialThree",
				_GetTemplateForDescriptionTestimonialThree()
			},
			{
				"Description.TestimonialTwo",
				_GetTemplateForDescriptionTestimonialTwo()
			},
			{
				"Heading.EarnSeriousCash",
				_GetTemplateForHeadingEarnSeriousCash()
			},
			{
				"Heading.MakeAnything",
				_GetTemplateForHeadingMakeAnything()
			},
			{
				"Heading.MakeAnythingSub",
				_GetTemplateForHeadingMakeAnythingSub()
			},
			{
				"Heading.ReachMillionsPlayers",
				_GetTemplateForHeadingReachMillionsPlayers()
			},
			{
				"Heading.RobloxDevHub",
				_GetTemplateForHeadingRobloxDevHub()
			},
			{
				"Heading.RobloxWiki",
				_GetTemplateForHeadingRobloxWiki()
			},
			{
				"Heading.Studio",
				_GetTemplateForHeadingStudio()
			},
			{
				"Heading.TryFreeRobloxStudioToday",
				_GetTemplateForHeadingTryFreeRobloxStudioToday()
			},
			{
				"Heading.WhatCreatorsSaying",
				_GetTemplateForHeadingWhatCreatorsSaying()
			},
			{
				"Label.CreateWithFriends",
				_GetTemplateForLabelCreateWithFriends()
			},
			{
				"Label.GetStarted",
				_GetTemplateForLabelGetStarted()
			},
			{
				"Label.GoToTop",
				_GetTemplateForLabelGoToTop()
			},
			{
				"Label.QuotationMark",
				_GetTemplateForLabelQuotationMark()
			},
			{
				"Label.RobloxStudioOnWindowsAndMac",
				_GetTemplateForLabelRobloxStudioOnWindowsAndMac()
			},
			{
				"Label.TestimonialOneName",
				_GetTemplateForLabelTestimonialOneName()
			},
			{
				"Label.TestimonialThreeName",
				_GetTemplateForLabelTestimonialThreeName()
			},
			{
				"Label.TestimonialTwoName",
				_GetTemplateForLabelTestimonialTwoName()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.DevelopLanding";
	}

	protected virtual string _GetTemplateForActionManageMyGames()
	{
		return "Manage my games";
	}

	protected virtual string _GetTemplateForActionRobloxDevHub()
	{
		return "Continue to the Developer Hub";
	}

	protected virtual string _GetTemplateForActionRobloxWiki()
	{
		return "Continue to Roblox Wiki";
	}

	protected virtual string _GetTemplateForActionStartCreating()
	{
		return "Start Creating";
	}

	protected virtual string _GetTemplateForDescriptionEarnSeriousCash()
	{
		return "Creators like you are getting paid for what they love to do. Our top developers are earning over $2M a year by providing in-game purchases";
	}

	protected virtual string _GetTemplateForDescriptionFreeImmersiveCreationEngine()
	{
		return "With our FREE and immersive creation engine";
	}

	protected virtual string _GetTemplateForDescriptionMakeAnything()
	{
		return "Roblox Studio lets you create anything and release with one click to smartphones, tablets, desktops, consoles, and virtual reality devices";
	}

	protected virtual string _GetTemplateForDescriptionReachMillionsPlayers()
	{
		return "Connect with a massive audience by tapping into an incredibly enthusiastic and international community of over 50 million monthly players";
	}

	protected virtual string _GetTemplateForDescriptionRobloxDevHub()
	{
		return "The Developer Hub is your one-stop shop for publishing on Roblox. Learn from a wide set of tutorials, connect with other developers, get platform updates, browse our API references, and much more.";
	}

	protected virtual string _GetTemplateForDescriptionRobloxWiki()
	{
		return "The Roblox Wiki is the ultimate resource for documentation, tutorials, and samples which will help you learn to make games with Roblox Studio";
	}

	protected virtual string _GetTemplateForDescriptionTestimonialAlexBalfanz()
	{
		return "Roblox was so easy to get into. You can have a whole career on it because it’s such a hot platform and the team there is always providing great resources for developers.";
	}

	protected virtual string _GetTemplateForDescriptionTestimonialAndrewBereza()
	{
		return "Roblox allows me to focus on my game development and potential future career without having to worry about the financial hardships of being a college student.";
	}

	protected virtual string _GetTemplateForDescriptionTestimonialJacksonMunsell()
	{
		return "I enjoy creating games on Roblox because it’s social. It takes the socialization of platforms like Facebook to a new level with the games and creativity of the community.";
	}

	protected virtual string _GetTemplateForDescriptionTestimonialOne()
	{
		return "Roblox allows me to focus on my game development and potential future career without having to worry about the financial hardships of being a college student.";
	}

	protected virtual string _GetTemplateForDescriptionTestimonialThree()
	{
		return "Roblox was so easy to get into. You can have a whole career on it because it’s such a hot platform and the team there is always providing great resources for developers.";
	}

	protected virtual string _GetTemplateForDescriptionTestimonialTwo()
	{
		return "I enjoy creating games on Roblox because it’s social. It takes the socialization of platforms like Facebook to a new level with the games and creativity of the community.";
	}

	protected virtual string _GetTemplateForHeadingEarnSeriousCash()
	{
		return "Earn Serious Cash";
	}

	protected virtual string _GetTemplateForHeadingMakeAnything()
	{
		return "Make Anything You Can Imagine";
	}

	protected virtual string _GetTemplateForHeadingMakeAnythingSub()
	{
		return "Make Anything";
	}

	protected virtual string _GetTemplateForHeadingReachMillionsPlayers()
	{
		return "Reach Millions of Players";
	}

	protected virtual string _GetTemplateForHeadingRobloxDevHub()
	{
		return "Developer Hub";
	}

	protected virtual string _GetTemplateForHeadingRobloxWiki()
	{
		return "Roblox Wiki";
	}

	protected virtual string _GetTemplateForHeadingStudio()
	{
		return "Studio";
	}

	protected virtual string _GetTemplateForHeadingTryFreeRobloxStudioToday()
	{
		return "Roblox Studio is FREE! Try it out today!";
	}

	protected virtual string _GetTemplateForHeadingWhatCreatorsSaying()
	{
		return "What Our Creators Are Saying";
	}

	protected virtual string _GetTemplateForLabelCreateWithFriends()
	{
		return "Create With Friends";
	}

	protected virtual string _GetTemplateForLabelGetStarted()
	{
		return "Get Started";
	}

	protected virtual string _GetTemplateForLabelGoToTop()
	{
		return "Go to top";
	}

	protected virtual string _GetTemplateForLabelQuotationMark()
	{
		return "Quotation Mark";
	}

	protected virtual string _GetTemplateForLabelRobloxStudioOnWindowsAndMac()
	{
		return "Roblox Studio is available on Windows and Mac";
	}

	protected virtual string _GetTemplateForLabelTestimonialOneName()
	{
		return "Andrew Bereza";
	}

	protected virtual string _GetTemplateForLabelTestimonialThreeName()
	{
		return "Alex Balfanz";
	}

	protected virtual string _GetTemplateForLabelTestimonialTwoName()
	{
		return "Jackson Munsell";
	}
}
