using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class PaymentResources_en_us : TranslationResourcesBase, IPaymentResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentCheckInfoErrorMessage"
	/// English String: "Unfortunately we are unable to process your payment. Please confirm the billing information entered matches the card provided and try again. If this fails, please try another card or different payment method.\t"
	/// </summary>
	public virtual string MessageFraudBlockedPaymentCheckInfoErrorMessage => "Unfortunately we are unable to process your payment. Please confirm the billing information entered matches the card provided and try again. If this fails, please try another card or different payment method.\t";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public virtual string MessageFraudWarningForUnder13WithCreditCard => "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted.";

	public PaymentResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Message.FraudBlockedPaymentCheckInfoErrorMessage",
				_GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
			},
			{
				"Message.FraudBlockedPaymentErrorMessage",
				_GetTemplateForMessageFraudBlockedPaymentErrorMessage()
			},
			{
				"Message.FraudForUnder13UsingCreditCard",
				_GetTemplateForMessageFraudForUnder13UsingCreditCard()
			},
			{
				"Message.FraudWarningForUnder13WithCreditCard",
				_GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.Payment";
	}

	protected virtual string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "Unfortunately we are unable to process your payment. Please confirm the billing information entered matches the card provided and try again. If this fails, please try another card or different payment method.\t";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public virtual string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}.";
	}

	protected virtual string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}.";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public virtual string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}";
	}

	protected virtual string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}";
	}

	protected virtual string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted.";
	}
}
