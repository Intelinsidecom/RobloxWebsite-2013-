namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string MessageFraudBlockedPaymentCheckInfoErrorMessage => "æˆ‘å€‘ç„¡æ³•è™•ç†æ‚¨çš„ä»˜æ¬¾ï¼Œè«‹ç¢ºèªä»˜æ¬¾è³‡è¨Šå’Œæ‰€æä¾›çš„ä¿¡ç”¨å¡ç›¸ç¬¦é‡æ–°å˜—è©¦ã€‚è‹¥ä¾ç„¶å¤±æ•—ï¼Œè«‹å˜—è©¦å…¶å®ƒä¿¡ç”¨å¡æˆ–ä»˜æ¬¾æ–¹å¼ã€‚";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public override string MessageFraudWarningForUnder13WithCreditCard => "åœ¨ä½¿ç”¨çˆ¶æ¯çš„ä¿¡ç”¨å¡ä¹‹å‰ï¼Œè«‹å…ˆç²å¾—ä»–å€‘çš„åŒæ„ï¼›æˆ‘å€‘å¯èƒ½æœƒå‘ä¿¡ç”¨å¡æŒæœ‰äººç¢ºèªæ­¤ç­†äº¤æ˜“ã€‚å¦‚æžœæŒæœ‰äººæ²’æœ‰æ ¸å‡†æ­¤ç­†äº¤æ˜“ï¼Œæˆ‘å€‘å°‡æœƒåˆªé™¤æ‚¨çš„å¸³è™Ÿã€‚";

	public PaymentResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "æˆ‘å€‘ç„¡æ³•è™•ç†æ‚¨çš„ä»˜æ¬¾ï¼Œè«‹ç¢ºèªä»˜æ¬¾è³‡è¨Šå’Œæ‰€æä¾›çš„ä¿¡ç”¨å¡ç›¸ç¬¦é‡æ–°å˜—è©¦ã€‚è‹¥ä¾ç„¶å¤±æ•—ï¼Œè«‹å˜—è©¦å…¶å®ƒä¿¡ç”¨å¡æˆ–ä»˜æ¬¾æ–¹å¼ã€‚";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public override string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"æ‚¨çš„ä»˜æ¬¾ç”±æ–¼å¯ç–‘è¡Œç‚ºé­åˆ°æ‹’çµ•ã€‚è‹¥æ‚¨èªç‚ºæœ‰èª¤ï¼Œè«‹å‰å¾€ {linkStart}roblox.com/support{linkEnd} è¯çµ¡æˆ‘å€‘ã€‚";
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "æ‚¨çš„ä»˜æ¬¾ç”±æ–¼å¯ç–‘è¡Œç‚ºé­åˆ°æ‹’çµ•ã€‚è‹¥æ‚¨èªç‚ºæœ‰èª¤ï¼Œè«‹å‰å¾€ {linkStart}roblox.com/support{linkEnd} è¯çµ¡æˆ‘å€‘ã€‚";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public override string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"åœ¨ä½¿ç”¨çˆ¶æ¯çš„ä¿¡ç”¨å¡ä¹‹å‰ï¼Œè«‹å…ˆç²å¾—ä»–å€‘çš„åŒæ„ï¼›æˆ‘å€‘å¯èƒ½æœƒå‘ä¿¡ç”¨å¡æŒæœ‰äººç¢ºèªæ­¤ç­†äº¤æ˜“ã€‚{lineStart}å¦‚æžœæŒæœ‰äººæ²’æœ‰æ ¸å‡†æ­¤ç­†äº¤æ˜“ï¼Œæˆ‘å€‘å°‡æœƒåˆªé™¤æ‚¨çš„å¸³è™Ÿã€‚{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "åœ¨ä½¿ç”¨çˆ¶æ¯çš„ä¿¡ç”¨å¡ä¹‹å‰ï¼Œè«‹å…ˆç²å¾—ä»–å€‘çš„åŒæ„ï¼›æˆ‘å€‘å¯èƒ½æœƒå‘ä¿¡ç”¨å¡æŒæœ‰äººç¢ºèªæ­¤ç­†äº¤æ˜“ã€‚{lineStart}å¦‚æžœæŒæœ‰äººæ²’æœ‰æ ¸å‡†æ­¤ç­†äº¤æ˜“ï¼Œæˆ‘å€‘å°‡æœƒåˆªé™¤æ‚¨çš„å¸³è™Ÿã€‚{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "åœ¨ä½¿ç”¨çˆ¶æ¯çš„ä¿¡ç”¨å¡ä¹‹å‰ï¼Œè«‹å…ˆç²å¾—ä»–å€‘çš„åŒæ„ï¼›æˆ‘å€‘å¯èƒ½æœƒå‘ä¿¡ç”¨å¡æŒæœ‰äººç¢ºèªæ­¤ç­†äº¤æ˜“ã€‚å¦‚æžœæŒæœ‰äººæ²’æœ‰æ ¸å‡†æ­¤ç­†äº¤æ˜“ï¼Œæˆ‘å€‘å°‡æœƒåˆªé™¤æ‚¨çš„å¸³è™Ÿã€‚";
	}
}


}
