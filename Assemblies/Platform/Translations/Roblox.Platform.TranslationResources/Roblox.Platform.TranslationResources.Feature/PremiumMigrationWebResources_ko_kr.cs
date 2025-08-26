namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PremiumMigrationWebResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationWebResources_ko_kr : PremiumMigrationWebResources_en_us, IPremiumMigrationWebResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationModalTitle"
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationModalTitle => "Builders Club ëŒ€ì‹  Roblox Premiumì´ ìƒê²¼ì–´ìš”";

	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "Builders Club ëŒ€ì‹  Roblox Premiumì´ ìƒê²¼ì–´ìš”";

	public PremiumMigrationWebResources_ko_kr(TranslationResourceState state)
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
		return $"ì•žìœ¼ë¡œ ê°€ìž…ìžë“¤ì€ Robuxë¥¼ ë§¤ì¼ ì§€ê¸‰ë°›ëŠ” ëŒ€ì‹ , í•œ ë‹¬ì— í•œ ë²ˆ ëª°ì•„ì„œ ë°›ê²Œ ë©ë‹ˆë‹¤. ë”°ë¼ì„œ ì˜¤ëŠ˜, ì´ë²ˆ ë‹¬ì— ë°›ì•„ì•¼ í•  ì´ ê¸ˆì•¡ì¸ {robuxAmount} Robuxê°€ ê³„ì •ì— í•œêº¼ë²ˆì— ì§€ê¸‰ë©ë‹ˆë‹¤.\n{newLine}{newLine}\nìžì„¸í•œ ë‚´ìš©ì€ Roblox ìˆ˜ì‹ í•¨ì—ì„œ í™•ì¸í•˜ì„¸ìš”.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "ì•žìœ¼ë¡œ ê°€ìž…ìžë“¤ì€ Robuxë¥¼ ë§¤ì¼ ì§€ê¸‰ë°›ëŠ” ëŒ€ì‹ , í•œ ë‹¬ì— í•œ ë²ˆ ëª°ì•„ì„œ ë°›ê²Œ ë©ë‹ˆë‹¤. ë”°ë¼ì„œ ì˜¤ëŠ˜, ì´ë²ˆ ë‹¬ì— ë°›ì•„ì•¼ í•  ì´ ê¸ˆì•¡ì¸ {robuxAmount} Robuxê°€ ê³„ì •ì— í•œêº¼ë²ˆì— ì§€ê¸‰ë©ë‹ˆë‹¤.\n{newLine}{newLine}\nìžì„¸í•œ ë‚´ìš©ì€ Roblox ìˆ˜ì‹ í•¨ì—ì„œ í™•ì¸í•˜ì„¸ìš”.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationModalBody"
	/// English String: "Going forward, you will receive a full monthâ€™s worth of Robux on the day of your subscription renewal. Today, weâ€™re giving you this month's Robux minus what youâ€™ve already received this month: {robuxAmount}.{newLine}{newLine}\nCheck your Roblox inbox for more details."
	/// </summary>
	public override string DescriptionMigrationModalBody(string robuxAmount, string newLine)
	{
		return $"ì´ì œë¶€í„°ëŠ” ë§¤ì›” ê°€ìž… ê°±ì‹ ì¼ë§ˆë‹¤ í•œ ë‹¬ì¹˜ Robuxê°€ í•œêº¼ë²ˆì— ì§€ê¸‰ë©ë‹ˆë‹¤. ë”°ë¼ì„œ ì˜¤ëŠ˜, íšŒì›ë‹˜ì€ ì´ë²ˆ ë‹¬ì— ì´ë¯¸ ë°›ì€ ì•¡ìˆ˜ë¥¼ ì œì™¸í•œ ê¸ˆì•¡ì¸ {robuxAmount}ë¥¼ ë°›ê²Œ ë˜ì£ .{newLine}{newLine}\nìžì„¸í•œ ë‚´ìš©ì€ Roblox ìˆ˜ì‹ í•¨ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForDescriptionMigrationModalBody()
	{
		return "ì´ì œë¶€í„°ëŠ” ë§¤ì›” ê°€ìž… ê°±ì‹ ì¼ë§ˆë‹¤ í•œ ë‹¬ì¹˜ Robuxê°€ í•œêº¼ë²ˆì— ì§€ê¸‰ë©ë‹ˆë‹¤. ë”°ë¼ì„œ ì˜¤ëŠ˜, íšŒì›ë‹˜ì€ ì´ë²ˆ ë‹¬ì— ì´ë¯¸ ë°›ì€ ì•¡ìˆ˜ë¥¼ ì œì™¸í•œ ê¸ˆì•¡ì¸ {robuxAmount}ë¥¼ ë°›ê²Œ ë˜ì£ .{newLine}{newLine}\nìžì„¸í•œ ë‚´ìš©ì€ Roblox ìˆ˜ì‹ í•¨ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForHeadingMigrationModalTitle()
	{
		return "Builders Club ëŒ€ì‹  Roblox Premiumì´ ìƒê²¼ì–´ìš”";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Club ëŒ€ì‹  Roblox Premiumì´ ìƒê²¼ì–´ìš”";
	}
}


}
