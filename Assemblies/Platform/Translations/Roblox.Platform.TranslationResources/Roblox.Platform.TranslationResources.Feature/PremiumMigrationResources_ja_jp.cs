namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_ja_jp : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Clubã¯ç¾åœ¨ã¯Robloxãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã§ã™";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Builders Clubã¯ç¾åœ¨ã¯Robloxãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã§ã™";

	public PremiumMigrationResources_ja_jp(TranslationResourceState state)
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
		return $"ãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã§ã¯ã€ä¸€æ—¥ã«åˆ©ç”¨ã§ãã‚‹Robuxã®é¡ã‚’è¨­å®šã›ãšã€ä¸€ãƒ¶æœˆã”ã¨ã«ã”åˆ©ç”¨ã§ãã‚‹ç·é¡ã‚’ä¸€åº¦ã«ãŠæ¸¡ã—ã—ã¾ã™ã€‚ä»Šæ—¥ã¯ã€ä¸€å›žã§ {robuxAmount} ã®ãƒšã‚¤ã‚¢ã‚¦ãƒˆã‚’ãŠæ¸¡ã—ã—ã¾ã™ã€‚\n\nRobuxãƒšã‚¤ã‚¢ã‚¦ãƒˆã¨ãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã«ã¤ã„ã¦è©³ã—ãçŸ¥ã‚‹ã«ã¯ã€Robloxå—ä¿¡ãƒˆãƒ¬ã‚¤ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚ ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "ãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã§ã¯ã€ä¸€æ—¥ã«åˆ©ç”¨ã§ãã‚‹Robuxã®é¡ã‚’è¨­å®šã›ãšã€ä¸€ãƒ¶æœˆã”ã¨ã«ã”åˆ©ç”¨ã§ãã‚‹ç·é¡ã‚’ä¸€åº¦ã«ãŠæ¸¡ã—ã—ã¾ã™ã€‚ä»Šæ—¥ã¯ã€ä¸€å›žã§ {robuxAmount} ã®ãƒšã‚¤ã‚¢ã‚¦ãƒˆã‚’ãŠæ¸¡ã—ã—ã¾ã™ã€‚\n\nRobuxãƒšã‚¤ã‚¢ã‚¦ãƒˆã¨ãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã«ã¤ã„ã¦è©³ã—ãçŸ¥ã‚‹ã«ã¯ã€Robloxå—ä¿¡ãƒˆãƒ¬ã‚¤ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚ ";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today weâ€™re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"ãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã§ã¯ã€ä¸€æ—¥ã«åˆ©ç”¨ã§ãã‚‹Robuxã®é¡ã‚’è¨­å®šã›ãšã€ä¸€ãƒ¶æœˆã”ã¨ã«ã”åˆ©ç”¨ã§ãã‚‹ç·é¡ã‚’ä¸€åº¦ã«ãŠæ¸¡ã—ã—ã¾ã™ã€‚ä»Šæ—¥ã¯ã€ä¸€å›žã§ {robuxAmount}ã®ãƒšã‚¤ã‚¢ã‚¦ãƒˆã‚’ãŠæ¸¡ã—ã—ã¾ã™ã€‚{newLine}{newLine}Robuxãƒšã‚¤ã‚¢ã‚¦ãƒˆã¨ãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã«ã¤ã„ã¦è©³ã—ãçŸ¥ã‚‹ã«ã¯ã€Robloxå—ä¿¡ãƒˆãƒ¬ã‚¤ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚  ";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "ãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã§ã¯ã€ä¸€æ—¥ã«åˆ©ç”¨ã§ãã‚‹Robuxã®é¡ã‚’è¨­å®šã›ãšã€ä¸€ãƒ¶æœˆã”ã¨ã«ã”åˆ©ç”¨ã§ãã‚‹ç·é¡ã‚’ä¸€åº¦ã«ãŠæ¸¡ã—ã—ã¾ã™ã€‚ä»Šæ—¥ã¯ã€ä¸€å›žã§ {robuxAmount}ã®ãƒšã‚¤ã‚¢ã‚¦ãƒˆã‚’ãŠæ¸¡ã—ã—ã¾ã™ã€‚{newLine}{newLine}Robuxãƒšã‚¤ã‚¢ã‚¦ãƒˆã¨ãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³ã«ã¤ã„ã¦è©³ã—ãçŸ¥ã‚‹ã«ã¯ã€Robloxå—ä¿¡ãƒˆãƒ¬ã‚¤ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"ã“ã‚Œã‹ã‚‰ã¯ã€ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„è€…ã¯ä¸€æ—¥ã”ã¨ã®Robuxé¡ã§ã¯ãªãã€ä¸€ãƒ¶æœˆã«ã”åˆ©ç”¨ã§ãã‚‹å…¨é¡ã‚’ä¸€åº¦ã«ãŠæ”¯æ‰•ã„ã—ã¾ã™ã€‚ä»Šæ—¥ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä»ŠæœˆãŠæ¸¡ã—ã™ã‚‹äºˆå®šã ã£ãŸæ®‹ã‚Šã® {robuxAmount} Robuxã‚’ãŠæ”¯æ‰•ã„ã—ã¾ã™ã€‚\n{newLine}{newLine}\nè©³ã—ãã¯ã€Robloxå—ä¿¡ãƒˆãƒ¬ã‚¤ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚  ";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "ã“ã‚Œã‹ã‚‰ã¯ã€ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„è€…ã¯ä¸€æ—¥ã”ã¨ã®Robuxé¡ã§ã¯ãªãã€ä¸€ãƒ¶æœˆã«ã”åˆ©ç”¨ã§ãã‚‹å…¨é¡ã‚’ä¸€åº¦ã«ãŠæ”¯æ‰•ã„ã—ã¾ã™ã€‚ä»Šæ—¥ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä»ŠæœˆãŠæ¸¡ã—ã™ã‚‹äºˆå®šã ã£ãŸæ®‹ã‚Šã® {robuxAmount} Robuxã‚’ãŠæ”¯æ‰•ã„ã—ã¾ã™ã€‚\n{newLine}{newLine}\nè©³ã—ãã¯ã€Robloxå—ä¿¡ãƒˆãƒ¬ã‚¤ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚  ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Clubã¯ç¾åœ¨ã¯Robloxãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã§ã™";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"ã“ã‚Œã‹ã‚‰ã¯ã€ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„è€…ã¯ä¸€æ—¥ã”ã¨ã®Robuxé¡ã§ã¯ãªãã€ä¸€ãƒ¶æœˆã”ã¨ã®ã”åˆ©ç”¨é¡ã‚’ä¸€åº¦ã«ãŠæ¸¡ã—ã—ã¾ã™ã€‚ä»Šæ—¥ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä»ŠæœˆãŠæ¸¡ã—ã™ã‚‹äºˆå®šã ã£ãŸæ®‹ã‚Šã® {robuxAmount} Robuxã‚’ãŠæ”¯æ‰•ã„ã—ã¾ã™ã€‚\n\nè©³ã—ãã¯ã€Robloxå—ä¿¡ãƒˆãƒ¬ã‚¤ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "ã“ã‚Œã‹ã‚‰ã¯ã€ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„è€…ã¯ä¸€æ—¥ã”ã¨ã®Robuxé¡ã§ã¯ãªãã€ä¸€ãƒ¶æœˆã”ã¨ã®ã”åˆ©ç”¨é¡ã‚’ä¸€åº¦ã«ãŠæ¸¡ã—ã—ã¾ã™ã€‚ä»Šæ—¥ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä»ŠæœˆãŠæ¸¡ã—ã™ã‚‹äºˆå®šã ã£ãŸæ®‹ã‚Šã® {robuxAmount} Robuxã‚’ãŠæ”¯æ‰•ã„ã—ã¾ã™ã€‚\n\nè©³ã—ãã¯ã€Robloxå—ä¿¡ãƒˆãƒ¬ã‚¤ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Builders Clubã¯ç¾åœ¨ã¯Robloxãƒ—ãƒ¬ãƒŸã‚¢ãƒ ã§ã™";
	}
}


}
