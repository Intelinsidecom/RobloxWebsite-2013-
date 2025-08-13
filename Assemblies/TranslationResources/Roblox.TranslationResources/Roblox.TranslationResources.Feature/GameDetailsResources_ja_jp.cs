namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameDetailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameDetailsResources_ja_jp : GameDetailsResources_en_us, IGameDetailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ShareGameToChat"
	/// English String: "Share to chat"
	/// </summary>
	public override string ActionShareGameToChat => "シェアしてチャットする";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "詳細";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public override string HeadingRecommendedGames => "おすすめのゲーム";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "情報";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopyingCheckbox => "コピーを許可";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public override string LabelAllowedGear => "許可されたギア";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public override string LabelBy => "作：";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public override string LabelCopyingTitle => "コピー中";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "作成日";

	/// <summary>
	/// Key: "Label.ExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public override string LabelExperimentalMode => "試験モード";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Number users who added this game to favorites
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "お気に入り";

	/// <summary>
	/// Key: "Label.GameCopyLocked"
	/// English String: "This game is copylocked"
	/// </summary>
	public override string LabelGameCopyLocked => "このゲームはコピーガード仕様です";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public override string LabelGameDoesNotSell => "バーチャルアイテムやパワーアップはありません。";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public override string LabelGameRequiresBuildersClub => "このゲームにはBuilders Clubが必須です";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelGenre => "ジャンル";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public override string LabelLeaderboards => "リーダーボード";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public override string LabelMaxPlayers => "最大プレイヤー数";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public override string LabelNoRunningGames => "実行中のゲームはありません。";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public override string LabelPlaceCopyingAllowed => "このゲームのソースはコピーできます。";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "プレイ中";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public override string LabelPrivateSource => "非公開ソース";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public override string LabelPrivateSourceDescription => "このゲームのソースは非公開です";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public override string LabelPublicPrivateSourceCheckBox => "このチェックボックスにチェックを付けたままにしておくことで、他のすべてのRobloxユーザーに対して、利用規約に基づき、現在作成中のコンテンツを（さまざまな方法で）使用する権利を与えることに同意したものとみなされます。権利を与えることに同意しない場合、このボックスのチェックを外してください。";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public override string LabelPublicSource => "公開ソース";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public override string LabelPublicSourceDescription => "このゲームのソースは公開されています";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "規約違反を報告";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "サーバー";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public override string LabelStore => "ストア";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "アップデート済み";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "訪問数";

	public GameDetailsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShareGameToChat()
	{
		return "シェアしてチャットする";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"このボックスにチェックを付けることで、{boldTagStart}他のすべてのRobloxユーザーに対して、現在シェアしているコンテンツを（さまざまな方法で）使用する権利を与えることに同意{boldTagEnd}したものとみなされます。{boldTagStart2}権利を与えることに同意しない場合、このボックスのチェックを外してください。{boldTagEnd2}コンテンツのシェアについての詳細は、Robloxの{linkStart}利用規約{linkEnd}を確認してください。";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "このボックスにチェックを付けることで、{boldTagStart}他のすべてのRobloxユーザーに対して、現在シェアしているコンテンツを（さまざまな方法で）使用する権利を与えることに同意{boldTagEnd}したものとみなされます。{boldTagStart2}権利を与えることに同意しない場合、このボックスのチェックを外してください。{boldTagEnd2}コンテンツのシェアについての詳細は、Robloxの{linkStart}利用規約{linkEnd}を確認してください。";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "詳細";
	}

	protected override string _GetTemplateForHeadingRecommendedGames()
	{
		return "おすすめのゲーム";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "情報";
	}

	protected override string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "コピーを許可";
	}

	protected override string _GetTemplateForLabelAllowedGear()
	{
		return "許可されたギア";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "作：";
	}

	/// <summary>
	/// Key: "Label.ByCreator"
	/// English String: "{byText} {creatorLink}"
	/// </summary>
	public override string LabelByCreator(string byText, string creatorLink)
	{
		return $"{byText} {creatorLink}";
	}

	protected override string _GetTemplateForLabelByCreator()
	{
		return "{byText} {creatorLink}";
	}

	protected override string _GetTemplateForLabelCopyingTitle()
	{
		return "コピー中";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "作成日";
	}

	protected override string _GetTemplateForLabelExperimentalMode()
	{
		return "試験モード";
	}

	/// <summary>
	/// Key: "Label.ExperimentalWarning"
	/// English String: "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game."
	/// </summary>
	public override string LabelExperimentalWarning(string aTagStartWithHref, string ExperimentalGamesInfoLink, string hrefEnd, string aTagEnd)
	{
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}ゲームが正しく機能しない可能性があります。{aTagEnd}開発者のゲームアップデートが必要です。";
	}

	protected override string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}ゲームが正しく機能しない可能性があります。{aTagEnd}開発者のゲームアップデートが必要です。";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "お気に入り";
	}

	protected override string _GetTemplateForLabelGameCopyLocked()
	{
		return "このゲームはコピーガード仕様です";
	}

	protected override string _GetTemplateForLabelGameDoesNotSell()
	{
		return "バーチャルアイテムやパワーアップはありません。";
	}

	protected override string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "このゲームにはBuilders Clubが必須です";
	}

	protected override string _GetTemplateForLabelGenre()
	{
		return "ジャンル";
	}

	protected override string _GetTemplateForLabelLeaderboards()
	{
		return "リーダーボード";
	}

	protected override string _GetTemplateForLabelMaxPlayers()
	{
		return "最大プレイヤー数";
	}

	protected override string _GetTemplateForLabelNoRunningGames()
	{
		return "実行中のゲームはありません。";
	}

	protected override string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "このゲームのソースはコピーできます。";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "プレイ中";
	}

	protected override string _GetTemplateForLabelPrivateSource()
	{
		return "非公開ソース";
	}

	protected override string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "このゲームのソースは非公開です";
	}

	protected override string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "このチェックボックスにチェックを付けたままにしておくことで、他のすべてのRobloxユーザーに対して、利用規約に基づき、現在作成中のコンテンツを（さまざまな方法で）使用する権利を与えることに同意したものとみなされます。権利を与えることに同意しない場合、このボックスのチェックを外してください。";
	}

	protected override string _GetTemplateForLabelPublicSource()
	{
		return "公開ソース";
	}

	protected override string _GetTemplateForLabelPublicSourceDescription()
	{
		return "このゲームのソースは公開されています";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "規約違反を報告";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "サーバー";
	}

	protected override string _GetTemplateForLabelStore()
	{
		return "ストア";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "アップデート済み";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "訪問数";
	}
}
