namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PremiumMigrationResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PremiumMigrationResources_ru_ru : PremiumMigrationResources_en_us, IPremiumMigrationResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.MigrationTitle"
	/// obsoleted
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string HeadingMigrationTitle => "ÐšÐ»ÑƒÐ± ÑÐ¾Ð·Ð´Ð°Ñ‚ÐµÐ»ÐµÐ¹ Ñ‚ÐµÐ¿ÐµÑ€ÑŒ ÑÑ‚Ð°Ð» Roblox ÐŸÑ€ÐµÐ¼Ð¸ÑƒÐ¼";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "ÐšÐ»ÑƒÐ± ÑÐ¾Ð·Ð´Ð°Ñ‚ÐµÐ»ÐµÐ¹ Ñ‚ÐµÐ¿ÐµÑ€ÑŒ ÑÑ‚Ð°Ð» Roblox ÐŸÑ€ÐµÐ¼Ð¸ÑƒÐ¼";

	public PremiumMigrationResources_ru_ru(TranslationResourceState state)
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
		return $"Ð¡ÐµÐ¹Ñ‡Ð°Ñ ÐŸÑ€ÐµÐ¼Ð¸ÑƒÐ¼ Ð´Ð°ÐµÑ‚ Ð²Ð°Ð¼ ÑÑ€Ð°Ð·Ñƒ Ð¼ÐµÑÑÑ‡Ð½Ñ‹Ð¹ Ð´Ð¾Ð¿ÑƒÑÐº Ðº Robux Ð²Ð¼ÐµÑÑ‚Ð¾ ÐºÐ°Ð¶Ð´Ð¾Ð´Ð½ÐµÐ²Ð½Ð¾Ð³Ð¾! Ð¡ÐµÐ³Ð¾Ð´Ð½Ñ Ð¼Ñ‹ Ð´Ð°Ñ€Ð¸Ð¼ Ð²Ð°Ð¼ Ð¾Ð´Ð½Ð¾Ñ€Ð°Ð·Ð¾Ð²ÑƒÑŽ Ð²Ñ‹Ð¿Ð»Ð°Ñ‚Ñƒ Ð² Ñ€Ð°Ð·Ð¼ÐµÑ€Ðµ {robuxAmount}.\n\nÐ—Ð°Ð¹Ð´Ð¸Ñ‚Ðµ Ð² ÑÐ²Ð¾ÑŽ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ñ‚ÑŒ Ð¿Ð¾Ð´Ñ€Ð¾Ð±Ð½Ñ‹Ðµ ÑÐ²ÐµÐ´ÐµÐ½Ð¸Ñ Ð¾ Ð²Ñ‹Ð¿Ð»Ð°Ñ‚Ðµ Robux Ð¸ Ð¿Ð¾Ð´Ð¿Ð¸ÑÐºÐµ ÐŸÑ€ÐµÐ¼Ð¸ÑƒÐ¼. ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "Ð¡ÐµÐ¹Ñ‡Ð°Ñ ÐŸÑ€ÐµÐ¼Ð¸ÑƒÐ¼ Ð´Ð°ÐµÑ‚ Ð²Ð°Ð¼ ÑÑ€Ð°Ð·Ñƒ Ð¼ÐµÑÑÑ‡Ð½Ñ‹Ð¹ Ð´Ð¾Ð¿ÑƒÑÐº Ðº Robux Ð²Ð¼ÐµÑÑ‚Ð¾ ÐºÐ°Ð¶Ð´Ð¾Ð´Ð½ÐµÐ²Ð½Ð¾Ð³Ð¾! Ð¡ÐµÐ³Ð¾Ð´Ð½Ñ Ð¼Ñ‹ Ð´Ð°Ñ€Ð¸Ð¼ Ð²Ð°Ð¼ Ð¾Ð´Ð½Ð¾Ñ€Ð°Ð·Ð¾Ð²ÑƒÑŽ Ð²Ñ‹Ð¿Ð»Ð°Ñ‚Ñƒ Ð² Ñ€Ð°Ð·Ð¼ÐµÑ€Ðµ {robuxAmount}.\n\nÐ—Ð°Ð¹Ð´Ð¸Ñ‚Ðµ Ð² ÑÐ²Ð¾ÑŽ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ñ‚ÑŒ Ð¿Ð¾Ð´Ñ€Ð¾Ð±Ð½Ñ‹Ðµ ÑÐ²ÐµÐ´ÐµÐ½Ð¸Ñ Ð¾ Ð²Ñ‹Ð¿Ð»Ð°Ñ‚Ðµ Robux Ð¸ Ð¿Ð¾Ð´Ð¿Ð¸ÑÐºÐµ ÐŸÑ€ÐµÐ¼Ð¸ÑƒÐ¼. ";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today weâ€™re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"Ð¡ÐµÐ¹Ñ‡Ð°Ñ ÐŸÑ€ÐµÐ¼Ð¸ÑƒÐ¼ Ð´Ð°ÐµÑ‚ Ð²Ð°Ð¼ ÑÑ€Ð°Ð·Ñƒ Ð¼ÐµÑÑÑ‡Ð½Ñ‹Ð¹ Ð´Ð¾Ð¿ÑƒÑÐº Ðº Robux Ð²Ð¼ÐµÑÑ‚Ð¾ ÐºÐ°Ð¶Ð´Ð¾Ð´Ð½ÐµÐ²Ð½Ð¾Ð³Ð¾! Ð¡ÐµÐ³Ð¾Ð´Ð½Ñ Ð¼Ñ‹ Ð´Ð°Ñ€Ð¸Ð¼ Ð²Ð°Ð¼ Ð¾Ð´Ð½Ð¾Ñ€Ð°Ð·Ð¾Ð²ÑƒÑŽ Ð²Ñ‹Ð¿Ð»Ð°Ñ‚Ñƒ Ð² Ñ€Ð°Ð·Ð¼ÐµÑ€Ðµ {robuxAmount}.{newLine}{newLine}Ð—Ð°Ð¹Ð´Ð¸Ñ‚Ðµ Ð² ÑÐ²Ð¾ÑŽ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ñ‚ÑŒ Ð¿Ð¾Ð´Ñ€Ð¾Ð±Ð½Ñ‹Ðµ ÑÐ²ÐµÐ´ÐµÐ½Ð¸Ñ Ð¾ Ð²Ñ‹Ð¿Ð»Ð°Ñ‚Ðµ Robux Ð¸ Ð¿Ð¾Ð´Ð¿Ð¸ÑÐºÐµ ÐŸÑ€ÐµÐ¼Ð¸ÑƒÐ¼.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "Ð¡ÐµÐ¹Ñ‡Ð°Ñ ÐŸÑ€ÐµÐ¼Ð¸ÑƒÐ¼ Ð´Ð°ÐµÑ‚ Ð²Ð°Ð¼ ÑÑ€Ð°Ð·Ñƒ Ð¼ÐµÑÑÑ‡Ð½Ñ‹Ð¹ Ð´Ð¾Ð¿ÑƒÑÐº Ðº Robux Ð²Ð¼ÐµÑÑ‚Ð¾ ÐºÐ°Ð¶Ð´Ð¾Ð´Ð½ÐµÐ²Ð½Ð¾Ð³Ð¾! Ð¡ÐµÐ³Ð¾Ð´Ð½Ñ Ð¼Ñ‹ Ð´Ð°Ñ€Ð¸Ð¼ Ð²Ð°Ð¼ Ð¾Ð´Ð½Ð¾Ñ€Ð°Ð·Ð¾Ð²ÑƒÑŽ Ð²Ñ‹Ð¿Ð»Ð°Ñ‚Ñƒ Ð² Ñ€Ð°Ð·Ð¼ÐµÑ€Ðµ {robuxAmount}.{newLine}{newLine}Ð—Ð°Ð¹Ð´Ð¸Ñ‚Ðµ Ð² ÑÐ²Ð¾ÑŽ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð¿Ð¾Ð»ÑƒÑ‡Ð¸Ñ‚ÑŒ Ð¿Ð¾Ð´Ñ€Ð¾Ð±Ð½Ñ‹Ðµ ÑÐ²ÐµÐ´ÐµÐ½Ð¸Ñ Ð¾ Ð²Ñ‹Ð¿Ð»Ð°Ñ‚Ðµ Robux Ð¸ Ð¿Ð¾Ð´Ð¿Ð¸ÑÐºÐµ ÐŸÑ€ÐµÐ¼Ð¸ÑƒÐ¼.  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"Ð§ÐµÐ¼ Ð´Ð°Ð»ÑŒÑˆÐµ Ð¿Ñ€Ð¾Ð´Ð²Ð¸Ð³Ð°ÐµÑ‚ÑÑ Ð¿Ð¾Ð´Ð¿Ð¸ÑÑ‡Ð¸Ðº, Ñ‚ÐµÐ¼ Ð±Ð¾Ð»ÑŒÑˆÐµ Ð²Ð¾Ð·Ñ€Ð°ÑÑ‚Ð°ÐµÑ‚ ÐµÐ³Ð¾ ÐµÐ¶ÐµÐ¼ÐµÑÑÑ‡Ð½Ð¾Ðµ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½Ð¸Ðµ Robux Ð²Ð¼ÐµÑÑ‚Ð¾ ÐµÐ¶ÐµÐ´Ð½ÐµÐ²Ð½Ð¾Ð³Ð¾. Ð¡ÐµÐ³Ð¾Ð´Ð½Ñ Ð¼Ñ‹ Ð¿ÐµÑ€ÐµÐ²Ð¾Ð´Ð¸Ð¼ {robuxAmount} Robux Ð½Ð° Ð²Ð°ÑˆÑƒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð¿Ð¾Ð¿Ð¾Ð»Ð½Ð¸Ñ‚ÑŒ Ð²Ð°Ñˆ ÑÑ‡ÐµÑ‚ Ð·Ð° Ñ‚ÐµÐºÑƒÑ‰Ð¸Ð¹ Ð¼ÐµÑÑÑ†.\n{newLine}{newLine}\nÐŸÑ€Ð¾Ð²ÐµÑ€ÑŒÑ‚Ðµ Ð²Ð°ÑˆÑƒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox.  ";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "Ð§ÐµÐ¼ Ð´Ð°Ð»ÑŒÑˆÐµ Ð¿Ñ€Ð¾Ð´Ð²Ð¸Ð³Ð°ÐµÑ‚ÑÑ Ð¿Ð¾Ð´Ð¿Ð¸ÑÑ‡Ð¸Ðº, Ñ‚ÐµÐ¼ Ð±Ð¾Ð»ÑŒÑˆÐµ Ð²Ð¾Ð·Ñ€Ð°ÑÑ‚Ð°ÐµÑ‚ ÐµÐ³Ð¾ ÐµÐ¶ÐµÐ¼ÐµÑÑÑ‡Ð½Ð¾Ðµ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½Ð¸Ðµ Robux Ð²Ð¼ÐµÑÑ‚Ð¾ ÐµÐ¶ÐµÐ´Ð½ÐµÐ²Ð½Ð¾Ð³Ð¾. Ð¡ÐµÐ³Ð¾Ð´Ð½Ñ Ð¼Ñ‹ Ð¿ÐµÑ€ÐµÐ²Ð¾Ð´Ð¸Ð¼ {robuxAmount} Robux Ð½Ð° Ð²Ð°ÑˆÑƒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð¿Ð¾Ð¿Ð¾Ð»Ð½Ð¸Ñ‚ÑŒ Ð²Ð°Ñˆ ÑÑ‡ÐµÑ‚ Ð·Ð° Ñ‚ÐµÐºÑƒÑ‰Ð¸Ð¹ Ð¼ÐµÑÑÑ†.\n{newLine}{newLine}\nÐŸÑ€Ð¾Ð²ÐµÑ€ÑŒÑ‚Ðµ Ð²Ð°ÑˆÑƒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox.  ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "ÐšÐ»ÑƒÐ± ÑÐ¾Ð·Ð´Ð°Ñ‚ÐµÐ»ÐµÐ¹ Ñ‚ÐµÐ¿ÐµÑ€ÑŒ ÑÑ‚Ð°Ð» Roblox ÐŸÑ€ÐµÐ¼Ð¸ÑƒÐ¼";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, weâ€™re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"Ð§ÐµÐ¼ Ð´Ð°Ð»ÑŒÑˆÐµ Ð¿Ñ€Ð¾Ð´Ð²Ð¸Ð³Ð°ÐµÑ‚ÑÑ Ð¿Ð¾Ð´Ð¿Ð¸ÑÑ‡Ð¸Ðº, Ñ‚ÐµÐ¼ Ð±Ð¾Ð»ÑŒÑˆÐµ Ð²Ð¾Ð·Ñ€Ð°ÑÑ‚Ð°ÐµÑ‚ ÐµÐ³Ð¾ ÐµÐ¶ÐµÐ¼ÐµÑÑÑ‡Ð½Ð¾Ðµ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½Ð¸Ðµ Robux Ð²Ð¼ÐµÑÑ‚Ð¾ ÐµÐ¶ÐµÐ´Ð½ÐµÐ²Ð½Ð¾Ð³Ð¾. Ð¡ÐµÐ³Ð¾Ð´Ð½Ñ Ð¼Ñ‹ Ð¿ÐµÑ€ÐµÐ²Ð¾Ð´Ð¸Ð¼ {robuxAmount} Robux Ð½Ð° Ð²Ð°ÑˆÑƒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð¿Ð¾Ð¿Ð¾Ð»Ð½Ð¸Ñ‚ÑŒ Ð²Ð°Ñˆ ÑÑ‡ÐµÑ‚ Ð·Ð° Ñ‚ÐµÐºÑƒÑ‰Ð¸Ð¹ Ð¼ÐµÑÑÑ†.\n\nÐŸÑ€Ð¾Ð²ÐµÑ€ÑŒÑ‚Ðµ Ð²Ð°ÑˆÑƒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox.";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "Ð§ÐµÐ¼ Ð´Ð°Ð»ÑŒÑˆÐµ Ð¿Ñ€Ð¾Ð´Ð²Ð¸Ð³Ð°ÐµÑ‚ÑÑ Ð¿Ð¾Ð´Ð¿Ð¸ÑÑ‡Ð¸Ðº, Ñ‚ÐµÐ¼ Ð±Ð¾Ð»ÑŒÑˆÐµ Ð²Ð¾Ð·Ñ€Ð°ÑÑ‚Ð°ÐµÑ‚ ÐµÐ³Ð¾ ÐµÐ¶ÐµÐ¼ÐµÑÑÑ‡Ð½Ð¾Ðµ Ð¿Ð¾Ð»ÑƒÑ‡ÐµÐ½Ð¸Ðµ Robux Ð²Ð¼ÐµÑÑ‚Ð¾ ÐµÐ¶ÐµÐ´Ð½ÐµÐ²Ð½Ð¾Ð³Ð¾. Ð¡ÐµÐ³Ð¾Ð´Ð½Ñ Ð¼Ñ‹ Ð¿ÐµÑ€ÐµÐ²Ð¾Ð´Ð¸Ð¼ {robuxAmount} Robux Ð½Ð° Ð²Ð°ÑˆÑƒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ, Ñ‡Ñ‚Ð¾Ð±Ñ‹ Ð¿Ð¾Ð¿Ð¾Ð»Ð½Ð¸Ñ‚ÑŒ Ð²Ð°Ñˆ ÑÑ‡ÐµÑ‚ Ð·Ð° Ñ‚ÐµÐºÑƒÑ‰Ð¸Ð¹ Ð¼ÐµÑÑÑ†.\n\nÐŸÑ€Ð¾Ð²ÐµÑ€ÑŒÑ‚Ðµ Ð²Ð°ÑˆÑƒ ÑƒÑ‡ÐµÑ‚Ð½ÑƒÑŽ Ð·Ð°Ð¿Ð¸ÑÑŒ Roblox.";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "ÐšÐ»ÑƒÐ± ÑÐ¾Ð·Ð´Ð°Ñ‚ÐµÐ»ÐµÐ¹ Ñ‚ÐµÐ¿ÐµÑ€ÑŒ ÑÑ‚Ð°Ð» Roblox ÐŸÑ€ÐµÐ¼Ð¸ÑƒÐ¼";
	}
}


}
