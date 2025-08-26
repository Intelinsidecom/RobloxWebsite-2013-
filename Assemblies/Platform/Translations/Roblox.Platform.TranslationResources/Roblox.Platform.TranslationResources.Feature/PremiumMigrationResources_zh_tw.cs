namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_zh_tw : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club æˆç‚º Roblox Premium äº†";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Builders Club æˆç‚º Roblox Premium äº†";

	public PremiumMigrationResources_zh_tw(TranslationResourceState state)
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
		return $"å’Œä»¥å¾€æ¯æ—¥ç™¼æ”¾ Robux ä¸åŒï¼ŒPremium å°‡æœƒæ¯æœˆç™¼æ”¾æ•´å€‹æœˆçš„ Robux çµ¦æ‚¨ï¼æˆ‘å€‘ä»Šå¤©æœƒç™¼æ”¾çµ¦æ‚¨æœ¬æœˆçš„ Robux é‡‘é¡ï¼Œæ‰£é™¤æ‚¨å·²ç¶“ç²å¾—çš„é‡‘é¡ã€‚æ‚¨å°‡ç²å¾—ï¼š{robuxAmount}ã€‚\n\nè‹¥è¦äº†è§£ã„æ›´å¤šé—œæ–¼ Robux ç™¼æ”¾å’Œ Premium è¨‚é–±çš„è³‡è¨Šï¼Œè«‹å‰å¾€æ”¶ä»¶åŒ£ã€‚";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "å’Œä»¥å¾€æ¯æ—¥ç™¼æ”¾ Robux ä¸åŒï¼ŒPremium å°‡æœƒæ¯æœˆç™¼æ”¾æ•´å€‹æœˆçš„ Robux çµ¦æ‚¨ï¼æˆ‘å€‘ä»Šå¤©æœƒç™¼æ”¾çµ¦æ‚¨æœ¬æœˆçš„ Robux é‡‘é¡ï¼Œæ‰£é™¤æ‚¨å·²ç¶“ç²å¾—çš„é‡‘é¡ã€‚æ‚¨å°‡ç²å¾—ï¼š{robuxAmount}ã€‚\n\nè‹¥è¦äº†è§£ã„æ›´å¤šé—œæ–¼ Robux ç™¼æ”¾å’Œ Premium è¨‚é–±çš„è³‡è¨Šï¼Œè«‹å‰å¾€æ”¶ä»¶åŒ£ã€‚";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today weâ€™re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"å’Œä»¥å¾€æ¯æ—¥ç™¼æ”¾ Robux ä¸åŒï¼ŒPremium å°‡æœƒæ¯æœˆç™¼æ”¾æ•´å€‹æœˆçš„ Robux çµ¦æ‚¨ï¼æˆ‘å€‘ä»Šå¤©æœƒç™¼æ”¾çµ¦æ‚¨æœ¬æœˆçš„ Robux é‡‘é¡ï¼Œæ‰£é™¤æ‚¨å·²ç¶“ç²å¾—çš„é‡‘é¡ã€‚æ‚¨å°‡ç²å¾—ï¼šR${robuxAmount}ã€‚{newLine}{newLine}è‹¥è¦äº†è§£ã„æ›´å¤šé—œæ–¼ Robux ç™¼æ”¾å’Œ Premium è¨‚é–±çš„è³‡è¨Šï¼Œè«‹å‰å¾€æ”¶ä»¶åŒ£ã€‚";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "å’Œä»¥å¾€æ¯æ—¥ç™¼æ”¾ Robux ä¸åŒï¼ŒPremium å°‡æœƒæ¯æœˆç™¼æ”¾æ•´å€‹æœˆçš„ Robux çµ¦æ‚¨ï¼æˆ‘å€‘ä»Šå¤©æœƒç™¼æ”¾çµ¦æ‚¨æœ¬æœˆçš„ Robux é‡‘é¡ï¼Œæ‰£é™¤æ‚¨å·²ç¶“ç²å¾—çš„é‡‘é¡ã€‚æ‚¨å°‡ç²å¾—ï¼šR${robuxAmount}ã€‚{newLine}{newLine}è‹¥è¦äº†è§£ã„æ›´å¤šé—œæ–¼ Robux ç™¼æ”¾å’Œ Premium è¨‚é–±çš„è³‡è¨Šï¼Œè«‹å‰å¾€æ”¶ä»¶åŒ£ã€‚";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"å’Œä»¥å¾€æ¯æ—¥ç™¼æ”¾ Robux ä¸åŒï¼Œè¨‚é–±è€…æ¯å€‹æœˆå°‡æœƒç²å¾—ä¸€æ•´å€‹æœˆçš„ Robux é‡‘é¡ã€‚æˆ‘å€‘ä»Šå¤©æœƒçµ¦æ‚¨ {robuxAmount} Robuxï¼Œè£œå„Ÿæ‚¨æœ¬æœˆå°šæœªç²å¾—çš„é‡‘é¡ã€‚\n{newLine}{newLine}\nè‹¥è¦äº†è§£æ›´å¤šï¼Œè«‹å‰å¾€æ‚¨çš„ Roblox æ”¶ä»¶ç®±ã€‚";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "å’Œä»¥å¾€æ¯æ—¥ç™¼æ”¾ Robux ä¸åŒï¼Œè¨‚é–±è€…æ¯å€‹æœˆå°‡æœƒç²å¾—ä¸€æ•´å€‹æœˆçš„ Robux é‡‘é¡ã€‚æˆ‘å€‘ä»Šå¤©æœƒçµ¦æ‚¨ {robuxAmount} Robuxï¼Œè£œå„Ÿæ‚¨æœ¬æœˆå°šæœªç²å¾—çš„é‡‘é¡ã€‚\n{newLine}{newLine}\nè‹¥è¦äº†è§£æ›´å¤šï¼Œè«‹å‰å¾€æ‚¨çš„ Roblox æ”¶ä»¶ç®±ã€‚";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club æˆç‚º Roblox Premium äº†";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"å’Œä»¥å¾€æ¯æ—¥ç™¼æ”¾ Robux ä¸åŒï¼Œè¨‚é–±è€…æ¯å€‹æœˆå°‡æœƒç²å¾—ä¸€æ•´å€‹æœˆçš„ Robux é‡‘é¡ã€‚æˆ‘å€‘ä»Šå¤©æœƒçµ¦æ‚¨ {robuxAmount} Robuxï¼Œè£œå„Ÿæ‚¨æœ¬æœˆå°šæœªç²å¾—çš„é‡‘é¡ã€‚\n\nè‹¥è¦äº†è§£æ›´å¤šï¼Œè«‹å‰å¾€æ‚¨çš„ Roblox æ”¶ä»¶ç®±ã€‚";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "å’Œä»¥å¾€æ¯æ—¥ç™¼æ”¾ Robux ä¸åŒï¼Œè¨‚é–±è€…æ¯å€‹æœˆå°‡æœƒç²å¾—ä¸€æ•´å€‹æœˆçš„ Robux é‡‘é¡ã€‚æˆ‘å€‘ä»Šå¤©æœƒçµ¦æ‚¨ {robuxAmount} Robuxï¼Œè£œå„Ÿæ‚¨æœ¬æœˆå°šæœªç²å¾—çš„é‡‘é¡ã€‚\n\nè‹¥è¦äº†è§£æ›´å¤šï¼Œè«‹å‰å¾€æ‚¨çš„ Roblox æ”¶ä»¶ç®±ã€‚";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Builders Club æˆç‚º Roblox Premium äº†";
	}
}


}
