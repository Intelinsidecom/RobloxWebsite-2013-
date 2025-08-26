namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PremiumMigrationWebResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationWebResources_ja_jp : PremiumMigrationWebResources_en_us, IPremiumMigrationWebResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationModalTitle"
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationModalTitle => "Builders Clubã¯ç¾åœ¨ã¯Roblox Premiumã§ã™";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Clubã¯ç¾åœ¨ã¯Roblox Premiumã§ã™";

	public PremiumMigrationWebResources_ja_jp(TranslationResourceState state)
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
		return $"ã“ã‚Œã‹ã‚‰ã¯ã€ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„è€…ã¯ä¸€æ—¥ã”ã¨ã®Robuxé¡ã§ã¯ãªãã€ä¸€ãƒ¶æœˆã”ã¨ã®ã”åˆ©ç”¨é¡ã‚’ä¸€åº¦ã«ãŠæ¸¡ã—ã—ã¾ã™ã€‚ä»Šæ—¥ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä»ŠæœˆãŠæ¸¡ã—ã™ã‚‹äºˆå®šã ã£ãŸæ®‹ã‚Šã® {robuxAmount} Robuxã‚’ãŠæ”¯æ‰•ã„ã—ã¾ã™ã€‚\n{newLine}{newLine}\nè©³ã—ãã¯ã€Robloxå—ä¿¡ãƒˆãƒ¬ã‚¤ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚  ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "ã“ã‚Œã‹ã‚‰ã¯ã€ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„è€…ã¯ä¸€æ—¥ã”ã¨ã®Robuxé¡ã§ã¯ãªãã€ä¸€ãƒ¶æœˆã”ã¨ã®ã”åˆ©ç”¨é¡ã‚’ä¸€åº¦ã«ãŠæ¸¡ã—ã—ã¾ã™ã€‚ä»Šæ—¥ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä»ŠæœˆãŠæ¸¡ã—ã™ã‚‹äºˆå®šã ã£ãŸæ®‹ã‚Šã® {robuxAmount} Robuxã‚’ãŠæ”¯æ‰•ã„ã—ã¾ã™ã€‚\n{newLine}{newLine}\nè©³ã—ãã¯ã€Robloxå—ä¿¡ãƒˆãƒ¬ã‚¤ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚  ";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full monthâ€™s worth of Robux on the day of your subscription renewal. Today, weâ€™re giving you this month's Robux minus what youâ€™ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public override string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"ã“ã‚Œã‹ã‚‰ã¯ã€ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³æ›´æ–°æ—¥ã«ä¸€ãƒ¶æœˆåˆ†ã®Robuxã”åˆ©ç”¨é¡ã‚’ä¸€åº¦ã«ãŠæ¸¡ã—ã—ã¾ã™ã€‚ä»Šæ—¥ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä»Šæœˆåˆ†ã‹ã‚‰ã™ã§ã«å—ã‘å–ã£ãŸé¡ã‚’å·®ã—å¼•ãã—ãŸæ®‹ã‚Šã®Robuxã‚’ãŠæ”¯æ‰•ã„ã—ã¾ã™: \n{robuxAmount}.{newLine}{newLine}\nè©³ã—ãã¯ã€Robloxå—ä¿¡ãƒˆãƒ¬ã‚¤ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "ã“ã‚Œã‹ã‚‰ã¯ã€ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³æ›´æ–°æ—¥ã«ä¸€ãƒ¶æœˆåˆ†ã®Robuxã”åˆ©ç”¨é¡ã‚’ä¸€åº¦ã«ãŠæ¸¡ã—ã—ã¾ã™ã€‚ä»Šæ—¥ã¯ã€ãŠæŒã¡ã®ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã«ä»Šæœˆåˆ†ã‹ã‚‰ã™ã§ã«å—ã‘å–ã£ãŸé¡ã‚’å·®ã—å¼•ãã—ãŸæ®‹ã‚Šã®Robuxã‚’ãŠæ”¯æ‰•ã„ã—ã¾ã™: \n{robuxAmount}.{newLine}{newLine}\nè©³ã—ãã¯ã€Robloxå—ä¿¡ãƒˆãƒ¬ã‚¤ã‚’ãƒã‚§ãƒƒã‚¯ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "Builders Clubã¯ç¾åœ¨ã¯Roblox Premiumã§ã™";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Clubã¯ç¾åœ¨ã¯Roblox Premiumã§ã™";
	}
}


}
