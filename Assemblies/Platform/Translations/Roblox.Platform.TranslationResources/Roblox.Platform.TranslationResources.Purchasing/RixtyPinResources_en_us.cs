using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Purchasing;

internal class RixtyPinResources_en_us : TranslationResourcesBase, IRixtyPinResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	public virtual string ActionBuyNow => "Buy Now";

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	public virtual string ActionBuyRobux => "Buy Robux";

	/// <summary>
	/// Key: "Action.MoreBCOptions"
	/// English String: "More Builders Club Options"
	/// </summary>
	public virtual string ActionMoreBCOptions => "More Builders Club Options";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public virtual string ActionRedeem => "Redeem";

	/// <summary>
	/// Key: "Heading.AlreadyHaveCredit"
	/// English String: "You have Roblox Credit!"
	/// </summary>
	public virtual string HeadingAlreadyHaveCredit => "You have Roblox Credit!";

	/// <summary>
	/// Key: "Heading.BuyRobuxUsingRixty"
	/// English String: "Buy Robux using Rixty"
	/// </summary>
	public virtual string HeadingBuyRobuxUsingRixty => "Buy Robux using Rixty";

	/// <summary>
	/// Key: "Heading.GetRobuxOrBcWithRixty"
	/// English String: "Get Robux or Builders Club with Rixty"
	/// </summary>
	public virtual string HeadingGetRobuxOrBcWithRixty => "Get Robux or Builders Club with Rixty";

	/// <summary>
	/// Key: "Heading.GetRobuxWithRixty"
	/// English String: "Get Robux with Rixty"
	/// </summary>
	public virtual string HeadingGetRobuxWithRixty => "Get Robux with Rixty";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// English String: "How to Use"
	/// </summary>
	public virtual string HeadingHowToUse => "How to Use";

	/// <summary>
	/// Key: "Heading.PayWithRixty"
	/// English String: "Pay with Rixty"
	/// </summary>
	public virtual string HeadingPayWithRixty => "Pay with Rixty";

	/// <summary>
	/// Key: "Heading.RedeemRixtyCards"
	/// English String: "Redeem Rixty Cards"
	/// </summary>
	public virtual string HeadingRedeemRixtyCards => "Redeem Rixty Cards";

	/// <summary>
	/// Key: "Label.AlreadyHaveAccount"
	/// English String: "I already have a Rixty account"
	/// </summary>
	public virtual string LabelAlreadyHaveAccount => "I already have a Rixty account";

	/// <summary>
	/// Key: "Label.BuildersClubImage"
	/// Alternate text for Builders Club image
	/// English String: "Builders Club"
	/// </summary>
	public virtual string LabelBuildersClubImage => "Builders Club";

	/// <summary>
	/// Key: "Label.EnterPin"
	/// English String: "Enter PIN:"
	/// </summary>
	public virtual string LabelEnterPin => "Enter PIN:";

	/// <summary>
	/// Key: "Label.EnterPinImage"
	/// English String: "Enter Your PIN"
	/// </summary>
	public virtual string LabelEnterPinImage => "Enter Your PIN";

	/// <summary>
	/// Key: "Label.FortyFiveDaysBC"
	/// English String: "45 Day Builders Club Extension - $10.00 (Existing BC members only)"
	/// </summary>
	public virtual string LabelFortyFiveDaysBC => "45 Day Builders Club Extension - $10.00 (Existing BC members only)";

	/// <summary>
	/// Key: "Label.InstructionForCombineCards"
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public virtual string LabelInstructionForCombineCards => "Combine cards for more Roblox credit.";

	/// <summary>
	/// Key: "Label.InstructionForEnterPin"
	/// English String: "Enter your Rixty PIN."
	/// </summary>
	public virtual string LabelInstructionForEnterPin => "Enter your Rixty PIN.";

	/// <summary>
	/// Key: "Label.OrUppercase"
	/// English String: "OR"
	/// </summary>
	public virtual string LabelOrUppercase => "OR";

	/// <summary>
	/// Key: "Label.PinImageText"
	/// English String: "Your PIN is on your receipt"
	/// </summary>
	public virtual string LabelPinImageText => "Your PIN is on your receipt";

	/// <summary>
	/// Key: "Label.RixtyLogo"
	/// English String: "Rixty Logo"
	/// </summary>
	public virtual string LabelRixtyLogo => "Rixty Logo";

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	public virtual string LabelRobux => "Robux";

	/// <summary>
	/// Key: "Label.ThirtyDaysBC"
	/// English String: "30 Days of Builders Club - $10.00"
	/// </summary>
	public virtual string LabelThirtyDaysBC => "30 Days of Builders Club - $10.00";

	/// <summary>
	/// Key: "Label.WhySpendCredit"
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public virtual string LabelWhySpendCredit => "Spend your Roblox credit on Robux and Builders Club!";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// English String: "Your Balance:"
	/// </summary>
	public virtual string LabelYourBalance => "Your Balance:";

	/// <summary>
	/// Key: "Message.AnErrorOccurred"
	/// English String: "An error occurred"
	/// </summary>
	public virtual string MessageAnErrorOccurred => "An error occurred";

	/// <summary>
	/// Key: "Message.Failure"
	/// English String: "Failure"
	/// </summary>
	public virtual string MessageFailure => "Failure";

	/// <summary>
	/// Key: "Message.Loading"
	/// English String: "Loading"
	/// </summary>
	public virtual string MessageLoading => "Loading";

	/// <summary>
	/// Key: "Message.PinAlreadyRedeemed"
	/// English String: "PIN already redeemed"
	/// </summary>
	public virtual string MessagePinAlreadyRedeemed => "PIN already redeemed";

	/// <summary>
	/// Key: "Message.RixtyUnavailable"
	/// English String: "Currently unavailable. Please try again later."
	/// </summary>
	public virtual string MessageRixtyUnavailable => "Currently unavailable. Please try again later.";

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	public virtual string MessageSuccess => "Success";

	/// <summary>
	/// Key: "Message.SuccessfulRedemption"
	/// English String: "You have successfully redeemed your PIN!"
	/// </summary>
	public virtual string MessageSuccessfulRedemption => "You have successfully redeemed your PIN!";

	public RixtyPinResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.BuyNow",
				_GetTemplateForActionBuyNow()
			},
			{
				"Action.BuyRobux",
				_GetTemplateForActionBuyRobux()
			},
			{
				"Action.MoreBCOptions",
				_GetTemplateForActionMoreBCOptions()
			},
			{
				"Action.Redeem",
				_GetTemplateForActionRedeem()
			},
			{
				"Description.UseCashForRobux",
				_GetTemplateForDescriptionUseCashForRobux()
			},
			{
				"Description.UseCashForRobuxAndPremium",
				_GetTemplateForDescriptionUseCashForRobuxAndPremium()
			},
			{
				"Heading.AlreadyHaveCredit",
				_GetTemplateForHeadingAlreadyHaveCredit()
			},
			{
				"Heading.BuyRobuxUsingRixty",
				_GetTemplateForHeadingBuyRobuxUsingRixty()
			},
			{
				"Heading.GetRobuxOrBcWithRixty",
				_GetTemplateForHeadingGetRobuxOrBcWithRixty()
			},
			{
				"Heading.GetRobuxWithRixty",
				_GetTemplateForHeadingGetRobuxWithRixty()
			},
			{
				"Heading.HowToUse",
				_GetTemplateForHeadingHowToUse()
			},
			{
				"Heading.PayWithRixty",
				_GetTemplateForHeadingPayWithRixty()
			},
			{
				"Heading.RedeemRixtyCards",
				_GetTemplateForHeadingRedeemRixtyCards()
			},
			{
				"Label.AlreadyHaveAccount",
				_GetTemplateForLabelAlreadyHaveAccount()
			},
			{
				"Label.BuildersClubExtensionExisting",
				_GetTemplateForLabelBuildersClubExtensionExisting()
			},
			{
				"Label.BuildersClubImage",
				_GetTemplateForLabelBuildersClubImage()
			},
			{
				"Label.BuildersClubOffer",
				_GetTemplateForLabelBuildersClubOffer()
			},
			{
				"Label.BuyRobuxWithRixty",
				_GetTemplateForLabelBuyRobuxWithRixty()
			},
			{
				"Label.EnterPin",
				_GetTemplateForLabelEnterPin()
			},
			{
				"Label.EnterPinImage",
				_GetTemplateForLabelEnterPinImage()
			},
			{
				"Label.FortyFiveDaysBC",
				_GetTemplateForLabelFortyFiveDaysBC()
			},
			{
				"Label.GetPhysicalRixtyCard",
				_GetTemplateForLabelGetPhysicalRixtyCard()
			},
			{
				"Label.InstructionForCombineCards",
				_GetTemplateForLabelInstructionForCombineCards()
			},
			{
				"Label.InstructionForEnterPin",
				_GetTemplateForLabelInstructionForEnterPin()
			},
			{
				"Label.OrUppercase",
				_GetTemplateForLabelOrUppercase()
			},
			{
				"Label.PinImageText",
				_GetTemplateForLabelPinImageText()
			},
			{
				"Label.RixtyLogo",
				_GetTemplateForLabelRixtyLogo()
			},
			{
				"Label.Robux",
				_GetTemplateForLabelRobux()
			},
			{
				"Label.ThirtyDaysBC",
				_GetTemplateForLabelThirtyDaysBC()
			},
			{
				"Label.WhySpendCredit",
				_GetTemplateForLabelWhySpendCredit()
			},
			{
				"Label.YourBalance",
				_GetTemplateForLabelYourBalance()
			},
			{
				"Message.AnErrorOccurred",
				_GetTemplateForMessageAnErrorOccurred()
			},
			{
				"Message.Failure",
				_GetTemplateForMessageFailure()
			},
			{
				"Message.Loading",
				_GetTemplateForMessageLoading()
			},
			{
				"Message.PinAlreadyRedeemed",
				_GetTemplateForMessagePinAlreadyRedeemed()
			},
			{
				"Message.RixtyUnavailable",
				_GetTemplateForMessageRixtyUnavailable()
			},
			{
				"Message.Success",
				_GetTemplateForMessageSuccess()
			},
			{
				"Message.SuccessfulRedemption",
				_GetTemplateForMessageSuccessfulRedemption()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Purchasing.RixtyPin";
	}

	protected virtual string _GetTemplateForActionBuyNow()
	{
		return "Buy Now";
	}

	protected virtual string _GetTemplateForActionBuyRobux()
	{
		return "Buy Robux";
	}

	protected virtual string _GetTemplateForActionMoreBCOptions()
	{
		return "More Builders Club Options";
	}

	protected virtual string _GetTemplateForActionRedeem()
	{
		return "Redeem";
	}

	/// <summary>
	/// Key: "Description.UseCashForRobux"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	public virtual string DescriptionUseCashForRobux(string lineBreak)
	{
		return $"With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!";
	}

	protected virtual string _GetTemplateForDescriptionUseCashForRobux()
	{
		return "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!";
	}

	/// <summary>
	/// Key: "Description.UseCashForRobuxAndPremium"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	public virtual string DescriptionUseCashForRobuxAndPremium(string lineBreak)
	{
		return $"With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!";
	}

	protected virtual string _GetTemplateForDescriptionUseCashForRobuxAndPremium()
	{
		return "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!";
	}

	protected virtual string _GetTemplateForHeadingAlreadyHaveCredit()
	{
		return "You have Roblox Credit!";
	}

	protected virtual string _GetTemplateForHeadingBuyRobuxUsingRixty()
	{
		return "Buy Robux using Rixty";
	}

	protected virtual string _GetTemplateForHeadingGetRobuxOrBcWithRixty()
	{
		return "Get Robux or Builders Club with Rixty";
	}

	protected virtual string _GetTemplateForHeadingGetRobuxWithRixty()
	{
		return "Get Robux with Rixty";
	}

	protected virtual string _GetTemplateForHeadingHowToUse()
	{
		return "How to Use";
	}

	protected virtual string _GetTemplateForHeadingPayWithRixty()
	{
		return "Pay with Rixty";
	}

	protected virtual string _GetTemplateForHeadingRedeemRixtyCards()
	{
		return "Redeem Rixty Cards";
	}

	protected virtual string _GetTemplateForLabelAlreadyHaveAccount()
	{
		return "I already have a Rixty account";
	}

	/// <summary>
	/// Key: "Label.BuildersClubExtensionExisting"
	/// For example, 45 Day Builders Club Extension - $10.00 (Existing BC members only)
	/// English String: "{numberOfDays} Day Builders Club Extension - {cost} (Existing BC members only)"
	/// </summary>
	public virtual string LabelBuildersClubExtensionExisting(string numberOfDays, string cost)
	{
		return $"{numberOfDays} Day Builders Club Extension - {cost} (Existing BC members only)";
	}

	protected virtual string _GetTemplateForLabelBuildersClubExtensionExisting()
	{
		return "{numberOfDays} Day Builders Club Extension - {cost} (Existing BC members only)";
	}

	protected virtual string _GetTemplateForLabelBuildersClubImage()
	{
		return "Builders Club";
	}

	/// <summary>
	/// Key: "Label.BuildersClubOffer"
	/// New purchase offer of builders club
	/// English String: "{numberOfDays} Days of Builders Club - {cost}"
	/// </summary>
	public virtual string LabelBuildersClubOffer(string numberOfDays, string cost)
	{
		return $"{numberOfDays} Days of Builders Club - {cost}";
	}

	protected virtual string _GetTemplateForLabelBuildersClubOffer()
	{
		return "{numberOfDays} Days of Builders Club - {cost}";
	}

	/// <summary>
	/// Key: "Label.BuyRobuxWithRixty"
	/// For example, "400 Robux for $4.95"
	/// English String: "{robuxAmount} Robux for {currencyAmount}"
	/// </summary>
	public virtual string LabelBuyRobuxWithRixty(string robuxAmount, string currencyAmount)
	{
		return $"{robuxAmount} Robux for {currencyAmount}";
	}

	protected virtual string _GetTemplateForLabelBuyRobuxWithRixty()
	{
		return "{robuxAmount} Robux for {currencyAmount}";
	}

	protected virtual string _GetTemplateForLabelEnterPin()
	{
		return "Enter PIN:";
	}

	protected virtual string _GetTemplateForLabelEnterPinImage()
	{
		return "Enter Your PIN";
	}

	protected virtual string _GetTemplateForLabelFortyFiveDaysBC()
	{
		return "45 Day Builders Club Extension - $10.00 (Existing BC members only)";
	}

	/// <summary>
	/// Key: "Label.GetPhysicalRixtyCard"
	/// English String: "{startLink}Go to your local store{endLink} and get a Rixty Card."
	/// </summary>
	public virtual string LabelGetPhysicalRixtyCard(string startLink, string endLink)
	{
		return $"{startLink}Go to your local store{endLink} and get a Rixty Card.";
	}

	protected virtual string _GetTemplateForLabelGetPhysicalRixtyCard()
	{
		return "{startLink}Go to your local store{endLink} and get a Rixty Card.";
	}

	protected virtual string _GetTemplateForLabelInstructionForCombineCards()
	{
		return "Combine cards for more Roblox credit.";
	}

	protected virtual string _GetTemplateForLabelInstructionForEnterPin()
	{
		return "Enter your Rixty PIN.";
	}

	protected virtual string _GetTemplateForLabelOrUppercase()
	{
		return "OR";
	}

	protected virtual string _GetTemplateForLabelPinImageText()
	{
		return "Your PIN is on your receipt";
	}

	protected virtual string _GetTemplateForLabelRixtyLogo()
	{
		return "Rixty Logo";
	}

	protected virtual string _GetTemplateForLabelRobux()
	{
		return "Robux";
	}

	protected virtual string _GetTemplateForLabelThirtyDaysBC()
	{
		return "30 Days of Builders Club - $10.00";
	}

	protected virtual string _GetTemplateForLabelWhySpendCredit()
	{
		return "Spend your Roblox credit on Robux and Builders Club!";
	}

	protected virtual string _GetTemplateForLabelYourBalance()
	{
		return "Your Balance:";
	}

	protected virtual string _GetTemplateForMessageAnErrorOccurred()
	{
		return "An error occurred";
	}

	protected virtual string _GetTemplateForMessageFailure()
	{
		return "Failure";
	}

	protected virtual string _GetTemplateForMessageLoading()
	{
		return "Loading";
	}

	protected virtual string _GetTemplateForMessagePinAlreadyRedeemed()
	{
		return "PIN already redeemed";
	}

	protected virtual string _GetTemplateForMessageRixtyUnavailable()
	{
		return "Currently unavailable. Please try again later.";
	}

	protected virtual string _GetTemplateForMessageSuccess()
	{
		return "Success";
	}

	protected virtual string _GetTemplateForMessageSuccessfulRedemption()
	{
		return "You have successfully redeemed your PIN!";
	}
}
