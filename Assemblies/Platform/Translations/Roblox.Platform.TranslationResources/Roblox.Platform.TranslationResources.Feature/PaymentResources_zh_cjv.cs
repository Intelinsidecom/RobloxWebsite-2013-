namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string MessageFraudBlockedPaymentCheckInfoErrorMessage => "å¾ˆæŠ±æ­‰ï¼Œæˆ‘ä»¬æ— æ³•å¤„ç†æ‚¨çš„ä»˜æ¬¾ã€‚è¯·ç¡®è®¤è¾“å…¥çš„å¸å•ä¿¡æ¯ä¸Žæ‰€æä¾›çš„ä¿¡ç”¨å¡åŒ¹é…ã€‚å¦‚æžœæ­¤æ“ä½œå¤±è´¥ï¼Œè¯·å°è¯•å…¶ä»–ä¿¡ç”¨å¡æˆ–ä»˜æ¬¾æ–¹å¼ã€‚";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public override string MessageFraudWarningForUnder13WithCreditCard => "åœ¨ä½¿ç”¨çˆ¶æ¯çš„ä¿¡ç”¨å¡ä¹‹å‰ï¼Œè¯·å…ˆå¾å¾—ä»–ä»¬çš„åŒæ„ï¼›æˆ‘ä»¬å¯èƒ½ä¼šå‘ä¿¡ç”¨å¡æŒæœ‰äººç¡®è®¤äº¤æ˜“è®°å½•ã€‚å¦‚æžœæŒæœ‰äººæ²¡æœ‰æ‰¹å‡†äº¤æ˜“ï¼Œæˆ‘ä»¬å°†åˆ é™¤ä½ çš„å¸æˆ·ã€‚";

	public PaymentResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "å¾ˆæŠ±æ­‰ï¼Œæˆ‘ä»¬æ— æ³•å¤„ç†æ‚¨çš„ä»˜æ¬¾ã€‚è¯·ç¡®è®¤è¾“å…¥çš„å¸å•ä¿¡æ¯ä¸Žæ‰€æä¾›çš„ä¿¡ç”¨å¡åŒ¹é…ã€‚å¦‚æžœæ­¤æ“ä½œå¤±è´¥ï¼Œè¯·å°è¯•å…¶ä»–ä¿¡ç”¨å¡æˆ–ä»˜æ¬¾æ–¹å¼ã€‚";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public override string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"å› æ£€æµ‹åˆ°å¯ç–‘æ´»åŠ¨ï¼Œä½ çš„ä»˜æ¬¾å·²è¢«æ‹’ã€‚å¦‚æžœä½ è®¤ä¸ºæ­¤ä¿¡æ¯æœ‰è¯¯ï¼Œè¯·å‰å¾€ {linkStart}roblox.com/support{linkEnd} ä¸Žæˆ‘ä»¬è”ç³»ã€‚";
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "å› æ£€æµ‹åˆ°å¯ç–‘æ´»åŠ¨ï¼Œä½ çš„ä»˜æ¬¾å·²è¢«æ‹’ã€‚å¦‚æžœä½ è®¤ä¸ºæ­¤ä¿¡æ¯æœ‰è¯¯ï¼Œè¯·å‰å¾€ {linkStart}roblox.com/support{linkEnd} ä¸Žæˆ‘ä»¬è”ç³»ã€‚";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public override string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"åœ¨ä½¿ç”¨çˆ¶æ¯çš„ä¿¡ç”¨å¡ä¹‹å‰ï¼Œè¯·å…ˆå¾å¾—ä»–ä»¬çš„åŒæ„ï¼›æˆ‘ä»¬å¯èƒ½ä¼šå‘ä¿¡ç”¨å¡æŒæœ‰äººç¡®è®¤äº¤æ˜“è®°å½•ã€‚{lineStart}å¦‚æžœæŒæœ‰äººæ²¡æœ‰æ‰¹å‡†äº¤æ˜“ï¼Œæˆ‘ä»¬å°†åˆ é™¤ä½ çš„å¸æˆ·ã€‚{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "åœ¨ä½¿ç”¨çˆ¶æ¯çš„ä¿¡ç”¨å¡ä¹‹å‰ï¼Œè¯·å…ˆå¾å¾—ä»–ä»¬çš„åŒæ„ï¼›æˆ‘ä»¬å¯èƒ½ä¼šå‘ä¿¡ç”¨å¡æŒæœ‰äººç¡®è®¤äº¤æ˜“è®°å½•ã€‚{lineStart}å¦‚æžœæŒæœ‰äººæ²¡æœ‰æ‰¹å‡†äº¤æ˜“ï¼Œæˆ‘ä»¬å°†åˆ é™¤ä½ çš„å¸æˆ·ã€‚{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "åœ¨ä½¿ç”¨çˆ¶æ¯çš„ä¿¡ç”¨å¡ä¹‹å‰ï¼Œè¯·å…ˆå¾å¾—ä»–ä»¬çš„åŒæ„ï¼›æˆ‘ä»¬å¯èƒ½ä¼šå‘ä¿¡ç”¨å¡æŒæœ‰äººç¡®è®¤äº¤æ˜“è®°å½•ã€‚å¦‚æžœæŒæœ‰äººæ²¡æœ‰æ‰¹å‡†äº¤æ˜“ï¼Œæˆ‘ä»¬å°†åˆ é™¤ä½ çš„å¸æˆ·ã€‚";
	}
}


}
