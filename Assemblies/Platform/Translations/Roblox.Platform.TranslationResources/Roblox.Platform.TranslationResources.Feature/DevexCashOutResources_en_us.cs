using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class DevexCashOutResources_en_us : TranslationResourcesBase, IDevexCashOutResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "CashOutForm.CashOutSubmit"
	/// English String: "Cash Out"
	/// </summary>
	public virtual string CashOutFormCashOutSubmit => "Cash Out";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public virtual string CashOutFormEmailAddressLabel => "Email Address";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public virtual string CashOutFormExchangeRateLabel => "Exchange Rate";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public virtual string CashOutFormFirstNameLabel => "First Name";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public virtual string CashOutFormLastNameLabel => "Last Name";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public virtual string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public virtual string CashOutFormRobuxAmountLabel => "Robux Amount";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public virtual string CashOutFormYouGetLabel => "You get up to:";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public virtual string LabelPasswordLabel => "Password";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public virtual string LabelPasswordPlaceholder => "Verify Account Password";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public virtual string PageHeaderDescription => "Create games, earn money.";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public virtual string PageHeaderTitle => "Developer Exchange";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public virtual string ResponseCannotLoadExchangeRate => "Sorry, we were unable to load the current exchange rate. Please try again.";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public virtual string ResponseCurrencyOperationUnavailable => "Sorry, something went wrong. Please try again.";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public virtual string ResponseFirstNameRequiredErrorMessage => "Please enter your first name.";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public virtual string ResponseIncorrectCredentials => "Invalid password.";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public virtual string ResponseInsufficientFunds => "You do not have enough Robux to complete this transaction.";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public virtual string ResponseInvalidEmailErrorMessage => "Please enter a valid email address.";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public virtual string ResponseLastNameRequiredErrorMessage => "Please enter your last name.";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public virtual string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "Robux amount below minimum cash out threshold.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public virtual string ResponseUnknownError => "Sorry, something went wrong. Please try again.";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public virtual string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "You cannot cash out for less than the minimum amount.";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public virtual string ResponseUserCannotCashout => "Sorry, you are not eligible to cash out at this time.";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public virtual string ResponseUserDoesNotHavePremium => "You need a Roblox Premium subscription to cash out.";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public virtual string ResponseUserDoesNotHaveVerifiedEmail => "You need a verified email address to cash out.";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public virtual string ResponseUserMustProvideFirstAndLastName => "You need to provide your first and last name.";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public virtual string ResponseUserNotEligibleError => "Sorry, you are not eligible to cash out at this time.";

	public DevexCashOutResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"CashOutForm.CashOutSubmit",
				_GetTemplateForCashOutFormCashOutSubmit()
			},
			{
				"CashOutForm.Description",
				_GetTemplateForCashOutFormDescription()
			},
			{
				"CashOutForm.EmailAddressLabel",
				_GetTemplateForCashOutFormEmailAddressLabel()
			},
			{
				"CashOutForm.ExchangeRateLabel",
				_GetTemplateForCashOutFormExchangeRateLabel()
			},
			{
				"CashOutForm.FirstNameLabel",
				_GetTemplateForCashOutFormFirstNameLabel()
			},
			{
				"CashOutForm.LastNameLabel",
				_GetTemplateForCashOutFormLastNameLabel()
			},
			{
				"CashOutForm.Robux",
				_GetTemplateForCashOutFormRobux()
			},
			{
				"CashOutForm.RobuxAmountLabel",
				_GetTemplateForCashOutFormRobuxAmountLabel()
			},
			{
				"CashOutForm.TermsOfService",
				_GetTemplateForCashOutFormTermsOfService()
			},
			{
				"CashOutForm.YouGetLabel",
				_GetTemplateForCashOutFormYouGetLabel()
			},
			{
				"Label.PasswordLabel",
				_GetTemplateForLabelPasswordLabel()
			},
			{
				"Label.PasswordPlaceholder",
				_GetTemplateForLabelPasswordPlaceholder()
			},
			{
				"PageHeader.Description",
				_GetTemplateForPageHeaderDescription()
			},
			{
				"PageHeader.Title",
				_GetTemplateForPageHeaderTitle()
			},
			{
				"Response.CannotLoadExchangeRate",
				_GetTemplateForResponseCannotLoadExchangeRate()
			},
			{
				"Response.CurrencyOperationUnavailable",
				_GetTemplateForResponseCurrencyOperationUnavailable()
			},
			{
				"Response.FirstNameRequiredErrorMessage",
				_GetTemplateForResponseFirstNameRequiredErrorMessage()
			},
			{
				"Response.IncorrectCredentials",
				_GetTemplateForResponseIncorrectCredentials()
			},
			{
				"Response.InsufficientFunds",
				_GetTemplateForResponseInsufficientFunds()
			},
			{
				"Response.InvalidEmailErrorMessage",
				_GetTemplateForResponseInvalidEmailErrorMessage()
			},
			{
				"Response.LastNameRequiredErrorMessage",
				_GetTemplateForResponseLastNameRequiredErrorMessage()
			},
			{
				"Response.RobuxAmountIsBelowMinimumCashoutThreshold",
				_GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
			},
			{
				"Response.UnknownError",
				_GetTemplateForResponseUnknownError()
			},
			{
				"Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout",
				_GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
			},
			{
				"Response.UserCannotCashout",
				_GetTemplateForResponseUserCannotCashout()
			},
			{
				"Response.UserDoesNotHavePremium",
				_GetTemplateForResponseUserDoesNotHavePremium()
			},
			{
				"Response.UserDoesNotHaveVerifiedEmail",
				_GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
			},
			{
				"Response.UserMustProvideFirstAndLastName",
				_GetTemplateForResponseUserMustProvideFirstAndLastName()
			},
			{
				"Response.UserNotEligibleError",
				_GetTemplateForResponseUserNotEligibleError()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.DevexCashOut";
	}

	protected virtual string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "Cash Out";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public virtual string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}";
	}

	protected virtual string _GetTemplateForCashOutFormDescription()
	{
		return "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}";
	}

	protected virtual string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "Email Address";
	}

	protected virtual string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "Exchange Rate";
	}

	protected virtual string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "First Name";
	}

	protected virtual string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "Last Name";
	}

	protected virtual string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected virtual string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Robux Amount";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public virtual string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"I have read and agree to the {linkStart}Terms of Use{linkEnd}";
	}

	protected virtual string _GetTemplateForCashOutFormTermsOfService()
	{
		return "I have read and agree to the {linkStart}Terms of Use{linkEnd}";
	}

	protected virtual string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "You get up to:";
	}

	protected virtual string _GetTemplateForLabelPasswordLabel()
	{
		return "Password";
	}

	protected virtual string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "Verify Account Password";
	}

	protected virtual string _GetTemplateForPageHeaderDescription()
	{
		return "Create games, earn money.";
	}

	protected virtual string _GetTemplateForPageHeaderTitle()
	{
		return "Developer Exchange";
	}

	protected virtual string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "Sorry, we were unable to load the current exchange rate. Please try again.";
	}

	protected virtual string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "Sorry, something went wrong. Please try again.";
	}

	protected virtual string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "Please enter your first name.";
	}

	protected virtual string _GetTemplateForResponseIncorrectCredentials()
	{
		return "Invalid password.";
	}

	protected virtual string _GetTemplateForResponseInsufficientFunds()
	{
		return "You do not have enough Robux to complete this transaction.";
	}

	protected virtual string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "Please enter a valid email address.";
	}

	protected virtual string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "Please enter your last name.";
	}

	protected virtual string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "Robux amount below minimum cash out threshold.";
	}

	protected virtual string _GetTemplateForResponseUnknownError()
	{
		return "Sorry, something went wrong. Please try again.";
	}

	protected virtual string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "You cannot cash out for less than the minimum amount.";
	}

	protected virtual string _GetTemplateForResponseUserCannotCashout()
	{
		return "Sorry, you are not eligible to cash out at this time.";
	}

	protected virtual string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "You need a Roblox Premium subscription to cash out.";
	}

	protected virtual string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "You need a verified email address to cash out.";
	}

	protected virtual string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "You need to provide your first and last name.";
	}

	protected virtual string _GetTemplateForResponseUserNotEligibleError()
	{
		return "Sorry, you are not eligible to cash out at this time.";
	}
}
