namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string MessageFraudBlockedPaymentCheckInfoErrorMessage => "ìœ ê°ìŠ¤ëŸ½ê²Œë„ ê²°ì œë¥¼ ì§„í–‰í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ì²­êµ¬ ë‚´ì—­ê³¼ ì¹´ë“œ ì •ë³´ê°€ ì¼ì¹˜í•˜ëŠ”ì§€ í™•ì¸ í›„ ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”. ë¬¸ì œê°€ ê³„ì†ë˜ë©´ ë‹¤ë¥¸ ì¹´ë“œ í˜¹ì€ ê²°ì œìˆ˜ë‹¨ì„ ì´ìš©í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public override string MessageFraudWarningForUnder13WithCreditCard => "ì‹ ìš©ì¹´ë“œë¥¼ ì‚¬ìš©í•˜ê¸° ì „ì— ë¶€ëª¨ë‹˜ì˜ í—ˆë½ì„ ë°›ìœ¼ì„¸ìš”. ì¹´ë“œ ëª…ì˜ìžì—ê²Œ ì—°ë½í•˜ì—¬ í—ˆìš© ì—¬ë¶€ë¥¼ í™•ì¸í•  ìˆ˜ ìžˆìœ¼ë©°, í—ˆë½ë°›ì§€ ì•Šì€ ì¹´ë“œë¥¼ ì‚¬ìš©í•  ê²½ìš° ê³„ì •ì´ ì‚­ì œë©ë‹ˆë‹¤.";

	public PaymentResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "ìœ ê°ìŠ¤ëŸ½ê²Œë„ ê²°ì œë¥¼ ì§„í–‰í•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤. ì²­êµ¬ ë‚´ì—­ê³¼ ì¹´ë“œ ì •ë³´ê°€ ì¼ì¹˜í•˜ëŠ”ì§€ í™•ì¸ í›„ ë‹¤ì‹œ ì‹œë„í•˜ì„¸ìš”. ë¬¸ì œê°€ ê³„ì†ë˜ë©´ ë‹¤ë¥¸ ì¹´ë“œ í˜¹ì€ ê²°ì œìˆ˜ë‹¨ì„ ì´ìš©í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public override string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"ì˜ì‹¬ìŠ¤ëŸ¬ìš´ í™œë™ìœ¼ë¡œ ì¸í•´ ì²­êµ¬ê°€ ì°¨ë‹¨ë˜ì—ˆìŠµë‹ˆë‹¤. ì˜¤ë¥˜ë¼ê³  ìƒê°í•˜ëŠ” ê²½ìš° {linkStart}roblox.com/support{linkEnd}ë¡œ ë¬¸ì˜í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "ì˜ì‹¬ìŠ¤ëŸ¬ìš´ í™œë™ìœ¼ë¡œ ì¸í•´ ì²­êµ¬ê°€ ì°¨ë‹¨ë˜ì—ˆìŠµë‹ˆë‹¤. ì˜¤ë¥˜ë¼ê³  ìƒê°í•˜ëŠ” ê²½ìš° {linkStart}roblox.com/support{linkEnd}ë¡œ ë¬¸ì˜í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public override string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"ì‹ ìš©ì¹´ë“œë¥¼ ì‚¬ìš©í•˜ê¸° ì „ì— ë¶€ëª¨ë‹˜ì˜ í—ˆë½ì„ ë°›ìœ¼ì„¸ìš”. ì¹´ë“œ ëª…ì˜ìžì—ê²Œ ì—°ë½í•˜ì—¬ í—ˆìš© ì—¬ë¶€ë¥¼ í™•ì¸í•  ìˆ˜ ìžˆìœ¼ë©°,{lineStart}í—ˆë½ë°›ì§€ ì•Šì€ ì¹´ë“œë¥¼ ì‚¬ìš©í•  ê²½ìš° ê³„ì •ì´ ì‚­ì œë©ë‹ˆë‹¤.{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "ì‹ ìš©ì¹´ë“œë¥¼ ì‚¬ìš©í•˜ê¸° ì „ì— ë¶€ëª¨ë‹˜ì˜ í—ˆë½ì„ ë°›ìœ¼ì„¸ìš”. ì¹´ë“œ ëª…ì˜ìžì—ê²Œ ì—°ë½í•˜ì—¬ í—ˆìš© ì—¬ë¶€ë¥¼ í™•ì¸í•  ìˆ˜ ìžˆìœ¼ë©°,{lineStart}í—ˆë½ë°›ì§€ ì•Šì€ ì¹´ë“œë¥¼ ì‚¬ìš©í•  ê²½ìš° ê³„ì •ì´ ì‚­ì œë©ë‹ˆë‹¤.{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "ì‹ ìš©ì¹´ë“œë¥¼ ì‚¬ìš©í•˜ê¸° ì „ì— ë¶€ëª¨ë‹˜ì˜ í—ˆë½ì„ ë°›ìœ¼ì„¸ìš”. ì¹´ë“œ ëª…ì˜ìžì—ê²Œ ì—°ë½í•˜ì—¬ í—ˆìš© ì—¬ë¶€ë¥¼ í™•ì¸í•  ìˆ˜ ìžˆìœ¼ë©°, í—ˆë½ë°›ì§€ ì•Šì€ ì¹´ë“œë¥¼ ì‚¬ìš©í•  ê²½ìš° ê³„ì •ì´ ì‚­ì œë©ë‹ˆë‹¤.";
	}
}


}
