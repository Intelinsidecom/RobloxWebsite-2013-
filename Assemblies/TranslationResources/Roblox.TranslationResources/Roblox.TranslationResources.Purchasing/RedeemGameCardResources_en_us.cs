using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Purchasing;

internal class RedeemGameCardResources_en_us : TranslationResourcesBase, IRedeemGameCardResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Dialog.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public virtual string ActionDialogClose => "Close";

	/// <summary>
	/// Key: "Action.Dialog.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public virtual string ActionDialogLogin => "Login";

	/// <summary>
	/// Key: "Action.Dialog.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public virtual string ActionDialogSignUp => "Sign Up";

	/// <summary>
	/// Key: "Action.PurchaseCard"
	/// link text
	/// English String: "Purchase Card"
	/// </summary>
	public virtual string ActionPurchaseCard => "Purchase Card";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public virtual string ActionRedeem => "Redeem";

	/// <summary>
	/// Key: "Description.CombineCards"
	/// bullet point in a list
	/// English String: "Combine cards for more Roblox credit."
	/// </summary>
	public virtual string DescriptionCombineCards => "Combine cards for more Roblox credit.";

	/// <summary>
	/// Key: "Description.Dialog.RobloxRedeemCard"
	/// diglog main text
	/// English String: "You must be logged in to your Roblox account to redeem your Game Card!"
	/// </summary>
	public virtual string DescriptionDialogRobloxRedeemCard => "You must be logged in to your Roblox account to redeem your Game Card!";

	/// <summary>
	/// Key: "Description.LegalDisclaimer"
	/// descrption text
	/// English String: "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment."
	/// </summary>
	public virtual string DescriptionLegalDisclaimer => "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment.";

	/// <summary>
	/// Key: "Description.RetailersInfo"
	/// bullet point of a list
	/// English String: "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone."
	/// </summary>
	public virtual string DescriptionRetailersInfo => "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone.";

	/// <summary>
	/// Key: "Description.SpendRobloxCredit"
	/// bullet point of a list
	/// English String: "Spend your Roblox credit on Robux and Builders Club!"
	/// </summary>
	public virtual string DescriptionSpendRobloxCredit => "Spend your Roblox credit on Robux and Builders Club!";

	/// <summary>
	/// Key: "Description.TypeCardPin"
	/// bullet point in a list
	/// English String: "Type in your card PIN in the redeem section."
	/// </summary>
	public virtual string DescriptionTypeCardPin => "Type in your card PIN in the redeem section.";

	/// <summary>
	/// Key: "Heading.EnterPin"
	/// section heading  - please keep PIN capitalized if the languiage supports it
	/// English String: "Enter PIN"
	/// </summary>
	public virtual string HeadingEnterPin => "Enter PIN";

	/// <summary>
	/// Key: "Heading.GetRobloxCreditFor"
	/// section heading
	/// English String: "Get Roblox credit for"
	/// </summary>
	public virtual string HeadingGetRobloxCreditFor => "Get Roblox credit for";

	/// <summary>
	/// Key: "Heading.HowToRedeem"
	/// modal(dialog box) heading
	/// English String: "How to Redeem"
	/// </summary>
	public virtual string HeadingHowToRedeem => "How to Redeem";

	/// <summary>
	/// Key: "Heading.HowToUse"
	/// section heading
	/// English String: "How to Use"
	/// </summary>
	public virtual string HeadingHowToUse => "How to Use";

	/// <summary>
	/// Key: "Heading.RedeemRobloxCards"
	/// page heading
	/// English String: "Redeem Roblox cards"
	/// </summary>
	public virtual string HeadingRedeemRobloxCards => "Redeem Roblox cards";

	/// <summary>
	/// Key: "Label.Dialog.RedeemGameCard"
	/// dialog title
	/// English String: "Redeem Roblox Game Card"
	/// </summary>
	public virtual string LabelDialogRedeemGameCard => "Redeem Roblox Game Card";

	/// <summary>
	/// Key: "Label.NeedGameCard"
	/// label
	/// English String: "Need a Roblox game card?"
	/// </summary>
	public virtual string LabelNeedGameCard => "Need a Roblox game card?";

	/// <summary>
	/// Key: "Label.PinCode"
	/// please keep PIN capitalized if language supports capitalization
	/// English String: "PIN Code"
	/// </summary>
	public virtual string LabelPinCode => "PIN Code";

	/// <summary>
	/// Key: "Label.RobuxRedeemed"
	/// English String: "Robux Redeemed:"
	/// </summary>
	public virtual string LabelRobuxRedeemed => "Robux Redeemed:";

	/// <summary>
	/// Key: "Label.YourBalance"
	/// label
	/// English String: "Your Credit Balance:"
	/// </summary>
	public virtual string LabelYourBalance => "Your Credit Balance:";

	/// <summary>
	/// Key: "Response.AlreadyRedeemedError"
	/// error message
	/// English String: "This gift card has already been redeemed."
	/// </summary>
	public virtual string ResponseAlreadyRedeemedError => "This gift card has already been redeemed.";

	/// <summary>
	/// Key: "Response.BonusPreview"
	/// success message upsell text
	/// English String: "Redeem one more Roblox card from GameStop to receive your bonus Robux."
	/// </summary>
	public virtual string ResponseBonusPreview => "Redeem one more Roblox card from GameStop to receive your bonus Robux.";

	/// <summary>
	/// Key: "Response.BuildersClubExtended"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been extended!"
	/// </summary>
	public virtual string ResponseBuildersClubExtended => "Your Builders Club Membership has successfully been extended!";

	/// <summary>
	/// Key: "Response.BuildersClubExtendedSubText"
	/// sub text on success message
	/// English String: "Please allow up to 5 minutes for the changes to take effect."
	/// </summary>
	public virtual string ResponseBuildersClubExtendedSubText => "Please allow up to 5 minutes for the changes to take effect.";

	/// <summary>
	/// Key: "Response.BuildersClubRedeemed"
	/// success message
	/// English String: "Your Builders Club Membership has successfully been redeemed!"
	/// </summary>
	public virtual string ResponseBuildersClubRedeemed => "Your Builders Club Membership has successfully been redeemed!";

	/// <summary>
	/// Key: "Response.CodeNotFoundError"
	/// error message
	/// English String: "No matching code found."
	/// </summary>
	public virtual string ResponseCodeNotFoundError => "No matching code found.";

	/// <summary>
	/// Key: "Response.CouldNotFindObject"
	/// error message
	/// English String: "Could not find requested object."
	/// </summary>
	public virtual string ResponseCouldNotFindObject => "Could not find requested object.";

	/// <summary>
	/// Key: "Response.FeatureDisabledError"
	/// error message
	/// English String: "This feature is currently disabled."
	/// </summary>
	public virtual string ResponseFeatureDisabledError => "This feature is currently disabled.";

	/// <summary>
	/// Key: "Response.GenericError"
	/// error message
	/// English String: "Something went wrong, please try again later."
	/// </summary>
	public virtual string ResponseGenericError => "Something went wrong, please try again later.";

	/// <summary>
	/// Key: "Response.InvalidPIN"
	/// error message
	/// English String: "Invalid PIN"
	/// </summary>
	public virtual string ResponseInvalidPIN => "Invalid PIN";

	/// <summary>
	/// Key: "Response.LoginRequiredError"
	/// error message
	/// English String: "You must be logged in to perform this action."
	/// </summary>
	public virtual string ResponseLoginRequiredError => "You must be logged in to perform this action.";

	/// <summary>
	/// Key: "Response.ObjectNotFoundError"
	/// error message
	/// English String: "Could not find the requested object. Please try your request again and contact customer service if this problem persists."
	/// </summary>
	public virtual string ResponseObjectNotFoundError => "Could not find the requested object. Please try your request again and contact customer service if this problem persists.";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your card!"
	/// </summary>
	public virtual string ResponseRedeemSuccess => "You have successfully redeemed your card!";

	/// <summary>
	/// Key: "Response.TooManyCodesRedeemedError"
	/// error message
	/// English String: "Too many codes redeemed. Try your request again later."
	/// </summary>
	public virtual string ResponseTooManyCodesRedeemedError => "Too many codes redeemed. Try your request again later.";

	/// <summary>
	/// Key: "Response.TooManyRequestsError"
	/// error messages
	/// English String: "Too many failed request attempts. Try your request again later."
	/// </summary>
	public virtual string ResponseTooManyRequestsError => "Too many failed request attempts. Try your request again later.";

	public RedeemGameCardResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Dialog.Close",
				_GetTemplateForActionDialogClose()
			},
			{
				"Action.Dialog.Login",
				_GetTemplateForActionDialogLogin()
			},
			{
				"Action.Dialog.SignUp",
				_GetTemplateForActionDialogSignUp()
			},
			{
				"Action.PurchaseCard",
				_GetTemplateForActionPurchaseCard()
			},
			{
				"Action.Redeem",
				_GetTemplateForActionRedeem()
			},
			{
				"Description.CombineCards",
				_GetTemplateForDescriptionCombineCards()
			},
			{
				"Description.Dialog.RobloxRedeemCard",
				_GetTemplateForDescriptionDialogRobloxRedeemCard()
			},
			{
				"Description.LegalDisclaimer",
				_GetTemplateForDescriptionLegalDisclaimer()
			},
			{
				"Description.RetailerLink",
				_GetTemplateForDescriptionRetailerLink()
			},
			{
				"Description.RetailersInfo",
				_GetTemplateForDescriptionRetailersInfo()
			},
			{
				"Description.SpendRobloxCredit",
				_GetTemplateForDescriptionSpendRobloxCredit()
			},
			{
				"Description.TypeCardPin",
				_GetTemplateForDescriptionTypeCardPin()
			},
			{
				"Heading.EnterPin",
				_GetTemplateForHeadingEnterPin()
			},
			{
				"Heading.GetRobloxCreditFor",
				_GetTemplateForHeadingGetRobloxCreditFor()
			},
			{
				"Heading.HowToRedeem",
				_GetTemplateForHeadingHowToRedeem()
			},
			{
				"Heading.HowToUse",
				_GetTemplateForHeadingHowToUse()
			},
			{
				"Heading.RedeemRobloxCards",
				_GetTemplateForHeadingRedeemRobloxCards()
			},
			{
				"Label.Dialog.RedeemGameCard",
				_GetTemplateForLabelDialogRedeemGameCard()
			},
			{
				"Label.NeedGameCard",
				_GetTemplateForLabelNeedGameCard()
			},
			{
				"Label.PinCode",
				_GetTemplateForLabelPinCode()
			},
			{
				"Label.RobuxRedeemed",
				_GetTemplateForLabelRobuxRedeemed()
			},
			{
				"Label.YourBalance",
				_GetTemplateForLabelYourBalance()
			},
			{
				"Response.AlreadyRedeemedError",
				_GetTemplateForResponseAlreadyRedeemedError()
			},
			{
				"Response.BonusPreview",
				_GetTemplateForResponseBonusPreview()
			},
			{
				"Response.BuildersClubExtended",
				_GetTemplateForResponseBuildersClubExtended()
			},
			{
				"Response.BuildersClubExtendedSubText",
				_GetTemplateForResponseBuildersClubExtendedSubText()
			},
			{
				"Response.BuildersClubRedeemed",
				_GetTemplateForResponseBuildersClubRedeemed()
			},
			{
				"Response.CodeNotFoundError",
				_GetTemplateForResponseCodeNotFoundError()
			},
			{
				"Response.CouldNotFindObject",
				_GetTemplateForResponseCouldNotFindObject()
			},
			{
				"Response.FeatureDisabledError",
				_GetTemplateForResponseFeatureDisabledError()
			},
			{
				"Response.GenericError",
				_GetTemplateForResponseGenericError()
			},
			{
				"Response.InvalidPIN",
				_GetTemplateForResponseInvalidPIN()
			},
			{
				"Response.LoginRequiredError",
				_GetTemplateForResponseLoginRequiredError()
			},
			{
				"Response.MerchantNotFoundError",
				_GetTemplateForResponseMerchantNotFoundError()
			},
			{
				"Response.ObjectNotFoundError",
				_GetTemplateForResponseObjectNotFoundError()
			},
			{
				"Response.RedeemSuccess",
				_GetTemplateForResponseRedeemSuccess()
			},
			{
				"Response.RedeemSuccessForProduct",
				_GetTemplateForResponseRedeemSuccessForProduct()
			},
			{
				"Response.TooManyCodesRedeemedError",
				_GetTemplateForResponseTooManyCodesRedeemedError()
			},
			{
				"Response.TooManyRequestsError",
				_GetTemplateForResponseTooManyRequestsError()
			},
			{
				"Response.TwoCardsBonus",
				_GetTemplateForResponseTwoCardsBonus()
			},
			{
				"Response.WalmartRewardUpsell",
				_GetTemplateForResponseWalmartRewardUpsell()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Purchasing.RedeemGameCard";
	}

	protected virtual string _GetTemplateForActionDialogClose()
	{
		return "Close";
	}

	protected virtual string _GetTemplateForActionDialogLogin()
	{
		return "Login";
	}

	protected virtual string _GetTemplateForActionDialogSignUp()
	{
		return "Sign Up";
	}

	protected virtual string _GetTemplateForActionPurchaseCard()
	{
		return "Purchase Card";
	}

	protected virtual string _GetTemplateForActionRedeem()
	{
		return "Redeem";
	}

	protected virtual string _GetTemplateForDescriptionCombineCards()
	{
		return "Combine cards for more Roblox credit.";
	}

	protected virtual string _GetTemplateForDescriptionDialogRobloxRedeemCard()
	{
		return "You must be logged in to your Roblox account to redeem your Game Card!";
	}

	protected virtual string _GetTemplateForDescriptionLegalDisclaimer()
	{
		return "Purchases can be made with only one form of payment. Game card credits cannot be combined with other forms of payment.";
	}

	/// <summary>
	/// Key: "Description.RetailerLink"
	/// bullet point in a list
	/// English String: "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. "
	/// </summary>
	public virtual string DescriptionRetailerLink(string retailerLinkStart, string retailerLinkEnd)
	{
		return $"Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. ";
	}

	protected virtual string _GetTemplateForDescriptionRetailerLink()
	{
		return "Buy a Roblox game card at one of the {retailerLinkStart}participating retailers{retailerLinkEnd} or receive a Roblox gift card from someone. ";
	}

	protected virtual string _GetTemplateForDescriptionRetailersInfo()
	{
		return "Buy a Roblox game card at one of the participating retailers or receive a Roblox gift card from someone.";
	}

	protected virtual string _GetTemplateForDescriptionSpendRobloxCredit()
	{
		return "Spend your Roblox credit on Robux and Builders Club!";
	}

	protected virtual string _GetTemplateForDescriptionTypeCardPin()
	{
		return "Type in your card PIN in the redeem section.";
	}

	protected virtual string _GetTemplateForHeadingEnterPin()
	{
		return "Enter PIN";
	}

	protected virtual string _GetTemplateForHeadingGetRobloxCreditFor()
	{
		return "Get Roblox credit for";
	}

	protected virtual string _GetTemplateForHeadingHowToRedeem()
	{
		return "How to Redeem";
	}

	protected virtual string _GetTemplateForHeadingHowToUse()
	{
		return "How to Use";
	}

	protected virtual string _GetTemplateForHeadingRedeemRobloxCards()
	{
		return "Redeem Roblox cards";
	}

	protected virtual string _GetTemplateForLabelDialogRedeemGameCard()
	{
		return "Redeem Roblox Game Card";
	}

	protected virtual string _GetTemplateForLabelNeedGameCard()
	{
		return "Need a Roblox game card?";
	}

	protected virtual string _GetTemplateForLabelPinCode()
	{
		return "PIN Code";
	}

	protected virtual string _GetTemplateForLabelRobuxRedeemed()
	{
		return "Robux Redeemed:";
	}

	protected virtual string _GetTemplateForLabelYourBalance()
	{
		return "Your Credit Balance:";
	}

	protected virtual string _GetTemplateForResponseAlreadyRedeemedError()
	{
		return "This gift card has already been redeemed.";
	}

	protected virtual string _GetTemplateForResponseBonusPreview()
	{
		return "Redeem one more Roblox card from GameStop to receive your bonus Robux.";
	}

	protected virtual string _GetTemplateForResponseBuildersClubExtended()
	{
		return "Your Builders Club Membership has successfully been extended!";
	}

	protected virtual string _GetTemplateForResponseBuildersClubExtendedSubText()
	{
		return "Please allow up to 5 minutes for the changes to take effect.";
	}

	protected virtual string _GetTemplateForResponseBuildersClubRedeemed()
	{
		return "Your Builders Club Membership has successfully been redeemed!";
	}

	protected virtual string _GetTemplateForResponseCodeNotFoundError()
	{
		return "No matching code found.";
	}

	protected virtual string _GetTemplateForResponseCouldNotFindObject()
	{
		return "Could not find requested object.";
	}

	protected virtual string _GetTemplateForResponseFeatureDisabledError()
	{
		return "This feature is currently disabled.";
	}

	protected virtual string _GetTemplateForResponseGenericError()
	{
		return "Something went wrong, please try again later.";
	}

	protected virtual string _GetTemplateForResponseInvalidPIN()
	{
		return "Invalid PIN";
	}

	protected virtual string _GetTemplateForResponseLoginRequiredError()
	{
		return "You must be logged in to perform this action.";
	}

	/// <summary>
	/// Key: "Response.MerchantNotFoundError"
	/// error message
	/// English String: "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}"
	/// </summary>
	public virtual string ResponseMerchantNotFoundError(string authenticatedUserId, string cardPin)
	{
		return $"User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}";
	}

	protected virtual string _GetTemplateForResponseMerchantNotFoundError()
	{
		return "User tried to redeem Pin but the merchant does not exist. UserId: {authenticatedUserId} Pin Number: {cardPin}";
	}

	protected virtual string _GetTemplateForResponseObjectNotFoundError()
	{
		return "Could not find the requested object. Please try your request again and contact customer service if this problem persists.";
	}

	protected virtual string _GetTemplateForResponseRedeemSuccess()
	{
		return "You have successfully redeemed your card!";
	}

	/// <summary>
	/// Key: "Response.RedeemSuccessForProduct"
	/// success message
	/// English String: "You have successfully redeemed your card for {productName}"
	/// </summary>
	public virtual string ResponseRedeemSuccessForProduct(string productName)
	{
		return $"You have successfully redeemed your card for {productName}";
	}

	protected virtual string _GetTemplateForResponseRedeemSuccessForProduct()
	{
		return "You have successfully redeemed your card for {productName}";
	}

	protected virtual string _GetTemplateForResponseTooManyCodesRedeemedError()
	{
		return "Too many codes redeemed. Try your request again later.";
	}

	protected virtual string _GetTemplateForResponseTooManyRequestsError()
	{
		return "Too many failed request attempts. Try your request again later.";
	}

	/// <summary>
	/// Key: "Response.TwoCardsBonus"
	/// success message
	/// English String: "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account."
	/// </summary>
	public virtual string ResponseTwoCardsBonus(string robuxCount)
	{
		return $"Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account.";
	}

	protected virtual string _GetTemplateForResponseTwoCardsBonus()
	{
		return "Thanks for redeeming two Roblox cards from GameStop. {robuxCount} Robux have been added to your account.";
	}

	/// <summary>
	/// Key: "Response.WalmartRewardUpsell"
	/// upsell message
	/// English String: "Redeem one more Roblox card from Walmart to receive {rewardName}."
	/// </summary>
	public virtual string ResponseWalmartRewardUpsell(string rewardName)
	{
		return $"Redeem one more Roblox card from Walmart to receive {rewardName}.";
	}

	protected virtual string _GetTemplateForResponseWalmartRewardUpsell()
	{
		return "Redeem one more Roblox card from Walmart to receive {rewardName}.";
	}
}
