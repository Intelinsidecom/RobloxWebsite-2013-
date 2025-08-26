namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PremiumMigrationWebResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationWebResources_zh_cn : PremiumMigrationWebResources_en_us, IPremiumMigrationWebResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationModalTitle"
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationModalTitle => "Builders Club çŽ°å·²æ›´åä¸º Roblox Premium";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club çŽ°å·²æ›´åä¸º Roblox Premium";

	public PremiumMigrationWebResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.MigrationBody"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationBody(string robuxAmount, string newLine)
	{
		return $"å³æ—¥èµ·ï¼Œè®¢é˜…è€…å°†ç›´æŽ¥èŽ·å¾—ä¸€æ•´ä¸ªæœˆçš„ Robux é¢åº¦ï¼Œè€Œæ— éœ€ç­‰å¾…æ¯æ—¥å‘æ”¾çš„é¢åº¦ã€‚æˆ‘ä»¬ä»Šå¤©ä¼šç»™ä½  {robuxAmount} Robux ä»¥è¡¥å¿ä½ æœ¬æœˆå°šæœªèŽ·å¾—çš„é¢åº¦ã€‚\n{newLine}{newLine}\nè¦äº†è§£æ›´å¤šä¿¡æ¯ï¼Œè¯·å‰å¾€ä½ çš„ Roblox æ”¶ä»¶ç®±ã€‚  ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "å³æ—¥èµ·ï¼Œè®¢é˜…è€…å°†ç›´æŽ¥èŽ·å¾—ä¸€æ•´ä¸ªæœˆçš„ Robux é¢åº¦ï¼Œè€Œæ— éœ€ç­‰å¾…æ¯æ—¥å‘æ”¾çš„é¢åº¦ã€‚æˆ‘ä»¬ä»Šå¤©ä¼šç»™ä½  {robuxAmount} Robux ä»¥è¡¥å¿ä½ æœ¬æœˆå°šæœªèŽ·å¾—çš„é¢åº¦ã€‚\n{newLine}{newLine}\nè¦äº†è§£æ›´å¤šä¿¡æ¯ï¼Œè¯·å‰å¾€ä½ çš„ Roblox æ”¶ä»¶ç®±ã€‚  ";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full monthâ€™s worth of Robux on the day of your subscription renewal. Today, weâ€™re giving you this month's Robux minus what youâ€™ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public override string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"å³æ—¥èµ·ï¼Œä½ åœ¨æ›´æ–°è®¢é˜…çš„å½“å¤©å°†ç›´æŽ¥èŽ·å¾—ä¸€æ•´ä¸ªæœˆçš„ Robux é¢åº¦ã€‚æˆ‘ä»¬å°†æŠŠæœ¬æœˆçš„ Robux å‡åŽ»ä½ åœ¨æœ¬æœˆå·²ç»æ‹¿åˆ°çš„é¢åº¦ï¼Œä½ å°†æ‹¿åˆ°çš„æ€»é¢ä¸ºï¼š{robuxAmount}ã€‚{newLine}{newLine}\nè¦äº†è§£æ›´å¤šä¿¡æ¯ï¼Œè¯·å‰å¾€ä½ çš„ Roblox æ”¶ä»¶ç®±ã€‚";
	}

	protected override string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "å³æ—¥èµ·ï¼Œä½ åœ¨æ›´æ–°è®¢é˜…çš„å½“å¤©å°†ç›´æŽ¥èŽ·å¾—ä¸€æ•´ä¸ªæœˆçš„ Robux é¢åº¦ã€‚æˆ‘ä»¬å°†æŠŠæœ¬æœˆçš„ Robux å‡åŽ»ä½ åœ¨æœ¬æœˆå·²ç»æ‹¿åˆ°çš„é¢åº¦ï¼Œä½ å°†æ‹¿åˆ°çš„æ€»é¢ä¸ºï¼š{robuxAmount}ã€‚{newLine}{newLine}\nè¦äº†è§£æ›´å¤šä¿¡æ¯ï¼Œè¯·å‰å¾€ä½ çš„ Roblox æ”¶ä»¶ç®±ã€‚";
	}

	protected override string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "Builders Club çŽ°å·²æ›´åä¸º Roblox Premium";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club çŽ°å·²æ›´åä¸º Roblox Premium";
	}
}


}
