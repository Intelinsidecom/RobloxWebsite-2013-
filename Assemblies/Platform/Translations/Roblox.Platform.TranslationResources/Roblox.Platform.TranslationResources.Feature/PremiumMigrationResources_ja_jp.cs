namespace Roblox.TranslationResources.Feature;

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
	public override string HeadingMigrationTitle => "Builders Clubは現在はRobloxプレミアムです";

	/// <summary>
	/// Key: "PopUp.Title"
	/// As in, "The program formerly known as Builder's Club is now called Premium."
	/// English String: "Builders Club is now Roblox Premium"
	/// </summary>
	public override string PopUpTitle => "Builders Clubは現在はRobloxプレミアムです";

	public PremiumMigrationResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	/// <summary>
	/// Key: "Description.MigrationBody"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}\n\nCheck your Roblox inbox to learn more about your Robux payout and Premium subscription. "
	/// </summary>
	public override string DescriptionMigrationBody(string robuxAmount)
	{
		return $"プレミアムでは、一日に利用できるRobuxの額を設定せず、一ヶ月ごとにご利用できる総額を一度にお渡しします。今日は、一回で {robuxAmount} のペイアウトをお渡しします。\n\nRobuxペイアウトとプレミアムサブスクリプションについて詳しく知るには、Roblox受信トレイをチェックしてください。 ";
	}

	protected override string _GetTemplateForDescriptionMigrationBody()
	{
		return "プレミアムでは、一日に利用できるRobuxの額を設定せず、一ヶ月ごとにご利用できる総額を一度にお渡しします。今日は、一回で {robuxAmount} のペイアウトをお渡しします。\n\nRobuxペイアウトとプレミアムサブスクリプションについて詳しく知るには、Roblox受信トレイをチェックしてください。 ";
	}

	/// <summary>
	/// Key: "Description.MigrationContent"
	/// obsoleted
	/// English String: "Premium now gives you a monthly allowance of Robux all at once, instead of a daily allowance! Today we’re giving you a one time payout of {robuxAmount}.{newLine}{newLine}Check your Roblox inbox to learn more about your Robux payout and Premium subscription.  "
	/// </summary>
	public override string DescriptionMigrationContent(string robuxAmount, string newLine)
	{
		return $"プレミアムでは、一日に利用できるRobuxの額を設定せず、一ヶ月ごとにご利用できる総額を一度にお渡しします。今日は、一回で {robuxAmount}のペイアウトをお渡しします。{newLine}{newLine}Robuxペイアウトとプレミアムサブスクリプションについて詳しく知るには、Roblox受信トレイをチェックしてください。  ";
	}

	protected override string _GetTemplateForDescriptionMigrationContent()
	{
		return "プレミアムでは、一日に利用できるRobuxの額を設定せず、一ヶ月ごとにご利用できる総額を一度にお渡しします。今日は、一回で {robuxAmount}のペイアウトをお渡しします。{newLine}{newLine}Robuxペイアウトとプレミアムサブスクリプションについて詳しく知るには、Roblox受信トレイをチェックしてください。  ";
	}

	/// <summary>
	/// Key: "Description.MigrationMesg"
	/// obsoleted
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n{newLine}{newLine}\nCheck your Roblox Inbox for more details.  "
	/// </summary>
	public override string DescriptionMigrationMesg(string robuxAmount, string newLine)
	{
		return $"これからは、サブスクリプション契約者は一日ごとのRobux額ではなく、一ヶ月にご利用できる全額を一度にお支払いします。今日は、お持ちのアカウントに今月お渡しする予定だった残りの {robuxAmount} Robuxをお支払いします。\n{newLine}{newLine}\n詳しくは、Roblox受信トレイをチェックしてください。  ";
	}

	protected override string _GetTemplateForDescriptionMigrationMesg()
	{
		return "これからは、サブスクリプション契約者は一日ごとのRobux額ではなく、一ヶ月にご利用できる全額を一度にお支払いします。今日は、お持ちのアカウントに今月お渡しする予定だった残りの {robuxAmount} Robuxをお支払いします。\n{newLine}{newLine}\n詳しくは、Roblox受信トレイをチェックしてください。  ";
	}

	protected override string _GetTemplateForHeadingMigrationTitle()
	{
		return "Builders Clubは現在はRobloxプレミアムです";
	}

	/// <summary>
	/// Key: "PopUp.Body"
	/// English String: "Moving forward, subscribers will be granted a monthly lump sum of Robux instead of receiving it in daily increments. Today, we’re depositing {robuxAmount} Robux in your account to make up for the remaining amount you would have earned this month.\n\nCheck your Roblox Inbox for more details."
	/// </summary>
	public override string PopUpBody(string robuxAmount)
	{
		return $"これからは、サブスクリプション契約者は一日ごとのRobux額ではなく、一ヶ月ごとのご利用額を一度にお渡しします。今日は、お持ちのアカウントに今月お渡しする予定だった残りの {robuxAmount} Robuxをお支払いします。\n\n詳しくは、Roblox受信トレイをチェックしてください。";
	}

	protected override string _GetTemplateForPopUpBody()
	{
		return "これからは、サブスクリプション契約者は一日ごとのRobux額ではなく、一ヶ月ごとのご利用額を一度にお渡しします。今日は、お持ちのアカウントに今月お渡しする予定だった残りの {robuxAmount} Robuxをお支払いします。\n\n詳しくは、Roblox受信トレイをチェックしてください。";
	}

	protected override string _GetTemplateForPopUpTitle()
	{
		return "Builders Clubは現在はRobloxプレミアムです";
	}
}
