using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class DevExHomeResources_en_us : TranslationResourcesBase, IDevExHomeResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "GetActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string GetActionCancel => "Cancel";

	/// <summary>
	/// Key: "GetActionCashOut"
	/// English String: "Cash Out"
	/// </summary>
	public virtual string GetActionCashOut => "Cash Out";

	/// <summary>
	/// Key: "GetActionGetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public virtual string GetActionGetObc => "Get OBC Now";

	/// <summary>
	/// Key: "GetActionUpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public virtual string GetActionUpgradeMembership => "Upgrade Membership";

	/// <summary>
	/// Key: "GetActionVerify"
	/// English String: "Verify"
	/// </summary>
	public virtual string GetActionVerify => "Verify";

	/// <summary>
	/// Key: "GetActionVerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public virtual string GetActionVerifyEmail => "Verify Email";

	/// <summary>
	/// Key: "GetActionVerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public virtual string GetActionVerifyNow => "Verify Now";

	/// <summary>
	/// Key: "GetActionVisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public virtual string GetActionVisitDevEx => "Visit DevEx";

	/// <summary>
	/// Key: "GetLabelAlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public virtual string GetLabelAlmostReady => "You're almost ready!";

	/// <summary>
	/// Key: "GetLabelBuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public virtual string GetLabelBuilderClubForCash => "You'll need Outrageous Builder's Club to exchange Robux for cash.";

	/// <summary>
	/// Key: "GetLabelBuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public virtual string GetLabelBuildersCludForCashout => "You need Outrageous Builders Club to Cash Out.";

	/// <summary>
	/// Key: "GetLabelCurrentExchangeRate"
	/// English String: "Current Exchange Rates"
	/// </summary>
	public virtual string GetLabelCurrentExchangeRate => "Current Exchange Rates";

	/// <summary>
	/// Key: "GetLabelNeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public virtual string GetLabelNeedVerifiedEmail => "You need a verified email address to use DevEx.";

	/// <summary>
	/// Key: "GetLabelNotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public virtual string GetLabelNotEligible => "You are not eligible currently.";

	/// <summary>
	/// Key: "GetLabelNotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public virtual string GetLabelNotEnoughRobuxForCashout => "You don't have enough Robux to Cash Out.";

	/// <summary>
	/// Key: "GetLabelRobux"
	/// English String: "Robux"
	/// </summary>
	public virtual string GetLabelRobux => "Robux";

	/// <summary>
	/// Key: "GetLabelTradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public virtual string GetLabelTradingRobux => "You're on your way to trading Robux for cash!";

	/// <summary>
	/// Key: "GetLabelTradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public virtual string GetLabelTradingRobuxCash => "You're almost there! You almost qualify to trade your Robux for cash!";

	/// <summary>
	/// Key: "GetLabelVerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public virtual string GetLabelVerifiedEmailForCashout => "You must verify your email before you can cash out.";

	public DevExHomeResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"GetActionCancel",
				_GetTemplateForGetActionCancel()
			},
			{
				"GetActionCashOut",
				_GetTemplateForGetActionCashOut()
			},
			{
				"GetActionGetObc",
				_GetTemplateForGetActionGetObc()
			},
			{
				"GetActionUpgradeMembership",
				_GetTemplateForGetActionUpgradeMembership()
			},
			{
				"GetActionVerify",
				_GetTemplateForGetActionVerify()
			},
			{
				"GetActionVerifyEmail",
				_GetTemplateForGetActionVerifyEmail()
			},
			{
				"GetActionVerifyNow",
				_GetTemplateForGetActionVerifyNow()
			},
			{
				"GetActionVisitDevEx",
				_GetTemplateForGetActionVisitDevEx()
			},
			{
				"GetLabelAlmostReady",
				_GetTemplateForGetLabelAlmostReady()
			},
			{
				"GetLabelBuilderClubForCash",
				_GetTemplateForGetLabelBuilderClubForCash()
			},
			{
				"GetLabelBuildersCludForCashout",
				_GetTemplateForGetLabelBuildersCludForCashout()
			},
			{
				"GetLabelCurrentExchangeRate",
				_GetTemplateForGetLabelCurrentExchangeRate()
			},
			{
				"GetLabelNeedVerifiedEmail",
				_GetTemplateForGetLabelNeedVerifiedEmail()
			},
			{
				"GetLabelNotEligible",
				_GetTemplateForGetLabelNotEligible()
			},
			{
				"GetLabelNotEnoughRobuxForCashout",
				_GetTemplateForGetLabelNotEnoughRobuxForCashout()
			},
			{
				"GetLabelRobux",
				_GetTemplateForGetLabelRobux()
			},
			{
				"GetLabelTradingRobux",
				_GetTemplateForGetLabelTradingRobux()
			},
			{
				"GetLabelTradingRobuxCash",
				_GetTemplateForGetLabelTradingRobuxCash()
			},
			{
				"GetLabelVerifiedEmailForCashout",
				_GetTemplateForGetLabelVerifiedEmailForCashout()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.DevExHome";
	}

	protected virtual string _GetTemplateForGetActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForGetActionCashOut()
	{
		return "Cash Out";
	}

	protected virtual string _GetTemplateForGetActionGetObc()
	{
		return "Get OBC Now";
	}

	protected virtual string _GetTemplateForGetActionUpgradeMembership()
	{
		return "Upgrade Membership";
	}

	protected virtual string _GetTemplateForGetActionVerify()
	{
		return "Verify";
	}

	protected virtual string _GetTemplateForGetActionVerifyEmail()
	{
		return "Verify Email";
	}

	protected virtual string _GetTemplateForGetActionVerifyNow()
	{
		return "Verify Now";
	}

	protected virtual string _GetTemplateForGetActionVisitDevEx()
	{
		return "Visit DevEx";
	}

	protected virtual string _GetTemplateForGetLabelAlmostReady()
	{
		return "You're almost ready!";
	}

	protected virtual string _GetTemplateForGetLabelBuilderClubForCash()
	{
		return "You'll need Outrageous Builder's Club to exchange Robux for cash.";
	}

	protected virtual string _GetTemplateForGetLabelBuildersCludForCashout()
	{
		return "You need Outrageous Builders Club to Cash Out.";
	}

	protected virtual string _GetTemplateForGetLabelCurrentExchangeRate()
	{
		return "Current Exchange Rates";
	}

	protected virtual string _GetTemplateForGetLabelNeedVerifiedEmail()
	{
		return "You need a verified email address to use DevEx.";
	}

	protected virtual string _GetTemplateForGetLabelNotEligible()
	{
		return "You are not eligible currently.";
	}

	protected virtual string _GetTemplateForGetLabelNotEnoughRobuxForCashout()
	{
		return "You don't have enough Robux to Cash Out.";
	}

	protected virtual string _GetTemplateForGetLabelRobux()
	{
		return "Robux";
	}

	protected virtual string _GetTemplateForGetLabelTradingRobux()
	{
		return "You're on your way to trading Robux for cash!";
	}

	protected virtual string _GetTemplateForGetLabelTradingRobuxCash()
	{
		return "You're almost there! You almost qualify to trade your Robux for cash!";
	}

	protected virtual string _GetTemplateForGetLabelVerifiedEmailForCashout()
	{
		return "You must verify your email before you can cash out.";
	}
}
