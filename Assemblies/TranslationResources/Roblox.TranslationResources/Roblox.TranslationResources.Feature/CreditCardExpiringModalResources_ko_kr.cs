namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CreditCardExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreditCardExpiringModalResources_ko_kr : CreditCardExpiringModalResources_en_us, ICreditCardExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.DontRemindAgain"
	/// link text
	/// English String: "Don't remind me again"
	/// </summary>
	public override string ActionDontRemindAgain => "다시 알려주지 마세요";

	/// <summary>
	/// Key: "Action.UpdateNow"
	/// button text
	/// English String: "Update Now"
	/// </summary>
	public override string ActionUpdateNow => "지금 업데이트";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public override string DescriptionUpdateYourCreditCard => "Builders Club 멤버십이 만료되지 않도록 신용카드 정보를 업데이트하세요!";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public override string HeadingCreditCardExpiration => "신용카드 유효기간";

	public CreditCardExpiringModalResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDontRemindAgain()
	{
		return "다시 알려주지 마세요";
	}

	protected override string _GetTemplateForActionUpdateNow()
	{
		return "지금 업데이트";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public override string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"신용카드 유효기간이 {expirationDate}에 만료됩니다!";
	}

	protected override string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "신용카드 유효기간이 {expirationDate}에 만료됩니다!";
	}

	protected override string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "Builders Club 멤버십이 만료되지 않도록 신용카드 정보를 업데이트하세요!";
	}

	protected override string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "신용카드 유효기간";
	}
}
