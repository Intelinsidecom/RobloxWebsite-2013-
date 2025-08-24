namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PaymentResources_zh_tw : PaymentResources_en_us, IPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Message.FraudBlockedPaymentCheckInfoErrorMessage"
	/// English String: "Unfortunately we are unable to process your payment. Please confirm the billing information entered matches the card provided and try again. If this fails, please try another card or different payment method.\t"
	/// </summary>
	public override string MessageFraudBlockedPaymentCheckInfoErrorMessage => "我們無法處理您的付款，請確認付款資訊和所提供的信用卡相符重新嘗試。若依然失敗，請嘗試其它信用卡或付款方式。";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public override string MessageFraudWarningForUnder13WithCreditCard => "在使用父母的信用卡之前，請先獲得他們的同意；我們可能會向信用卡持有人確認此筆交易。如果持有人沒有核准此筆交易，我們將會刪除您的帳號。";

	public PaymentResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "我們無法處理您的付款，請確認付款資訊和所提供的信用卡相符重新嘗試。若依然失敗，請嘗試其它信用卡或付款方式。";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public override string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"您的付款由於可疑行為遭到拒絕。若您認為有誤，請前往 {linkStart}roblox.com/support{linkEnd} 聯絡我們。";
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "您的付款由於可疑行為遭到拒絕。若您認為有誤，請前往 {linkStart}roblox.com/support{linkEnd} 聯絡我們。";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public override string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"在使用父母的信用卡之前，請先獲得他們的同意；我們可能會向信用卡持有人確認此筆交易。{lineStart}如果持有人沒有核准此筆交易，我們將會刪除您的帳號。{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "在使用父母的信用卡之前，請先獲得他們的同意；我們可能會向信用卡持有人確認此筆交易。{lineStart}如果持有人沒有核准此筆交易，我們將會刪除您的帳號。{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "在使用父母的信用卡之前，請先獲得他們的同意；我們可能會向信用卡持有人確認此筆交易。如果持有人沒有核准此筆交易，我們將會刪除您的帳號。";
	}
}
