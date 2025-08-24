using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class CashOutResources_en_us : TranslationResourcesBase, ICashOutResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.CashOut"
	/// English String: "Cash Out"
	/// </summary>
	public virtual string ActionCashOut => "Cash Out";

	/// <summary>
	/// Key: "Action.GetItNow"
	/// button text
	/// English String: "Get it now"
	/// </summary>
	public virtual string ActionGetItNow => "Get it now";

	/// <summary>
	/// Key: "Action.GetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public virtual string ActionGetObc => "Get OBC Now";

	/// <summary>
	/// Key: "Action.UpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public virtual string ActionUpgradeMembership => "Upgrade Membership";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public virtual string ActionVerify => "Verify";

	/// <summary>
	/// Key: "Action.VerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public virtual string ActionVerifyEmail => "Verify Email";

	/// <summary>
	/// Key: "Action.VerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public virtual string ActionVerifyNow => "Verify Now";

	/// <summary>
	/// Key: "Action.VisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public virtual string ActionVisitDevEx => "Visit DevEx";

	/// <summary>
	/// Key: "Heading.CreateGamesEarnMoney"
	/// section heading
	/// English String: "Developer Exchange: Create games, earn money."
	/// </summary>
	public virtual string HeadingCreateGamesEarnMoney => "Developer Exchange: Create games, earn money.";

	/// <summary>
	/// Key: "Heading.DeveloperExchange"
	/// heading
	/// English String: "Developer Exchange"
	/// </summary>
	public virtual string HeadingDeveloperExchange => "Developer Exchange";

	/// <summary>
	/// Key: "Heading.YourUpdate"
	/// section heading
	/// English String: "Your Update"
	/// </summary>
	public virtual string HeadingYourUpdate => "Your Update";

	/// <summary>
	/// Key: "Label.AlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public virtual string LabelAlmostReady => "You're almost ready!";

	/// <summary>
	/// Key: "Label.BuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public virtual string LabelBuilderClubForCash => "You'll need Outrageous Builder's Club to exchange Robux for cash.";

	/// <summary>
	/// Key: "Label.BuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public virtual string LabelBuildersCludForCashout => "You need Outrageous Builders Club to Cash Out.";

	/// <summary>
	/// Key: "Label.CurrentExchangeRate"
	/// English String: "Current Rate"
	/// </summary>
	public virtual string LabelCurrentExchangeRate => "Current Rate";

	/// <summary>
	/// Key: "Label.DevExStatusCompleted"
	/// label
	/// English String: "Its status is Completed"
	/// </summary>
	public virtual string LabelDevExStatusCompleted => "Its status is Completed";

	/// <summary>
	/// Key: "Label.DevExStatusPending"
	/// label
	/// English String: "Its status is Pending"
	/// </summary>
	public virtual string LabelDevExStatusPending => "Its status is Pending";

	/// <summary>
	/// Key: "Label.DevExStatusRejected"
	/// label
	/// English String: "Its status is Rejected"
	/// </summary>
	public virtual string LabelDevExStatusRejected => "Its status is Rejected";

	/// <summary>
	/// Key: "Label.NeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public virtual string LabelNeedVerifiedEmail => "You need a verified email address to use DevEx.";

	/// <summary>
	/// Key: "Label.NotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public virtual string LabelNotEligible => "You are not eligible currently.";

	/// <summary>
	/// Key: "Label.NotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public virtual string LabelNotEnoughRobuxForCashout => "You don't have enough Robux to Cash Out.";

	/// <summary>
	/// Key: "Label.PremiumForCash"
	/// English String: "You'll need Roblox Premium to exchange Robux for cash."
	/// </summary>
	public virtual string LabelPremiumForCash => "You'll need Roblox Premium to exchange Robux for cash.";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public virtual string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.TradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public virtual string LabelTradingRobux => "You're on your way to trading Robux for cash!";

	/// <summary>
	/// Key: "Label.TradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public virtual string LabelTradingRobuxCash => "You're almost there! You almost qualify to trade your Robux for cash!";

	/// <summary>
	/// Key: "Label.VerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public virtual string LabelVerifiedEmailForCashout => "You must verify your email before you can cash out.";

	public CashOutResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.CashOut",
				_GetTemplateForActionCashOut()
			},
			{
				"Action.GetItNow",
				_GetTemplateForActionGetItNow()
			},
			{
				"Action.GetObc",
				_GetTemplateForActionGetObc()
			},
			{
				"Action.UpgradeMembership",
				_GetTemplateForActionUpgradeMembership()
			},
			{
				"Action.Verify",
				_GetTemplateForActionVerify()
			},
			{
				"Action.VerifyEmail",
				_GetTemplateForActionVerifyEmail()
			},
			{
				"Action.VerifyNow",
				_GetTemplateForActionVerifyNow()
			},
			{
				"Action.VisitDevEx",
				_GetTemplateForActionVisitDevEx()
			},
			{
				"Description.DevExRequestCompleted",
				_GetTemplateForDescriptionDevExRequestCompleted()
			},
			{
				"Description.DevExRequestSubmittedOn",
				_GetTemplateForDescriptionDevExRequestSubmittedOn()
			},
			{
				"Description.DevExTermsDisclaimer",
				_GetTemplateForDescriptionDevExTermsDisclaimer()
			},
			{
				"Description.LearnMoreAboutDevEx",
				_GetTemplateForDescriptionLearnMoreAboutDevEx()
			},
			{
				"Description.VisitDevEx",
				_GetTemplateForDescriptionVisitDevEx()
			},
			{
				"Heading.CreateGamesEarnMoney",
				_GetTemplateForHeadingCreateGamesEarnMoney()
			},
			{
				"Heading.DeveloperExchange",
				_GetTemplateForHeadingDeveloperExchange()
			},
			{
				"Heading.YourUpdate",
				_GetTemplateForHeadingYourUpdate()
			},
			{
				"Label.AlmostReady",
				_GetTemplateForLabelAlmostReady()
			},
			{
				"Label.AmountRobux",
				_GetTemplateForLabelAmountRobux()
			},
			{
				"Label.BuilderClubForCash",
				_GetTemplateForLabelBuilderClubForCash()
			},
			{
				"Label.BuildersCludForCashout",
				_GetTemplateForLabelBuildersCludForCashout()
			},
			{
				"Label.CurrentExchangeRate",
				_GetTemplateForLabelCurrentExchangeRate()
			},
			{
				"Label.CurrentRateCaption",
				_GetTemplateForLabelCurrentRateCaption()
			},
			{
				"Label.DevExStatusCompleted",
				_GetTemplateForLabelDevExStatusCompleted()
			},
			{
				"Label.DevExStatusPending",
				_GetTemplateForLabelDevExStatusPending()
			},
			{
				"Label.DevExStatusRejected",
				_GetTemplateForLabelDevExStatusRejected()
			},
			{
				"Label.NeedVerifiedEmail",
				_GetTemplateForLabelNeedVerifiedEmail()
			},
			{
				"Label.NotEligible",
				_GetTemplateForLabelNotEligible()
			},
			{
				"Label.NotEnoughRobuxForCashout",
				_GetTemplateForLabelNotEnoughRobuxForCashout()
			},
			{
				"Label.PremiumForCash",
				_GetTemplateForLabelPremiumForCash()
			},
			{
				"Label.Robux",
				_GetTemplateForLabelRobux()
			},
			{
				"Label.RobuxToUSD",
				_GetTemplateForLabelRobuxToUSD()
			},
			{
				"Label.TradingRobux",
				_GetTemplateForLabelTradingRobux()
			},
			{
				"Label.TradingRobuxCash",
				_GetTemplateForLabelTradingRobuxCash()
			},
			{
				"Label.VerifiedEmailForCashout",
				_GetTemplateForLabelVerifiedEmailForCashout()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.CashOut";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionCashOut()
	{
		return "Cash Out";
	}

	protected virtual string _GetTemplateForActionGetItNow()
	{
		return "Get it now";
	}

	protected virtual string _GetTemplateForActionGetObc()
	{
		return "Get OBC Now";
	}

	protected virtual string _GetTemplateForActionUpgradeMembership()
	{
		return "Upgrade Membership";
	}

	protected virtual string _GetTemplateForActionVerify()
	{
		return "Verify";
	}

	protected virtual string _GetTemplateForActionVerifyEmail()
	{
		return "Verify Email";
	}

	protected virtual string _GetTemplateForActionVerifyNow()
	{
		return "Verify Now";
	}

	protected virtual string _GetTemplateForActionVisitDevEx()
	{
		return "Visit DevEx";
	}

	/// <summary>
	/// Key: "Description.DevExRequestCompleted"
	/// description
	/// English String: "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details."
	/// </summary>
	public virtual string DescriptionDevExRequestCompleted(string startMoneyLink, string endMoneyLink)
	{
		return $"Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details.";
	}

	protected virtual string _GetTemplateForDescriptionDevExRequestCompleted()
	{
		return "Your DevEx request has been completed. Check your {startMoneyLink}Money{endMoneyLink} page for details.";
	}

	/// <summary>
	/// Key: "Description.DevExRequestSubmittedOn"
	/// description
	/// English String: "Your DevEx request was submitted on: {requestDate}"
	/// </summary>
	public virtual string DescriptionDevExRequestSubmittedOn(string requestDate)
	{
		return $"Your DevEx request was submitted on: {requestDate}";
	}

	protected virtual string _GetTemplateForDescriptionDevExRequestSubmittedOn()
	{
		return "Your DevEx request was submitted on: {requestDate}";
	}

	/// <summary>
	/// Key: "Description.DevExTermsDisclaimer"
	/// description
	/// English String: "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information."
	/// </summary>
	public virtual string DescriptionDevExTermsDisclaimer(string helpLinkStart, string helpLinkEnd)
	{
		return $"* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information.";
	}

	protected virtual string _GetTemplateForDescriptionDevExTermsDisclaimer()
	{
		return "* Old Robux may be cashed out at a different rate. Please click {helpLinkStart}here{helpLinkEnd} for more information.";
	}

	/// <summary>
	/// Key: "Description.LearnMoreAboutDevEx"
	/// descption
	/// English String: "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange."
	/// </summary>
	public virtual string DescriptionLearnMoreAboutDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}Learn more{endDevExLink} about our Developer Exchange.";
	}

	protected virtual string _GetTemplateForDescriptionLearnMoreAboutDevEx()
	{
		return "{startDevExLink}Learn more{endDevExLink} about our Developer Exchange.";
	}

	/// <summary>
	/// Key: "Description.VisitDevEx"
	/// description
	/// English String: "{startDevExLink}Visit{endDevExLink} our Developer Exchange."
	/// </summary>
	public virtual string DescriptionVisitDevEx(string startDevExLink, string endDevExLink)
	{
		return $"{startDevExLink}Visit{endDevExLink} our Developer Exchange.";
	}

	protected virtual string _GetTemplateForDescriptionVisitDevEx()
	{
		return "{startDevExLink}Visit{endDevExLink} our Developer Exchange.";
	}

	protected virtual string _GetTemplateForHeadingCreateGamesEarnMoney()
	{
		return "Developer Exchange: Create games, earn money.";
	}

	protected virtual string _GetTemplateForHeadingDeveloperExchange()
	{
		return "Developer Exchange";
	}

	protected virtual string _GetTemplateForHeadingYourUpdate()
	{
		return "Your Update";
	}

	protected virtual string _GetTemplateForLabelAlmostReady()
	{
		return "You're almost ready!";
	}

	/// <summary>
	/// Key: "Label.AmountRobux"
	/// label
	/// English String: "{amount} Robux"
	/// </summary>
	public virtual string LabelAmountRobux(string amount)
	{
		return $"{amount} Robux";
	}

	protected virtual string _GetTemplateForLabelAmountRobux()
	{
		return "{amount} Robux";
	}

	protected virtual string _GetTemplateForLabelBuilderClubForCash()
	{
		return "You'll need Outrageous Builder's Club to exchange Robux for cash.";
	}

	protected virtual string _GetTemplateForLabelBuildersCludForCashout()
	{
		return "You need Outrageous Builders Club to Cash Out.";
	}

	protected virtual string _GetTemplateForLabelCurrentExchangeRate()
	{
		return "Current Rate";
	}

	/// <summary>
	/// Key: "Label.CurrentRateCaption"
	/// English String: "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux"
	/// </summary>
	public virtual string LabelCurrentRateCaption(string minimumDevexRobuxAmount)
	{
		return $"Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux";
	}

	protected virtual string _GetTemplateForLabelCurrentRateCaption()
	{
		return "Current rate applies to all amounts greater than {minimumDevexRobuxAmount} Robux";
	}

	protected virtual string _GetTemplateForLabelDevExStatusCompleted()
	{
		return "Its status is Completed";
	}

	protected virtual string _GetTemplateForLabelDevExStatusPending()
	{
		return "Its status is Pending";
	}

	protected virtual string _GetTemplateForLabelDevExStatusRejected()
	{
		return "Its status is Rejected";
	}

	protected virtual string _GetTemplateForLabelNeedVerifiedEmail()
	{
		return "You need a verified email address to use DevEx.";
	}

	protected virtual string _GetTemplateForLabelNotEligible()
	{
		return "You are not eligible currently.";
	}

	protected virtual string _GetTemplateForLabelNotEnoughRobuxForCashout()
	{
		return "You don't have enough Robux to Cash Out.";
	}

	protected virtual string _GetTemplateForLabelPremiumForCash()
	{
		return "You'll need Roblox Premium to exchange Robux for cash.";
	}

	protected virtual string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	/// <summary>
	/// Key: "Label.RobuxToUSD"
	/// label
	/// English String: "{robuxAmount} Robux for {usdAmount}"
	/// </summary>
	public virtual string LabelRobuxToUSD(string robuxAmount, string usdAmount)
	{
		return $"{robuxAmount} Robux for {usdAmount}";
	}

	protected virtual string _GetTemplateForLabelRobuxToUSD()
	{
		return "{robuxAmount} Robux for {usdAmount}";
	}

	protected virtual string _GetTemplateForLabelTradingRobux()
	{
		return "You're on your way to trading Robux for cash!";
	}

	protected virtual string _GetTemplateForLabelTradingRobuxCash()
	{
		return "You're almost there! You almost qualify to trade your Robux for cash!";
	}

	protected virtual string _GetTemplateForLabelVerifiedEmailForCashout()
	{
		return "You must verify your email before you can cash out.";
	}
}
