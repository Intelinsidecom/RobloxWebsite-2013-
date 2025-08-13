namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CreditCardExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreditCardExpiringModalResources_zh_tw : CreditCardExpiringModalResources_en_us, ICreditCardExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.DontRemindAgain"
	/// link text
	/// English String: "Don't remind me again"
	/// </summary>
	public override string ActionDontRemindAgain => "不要再提醒我";

	/// <summary>
	/// Key: "Action.UpdateNow"
	/// button text
	/// English String: "Update Now"
	/// </summary>
	public override string ActionUpdateNow => "現在更新";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public override string DescriptionUpdateYourCreditCard => "請更新您的信用卡資料，避免您的 Builders Club 會員資格到期！";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public override string HeadingCreditCardExpiration => "信用卡到期";

	public CreditCardExpiringModalResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDontRemindAgain()
	{
		return "不要再提醒我";
	}

	protected override string _GetTemplateForActionUpdateNow()
	{
		return "現在更新";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public override string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"您的信用卡將於 {expirationDate} 到期！";
	}

	protected override string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "您的信用卡將於 {expirationDate} 到期！";
	}

	protected override string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "請更新您的信用卡資料，避免您的 Builders Club 會員資格到期！";
	}

	protected override string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "信用卡到期";
	}
}
