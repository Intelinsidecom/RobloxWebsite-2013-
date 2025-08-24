using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PremiumResources_en_us : TranslationResourcesBase, IPremiumResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Bought"
	/// English String: "Bought"
	/// </summary>
	public virtual string ActionBought => "Bought";

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now!"
	/// </summary>
	public virtual string ActionBuyNow => "Buy Now!";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public virtual string ActionBuyRobux => "Buy Robux";

	/// <summary>
	/// Key: "Description.GetMoreRobux"
	/// English String: "Get 10% more when purchasing Robux"
	/// </summary>
	public virtual string DescriptionGetMoreRobux => "Get 10% more when purchasing Robux";

	/// <summary>
	/// Key: "Description.GooglePlayMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that is charged to your Google Play account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Google Play account settings. If you’re under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public virtual string DescriptionGooglePlayMonthlySubscriptionDisclosure => "Roblox Premium is a monthly subscription that is charged to your Google Play account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Google Play account settings. If you’re under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.";

	/// <summary>
	/// Key: "Description.RobloxPremiumSubtitle"
	/// English String: "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games."
	/// </summary>
	public virtual string DescriptionRobloxPremiumSubtitle => "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games.";

	/// <summary>
	/// Key: "Description.SellMoreItems"
	/// English String: "Resell items and get more Robux selling your creations"
	/// </summary>
	public virtual string DescriptionSellMoreItems => "Resell items and get more Robux selling your creations";

	/// <summary>
	/// Key: "Description.Trade"
	/// English String: "Trade items with other Premium members"
	/// </summary>
	public virtual string DescriptionTrade => "Trade items with other Premium members";

	/// <summary>
	/// Key: "Heading.BuyRobux"
	/// The title of Robux page
	/// English String: "Buy Robux"
	/// </summary>
	public virtual string HeadingBuyRobux => "Buy Robux";

	/// <summary>
	/// Key: "Heading.ConfirmCancellation"
	/// English String: "Confirm Cancellation"
	/// </summary>
	public virtual string HeadingConfirmCancellation => "Confirm Cancellation";

	/// <summary>
	/// Key: "Heading.EvenMoreFeatures"
	/// English String: "Even more Features"
	/// </summary>
	public virtual string HeadingEvenMoreFeatures => "Even more Features";

	/// <summary>
	/// Key: "Heading.GeneralError"
	/// English String: "Error"
	/// </summary>
	public virtual string HeadingGeneralError => "Error";

	/// <summary>
	/// Key: "Heading.PremiumRobuxDiscounts"
	/// English String: "As a Premium user, you get discounts on Robux!"
	/// </summary>
	public virtual string HeadingPremiumRobuxDiscounts => "As a Premium user, you get discounts on Robux!";

	/// <summary>
	/// Key: "Heading.RobloxPremium"
	/// The title of Subscription page
	/// English String: "Roblox Premium"
	/// </summary>
	public virtual string HeadingRobloxPremium => "Roblox Premium";

	/// <summary>
	/// Key: "Heading.ServerError"
	/// English String: "Server Error"
	/// </summary>
	public virtual string HeadingServerError => "Server Error";

	/// <summary>
	/// Key: "Heading.SubscriptionUnavailable"
	/// English String: "Subscription Unavailable"
	/// </summary>
	public virtual string HeadingSubscriptionUnavailable => "Subscription Unavailable";

	/// <summary>
	/// Key: "Heading.SwitchPlanModal"
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public virtual string HeadingSwitchPlanModal => "Confirm Subscription Update";

	/// <summary>
	/// Key: "Heading.UnableToFindBc"
	/// English String: "Cannot find Builders Club"
	/// </summary>
	public virtual string HeadingUnableToFindBc => "Cannot find Builders Club";

	/// <summary>
	/// Key: "Heading.UpgradeToPremium"
	/// English String: "Upgrade to Roblox Premium"
	/// </summary>
	public virtual string HeadingUpgradeToPremium => "Upgrade to Roblox Premium";

	/// <summary>
	/// Key: "Heading.UpgradeUnavailable"
	/// English String: "Upgrade Unavailable"
	/// </summary>
	public virtual string HeadingUpgradeUnavailable => "Upgrade Unavailable";

	/// <summary>
	/// Key: "Label.10PercentMoreRobux"
	/// Part 1 of a two part label (Label.SinceYouSubscribed)
	/// English String: "You'll get 10% more Robux"
	/// </summary>
	public virtual string Label10PercentMoreRobux => "You'll get 10% more Robux";

	/// <summary>
	/// Key: "Label.AndGetMore"
	/// English String: "and get more!"
	/// </summary>
	public virtual string LabelAndGetMore => "and get more!";

	/// <summary>
	/// Key: "Label.BecauseYouSubscribed"
	/// English String: "Because you Subscribed!"
	/// </summary>
	public virtual string LabelBecauseYouSubscribed => "Because you Subscribed!";

	/// <summary>
	/// Key: "Label.BuyOnce"
	/// English String: "Buy Once"
	/// </summary>
	public virtual string LabelBuyOnce => "Buy Once";

	/// <summary>
	/// Key: "Label.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public virtual string LabelBuyRobux => "Buy Robux";

	/// <summary>
	/// Key: "Label.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string LabelCancel => "Cancel";

	/// <summary>
	/// Key: "Label.Confirm"
	/// English String: "Confirm"
	/// </summary>
	public virtual string LabelConfirm => "Confirm";

	/// <summary>
	/// Key: "Label.CurrentPlan"
	/// English String: "Your Current Plan"
	/// </summary>
	public virtual string LabelCurrentPlan => "Your Current Plan";

	/// <summary>
	/// Key: "Label.Get10PercentOffRobux"
	/// English String: "Get 10% off Robux"
	/// </summary>
	public virtual string LabelGet10PercentOffRobux => "Get 10% off Robux";

	/// <summary>
	/// Key: "Label.GetMoreRobux"
	/// English String: "Get More Robux"
	/// </summary>
	public virtual string LabelGetMoreRobux => "Get More Robux";

	/// <summary>
	/// Key: "Label.MembershipManagementRecurring"
	/// English String: "To manage your Premium subscription, please go to your Billing settings using a browser."
	/// </summary>
	public virtual string LabelMembershipManagementRecurring => "To manage your Premium subscription, please go to your Billing settings using a browser.";

	/// <summary>
	/// Key: "Label.No"
	/// English String: "No"
	/// </summary>
	public virtual string LabelNo => "No";

	/// <summary>
	/// Key: "Label.PremiumClub2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public virtual string LabelPremiumClub2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium"
	/// English String: "Roblox Premium"
	/// </summary>
	public virtual string LabelRobloxPremium => "Roblox Premium";

	/// <summary>
	/// Key: "Label.RobloxPremium1000"
	/// English String: "Roblox Premium 1000"
	/// </summary>
	public virtual string LabelRobloxPremium1000 => "Roblox Premium 1000";

	/// <summary>
	/// Key: "Label.RobloxPremium1000OneMonth"
	/// English String: "Roblox Premium 1000 One Month"
	/// </summary>
	public virtual string LabelRobloxPremium1000OneMonth => "Roblox Premium 1000 One Month";

	/// <summary>
	/// Key: "Label.RobloxPremium2200"
	/// English String: "Roblox Premium 2200"
	/// </summary>
	public virtual string LabelRobloxPremium2200 => "Roblox Premium 2200";

	/// <summary>
	/// Key: "Label.RobloxPremium2200OneMonth"
	/// English String: "Roblox Premium 2200 One Month"
	/// </summary>
	public virtual string LabelRobloxPremium2200OneMonth => "Roblox Premium 2200 One Month";

	/// <summary>
	/// Key: "Label.RobloxPremium450"
	/// English String: "Roblox Premium 450"
	/// </summary>
	public virtual string LabelRobloxPremium450 => "Roblox Premium 450";

	/// <summary>
	/// Key: "Label.RobloxPremium450OneMonth"
	/// English String: "Roblox Premium 450 One Month"
	/// </summary>
	public virtual string LabelRobloxPremium450OneMonth => "Roblox Premium 450 One Month";

	/// <summary>
	/// Key: "Label.SellMore"
	/// English String: "Sell More"
	/// </summary>
	public virtual string LabelSellMore => "Sell More";

	/// <summary>
	/// Key: "Label.SinceYouSubscribed"
	/// Part 2 of a 2 part label
	/// English String: "since you subscribed"
	/// </summary>
	public virtual string LabelSinceYouSubscribed => "since you subscribed";

	/// <summary>
	/// Key: "Label.Subscribe"
	/// English String: "Subscribe"
	/// </summary>
	public virtual string LabelSubscribe => "Subscribe";

	/// <summary>
	/// Key: "Label.Trade"
	/// English String: "Trade"
	/// </summary>
	public virtual string LabelTrade => "Trade";

	/// <summary>
	/// Key: "Label.ValuePacks"
	/// English String: "Value Packs"
	/// </summary>
	public virtual string LabelValuePacks => "Value Packs";

	/// <summary>
	/// Key: "Label.WantMoreRobux"
	/// English String: "Want more Robux?"
	/// </summary>
	public virtual string LabelWantMoreRobux => "Want more Robux?";

	/// <summary>
	/// Key: "Label.Yes"
	/// English String: "Yes"
	/// </summary>
	public virtual string LabelYes => "Yes";

	/// <summary>
	/// Key: "Message.GeneralError"
	/// English String: "An error occurred while updating your subscription. Please try again later."
	/// </summary>
	public virtual string MessageGeneralError => "An error occurred while updating your subscription. Please try again later.";

	/// <summary>
	/// Key: "Message.NoDataError"
	/// English String: "No subscriptions information."
	/// </summary>
	public virtual string MessageNoDataError => "No subscriptions information.";

	/// <summary>
	/// Key: "Message.ServerError"
	/// English String: "A server error occurred while updating your subscription. Please try again later."
	/// </summary>
	public virtual string MessageServerError => "A server error occurred while updating your subscription. Please try again later.";

	/// <summary>
	/// Key: "Message.UnableToFindBc"
	/// English String: "Cannot find Builders Club information for this user."
	/// </summary>
	public virtual string MessageUnableToFindBc => "Cannot find Builders Club information for this user.";

	/// <summary>
	/// Key: "Message.UpgradeUnavailableModal"
	/// English String: "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club."
	/// </summary>
	public virtual string MessageUpgradeUnavailableModal => "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club.";

	/// <summary>
	/// Key: "SwitchPlanTitle"
	/// Wrong string. Do translate this.
	/// English String: "Confirm Subscription Update"
	/// </summary>
	public virtual string SwitchPlanTitle => "Confirm Subscription Update";

	public PremiumResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Bought",
				_GetTemplateForActionBought()
			},
			{
				"Action.BuyNow",
				_GetTemplateForActionBuyNow()
			},
			{
				"Action.BuyRobux",
				_GetTemplateForActionBuyRobux()
			},
			{
				"Description.BuyMoreRobuxSubtitle",
				_GetTemplateForDescriptionBuyMoreRobuxSubtitle()
			},
			{
				"Description.BuyRobuxSubtitle",
				_GetTemplateForDescriptionBuyRobuxSubtitle()
			},
			{
				"Description.GetMoreRobux",
				_GetTemplateForDescriptionGetMoreRobux()
			},
			{
				"Description.GooglePlayMonthlySubscriptionDisclosure",
				_GetTemplateForDescriptionGooglePlayMonthlySubscriptionDisclosure()
			},
			{
				"Description.IosMonthlySubscriptionDisclosure",
				_GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
			},
			{
				"Description.IosSubscriptionDisclosure",
				_GetTemplateForDescriptionIosSubscriptionDisclosure()
			},
			{
				"Description.legalDisclosuresPremiumRobuxPage",
				_GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
			},
			{
				"Description.legalDisclosuresPremiumUpgradePage",
				_GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
			},
			{
				"Description.PremiumSubscriptionDisclosure",
				_GetTemplateForDescriptionPremiumSubscriptionDisclosure()
			},
			{
				"Description.RobloxPremiumSubtitle",
				_GetTemplateForDescriptionRobloxPremiumSubtitle()
			},
			{
				"Description.SellMoreItems",
				_GetTemplateForDescriptionSellMoreItems()
			},
			{
				"Description.Trade",
				_GetTemplateForDescriptionTrade()
			},
			{
				"Heading.BuyRobux",
				_GetTemplateForHeadingBuyRobux()
			},
			{
				"Heading.ConfirmCancellation",
				_GetTemplateForHeadingConfirmCancellation()
			},
			{
				"Heading.EvenMoreFeatures",
				_GetTemplateForHeadingEvenMoreFeatures()
			},
			{
				"Heading.GeneralError",
				_GetTemplateForHeadingGeneralError()
			},
			{
				"Heading.PremiumRobuxDiscounts",
				_GetTemplateForHeadingPremiumRobuxDiscounts()
			},
			{
				"Heading.RobloxPremium",
				_GetTemplateForHeadingRobloxPremium()
			},
			{
				"Heading.ServerError",
				_GetTemplateForHeadingServerError()
			},
			{
				"Heading.SubscriptionUnavailable",
				_GetTemplateForHeadingSubscriptionUnavailable()
			},
			{
				"Heading.SwitchPlanModal",
				_GetTemplateForHeadingSwitchPlanModal()
			},
			{
				"Heading.UnableToFindBc",
				_GetTemplateForHeadingUnableToFindBc()
			},
			{
				"Heading.UpgradeToPremium",
				_GetTemplateForHeadingUpgradeToPremium()
			},
			{
				"Heading.UpgradeUnavailable",
				_GetTemplateForHeadingUpgradeUnavailable()
			},
			{
				"Label.10PercentMoreRobux",
				_GetTemplateForLabel10PercentMoreRobux()
			},
			{
				"Label.AndGetMore",
				_GetTemplateForLabelAndGetMore()
			},
			{
				"Label.BecauseYouSubscribed",
				_GetTemplateForLabelBecauseYouSubscribed()
			},
			{
				"Label.BuyOnce",
				_GetTemplateForLabelBuyOnce()
			},
			{
				"Label.BuyRobux",
				_GetTemplateForLabelBuyRobux()
			},
			{
				"Label.Cancel",
				_GetTemplateForLabelCancel()
			},
			{
				"Label.Confirm",
				_GetTemplateForLabelConfirm()
			},
			{
				"Label.CurrentPlan",
				_GetTemplateForLabelCurrentPlan()
			},
			{
				"Label.Get10PercentOffRobux",
				_GetTemplateForLabelGet10PercentOffRobux()
			},
			{
				"Label.GetMoreRobux",
				_GetTemplateForLabelGetMoreRobux()
			},
			{
				"Label.MembershipManagementRecurring",
				_GetTemplateForLabelMembershipManagementRecurring()
			},
			{
				"Label.MembershipStatus",
				_GetTemplateForLabelMembershipStatus()
			},
			{
				"Label.MembershipStatusExpiration",
				_GetTemplateForLabelMembershipStatusExpiration()
			},
			{
				"Label.MembershipStatusRecurring",
				_GetTemplateForLabelMembershipStatusRecurring()
			},
			{
				"Label.No",
				_GetTemplateForLabelNo()
			},
			{
				"Label.PremiumClub2200",
				_GetTemplateForLabelPremiumClub2200()
			},
			{
				"Label.PriceMonth",
				_GetTemplateForLabelPriceMonth()
			},
			{
				"Label.PricePerMonth",
				_GetTemplateForLabelPricePerMonth()
			},
			{
				"Label.RobloxPremium",
				_GetTemplateForLabelRobloxPremium()
			},
			{
				"Label.RobloxPremium1000",
				_GetTemplateForLabelRobloxPremium1000()
			},
			{
				"Label.RobloxPremium1000OneMonth",
				_GetTemplateForLabelRobloxPremium1000OneMonth()
			},
			{
				"Label.RobloxPremium2200",
				_GetTemplateForLabelRobloxPremium2200()
			},
			{
				"Label.RobloxPremium2200OneMonth",
				_GetTemplateForLabelRobloxPremium2200OneMonth()
			},
			{
				"Label.RobloxPremium450",
				_GetTemplateForLabelRobloxPremium450()
			},
			{
				"Label.RobloxPremium450OneMonth",
				_GetTemplateForLabelRobloxPremium450OneMonth()
			},
			{
				"Label.SellMore",
				_GetTemplateForLabelSellMore()
			},
			{
				"Label.SinceYouSubscribed",
				_GetTemplateForLabelSinceYouSubscribed()
			},
			{
				"Label.Subscribe",
				_GetTemplateForLabelSubscribe()
			},
			{
				"Label.SubscribeUpsell",
				_GetTemplateForLabelSubscribeUpsell()
			},
			{
				"Label.Trade",
				_GetTemplateForLabelTrade()
			},
			{
				"Label.ValuePacks",
				_GetTemplateForLabelValuePacks()
			},
			{
				"Label.WantMoreRobux",
				_GetTemplateForLabelWantMoreRobux()
			},
			{
				"Label.Yes",
				_GetTemplateForLabelYes()
			},
			{
				"Message.ConfirmCancellationModal",
				_GetTemplateForMessageConfirmCancellationModal()
			},
			{
				"Message.GeneralError",
				_GetTemplateForMessageGeneralError()
			},
			{
				"Message.NoDataError",
				_GetTemplateForMessageNoDataError()
			},
			{
				"Message.ServerError",
				_GetTemplateForMessageServerError()
			},
			{
				"Message.SubscriptionUnavailableModal",
				_GetTemplateForMessageSubscriptionUnavailableModal()
			},
			{
				"Message.SwitchPlanBody",
				_GetTemplateForMessageSwitchPlanBody()
			},
			{
				"Message.UnableToFindBc",
				_GetTemplateForMessageUnableToFindBc()
			},
			{
				"Message.UpgradeUnavailableModal",
				_GetTemplateForMessageUpgradeUnavailableModal()
			},
			{
				"SwitchPlanTitle",
				_GetTemplateForSwitchPlanTitle()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Premium";
	}

	protected virtual string _GetTemplateForActionBought()
	{
		return "Bought";
	}

	protected virtual string _GetTemplateForActionBuyNow()
	{
		return "Buy Now!";
	}

	protected virtual string _GetTemplateForActionBuyRobux()
	{
		return "Buy Robux";
	}

	/// <summary>
	/// Key: "Description.BuyMoreRobuxSubtitle"
	/// English String: "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}"
	/// </summary>
	public virtual string DescriptionBuyMoreRobuxSubtitle(string lineBreak, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}";
	}

	protected virtual string _GetTemplateForDescriptionBuyMoreRobuxSubtitle()
	{
		return "Buy Robux to purchase upgrades for your avatar or special abilities in games.{lineBreak} Subscribe to Roblox Premium and get even more Robux each month, as well as bonus features. Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here.{learnMoreLinkEnd}";
	}

	/// <summary>
	/// Key: "Description.BuyRobuxSubtitle"
	/// English String: "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}."
	/// </summary>
	public virtual string DescriptionBuyRobuxSubtitle(string helpLinkStart, string helpLinkEnd, string paragraphBreaker, string learnMoreLinkStart, string learnMoreLinkEnd)
	{
		return $"Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}.";
	}

	protected virtual string _GetTemplateForDescriptionBuyRobuxSubtitle()
	{
		return "Get Robux to purchase upgrades for your avatar or buy special abilities in games. For more information on how to earn Robux, visit our {helpLinkStart}Robux Help page{helpLinkEnd}.{paragraphBreaker}Purchase Roblox Premium to get more Robux for the same price. Roblox Premium is billed every month until cancelled. {learnMoreLinkStart}Learn more here{learnMoreLinkEnd}.";
	}

	protected virtual string _GetTemplateForDescriptionGetMoreRobux()
	{
		return "Get 10% more when purchasing Robux";
	}

	protected virtual string _GetTemplateForDescriptionGooglePlayMonthlySubscriptionDisclosure()
	{
		return "Roblox Premium is a monthly subscription that is charged to your Google Play account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Google Play account settings. If you’re under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.";
	}

	/// <summary>
	/// Key: "Description.IosMonthlySubscriptionDisclosure"
	/// English String: "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public virtual string DescriptionIosMonthlySubscriptionDisclosure(string costPrice, string renewalPrice)
	{
		return $"Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.";
	}

	protected virtual string _GetTemplateForDescriptionIosMonthlySubscriptionDisclosure()
	{
		return "Roblox Premium is a monthly subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings. If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.";
	}

	/// <summary>
	/// Key: "Description.IosSubscriptionDisclosure"
	/// English String: "Roblox Premium is a {durationType} subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings."
	/// </summary>
	public virtual string DescriptionIosSubscriptionDisclosure(string durationType, string costPrice, string renewalPrice)
	{
		return $"Roblox Premium is a {durationType} subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings.";
	}

	protected virtual string _GetTemplateForDescriptionIosSubscriptionDisclosure()
	{
		return "Roblox Premium is a {durationType} subscription that costs {costPrice}. Payment will be charged to the iTunes Account at confirmation of purchase. Roblox Premium will automatically renew unless auto-renewal is turned off at least 24-hours before the end of the current period. Your account will be charged {renewalPrice} for renewal within 24-hours prior to the end of the current period. Subscriptions may be managed and auto-renewal may be turned off by going to your Account Settings.";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumRobuxPage"
	/// English String: "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted."
	/// </summary>
	public virtual string DescriptionlegalDisclosuresPremiumRobuxPage(string termsLinkStart, string termsLinkEnd)
	{
		return $"When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.";
	}

	protected virtual string _GetTemplateForDescriptionlegalDisclosuresPremiumRobuxPage()
	{
		return "When you buy Robux, you receive only a limited, non-refundable, non-transferable, revocable license to use Robux, which have no value in real currency. See {termsLinkStart}Terms of Use{termsLinkEnd} for other limitations.  If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.";
	}

	/// <summary>
	/// Key: "Description.legalDisclosuresPremiumUpgradePage"
	/// English String: "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public virtual string DescriptionlegalDisclosuresPremiumUpgradePage(string termsLinkStart, string termsLinkEnd, string privacyLinkStart, string privatyLinkEnd, string billingLinkStart, string billingLinkEnd)
	{
		return $"If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period.";
	}

	protected virtual string _GetTemplateForDescriptionlegalDisclosuresPremiumUpgradePage()
	{
		return "If you are under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {termsLinkStart}Terms of Use{termsLinkEnd} and {privacyLinkStart}Privacy Policy{privatyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingLinkStart}billing tab{billingLinkEnd}  of the setting page. If you cancel, you will still be charged for the current billing period.";
	}

	/// <summary>
	/// Key: "Description.PremiumSubscriptionDisclosure"
	/// Duplicated
	/// English String: "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period."
	/// </summary>
	public virtual string DescriptionPremiumSubscriptionDisclosure(string teamOfUseLinkStart, string teamOfUseLinkEnd, string privacyPolicyLinkStart, string privacyPolicyLinkEnd, string billingTabLinkStart, string billingTabLinkEnd)
	{
		return $"If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period.";
	}

	protected virtual string _GetTemplateForDescriptionPremiumSubscriptionDisclosure()
	{
		return "If you're under 18 make sure you have the permission of your parent or legal guardian before making a purchase. Making a purchase without permission may result in your account being deleted.  By clicking “Submit Order” (1) you authorize us to charge your account every month until you cancel the subscription, and (2) you represent that you understand and agree to the {teamOfUseLinkStart}Terms of Use{teamOfUseLinkEnd} and {privacyPolicyLinkStart}Privacy Policy{privacyPolicyLinkEnd}. You can cancel at any time by clicking “Cancel membership” on the {billingTabLinkStart}billing tab{billingTabLinkEnd} of the setting page. If you cancel, you will still be charged for the current billing period.";
	}

	protected virtual string _GetTemplateForDescriptionRobloxPremiumSubtitle()
	{
		return "Joining Roblox Premium gets you a monthly Robux allowance and a 10% bonus when buying Robux. You will also get access to Roblox's economy features including buying, selling, and trading items, as well as increased revenue share on all sales in your games.";
	}

	protected virtual string _GetTemplateForDescriptionSellMoreItems()
	{
		return "Resell items and get more Robux selling your creations";
	}

	protected virtual string _GetTemplateForDescriptionTrade()
	{
		return "Trade items with other Premium members";
	}

	protected virtual string _GetTemplateForHeadingBuyRobux()
	{
		return "Buy Robux";
	}

	protected virtual string _GetTemplateForHeadingConfirmCancellation()
	{
		return "Confirm Cancellation";
	}

	protected virtual string _GetTemplateForHeadingEvenMoreFeatures()
	{
		return "Even more Features";
	}

	protected virtual string _GetTemplateForHeadingGeneralError()
	{
		return "Error";
	}

	protected virtual string _GetTemplateForHeadingPremiumRobuxDiscounts()
	{
		return "As a Premium user, you get discounts on Robux!";
	}

	protected virtual string _GetTemplateForHeadingRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected virtual string _GetTemplateForHeadingServerError()
	{
		return "Server Error";
	}

	protected virtual string _GetTemplateForHeadingSubscriptionUnavailable()
	{
		return "Subscription Unavailable";
	}

	protected virtual string _GetTemplateForHeadingSwitchPlanModal()
	{
		return "Confirm Subscription Update";
	}

	protected virtual string _GetTemplateForHeadingUnableToFindBc()
	{
		return "Cannot find Builders Club";
	}

	protected virtual string _GetTemplateForHeadingUpgradeToPremium()
	{
		return "Upgrade to Roblox Premium";
	}

	protected virtual string _GetTemplateForHeadingUpgradeUnavailable()
	{
		return "Upgrade Unavailable";
	}

	protected virtual string _GetTemplateForLabel10PercentMoreRobux()
	{
		return "You'll get 10% more Robux";
	}

	protected virtual string _GetTemplateForLabelAndGetMore()
	{
		return "and get more!";
	}

	protected virtual string _GetTemplateForLabelBecauseYouSubscribed()
	{
		return "Because you Subscribed!";
	}

	protected virtual string _GetTemplateForLabelBuyOnce()
	{
		return "Buy Once";
	}

	protected virtual string _GetTemplateForLabelBuyRobux()
	{
		return "Buy Robux";
	}

	protected virtual string _GetTemplateForLabelCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForLabelConfirm()
	{
		return "Confirm";
	}

	protected virtual string _GetTemplateForLabelCurrentPlan()
	{
		return "Your Current Plan";
	}

	protected virtual string _GetTemplateForLabelGet10PercentOffRobux()
	{
		return "Get 10% off Robux";
	}

	protected virtual string _GetTemplateForLabelGetMoreRobux()
	{
		return "Get More Robux";
	}

	protected virtual string _GetTemplateForLabelMembershipManagementRecurring()
	{
		return "To manage your Premium subscription, please go to your Billing settings using a browser.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatus"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}."
	/// </summary>
	public virtual string LabelMembershipStatus(string premiumSubscription, string expirationDate)
	{
		return $"Your current plan is {premiumSubscription}. It will expire on {expirationDate}.";
	}

	protected virtual string _GetTemplateForLabelMembershipStatus()
	{
		return "Your current plan is {premiumSubscription}. It will expire on {expirationDate}.";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusExpiration"
	/// English String: "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. "
	/// </summary>
	public virtual string LabelMembershipStatusExpiration(string premiumSubscription, string expirationDate)
	{
		return $"Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. ";
	}

	protected virtual string _GetTemplateForLabelMembershipStatusExpiration()
	{
		return "Your current plan is {premiumSubscription}. It will expire on {expirationDate}. You can repurchase or buy a new plan once your membership expires. ";
	}

	/// <summary>
	/// Key: "Label.MembershipStatusRecurring"
	/// English String: "Your current plan is {premiumSubscription}. It will renew on {renewal}."
	/// </summary>
	public virtual string LabelMembershipStatusRecurring(string premiumSubscription, string renewal)
	{
		return $"Your current plan is {premiumSubscription}. It will renew on {renewal}.";
	}

	protected virtual string _GetTemplateForLabelMembershipStatusRecurring()
	{
		return "Your current plan is {premiumSubscription}. It will renew on {renewal}.";
	}

	protected virtual string _GetTemplateForLabelNo()
	{
		return "No";
	}

	protected virtual string _GetTemplateForLabelPremiumClub2200()
	{
		return "Roblox Premium 2200";
	}

	/// <summary>
	/// Key: "Label.PriceMonth"
	/// English String: "{robux}{subTextStart}/month{subTextEnd}"
	/// </summary>
	public virtual string LabelPriceMonth(string robux, string subTextStart, string subTextEnd)
	{
		return $"{robux}{subTextStart}/month{subTextEnd}";
	}

	protected virtual string _GetTemplateForLabelPriceMonth()
	{
		return "{robux}{subTextStart}/month{subTextEnd}";
	}

	/// <summary>
	/// Key: "Label.PricePerMonth"
	/// Please don't translate this one. This should be removed.
	/// English String: "{robuxAmount}/month"
	/// </summary>
	public virtual string LabelPricePerMonth(string robuxAmount)
	{
		return $"{robuxAmount}/month";
	}

	protected virtual string _GetTemplateForLabelPricePerMonth()
	{
		return "{robuxAmount}/month";
	}

	protected virtual string _GetTemplateForLabelRobloxPremium()
	{
		return "Roblox Premium";
	}

	protected virtual string _GetTemplateForLabelRobloxPremium1000()
	{
		return "Roblox Premium 1000";
	}

	protected virtual string _GetTemplateForLabelRobloxPremium1000OneMonth()
	{
		return "Roblox Premium 1000 One Month";
	}

	protected virtual string _GetTemplateForLabelRobloxPremium2200()
	{
		return "Roblox Premium 2200";
	}

	protected virtual string _GetTemplateForLabelRobloxPremium2200OneMonth()
	{
		return "Roblox Premium 2200 One Month";
	}

	protected virtual string _GetTemplateForLabelRobloxPremium450()
	{
		return "Roblox Premium 450";
	}

	protected virtual string _GetTemplateForLabelRobloxPremium450OneMonth()
	{
		return "Roblox Premium 450 One Month";
	}

	protected virtual string _GetTemplateForLabelSellMore()
	{
		return "Sell More";
	}

	protected virtual string _GetTemplateForLabelSinceYouSubscribed()
	{
		return "since you subscribed";
	}

	protected virtual string _GetTemplateForLabelSubscribe()
	{
		return "Subscribe";
	}

	/// <summary>
	/// Key: "Label.SubscribeUpsell"
	/// English String: "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}"
	/// </summary>
	public virtual string LabelSubscribeUpsell(string upsellLinkStart, string upsellLinkEnd)
	{
		return $"Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}";
	}

	protected virtual string _GetTemplateForLabelSubscribeUpsell()
	{
		return "Subscribe {upsellLinkStart}and get more!{upsellLinkEnd}";
	}

	protected virtual string _GetTemplateForLabelTrade()
	{
		return "Trade";
	}

	protected virtual string _GetTemplateForLabelValuePacks()
	{
		return "Value Packs";
	}

	protected virtual string _GetTemplateForLabelWantMoreRobux()
	{
		return "Want more Robux?";
	}

	protected virtual string _GetTemplateForLabelYes()
	{
		return "Yes";
	}

	/// <summary>
	/// Key: "Message.ConfirmCancellationModal"
	/// English String: "By clicking \"Confirm\" will end your Builders Club membership so you can subscribe to Roblox Premium.{newLine} You will receive a one-time payout of {robuxAmount}"
	/// </summary>
	public virtual string MessageConfirmCancellationModal(string newLine, string robuxAmount)
	{
		return $"By clicking \"Confirm\" will end your Builders Club membership so you can subscribe to Roblox Premium.{newLine} You will receive a one-time payout of {robuxAmount}";
	}

	protected virtual string _GetTemplateForMessageConfirmCancellationModal()
	{
		return "By clicking \"Confirm\" will end your Builders Club membership so you can subscribe to Roblox Premium.{newLine} You will receive a one-time payout of {robuxAmount}";
	}

	protected virtual string _GetTemplateForMessageGeneralError()
	{
		return "An error occurred while updating your subscription. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageNoDataError()
	{
		return "No subscriptions information.";
	}

	protected virtual string _GetTemplateForMessageServerError()
	{
		return "A server error occurred while updating your subscription. Please try again later.";
	}

	/// <summary>
	/// Key: "Message.SubscriptionUnavailableModal"
	/// English String: "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}."
	/// </summary>
	public virtual string MessageSubscriptionUnavailableModal(string expiredDate)
	{
		return $"We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}.";
	}

	protected virtual string _GetTemplateForMessageSubscriptionUnavailableModal()
	{
		return "We are sorry, you cannot subscribe until your current cancelled plan has expired. Please re-subscribe on {expiredDate}.";
	}

	/// <summary>
	/// Key: "Message.SwitchPlanBody"
	/// English String: "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}"
	/// </summary>
	public virtual string MessageSwitchPlanBody(string price, string renewalDate)
	{
		return $"By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}";
	}

	protected virtual string _GetTemplateForMessageSwitchPlanBody()
	{
		return "By clicking \"Confirm\" you authorize us to charge you {price} each month until you cancel or switch subscriptions effective {renewalDate}";
	}

	protected virtual string _GetTemplateForMessageUnableToFindBc()
	{
		return "Cannot find Builders Club information for this user.";
	}

	protected virtual string _GetTemplateForMessageUpgradeUnavailableModal()
	{
		return "We are sorry, we cannot change your subscription because there is currently no package equivalent to Lifetime Builders Club.";
	}

	protected virtual string _GetTemplateForSwitchPlanTitle()
	{
		return "Confirm Subscription Update";
	}
}
