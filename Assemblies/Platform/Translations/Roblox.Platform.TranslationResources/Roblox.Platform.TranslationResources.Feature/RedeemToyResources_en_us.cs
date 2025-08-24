using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class RedeemToyResources_en_us : TranslationResourcesBase, IRedeemToyResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Cancel"
	/// button text
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.CantFindCode"
	/// link text
	/// English String: "Can't find your code?"
	/// </summary>
	public virtual string ActionCantFindCode => "Can't find your code?";

	/// <summary>
	/// Key: "Action.Close"
	/// button text
	/// English String: "Close"
	/// </summary>
	public virtual string ActionClose => "Close";

	/// <summary>
	/// Key: "Action.ContinueVideo"
	/// button text
	/// English String: "Continue to Video"
	/// </summary>
	public virtual string ActionContinueVideo => "Continue to Video";

	/// <summary>
	/// Key: "Action.HavePromoCode"
	/// link text
	/// English String: "Have a promo code? Click here"
	/// </summary>
	public virtual string ActionHavePromoCode => "Have a promo code? Click here";

	/// <summary>
	/// Key: "Action.HowToRedeem"
	/// link text
	/// English String: "How to redeem"
	/// </summary>
	public virtual string ActionHowToRedeem => "How to redeem";

	/// <summary>
	/// Key: "Action.Login"
	/// button text
	/// English String: "Login"
	/// </summary>
	public virtual string ActionLogin => "Login";

	/// <summary>
	/// Key: "Action.Redeem"
	/// button text
	/// English String: "Redeem"
	/// </summary>
	public virtual string ActionRedeem => "Redeem";

	/// <summary>
	/// Key: "Action.RedeemAnotherItem"
	/// button text
	/// English String: "Redeem Another Item"
	/// </summary>
	public virtual string ActionRedeemAnotherItem => "Redeem Another Item";

	/// <summary>
	/// Key: "Action.SignUp"
	/// button text
	/// English String: "Sign Up"
	/// </summary>
	public virtual string ActionSignUp => "Sign Up";

	/// <summary>
	/// Key: "Action.ViewItem"
	/// button text
	/// English String: "View Item"
	/// </summary>
	public virtual string ActionViewItem => "View Item";

	/// <summary>
	/// Key: "Description.LeavingRoblox"
	/// modal description text warning user that they are leaving Roblox main site
	/// English String: "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy."
	/// </summary>
	public virtual string DescriptionLeavingRoblox => "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy.";

	/// <summary>
	/// Key: "Heading.Dialog.Success"
	/// modal heading
	/// English String: "Successfully Redeemed"
	/// </summary>
	public virtual string HeadingDialogSuccess => "Successfully Redeemed";

	/// <summary>
	/// Key: "Heading.RedeemVirtualItem"
	/// page heading
	/// English String: "Redeem Roblox Virtual Item"
	/// </summary>
	public virtual string HeadingRedeemVirtualItem => "Redeem Roblox Virtual Item";

	/// <summary>
	/// Key: "Heading.YoureLeavingRoblox"
	/// modal heading
	/// English String: "You are leaving Roblox"
	/// </summary>
	public virtual string HeadingYoureLeavingRoblox => "You are leaving Roblox";

	/// <summary>
	/// Key: "Label.EnterToyCode"
	/// label
	/// English String: "Enter Toy Code"
	/// </summary>
	public virtual string LabelEnterToyCode => "Enter Toy Code";

	/// <summary>
	/// Key: "Response.InvalidCodeTryAgain"
	/// error message
	/// English String: "Invalid code, please try again."
	/// </summary>
	public virtual string ResponseInvalidCodeTryAgain => "Invalid code, please try again.";

	/// <summary>
	/// Key: "Response.LoginRequiredToRedeem"
	/// error message
	/// English String: "You must be logged in to your Roblox account to redeem the code for your virtual item!"
	/// </summary>
	public virtual string ResponseLoginRequiredToRedeem => "You must be logged in to your Roblox account to redeem the code for your virtual item!";

	/// <summary>
	/// Key: "Response.RedeemSuccess"
	/// success message
	/// English String: "You have successfully redeemed your item."
	/// </summary>
	public virtual string ResponseRedeemSuccess => "You have successfully redeemed your item.";

	public RedeemToyResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.CantFindCode",
				_GetTemplateForActionCantFindCode()
			},
			{
				"Action.Close",
				_GetTemplateForActionClose()
			},
			{
				"Action.ContinueVideo",
				_GetTemplateForActionContinueVideo()
			},
			{
				"Action.HavePromoCode",
				_GetTemplateForActionHavePromoCode()
			},
			{
				"Action.HowToRedeem",
				_GetTemplateForActionHowToRedeem()
			},
			{
				"Action.Login",
				_GetTemplateForActionLogin()
			},
			{
				"Action.Redeem",
				_GetTemplateForActionRedeem()
			},
			{
				"Action.RedeemAnotherItem",
				_GetTemplateForActionRedeemAnotherItem()
			},
			{
				"Action.SignUp",
				_GetTemplateForActionSignUp()
			},
			{
				"Action.ViewItem",
				_GetTemplateForActionViewItem()
			},
			{
				"Description.Dialog.Success",
				_GetTemplateForDescriptionDialogSuccess()
			},
			{
				"Description.LeavingRoblox",
				_GetTemplateForDescriptionLeavingRoblox()
			},
			{
				"Heading.Dialog.Success",
				_GetTemplateForHeadingDialogSuccess()
			},
			{
				"Heading.RedeemVirtualItem",
				_GetTemplateForHeadingRedeemVirtualItem()
			},
			{
				"Heading.YoureLeavingRoblox",
				_GetTemplateForHeadingYoureLeavingRoblox()
			},
			{
				"Label.EnterToyCode",
				_GetTemplateForLabelEnterToyCode()
			},
			{
				"Response.InvalidCodeTryAgain",
				_GetTemplateForResponseInvalidCodeTryAgain()
			},
			{
				"Response.LoginRequiredToRedeem",
				_GetTemplateForResponseLoginRequiredToRedeem()
			},
			{
				"Response.RedeemSuccess",
				_GetTemplateForResponseRedeemSuccess()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.RedeemToy";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionCantFindCode()
	{
		return "Can't find your code?";
	}

	protected virtual string _GetTemplateForActionClose()
	{
		return "Close";
	}

	protected virtual string _GetTemplateForActionContinueVideo()
	{
		return "Continue to Video";
	}

	protected virtual string _GetTemplateForActionHavePromoCode()
	{
		return "Have a promo code? Click here";
	}

	protected virtual string _GetTemplateForActionHowToRedeem()
	{
		return "How to redeem";
	}

	protected virtual string _GetTemplateForActionLogin()
	{
		return "Login";
	}

	protected virtual string _GetTemplateForActionRedeem()
	{
		return "Redeem";
	}

	protected virtual string _GetTemplateForActionRedeemAnotherItem()
	{
		return "Redeem Another Item";
	}

	protected virtual string _GetTemplateForActionSignUp()
	{
		return "Sign Up";
	}

	protected virtual string _GetTemplateForActionViewItem()
	{
		return "View Item";
	}

	/// <summary>
	/// Key: "Description.Dialog.Success"
	/// modal description text for successful redeem
	/// English String: "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}."
	/// </summary>
	public virtual string DescriptionDialogSuccess(string spanTagStart, string itemName, string spanTagEnd, string itemType, string creatorName)
	{
		return $"You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}.";
	}

	protected virtual string _GetTemplateForDescriptionDialogSuccess()
	{
		return "You have successfully redeemed {spanTagStart}{itemName}{spanTagEnd} ({itemType}) from {creatorName}.";
	}

	protected virtual string _GetTemplateForDescriptionLeavingRoblox()
	{
		return "You are about to leave Roblox to view a video on Youtube. Youtube is not part of Roblox.com and is governed by a separate privacy policy.";
	}

	protected virtual string _GetTemplateForHeadingDialogSuccess()
	{
		return "Successfully Redeemed";
	}

	protected virtual string _GetTemplateForHeadingRedeemVirtualItem()
	{
		return "Redeem Roblox Virtual Item";
	}

	protected virtual string _GetTemplateForHeadingYoureLeavingRoblox()
	{
		return "You are leaving Roblox";
	}

	protected virtual string _GetTemplateForLabelEnterToyCode()
	{
		return "Enter Toy Code";
	}

	protected virtual string _GetTemplateForResponseInvalidCodeTryAgain()
	{
		return "Invalid code, please try again.";
	}

	protected virtual string _GetTemplateForResponseLoginRequiredToRedeem()
	{
		return "You must be logged in to your Roblox account to redeem the code for your virtual item!";
	}

	protected virtual string _GetTemplateForResponseRedeemSuccess()
	{
		return "You have successfully redeemed your item.";
	}
}
