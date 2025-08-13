using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class RobloxCreditResources_en_us : TranslationResourcesBase, IRobloxCreditResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.ConvertToRobux"
	/// English String: "Convert To Robux"
	/// </summary>
	public virtual string ActionConvertToRobux => "Convert To Robux";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public virtual string ActionRedeem => "Redeem";

	/// <summary>
	/// Key: "Heading.GetRobux"
	/// English String: "Get Robux"
	/// </summary>
	public virtual string HeadingGetRobux => "Get Robux";

	/// <summary>
	/// Key: "Heading.RobloxCredit"
	/// English String: "Roblox credit"
	/// </summary>
	public virtual string HeadingRobloxCredit => "Roblox credit";

	/// <summary>
	/// Key: "Message.FailedDebitRobloxCredit"
	/// English String: "There has been an issue processing your Roblox credit. Please try again later!"
	/// </summary>
	public virtual string MessageFailedDebitRobloxCredit => "There has been an issue processing your Roblox credit. Please try again later!";

	/// <summary>
	/// Key: "Message.FailedGrantingRobux"
	/// English String: "We’ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux."
	/// </summary>
	public virtual string MessageFailedGrantingRobux => "We’ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux.";

	public RobloxCreditResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.ConvertToRobux",
				_GetTemplateForActionConvertToRobux()
			},
			{
				"Action.Redeem",
				_GetTemplateForActionRedeem()
			},
			{
				"Description.ConfirmRedeemCreditForRobux",
				_GetTemplateForDescriptionConfirmRedeemCreditForRobux()
			},
			{
				"Description.ConfirmRobloxCreditToRobuxRedemption",
				_GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
			},
			{
				"Heading.GetRobux",
				_GetTemplateForHeadingGetRobux()
			},
			{
				"Heading.RobloxCredit",
				_GetTemplateForHeadingRobloxCredit()
			},
			{
				"Label.CurrentBalance",
				_GetTemplateForLabelCurrentBalance()
			},
			{
				"Message.FailedDebitRobloxCredit",
				_GetTemplateForMessageFailedDebitRobloxCredit()
			},
			{
				"Message.FailedGrantingRobux",
				_GetTemplateForMessageFailedGrantingRobux()
			},
			{
				"Message.RobloxCreditToRobuxRedemptionConfirmation",
				_GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.RobloxCredit";
	}

	protected virtual string _GetTemplateForActionConvertToRobux()
	{
		return "Convert To Robux";
	}

	protected virtual string _GetTemplateForActionRedeem()
	{
		return "Redeem";
	}

	/// <summary>
	/// Key: "Description.ConfirmRedeemCreditForRobux"
	/// "NOT BEING USED" Incorrect message
	/// English String: "Redeem your {balance} Roblox credit to {robuxAmount}"
	/// </summary>
	public virtual string DescriptionConfirmRedeemCreditForRobux(string balance, string robuxAmount)
	{
		return $"Redeem your {balance} Roblox credit to {robuxAmount}";
	}

	protected virtual string _GetTemplateForDescriptionConfirmRedeemCreditForRobux()
	{
		return "Redeem your {balance} Roblox credit to {robuxAmount}";
	}

	/// <summary>
	/// Key: "Description.ConfirmRobloxCreditToRobuxRedemption"
	/// English String: "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}"
	/// </summary>
	public virtual string DescriptionConfirmRobloxCreditToRobuxRedemption(string balance, string iconRobux, string robuxAmount)
	{
		return $"Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}";
	}

	protected virtual string _GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
	{
		return "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}";
	}

	protected virtual string _GetTemplateForHeadingGetRobux()
	{
		return "Get Robux";
	}

	protected virtual string _GetTemplateForHeadingRobloxCredit()
	{
		return "Roblox credit";
	}

	/// <summary>
	/// Key: "Label.CurrentBalance"
	/// Roblox Credit Balance
	/// English String: "Current Balance: ${balance}"
	/// </summary>
	public virtual string LabelCurrentBalance(string balance)
	{
		return $"Current Balance: ${balance}";
	}

	protected virtual string _GetTemplateForLabelCurrentBalance()
	{
		return "Current Balance: ${balance}";
	}

	protected virtual string _GetTemplateForMessageFailedDebitRobloxCredit()
	{
		return "There has been an issue processing your Roblox credit. Please try again later!";
	}

	protected virtual string _GetTemplateForMessageFailedGrantingRobux()
	{
		return "We’ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux.";
	}

	/// <summary>
	/// Key: "Message.RobloxCreditToRobuxRedemptionConfirmation"
	/// English String: "You've successfully redeemed {robuxAmount} Robux!"
	/// </summary>
	public virtual string MessageRobloxCreditToRobuxRedemptionConfirmation(string robuxAmount)
	{
		return $"You've successfully redeemed {robuxAmount} Robux!";
	}

	protected virtual string _GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
	{
		return "You've successfully redeemed {robuxAmount} Robux!";
	}
}
