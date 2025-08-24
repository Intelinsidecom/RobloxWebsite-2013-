namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameDetailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameDetailsResources_ko_kr : GameDetailsResources_en_us, IGameDetailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ShareGameToChat"
	/// English String: "Share to chat"
	/// </summary>
	public override string ActionShareGameToChat => "공유 및 채팅";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "설명";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public override string HeadingRecommendedGames => "추천 게임";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "소개";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopyingCheckbox => "복사 허용";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public override string LabelAllowedGear => "허용된 장비";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public override string LabelBy => "개발:";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public override string LabelCopyingTitle => "복사 중";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "개발 완료";

	/// <summary>
	/// Key: "Label.ExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public override string LabelExperimentalMode => "실험 모드";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Number users who added this game to favorites
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "즐겨찾기";

	/// <summary>
	/// Key: "Label.GameCopyLocked"
	/// English String: "This game is copylocked"
	/// </summary>
	public override string LabelGameCopyLocked => "복제 방지된 게임입니다";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public override string LabelGameDoesNotSell => "이용 가능한 가상 아이템이나 파워업이 없어요.";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public override string LabelGameRequiresBuildersClub => "본 게임은 Builders Club이 필요합니다";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelGenre => "장르";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public override string LabelLeaderboards => "리더보드";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public override string LabelMaxPlayers => "최대 인원";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public override string LabelNoRunningGames => "현재 실행 중인 게임이 없습니다.";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public override string LabelPlaceCopyingAllowed => "본 게임의 소스는 복사할 수 있어요.";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "플레이 중";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public override string LabelPrivateSource => "비공개 소스";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public override string LabelPrivateSourceDescription => "소스가 비공개인 게임입니다";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public override string LabelPublicPrivateSourceCheckBox => "본 확인란을 선택하면 약관에 따라 회원님의 콘텐츠를 Roblox의 모든 사용자가 다양한 방식으로 사용할 수 있게 됩니다. 사용을 허락하지 않으려면 확인란을 선택 해제하세요.";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public override string LabelPublicSource => "공개 소스";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public override string LabelPublicSourceDescription => "소스가 공개인 게임입니다";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "신고하기";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "서버";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public override string LabelStore => "상점";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "업데이트";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "방문";

	public GameDetailsResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShareGameToChat()
	{
		return "공유 및 채팅";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"본 확인란을 선택하면 회원님이 지금 공유하려는 콘텐츠를 {boldTagStart}Roblox의 모든 사용자가 다양한 방식으로 사용할 수 있게 됩니다{boldTagEnd}. {boldTagStart2}사용을 허락하지 않으려면 확인란을 선택하지 마세요{boldTagEnd2}. 콘텐츠 공유에 관한 자세한 정보는 Roblox {linkStart}이용 약관{linkEnd}을 참고하세요.";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "본 확인란을 선택하면 회원님이 지금 공유하려는 콘텐츠를 {boldTagStart}Roblox의 모든 사용자가 다양한 방식으로 사용할 수 있게 됩니다{boldTagEnd}. {boldTagStart2}사용을 허락하지 않으려면 확인란을 선택하지 마세요{boldTagEnd2}. 콘텐츠 공유에 관한 자세한 정보는 Roblox {linkStart}이용 약관{linkEnd}을 참고하세요.";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "설명";
	}

	protected override string _GetTemplateForHeadingRecommendedGames()
	{
		return "추천 게임";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "소개";
	}

	protected override string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "복사 허용";
	}

	protected override string _GetTemplateForLabelAllowedGear()
	{
		return "허용된 장비";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "개발:";
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
		return "복사 중";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "개발 완료";
	}

	protected override string _GetTemplateForLabelExperimentalMode()
	{
		return "실험 모드";
	}

	/// <summary>
	/// Key: "Label.ExperimentalWarning"
	/// English String: "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game."
	/// </summary>
	public override string LabelExperimentalWarning(string aTagStartWithHref, string ExperimentalGamesInfoLink, string hrefEnd, string aTagEnd)
	{
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}게임이 제대로 작동하지 않을 수도 있어요.{aTagEnd} 개발자가 게임을 업데이트해야 합니다.";
	}

	protected override string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}게임이 제대로 작동하지 않을 수도 있어요.{aTagEnd} 개발자가 게임을 업데이트해야 합니다.";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "즐겨찾기";
	}

	protected override string _GetTemplateForLabelGameCopyLocked()
	{
		return "복제 방지된 게임입니다";
	}

	protected override string _GetTemplateForLabelGameDoesNotSell()
	{
		return "이용 가능한 가상 아이템이나 파워업이 없어요.";
	}

	protected override string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "본 게임은 Builders Club이 필요합니다";
	}

	protected override string _GetTemplateForLabelGenre()
	{
		return "장르";
	}

	protected override string _GetTemplateForLabelLeaderboards()
	{
		return "리더보드";
	}

	protected override string _GetTemplateForLabelMaxPlayers()
	{
		return "최대 인원";
	}

	protected override string _GetTemplateForLabelNoRunningGames()
	{
		return "현재 실행 중인 게임이 없습니다.";
	}

	protected override string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "본 게임의 소스는 복사할 수 있어요.";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "플레이 중";
	}

	protected override string _GetTemplateForLabelPrivateSource()
	{
		return "비공개 소스";
	}

	protected override string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "소스가 비공개인 게임입니다";
	}

	protected override string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "본 확인란을 선택하면 약관에 따라 회원님의 콘텐츠를 Roblox의 모든 사용자가 다양한 방식으로 사용할 수 있게 됩니다. 사용을 허락하지 않으려면 확인란을 선택 해제하세요.";
	}

	protected override string _GetTemplateForLabelPublicSource()
	{
		return "공개 소스";
	}

	protected override string _GetTemplateForLabelPublicSourceDescription()
	{
		return "소스가 공개인 게임입니다";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "신고하기";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "서버";
	}

	protected override string _GetTemplateForLabelStore()
	{
		return "상점";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "업데이트";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "방문";
	}
}
