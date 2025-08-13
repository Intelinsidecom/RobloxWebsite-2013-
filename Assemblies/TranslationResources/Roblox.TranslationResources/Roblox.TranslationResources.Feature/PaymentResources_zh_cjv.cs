namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PaymentResources_zh_cjv : PaymentResources_en_us, IPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Message.FraudBlockedPaymentCheckInfoErrorMessage"
	/// English String: "Unfortunately we are unable to process your payment. Please confirm the billing information entered matches the card provided and try again. If this fails, please try another card or different payment method.\t"
	/// </summary>
	public override string MessageFraudBlockedPaymentCheckInfoErrorMessage => "很抱歉，我们无法处理您的付款。请确认输入的帐单信息与所提供的信用卡匹配。如果此操作失败，请尝试其他信用卡或付款方式。";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public override string MessageFraudWarningForUnder13WithCreditCard => "在使用父母的信用卡之前，请先征得他们的同意；我们可能会向信用卡持有人确认交易记录。如果持有人没有批准交易，我们将删除你的帐户。";

	public PaymentResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "很抱歉，我们无法处理您的付款。请确认输入的帐单信息与所提供的信用卡匹配。如果此操作失败，请尝试其他信用卡或付款方式。";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public override string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"因检测到可疑活动，你的付款已被拒。如果你认为此信息有误，请前往 {linkStart}roblox.com/support{linkEnd} 与我们联系。";
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "因检测到可疑活动，你的付款已被拒。如果你认为此信息有误，请前往 {linkStart}roblox.com/support{linkEnd} 与我们联系。";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public override string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"在使用父母的信用卡之前，请先征得他们的同意；我们可能会向信用卡持有人确认交易记录。{lineStart}如果持有人没有批准交易，我们将删除你的帐户。{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "在使用父母的信用卡之前，请先征得他们的同意；我们可能会向信用卡持有人确认交易记录。{lineStart}如果持有人没有批准交易，我们将删除你的帐户。{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "在使用父母的信用卡之前，请先征得他们的同意；我们可能会向信用卡持有人确认交易记录。如果持有人没有批准交易，我们将删除你的帐户。";
	}
}
