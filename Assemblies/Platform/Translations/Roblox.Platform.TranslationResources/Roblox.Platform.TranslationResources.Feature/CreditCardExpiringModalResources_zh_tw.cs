using System;
using System.Collections.Generic;
namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CreditCardExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreditCardExpiringModalResources_zh_tw : CreditCardExpiringModalResources_en_us, ICreditCardExpiringModalResources, ITranslationResources
{

    public IReadOnlyDictionary<string, string> GetAllKeys()
    {
        return base.GetAllKeys();
    }

    public string GetFullContentNamespaceName()
    {
        return "Feature.CreditCardExpiringModal";
    }

	/// <summary>
	/// Key: "Action.DontRemindAgain"
	/// link text
	/// English String: "Don't remind me again"
	/// </summary>
	public override string ActionDontRemindAgain => "Ã¤Â¸ÂÃ¨Â¦ÂÃ¥â€ ÂÃ¦ÂÂÃ©â€ â€™Ã¦Ë†â€˜";

	/// <summary>
	/// Key: "Action.UpdateNow"
	/// button text
	/// English String: "Update Now"
	/// </summary>
	public override string ActionUpdateNow => "Ã§ÂÂ¾Ã¥Å“Â¨Ã¦â€ºÂ´Ã¦â€“Â°";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public override string DescriptionUpdateYourCreditCard => "Ã¨Â«â€¹Ã¦â€ºÂ´Ã¦â€“Â°Ã¦â€šÂ¨Ã§Å¡â€žÃ¤Â¿Â¡Ã§â€Â¨Ã¥ÂÂ¡Ã¨Â³â€¡Ã¦â€“â„¢Ã¯Â¼Å’Ã©ÂÂ¿Ã¥â€¦ÂÃ¦â€šÂ¨Ã§Å¡â€ž Builders Club Ã¦Å“Æ’Ã¥â€œÂ¡Ã¨Â³â€¡Ã¦Â Â¼Ã¥Ë†Â°Ã¦Å“Å¸Ã¯Â¼Â";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public override string HeadingCreditCardExpiration => "Ã¤Â¿Â¡Ã§â€Â¨Ã¥ÂÂ¡Ã¥Ë†Â°Ã¦Å“Å¸";

	public CreditCardExpiringModalResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDontRemindAgain()
	{
		return "Ã¤Â¸ÂÃ¨Â¦ÂÃ¥â€ ÂÃ¦ÂÂÃ©â€ â€™Ã¦Ë†â€˜";
	}

	protected override string _GetTemplateForActionUpdateNow()
	{
		return "Ã§ÂÂ¾Ã¥Å“Â¨Ã¦â€ºÂ´Ã¦â€“Â°";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public override string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"Ã¦â€šÂ¨Ã§Å¡â€žÃ¤Â¿Â¡Ã§â€Â¨Ã¥ÂÂ¡Ã¥Â°â€¡Ã¦â€“Â¼ {expirationDate} Ã¥Ë†Â°Ã¦Å“Å¸Ã¯Â¼Â";
	}

	protected override string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "Ã¦â€šÂ¨Ã§Å¡â€žÃ¤Â¿Â¡Ã§â€Â¨Ã¥ÂÂ¡Ã¥Â°â€¡Ã¦â€“Â¼ {expirationDate} Ã¥Ë†Â°Ã¦Å“Å¸Ã¯Â¼Â";
	}

	protected override string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "Ã¨Â«â€¹Ã¦â€ºÂ´Ã¦â€“Â°Ã¦â€šÂ¨Ã§Å¡â€žÃ¤Â¿Â¡Ã§â€Â¨Ã¥ÂÂ¡Ã¨Â³â€¡Ã¦â€“â„¢Ã¯Â¼Å’Ã©ÂÂ¿Ã¥â€¦ÂÃ¦â€šÂ¨Ã§Å¡â€ž Builders Club Ã¦Å“Æ’Ã¥â€œÂ¡Ã¨Â³â€¡Ã¦Â Â¼Ã¥Ë†Â°Ã¦Å“Å¸Ã¯Â¼Â";
	}

	protected override string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "Ã¤Â¿Â¡Ã§â€Â¨Ã¥ÂÂ¡Ã¥Ë†Â°Ã¦Å“Å¸";
	}
}


}

