namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_zh_cjv : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club çŽ°å·²æ›´åä¸º Roblox Premium";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Builders Club çŽ°å·²æ›´åä¸º Roblox Premium";

	public PremiumMigrationResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.MigrationBody"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today weâ€™re giving you a one time payout of {robuxAmount}\n\nCheck your Roblox inbox to learn more about your Robux payout and Premium subscription. "
	/// </summary>
	public override string DescriptionMigrationBody(string robuxAmount)
	{
		return $"å’Œä»¥å¾€æ¯æ—¥å‘æ”¾ Robux ä¸åŒï¼ŒPremium å°†ä¼šæ¯æœˆä¸€æ¬¡æ€§å‘æ”¾æ•´ä¸ªæœˆçš„ Robux ç»™ä½ ï¼æˆ‘ä»¬ä»Šå¤©ä¼šä¸€æ¬¡æ€§æ”¯ä»˜ç»™ä½  {robuxAmount}ã€‚\n\nè‹¥è¦äº†è§£æ›´å¤šå…³äºŽ Robux æ”¯ä»˜ä¸Ž Premium è®¢é˜…çš„ä¿¡æ¯ï¼Œè¯·å‰å¾€ Roblox æ”¶ä»¶ç®±ã€‚ ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "å’Œä»¥å¾€æ¯æ—¥å‘æ”¾ Robux ä¸åŒï¼ŒPremium å°†ä¼šæ¯æœˆä¸€æ¬¡æ€§å‘æ”¾æ•´ä¸ªæœˆçš„ Robux ç»™ä½ ï¼æˆ‘ä»¬ä»Šå¤©ä¼šä¸€æ¬¡æ€§æ”¯ä»˜ç»™ä½  {robuxAmount}ã€‚\n\nè‹¥è¦äº†è§£æ›´å¤šå…³äºŽ Robux æ”¯ä»˜ä¸Ž Premium è®¢é˜…çš„ä¿¡æ¯ï¼Œè¯·å‰å¾€ Roblox æ”¶ä»¶ç®±ã€‚ ";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today weâ€™re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"å’Œä»¥å¾€æ¯æ—¥å‘æ”¾ Robux ä¸åŒï¼ŒPremium å°†ä¼šæ¯æœˆä¸€æ¬¡æ€§å‘æ”¾æ•´ä¸ªæœˆçš„ Robux ç»™ä½ ï¼æˆ‘ä»¬ä»Šå¤©ä¼šä¸€æ¬¡æ€§æ”¯ä»˜ç»™ä½  {robuxAmount}ã€‚{newLine}{newLine}è‹¥è¦äº†è§£æ›´å¤šå…³äºŽ Robux æ”¯ä»˜ä¸Ž Premium è®¢é˜…çš„ä¿¡æ¯ï¼Œè¯·å‰å¾€ Roblox æ”¶ä»¶ç®±ã€‚  ";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "å’Œä»¥å¾€æ¯æ—¥å‘æ”¾ Robux ä¸åŒï¼ŒPremium å°†ä¼šæ¯æœˆä¸€æ¬¡æ€§å‘æ”¾æ•´ä¸ªæœˆçš„ Robux ç»™ä½ ï¼æˆ‘ä»¬ä»Šå¤©ä¼šä¸€æ¬¡æ€§æ”¯ä»˜ç»™ä½  {robuxAmount}ã€‚{newLine}{newLine}è‹¥è¦äº†è§£æ›´å¤šå…³äºŽ Robux æ”¯ä»˜ä¸Ž Premium è®¢é˜…çš„ä¿¡æ¯ï¼Œè¯·å‰å¾€ Roblox æ”¶ä»¶ç®±ã€‚  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"å³æ—¥èµ·ï¼Œè®¢é˜…è€…å°†ç›´æŽ¥èŽ·å¾—ä¸€æ•´ä¸ªæœˆçš„ Robux é¢åº¦ï¼Œè€Œæ— éœ€ç­‰å¾…æ¯æ—¥å‘æ”¾çš„é¢åº¦ã€‚æˆ‘ä»¬ä»Šå¤©ä¼šç»™ä½  {robuxAmount} Robux ä»¥è¡¥å¿ä½ æœ¬æœˆå°šæœªèŽ·å¾—çš„é¢åº¦ã€‚\n{newLine}{newLine}\nè¦äº†è§£æ›´å¤šä¿¡æ¯ï¼Œè¯·å‰å¾€ä½ çš„ Roblox æ”¶ä»¶ç®±ã€‚  ";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "å³æ—¥èµ·ï¼Œè®¢é˜…è€…å°†ç›´æŽ¥èŽ·å¾—ä¸€æ•´ä¸ªæœˆçš„ Robux é¢åº¦ï¼Œè€Œæ— éœ€ç­‰å¾…æ¯æ—¥å‘æ”¾çš„é¢åº¦ã€‚æˆ‘ä»¬ä»Šå¤©ä¼šç»™ä½  {robuxAmount} Robux ä»¥è¡¥å¿ä½ æœ¬æœˆå°šæœªèŽ·å¾—çš„é¢åº¦ã€‚\n{newLine}{newLine}\nè¦äº†è§£æ›´å¤šä¿¡æ¯ï¼Œè¯·å‰å¾€ä½ çš„ Roblox æ”¶ä»¶ç®±ã€‚  ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club çŽ°å·²æ›´åä¸º Roblox Premium";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"å³æ—¥èµ·ï¼Œè®¢é˜…è€…å°†ç›´æŽ¥èŽ·å¾—ä¸€æ•´ä¸ªæœˆçš„ Robux é¢åº¦ï¼Œè€Œæ— éœ€ç­‰å¾…æ¯æ—¥å‘æ”¾çš„é¢åº¦ã€‚æˆ‘ä»¬ä»Šå¤©ä¼šç»™ä½  {robuxAmount} Robux ä»¥è¡¥å¿ä½ æœ¬æœˆå°šæœªèŽ·å¾—çš„é¢åº¦ã€‚\n\nè¦äº†è§£æ›´å¤šä¿¡æ¯ï¼Œè¯·å‰å¾€ä½ çš„ Roblox æ”¶ä»¶ç®±ã€‚";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "å³æ—¥èµ·ï¼Œè®¢é˜…è€…å°†ç›´æŽ¥èŽ·å¾—ä¸€æ•´ä¸ªæœˆçš„ Robux é¢åº¦ï¼Œè€Œæ— éœ€ç­‰å¾…æ¯æ—¥å‘æ”¾çš„é¢åº¦ã€‚æˆ‘ä»¬ä»Šå¤©ä¼šç»™ä½  {robuxAmount} Robux ä»¥è¡¥å¿ä½ æœ¬æœˆå°šæœªèŽ·å¾—çš„é¢åº¦ã€‚\n\nè¦äº†è§£æ›´å¤šä¿¡æ¯ï¼Œè¯·å‰å¾€ä½ çš„ Roblox æ”¶ä»¶ç®±ã€‚";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Builders Club çŽ°å·²æ›´åä¸º Roblox Premium";
	}
}


}
