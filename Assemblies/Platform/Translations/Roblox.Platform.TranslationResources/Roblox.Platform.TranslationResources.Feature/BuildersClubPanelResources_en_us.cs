using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class BuildersClubPanelResources_en_us : TranslationResourcesBase, IBuildersClubPanelResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// button text
	/// English String: "Buy Robux"
	/// </summary>
	public virtual string ActionBuyRobux => "Buy Robux";

	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.RedeemCard"
	/// button text
	/// English String: "Redeem Card"
	/// </summary>
	public virtual string ActionRedeemCard => "Redeem Card";

	/// <summary>
	/// Key: "Action.UpdateCreditCard"
	/// button text
	/// English String: "Update Credit Card"
	/// </summary>
	public virtual string ActionUpdateCreditCard => "Update Credit Card";

	/// <summary>
	/// Key: "Action.WhereToBuy"
	/// button text
	/// English String: "Where to Buy"
	/// </summary>
	public virtual string ActionWhereToBuy => "Where to Buy";

	/// <summary>
	/// Key: "Description.BuyRobux"
	/// description text
	/// English String: "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. You’ll need Robux to make it all happen. What are you waiting for?"
	/// </summary>
	public virtual string DescriptionBuyRobux => "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. You’ll need Robux to make it all happen. What are you waiting for?";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// section heading
	/// English String: "Buy Robux"
	/// </summary>
	public virtual string HeadingBuyRobux => "Buy Robux";

	/// <summary>
	/// Key: "Heading.Cancellations"
	/// section heading
	/// English String: "Cancellation"
	/// </summary>
	public virtual string HeadingCancellations => "Cancellation";

	/// <summary>
	/// Key: "Heading.GameCards"
	/// section heading
	/// English String: "Game Cards"
	/// </summary>
	public virtual string HeadingGameCards => "Game Cards";

	/// <summary>
	/// Key: "Heading.Parents"
	/// section heading
	/// English String: "Parents"
	/// </summary>
	public virtual string HeadingParents => "Parents";

	/// <summary>
	/// Key: "Label.BuyRobuxWith"
	/// label - there are 2 images after the message about showing buying options
	/// English String: "Buy Robux with"
	/// </summary>
	public virtual string LabelBuyRobuxWith => "Buy Robux with";

	/// <summary>
	/// Key: "Label.Itunes"
	/// image alt tag text
	/// English String: "iTunes"
	/// </summary>
	public virtual string LabelItunes => "iTunes";

	/// <summary>
	/// Key: "Label.Rixty"
	/// image alt tag text
	/// English String: "Rixty"
	/// </summary>
	public virtual string LabelRixty => "Rixty";

	/// <summary>
	/// Key: "Label.RobloxGameCards"
	/// label
	/// English String: "Roblox Gamecards"
	/// </summary>
	public virtual string LabelRobloxGameCards => "Roblox Gamecards";

	public BuildersClubPanelResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.BuyRobux",
				_GetTemplateForActionBuyRobux()
			},
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.RedeemCard",
				_GetTemplateForActionRedeemCard()
			},
			{
				"Action.UpdateCreditCard",
				_GetTemplateForActionUpdateCreditCard()
			},
			{
				"Action.WhereToBuy",
				_GetTemplateForActionWhereToBuy()
			},
			{
				"Description.BillingPaymentHelp",
				_GetTemplateForDescriptionBillingPaymentHelp()
			},
			{
				"Description.BuyRobux",
				_GetTemplateForDescriptionBuyRobux()
			},
			{
				"Description.Cancellations",
				_GetTemplateForDescriptionCancellations()
			},
			{
				"Description.CancellationsPremium",
				_GetTemplateForDescriptionCancellationsPremium()
			},
			{
				"Description.LeanMoreKidsSafety",
				_GetTemplateForDescriptionLeanMoreKidsSafety()
			},
			{
				"Description.LearnMoreKidsSafetyPremium",
				_GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
			},
			{
				"Heading.BuyRobux",
				_GetTemplateForHeadingBuyRobux()
			},
			{
				"Heading.Cancellations",
				_GetTemplateForHeadingCancellations()
			},
			{
				"Heading.GameCards",
				_GetTemplateForHeadingGameCards()
			},
			{
				"Heading.Parents",
				_GetTemplateForHeadingParents()
			},
			{
				"Label.BuyRobuxWith",
				_GetTemplateForLabelBuyRobuxWith()
			},
			{
				"Label.CreditBalance",
				_GetTemplateForLabelCreditBalance()
			},
			{
				"Label.Itunes",
				_GetTemplateForLabelItunes()
			},
			{
				"Label.Rixty",
				_GetTemplateForLabelRixty()
			},
			{
				"Label.RobloxGameCards",
				_GetTemplateForLabelRobloxGameCards()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.BuildersClubPanel";
	}

	protected virtual string _GetTemplateForActionBuyRobux()
	{
		return "Buy Robux";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionRedeemCard()
	{
		return "Redeem Card";
	}

	protected virtual string _GetTemplateForActionUpdateCreditCard()
	{
		return "Update Credit Card";
	}

	protected virtual string _GetTemplateForActionWhereToBuy()
	{
		return "Where to Buy";
	}

	/// <summary>
	/// Key: "Description.BillingPaymentHelp"
	/// description - help text
	/// English String: "For billing and payment questions: {emailLink}"
	/// </summary>
	public virtual string DescriptionBillingPaymentHelp(string emailLink)
	{
		return $"For billing and payment questions: {emailLink}";
	}

	protected virtual string _GetTemplateForDescriptionBillingPaymentHelp()
	{
		return "For billing and payment questions: {emailLink}";
	}

	protected virtual string _GetTemplateForDescriptionBuyRobux()
	{
		return "Robux is the virtual currency used in many of our online games. You can also use Robux for finding a great look for your avatar. Get cool gear to take into multiplayer battles. Buy Limited items to sell and trade. You’ll need Robux to make it all happen. What are you waiting for?";
	}

	/// <summary>
	/// Key: "Description.Cancellations"
	/// description text
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public virtual string DescriptionCancellations(string linkStartTag, string linkEndTag)
	{
		return $"You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation.";
	}

	protected virtual string _GetTemplateForDescriptionCancellations()
	{
		return "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Builders Club privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation.";
	}

	/// <summary>
	/// Key: "Description.CancellationsPremium"
	/// English String: "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation."
	/// </summary>
	public virtual string DescriptionCancellationsPremium(string linkStartTag, string linkEndTag)
	{
		return $"You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation.";
	}

	protected virtual string _GetTemplateForDescriptionCancellationsPremium()
	{
		return "You can turn off membership auto renewal at any time before the renewal date and you will continue to receive Premium privileges for the remainder of the currently paid period. To turn off membership auto renewal, please click the 'Cancel Membership Renewal button' on the {linkStartTag}Billing{linkEndTag} tab of the Settings page and confirm the cancellation.";
	}

	/// <summary>
	/// Key: "Description.LeanMoreKidsSafety"
	/// description
	/// English String: "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public virtual string DescriptionLeanMoreKidsSafety(string startLinkTag, string endLinkTag)
	{
		return $"Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}.";
	}

	protected virtual string _GetTemplateForDescriptionLeanMoreKidsSafety()
	{
		return "Learn more about Builders Club and how we help {startLinkTag}keep kids safe{endLinkTag}.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreKidsSafetyPremium"
	/// English String: "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}."
	/// </summary>
	public virtual string DescriptionLearnMoreKidsSafetyPremium(string startLinkTag, string endLinkTag)
	{
		return $"Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}.";
	}

	protected virtual string _GetTemplateForDescriptionLearnMoreKidsSafetyPremium()
	{
		return "Learn more about Premium and how we help {startLinkTag}keep kids safe{endLinkTag}.";
	}

	protected virtual string _GetTemplateForHeadingBuyRobux()
	{
		return "Buy Robux";
	}

	protected virtual string _GetTemplateForHeadingCancellations()
	{
		return "Cancellation";
	}

	protected virtual string _GetTemplateForHeadingGameCards()
	{
		return "Game Cards";
	}

	protected virtual string _GetTemplateForHeadingParents()
	{
		return "Parents";
	}

	protected virtual string _GetTemplateForLabelBuyRobuxWith()
	{
		return "Buy Robux with";
	}

	/// <summary>
	/// Key: "Label.CreditBalance"
	/// label
	/// English String: "Credit Balance: {amount}"
	/// </summary>
	public virtual string LabelCreditBalance(string amount)
	{
		return $"Credit Balance: {amount}";
	}

	protected virtual string _GetTemplateForLabelCreditBalance()
	{
		return "Credit Balance: {amount}";
	}

	protected virtual string _GetTemplateForLabelItunes()
	{
		return "iTunes";
	}

	protected virtual string _GetTemplateForLabelRixty()
	{
		return "Rixty";
	}

	protected virtual string _GetTemplateForLabelRobloxGameCards()
	{
		return "Roblox Gamecards";
	}
}
