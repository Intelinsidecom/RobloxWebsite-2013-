namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_ko_kr : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club ëŒ€ì‹  Roblox í”„ë¦¬ë¯¸ì—„ì´ ìƒê²¼ì–´ìš”";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Builders Club ëŒ€ì‹  Roblox í”„ë¦¬ë¯¸ì—„ì´ ìƒê²¼ì–´ìš”";

	public PremiumMigrationResources_ko_kr(TranslationResourceState state)
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
		return $"í”„ë¦¬ë¯¸ì—„ì—ì„œëŠ” Robux ì§€ê¸‰ì´ ê¸°ì¡´ì˜ ì¼ì¼ ì§€ê¸‰ì´ ì•„ë‹Œ ì›”ë³„ ì´ì•¡ ì§€ê¸‰ ë°©ì‹ìœ¼ë¡œ ì´ë£¨ì–´ì§‘ë‹ˆë‹¤. ì˜¤ëŠ˜ ìˆ˜ë ¹í•  ê¸ˆì•¡ì€ R${robuxAmount}ìž…ë‹ˆë‹¤.\n\nRobux ì§€ê¸‰ ë° í”„ë¦¬ë¯¸ì—„ êµ¬ë…ì— ëŒ€í•œ ìžì„¸í•œ ë‚´ìš©ì„ Roblox ìˆ˜ì‹ í•¨ì—ì„œ í™•ì¸í•˜ì„¸ìš”.\n\n";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "í”„ë¦¬ë¯¸ì—„ì—ì„œëŠ” Robux ì§€ê¸‰ì´ ê¸°ì¡´ì˜ ì¼ì¼ ì§€ê¸‰ì´ ì•„ë‹Œ ì›”ë³„ ì´ì•¡ ì§€ê¸‰ ë°©ì‹ìœ¼ë¡œ ì´ë£¨ì–´ì§‘ë‹ˆë‹¤. ì˜¤ëŠ˜ ìˆ˜ë ¹í•  ê¸ˆì•¡ì€ R${robuxAmount}ìž…ë‹ˆë‹¤.\n\nRobux ì§€ê¸‰ ë° í”„ë¦¬ë¯¸ì—„ êµ¬ë…ì— ëŒ€í•œ ìžì„¸í•œ ë‚´ìš©ì„ Roblox ìˆ˜ì‹ í•¨ì—ì„œ í™•ì¸í•˜ì„¸ìš”.\n\n";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today weâ€™re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"í”„ë¦¬ë¯¸ì—„ì—ì„œëŠ” Robux ì§€ê¸‰ì´ ê¸°ì¡´ì˜ ì¼ì¼ ì§€ê¸‰ì´ ì•„ë‹Œ ì›”ë³„ ì´ì•¡ ì§€ê¸‰ ë°©ì‹ìœ¼ë¡œ ì´ë£¨ì–´ì§‘ë‹ˆë‹¤. ì˜¤ëŠ˜ ìˆ˜ë ¹í•  ê¸ˆì•¡ì€ {robuxAmount}ìž…ë‹ˆë‹¤.{newLine}{newLine}Robux ì§€ê¸‰ ë° í”„ë¦¬ë¯¸ì—„ êµ¬ë…ì— ëŒ€í•œ ìžì„¸í•œ ë‚´ìš©ì„ Roblox ìˆ˜ì‹ í•¨ì—ì„œ í™•ì¸í•˜ì„¸ìš”.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "í”„ë¦¬ë¯¸ì—„ì—ì„œëŠ” Robux ì§€ê¸‰ì´ ê¸°ì¡´ì˜ ì¼ì¼ ì§€ê¸‰ì´ ì•„ë‹Œ ì›”ë³„ ì´ì•¡ ì§€ê¸‰ ë°©ì‹ìœ¼ë¡œ ì´ë£¨ì–´ì§‘ë‹ˆë‹¤. ì˜¤ëŠ˜ ìˆ˜ë ¹í•  ê¸ˆì•¡ì€ {robuxAmount}ìž…ë‹ˆë‹¤.{newLine}{newLine}Robux ì§€ê¸‰ ë° í”„ë¦¬ë¯¸ì—„ êµ¬ë…ì— ëŒ€í•œ ìžì„¸í•œ ë‚´ìš©ì„ Roblox ìˆ˜ì‹ í•¨ì—ì„œ í™•ì¸í•˜ì„¸ìš”.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"ì•žìœ¼ë¡œ ê°€ìž…ìžë“¤ì€ Robuxë¥¼ ë§¤ì¼ ì§€ê¸‰ë°›ëŠ” ëŒ€ì‹ , í•œ ë‹¬ì— í•œ ë²ˆ ëª°ì•„ì„œ ë°›ê²Œ ë©ë‹ˆë‹¤. ë”°ë¼ì„œ ì˜¤ëŠ˜, ì´ë²ˆ ë‹¬ì— ë°›ì•„ì•¼ í•  ì´ ê¸ˆì•¡ì¸ {robuxAmount} Robuxê°€ ê³„ì •ì— í•œêº¼ë²ˆì— ì§€ê¸‰ë©ë‹ˆë‹¤.\n{newLine}{newLine}\nìžì„¸í•œ ë‚´ìš©ì€ Roblox ìˆ˜ì‹ í•¨ì—ì„œ í™•ì¸í•˜ì„¸ìš”.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "ì•žìœ¼ë¡œ ê°€ìž…ìžë“¤ì€ Robuxë¥¼ ë§¤ì¼ ì§€ê¸‰ë°›ëŠ” ëŒ€ì‹ , í•œ ë‹¬ì— í•œ ë²ˆ ëª°ì•„ì„œ ë°›ê²Œ ë©ë‹ˆë‹¤. ë”°ë¼ì„œ ì˜¤ëŠ˜, ì´ë²ˆ ë‹¬ì— ë°›ì•„ì•¼ í•  ì´ ê¸ˆì•¡ì¸ {robuxAmount} Robuxê°€ ê³„ì •ì— í•œêº¼ë²ˆì— ì§€ê¸‰ë©ë‹ˆë‹¤.\n{newLine}{newLine}\nìžì„¸í•œ ë‚´ìš©ì€ Roblox ìˆ˜ì‹ í•¨ì—ì„œ í™•ì¸í•˜ì„¸ìš”.  ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club ëŒ€ì‹  Roblox í”„ë¦¬ë¯¸ì—„ì´ ìƒê²¼ì–´ìš”";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"ì•žìœ¼ë¡œ ê°€ìž…ìžë“¤ì€ Robuxë¥¼ ë§¤ì¼ ì§€ê¸‰ë°›ëŠ” ëŒ€ì‹ , í•œ ë‹¬ì— í•œ ë²ˆ ëª°ì•„ì„œ ë°›ê²Œ ë©ë‹ˆë‹¤. ë”°ë¼ì„œ ì˜¤ëŠ˜, ì´ë²ˆ ë‹¬ì— ë°›ì•„ì•¼ í•  ì´ ê¸ˆì•¡ì¸ {robuxAmount} Robuxê°€ ê³„ì •ì— í•œêº¼ë²ˆì— ì§€ê¸‰ë©ë‹ˆë‹¤.\n\nìžì„¸í•œ ë‚´ìš©ì€ Roblox ìˆ˜ì‹ í•¨ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "ì•žìœ¼ë¡œ ê°€ìž…ìžë“¤ì€ Robuxë¥¼ ë§¤ì¼ ì§€ê¸‰ë°›ëŠ” ëŒ€ì‹ , í•œ ë‹¬ì— í•œ ë²ˆ ëª°ì•„ì„œ ë°›ê²Œ ë©ë‹ˆë‹¤. ë”°ë¼ì„œ ì˜¤ëŠ˜, ì´ë²ˆ ë‹¬ì— ë°›ì•„ì•¼ í•  ì´ ê¸ˆì•¡ì¸ {robuxAmount} Robuxê°€ ê³„ì •ì— í•œêº¼ë²ˆì— ì§€ê¸‰ë©ë‹ˆë‹¤.\n\nìžì„¸í•œ ë‚´ìš©ì€ Roblox ìˆ˜ì‹ í•¨ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Builders Club ëŒ€ì‹  Roblox í”„ë¦¬ë¯¸ì—„ì´ ìƒê²¼ì–´ìš”";
	}
}


}
