namespace Roblox.TranslationResources.Purchasing;

public interface IRixtyPinResources : ITranslationResources
{
	/// <summary>
	/// Key: "Action.BuyNow"
	/// English String: "Buy Now"
	/// </summary>
	string ActionBuyNow { get; }

	/// <summary>
	/// Key: "Action.BuyRobux"
	/// English String: "Buy Robux"
	/// </summary>
	string ActionBuyRobux { get; }

	/// <summary>
	/// Key: "Action.MoreBCOptions"
	/// English String: "More Builders Club Options"
	/// </summary>
	string ActionMoreBCOptions { get; }

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	string ActionRedeem { get; }

	/// <summary>
	/// Key: "Heading.AlreadyHaveCredit"
	/// English String: "You have Roblox Credit!"
	/// </summary>
	string HeadingAlreadyHaveCredit { get; }

	/// <summary>
	/// Key: "Heading.BuyRobuxUsingRixty"
	/// English String: "Buy Robux using Rixty"
	/// </summary>
	string HeadingBuyRobuxUsingRixty { get; }

	/// <summary>
	/// Key: "Heading.GetRobuxOrBcWithRixty"
	/// English String: "Get Robux or Builders Club with Rixty"
	/// </summary>
	string HeadingGetRobuxOrBcWithRixty { get; }

	/// <summary>
	/// Key: "Heading.GetRobuxWithRixty"
	/// English String: "Get Robux with Rixty"
	/// </summary>
	string HeadingGetRobuxWithRixty { get; }

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// English String: "How to Use"
	/// </summary>
	string HeadingHowToUse { get; }

	/// <summary>
	/// Key: "Heading.PayWithRixty"
	/// English String: "Pay with Rixty"
	/// </summary>
	string HeadingPayWithRixty { get; }

	/// <summary>
	/// Key: "Heading.RedeemRixtyCards"
	/// English String: "Redeem Rixty Cards"
	/// </summary>
	string HeadingRedeemRixtyCards { get; }

	/// <summary>
	/// Key: "Label.AlreadyHaveAccount"
	/// English String: "I already have a Rixty account"
	/// </summary>
	string LabelAlreadyHaveAccount { get; }

	/// <summary>
	/// Key: "Label.BuildersClubImage"
	/// Alternate text for Builders Club image
	/// English String: "Builders Club"
	/// </summary>
	string LabelBuildersClubImage { get; }

	/// <summary>
	/// Key: "Label.EnterPin"
	/// English String: "Enter PIN:"
	/// </summary>
	string LabelEnterPin { get; }

	/// <summary>
	/// Key: "Label.EnterPinImage"
	/// English String: "Enter Your PIN"
	/// </summary>
	string LabelEnterPinImage { get; }

	/// <summary>
	/// Key: "Label.FortyFiveDaysBC"
	/// English String: "45 Day Builders Club Extension - $10.00 (Existing BC members only)"
	/// </summary>
	string LabelFortyFiveDaysBC { get; }

	/// <summary>
	/// Key: "Label.InstructionForCombineCards"
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	string LabelInstructionForCombineCards { get; }

	/// <summary>
	/// Key: "Label.InstructionForEnterPin"
	/// English String: "Enter your Rixty PIN."
	/// </summary>
	string LabelInstructionForEnterPin { get; }

	/// <summary>
	/// Key: "Label.OrUppercase"
	/// English String: "OR"
	/// </summary>
	string LabelOrUppercase { get; }

	/// <summary>
	/// Key: "Label.PinImageText"
	/// English String: "Your PIN is on your receipt"
	/// </summary>
	string LabelPinImageText { get; }

	/// <summary>
	/// Key: "Label.RixtyLogo"
	/// English String: "Rixty Logo"
	/// </summary>
	string LabelRixtyLogo { get; }

	/// <summary>
	/// Key: "Label.Robux"
	/// English String: "Robux"
	/// </summary>
	string LabelRobux { get; }

	/// <summary>
	/// Key: "Label.ThirtyDaysBC"
	/// English String: "30 Days of Builders Club - $10.00"
	/// </summary>
	string LabelThirtyDaysBC { get; }

	/// <summary>
	/// Key: "Label.WhySpendCredit"
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	string LabelWhySpendCredit { get; }

	/// <summary>
	/// Key: "Label.YourBalance"
	/// English String: "Your Balance:"
	/// </summary>
	string LabelYourBalance { get; }

	/// <summary>
	/// Key: "Message.AnErrorOccurred"
	/// English String: "An error occurred"
	/// </summary>
	string MessageAnErrorOccurred { get; }

	/// <summary>
	/// Key: "Message.Failure"
	/// English String: "Failure"
	/// </summary>
	string MessageFailure { get; }

	/// <summary>
	/// Key: "Message.Loading"
	/// English String: "Loading"
	/// </summary>
	string MessageLoading { get; }

	/// <summary>
	/// Key: "Message.PinAlreadyRedeemed"
	/// English String: "PIN already redeemed"
	/// </summary>
	string MessagePinAlreadyRedeemed { get; }

	/// <summary>
	/// Key: "Message.RixtyUnavailable"
	/// English String: "Currently unavailable. Please try again later."
	/// </summary>
	string MessageRixtyUnavailable { get; }

	/// <summary>
	/// Key: "Message.Success"
	/// English String: "Success"
	/// </summary>
	string MessageSuccess { get; }

	/// <summary>
	/// Key: "Message.SuccessfulRedemption"
	/// English String: "You have successfully redeemed your PIN!"
	/// </summary>
	string MessageSuccessfulRedemption { get; }

	/// <summary>
	/// Key: "Description.UseCashForRobux"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	string DescriptionUseCashForRobux(string lineBreak);

	/// <summary>
	/// Key: "Description.UseCashForRobuxAndPremium"
	/// English String: "With Rixty, you can use cash and coins to buy Robux and Builders Club.{lineBreak}No credit card? No problem!"
	/// </summary>
	string DescriptionUseCashForRobuxAndPremium(string lineBreak);

	/// <summary>
	/// Key: "Label.BuildersClubExtensionExisting"
	/// For example, 45 Day Builders Club Extension - $10.00 (Existing BC members only)
	/// English String: "{numberOfDays} Day Builders Club Extension - {cost} (Existing BC members only)"
	/// </summary>
	string LabelBuildersClubExtensionExisting(string numberOfDays, string cost);

	/// <summary>
	/// Key: "Label.BuildersClubOffer"
	/// New purchase offer of builders club
	/// English String: "{numberOfDays} Days of Builders Club - {cost}"
	/// </summary>
	string LabelBuildersClubOffer(string numberOfDays, string cost);

	/// <summary>
	/// Key: "Label.BuyRobuxWithRixty"
	/// For example, "400 Robux for $4.95"
	/// English String: "{robuxAmount} Robux for {currencyAmount}"
	/// </summary>
	string LabelBuyRobuxWithRixty(string robuxAmount, string currencyAmount);

	/// <summary>
	/// Key: "Label.GetPhysicalRixtyCard"
	/// English String: "{startLink}Go to your local store{endLink} and get a Rixty Card."
	/// </summary>
	string LabelGetPhysicalRixtyCard(string startLink, string endLink);
}
