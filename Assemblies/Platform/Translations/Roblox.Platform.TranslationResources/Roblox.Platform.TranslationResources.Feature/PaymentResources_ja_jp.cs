namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PaymentResources_ja_jp : PaymentResources_en_us, IPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Message.FraudBlockedPaymentCheckInfoErrorMessage"
	/// English String: "Unfortunately we are unable to process your payment. Please confirm the billing information entered matches the card provided and try again. If this fails, please try another card or different payment method.\t"
	/// </summary>
	public override string MessageFraudBlockedPaymentCheckInfoErrorMessage => "申し訳ありませんが、お支払いを処理することができません。入力した請求先情報が登録したカードと一致することを確認してやり直してください。それでもうまくいかない場合、別のカード、もしくは他の支払い方法を試してください。\t";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public override string MessageFraudWarningForUnder13WithCreditCard => "クレジットカードを使用する前に、保護者の方の許可を取ってください。確認のため、カードの所有者の方に連絡する場合があります。許可なくカードを使用した場合、アカウントが削除されることがあります。";

	public PaymentResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "申し訳ありませんが、お支払いを処理することができません。入力した請求先情報が登録したカードと一致することを確認してやり直してください。それでもうまくいかない場合、別のカード、もしくは他の支払い方法を試してください。\t";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public override string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"不審なアクティビティのため課金がブロックされました。このエラーについては{linkStart}roblox.com/support{linkEnd}で対応いたします。";
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "不審なアクティビティのため課金がブロックされました。このエラーについては{linkStart}roblox.com/support{linkEnd}で対応いたします。";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public override string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"クレジットカードを使用する前に、保護者の方の許可を取ってください。確認のため、カードの所有者の方に連絡する場合があります。{lineStart}許可なくカードを使用した場合、アカウントが削除されることがあります。{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "クレジットカードを使用する前に、保護者の方の許可を取ってください。確認のため、カードの所有者の方に連絡する場合があります。{lineStart}許可なくカードを使用した場合、アカウントが削除されることがあります。{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "クレジットカードを使用する前に、保護者の方の許可を取ってください。確認のため、カードの所有者の方に連絡する場合があります。許可なくカードを使用した場合、アカウントが削除されることがあります。";
	}
}
