namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PaymentResources_ko_kr : PaymentResources_en_us, IPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Message.FraudBlockedPaymentCheckInfoErrorMessage"
	/// English String: "Unfortunately we are unable to process your payment. Please confirm the billing information entered matches the card provided and try again. If this fails, please try another card or different payment method.\t"
	/// </summary>
	public override string MessageFraudBlockedPaymentCheckInfoErrorMessage => "유감스럽게도 결제를 진행할 수 없습니다. 청구 내역과 카드 정보가 일치하는지 확인 후 다시 시도하세요. 문제가 계속되면 다른 카드 혹은 결제수단을 이용하세요.";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public override string MessageFraudWarningForUnder13WithCreditCard => "신용카드를 사용하기 전에 부모님의 허락을 받으세요. 카드 명의자에게 연락하여 허용 여부를 확인할 수 있으며, 허락받지 않은 카드를 사용할 경우 계정이 삭제됩니다.";

	public PaymentResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "유감스럽게도 결제를 진행할 수 없습니다. 청구 내역과 카드 정보가 일치하는지 확인 후 다시 시도하세요. 문제가 계속되면 다른 카드 혹은 결제수단을 이용하세요.";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public override string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"의심스러운 활동으로 인해 청구가 차단되었습니다. 오류라고 생각하는 경우 {linkStart}roblox.com/support{linkEnd}로 문의하세요.";
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "의심스러운 활동으로 인해 청구가 차단되었습니다. 오류라고 생각하는 경우 {linkStart}roblox.com/support{linkEnd}로 문의하세요.";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public override string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"신용카드를 사용하기 전에 부모님의 허락을 받으세요. 카드 명의자에게 연락하여 허용 여부를 확인할 수 있으며,{lineStart}허락받지 않은 카드를 사용할 경우 계정이 삭제됩니다.{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "신용카드를 사용하기 전에 부모님의 허락을 받으세요. 카드 명의자에게 연락하여 허용 여부를 확인할 수 있으며,{lineStart}허락받지 않은 카드를 사용할 경우 계정이 삭제됩니다.{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "신용카드를 사용하기 전에 부모님의 허락을 받으세요. 카드 명의자에게 연락하여 허용 여부를 확인할 수 있으며, 허락받지 않은 카드를 사용할 경우 계정이 삭제됩니다.";
	}
}
