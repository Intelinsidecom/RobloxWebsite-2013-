namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CreditCardExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreditCardExpiringModalResources_ja_jp : CreditCardExpiringModalResources_en_us, ICreditCardExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.DontRemindAgain"
	/// link text
	/// English String: "Don't remind me again"
	/// </summary>
	public override string ActionDontRemindAgain => "次から通知を受け取らない";

	/// <summary>
	/// Key: "Action.UpdateNow"
	/// button text
	/// English String: "Update Now"
	/// </summary>
	public override string ActionUpdateNow => "今すぐ更新";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public override string DescriptionUpdateYourCreditCard => "Builders Clubメンバーシップの期限が切れないようにクレジットカード情報を更新してください！";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public override string HeadingCreditCardExpiration => "クレジットカードの有効期限";

	public CreditCardExpiringModalResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDontRemindAgain()
	{
		return "次から通知を受け取らない";
	}

	protected override string _GetTemplateForActionUpdateNow()
	{
		return "今すぐ更新";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public override string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"クレジットカードの有効期限は {expirationDate} です！";
	}

	protected override string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "クレジットカードの有効期限は {expirationDate} です！";
	}

	protected override string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "Builders Clubメンバーシップの期限が切れないようにクレジットカード情報を更新してください！";
	}

	protected override string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "クレジットカードの有効期限";
	}
}
