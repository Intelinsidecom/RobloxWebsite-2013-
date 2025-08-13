using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class CreditCardExpiringModalResources_en_us : TranslationResourcesBase, ICreditCardExpiringModalResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.DontRemindAgain"
	/// link text
	/// English String: "Don't remind me again"
	/// </summary>
	public virtual string ActionDontRemindAgain => "Don't remind me again";

	/// <summary>
	/// Key: "Action.UpdateNow"
	/// button text
	/// English String: "Update Now"
	/// </summary>
	public virtual string ActionUpdateNow => "Update Now";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public virtual string DescriptionUpdateYourCreditCard => "Please update your credit card information to make sure your Builders Club membership doesn't expire!";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public virtual string HeadingCreditCardExpiration => "Credit Card Expiration";

	public CreditCardExpiringModalResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.DontRemindAgain",
				_GetTemplateForActionDontRemindAgain()
			},
			{
				"Action.UpdateNow",
				_GetTemplateForActionUpdateNow()
			},
			{
				"Description.CreditCardExpiration",
				_GetTemplateForDescriptionCreditCardExpiration()
			},
			{
				"Description.UpdateYourCreditCard",
				_GetTemplateForDescriptionUpdateYourCreditCard()
			},
			{
				"Heading.CreditCardExpiration",
				_GetTemplateForHeadingCreditCardExpiration()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.CreditCardExpiringModal";
	}

	protected virtual string _GetTemplateForActionDontRemindAgain()
	{
		return "Don't remind me again";
	}

	protected virtual string _GetTemplateForActionUpdateNow()
	{
		return "Update Now";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public virtual string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"Your Credit Card will expire on {expirationDate}!";
	}

	protected virtual string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "Your Credit Card will expire on {expirationDate}!";
	}

	protected virtual string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "Please update your credit card information to make sure your Builders Club membership doesn't expire!";
	}

	protected virtual string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "Credit Card Expiration";
	}
}
