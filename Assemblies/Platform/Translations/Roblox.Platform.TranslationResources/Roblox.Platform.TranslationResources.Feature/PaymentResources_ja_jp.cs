namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string MessageFraudBlockedPaymentCheckInfoErrorMessage => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ãŠæ”¯æ‰•ã„ã‚’å‡¦ç†ã™ã‚‹ã“ã¨ãŒã§ãã¾ã›ã‚“ã€‚å…¥åŠ›ã—ãŸè«‹æ±‚å…ˆæƒ…å ±ãŒç™»éŒ²ã—ãŸã‚«ãƒ¼ãƒ‰ã¨ä¸€è‡´ã™ã‚‹ã“ã¨ã‚’ç¢ºèªã—ã¦ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚ãã‚Œã§ã‚‚ã†ã¾ãã„ã‹ãªã„å ´åˆã€åˆ¥ã®ã‚«ãƒ¼ãƒ‰ã€ã‚‚ã—ãã¯ä»–ã®æ”¯æ‰•ã„æ–¹æ³•ã‚’è©¦ã—ã¦ãã ã•ã„ã€‚\t";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public override string MessageFraudWarningForUnder13WithCreditCard => "ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚«ãƒ¼ãƒ‰ã‚’ä½¿ç”¨ã™ã‚‹å‰ã«ã€ä¿è­·è€…ã®æ–¹ã®è¨±å¯ã‚’å–ã£ã¦ãã ã•ã„ã€‚ç¢ºèªã®ãŸã‚ã€ã‚«ãƒ¼ãƒ‰ã®æ‰€æœ‰è€…ã®æ–¹ã«é€£çµ¡ã™ã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚è¨±å¯ãªãã‚«ãƒ¼ãƒ‰ã‚’ä½¿ç”¨ã—ãŸå ´åˆã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒå‰Šé™¤ã•ã‚Œã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚";

	public PaymentResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ãŒã€ãŠæ”¯æ‰•ã„ã‚’å‡¦ç†ã™ã‚‹ã“ã¨ãŒã§ãã¾ã›ã‚“ã€‚å…¥åŠ›ã—ãŸè«‹æ±‚å…ˆæƒ…å ±ãŒç™»éŒ²ã—ãŸã‚«ãƒ¼ãƒ‰ã¨ä¸€è‡´ã™ã‚‹ã“ã¨ã‚’ç¢ºèªã—ã¦ã‚„ã‚Šç›´ã—ã¦ãã ã•ã„ã€‚ãã‚Œã§ã‚‚ã†ã¾ãã„ã‹ãªã„å ´åˆã€åˆ¥ã®ã‚«ãƒ¼ãƒ‰ã€ã‚‚ã—ãã¯ä»–ã®æ”¯æ‰•ã„æ–¹æ³•ã‚’è©¦ã—ã¦ãã ã•ã„ã€‚\t";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public override string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"ä¸å¯©ãªã‚¢ã‚¯ãƒ†ã‚£ãƒ“ãƒ†ã‚£ã®ãŸã‚èª²é‡‘ãŒãƒ–ãƒ­ãƒƒã‚¯ã•ã‚Œã¾ã—ãŸã€‚ã“ã®ã‚¨ãƒ©ãƒ¼ã«ã¤ã„ã¦ã¯{linkStart}roblox.com/support{linkEnd}ã§å¯¾å¿œã„ãŸã—ã¾ã™ã€‚";
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "ä¸å¯©ãªã‚¢ã‚¯ãƒ†ã‚£ãƒ“ãƒ†ã‚£ã®ãŸã‚èª²é‡‘ãŒãƒ–ãƒ­ãƒƒã‚¯ã•ã‚Œã¾ã—ãŸã€‚ã“ã®ã‚¨ãƒ©ãƒ¼ã«ã¤ã„ã¦ã¯{linkStart}roblox.com/support{linkEnd}ã§å¯¾å¿œã„ãŸã—ã¾ã™ã€‚";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public override string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚«ãƒ¼ãƒ‰ã‚’ä½¿ç”¨ã™ã‚‹å‰ã«ã€ä¿è­·è€…ã®æ–¹ã®è¨±å¯ã‚’å–ã£ã¦ãã ã•ã„ã€‚ç¢ºèªã®ãŸã‚ã€ã‚«ãƒ¼ãƒ‰ã®æ‰€æœ‰è€…ã®æ–¹ã«é€£çµ¡ã™ã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚{lineStart}è¨±å¯ãªãã‚«ãƒ¼ãƒ‰ã‚’ä½¿ç”¨ã—ãŸå ´åˆã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒå‰Šé™¤ã•ã‚Œã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚«ãƒ¼ãƒ‰ã‚’ä½¿ç”¨ã™ã‚‹å‰ã«ã€ä¿è­·è€…ã®æ–¹ã®è¨±å¯ã‚’å–ã£ã¦ãã ã•ã„ã€‚ç¢ºèªã®ãŸã‚ã€ã‚«ãƒ¼ãƒ‰ã®æ‰€æœ‰è€…ã®æ–¹ã«é€£çµ¡ã™ã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚{lineStart}è¨±å¯ãªãã‚«ãƒ¼ãƒ‰ã‚’ä½¿ç”¨ã—ãŸå ´åˆã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒå‰Šé™¤ã•ã‚Œã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "ã‚¯ãƒ¬ã‚¸ãƒƒãƒˆã‚«ãƒ¼ãƒ‰ã‚’ä½¿ç”¨ã™ã‚‹å‰ã«ã€ä¿è­·è€…ã®æ–¹ã®è¨±å¯ã‚’å–ã£ã¦ãã ã•ã„ã€‚ç¢ºèªã®ãŸã‚ã€ã‚«ãƒ¼ãƒ‰ã®æ‰€æœ‰è€…ã®æ–¹ã«é€£çµ¡ã™ã‚‹å ´åˆãŒã‚ã‚Šã¾ã™ã€‚è¨±å¯ãªãã‚«ãƒ¼ãƒ‰ã‚’ä½¿ç”¨ã—ãŸå ´åˆã€ã‚¢ã‚«ã‚¦ãƒ³ãƒˆãŒå‰Šé™¤ã•ã‚Œã‚‹ã“ã¨ãŒã‚ã‚Šã¾ã™ã€‚";
	}
}


}
