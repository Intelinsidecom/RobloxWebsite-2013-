namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameDetailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameDetailsResources_pt_br : GameDetailsResources_en_us, IGameDetailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ShareGameToChat"
	/// English String: "Share to chat"
	/// </summary>
	public override string ActionShareGameToChat => "Compartilhar no chat";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "Descrição";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public override string HeadingRecommendedGames => "Jogos recomendados";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Sobre";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopyingCheckbox => "Permitir cópia";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public override string LabelAllowedGear => "Equip. permitido";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public override string LabelBy => "De ";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public override string LabelCopyingTitle => "Cópia";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "Criado";

	/// <summary>
	/// Key: "Label.ExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public override string LabelExperimentalMode => "Modo experimental";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Number users who added this game to favorites
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "Favoritos";

	/// <summary>
	/// Key: "Label.GameCopyLocked"
	/// English String: "This game is copylocked"
	/// </summary>
	public override string LabelGameCopyLocked => "Este jogo possui bloqueio de cópia.";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public override string LabelGameDoesNotSell => "Nenhum poder ou item virtual disponível.";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public override string LabelGameRequiresBuildersClub => "Este jogo requer o Builders Club";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelGenre => "Gênero";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public override string LabelLeaderboards => "Classificação";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public override string LabelMaxPlayers => "Máx. de jogadores";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public override string LabelNoRunningGames => "Não há jogos rodando no momento.";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public override string LabelPlaceCopyingAllowed => "A fonte desse jogo pode ser copiada.";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "Jogando";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public override string LabelPrivateSource => "Fonte privada";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public override string LabelPrivateSourceDescription => "A fonte desse jogo é privada";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public override string LabelPublicPrivateSourceCheckBox => "Ao deixar esta caixa de seleção marcada, você está permitindo que outros usuários do Roblox utilizem (de várias maneiras) o conteúdo que você está disponibilizando, como definido nos Termos. Se você não quiser conceder este direito, desmarque esta caixa de seleção.";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public override string LabelPublicSource => "Fonte pública";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public override string LabelPublicSourceDescription => "A fonte desse jogo é pública";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "Denunciar abuso";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "Servidores";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public override string LabelStore => "Loja";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "Atualizado";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "Visitas";

	public GameDetailsResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShareGameToChat()
	{
		return "Compartilhar no chat";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"Ao marcar esta caixa de seleção, {boldTagStart}você está permitindo que outros usuários do Roblox utilizem{boldTagEnd} (de várias maneiras) o conteúdo que você está compartilhando. {boldTagStart2}Se você não quiser conceder este direito, não marque esta caixa de seleção{boldTagEnd2}. Para mais informações sobre o compartilhamento de conteúdo, consulte os {linkStart}Termos de Uso{linkEnd} do Roblox.";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "Ao marcar esta caixa de seleção, {boldTagStart}você está permitindo que outros usuários do Roblox utilizem{boldTagEnd} (de várias maneiras) o conteúdo que você está compartilhando. {boldTagStart2}Se você não quiser conceder este direito, não marque esta caixa de seleção{boldTagEnd2}. Para mais informações sobre o compartilhamento de conteúdo, consulte os {linkStart}Termos de Uso{linkEnd} do Roblox.";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "Descrição";
	}

	protected override string _GetTemplateForHeadingRecommendedGames()
	{
		return "Jogos recomendados";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Sobre";
	}

	protected override string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "Permitir cópia";
	}

	protected override string _GetTemplateForLabelAllowedGear()
	{
		return "Equip. permitido";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "De ";
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
		return "Cópia";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "Criado";
	}

	protected override string _GetTemplateForLabelExperimentalMode()
	{
		return "Modo experimental";
	}

	/// <summary>
	/// Key: "Label.ExperimentalWarning"
	/// English String: "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game."
	/// </summary>
	public override string LabelExperimentalWarning(string aTagStartWithHref, string ExperimentalGamesInfoLink, string hrefEnd, string aTagEnd)
	{
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}Este jogo pode não funcionar corretamente.{aTagEnd} O desenvolvedor precisa atualizar o jogo.";
	}

	protected override string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}Este jogo pode não funcionar corretamente.{aTagEnd} O desenvolvedor precisa atualizar o jogo.";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "Favoritos";
	}

	protected override string _GetTemplateForLabelGameCopyLocked()
	{
		return "Este jogo possui bloqueio de cópia.";
	}

	protected override string _GetTemplateForLabelGameDoesNotSell()
	{
		return "Nenhum poder ou item virtual disponível.";
	}

	protected override string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "Este jogo requer o Builders Club";
	}

	protected override string _GetTemplateForLabelGenre()
	{
		return "Gênero";
	}

	protected override string _GetTemplateForLabelLeaderboards()
	{
		return "Classificação";
	}

	protected override string _GetTemplateForLabelMaxPlayers()
	{
		return "Máx. de jogadores";
	}

	protected override string _GetTemplateForLabelNoRunningGames()
	{
		return "Não há jogos rodando no momento.";
	}

	protected override string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "A fonte desse jogo pode ser copiada.";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "Jogando";
	}

	protected override string _GetTemplateForLabelPrivateSource()
	{
		return "Fonte privada";
	}

	protected override string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "A fonte desse jogo é privada";
	}

	protected override string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "Ao deixar esta caixa de seleção marcada, você está permitindo que outros usuários do Roblox utilizem (de várias maneiras) o conteúdo que você está disponibilizando, como definido nos Termos. Se você não quiser conceder este direito, desmarque esta caixa de seleção.";
	}

	protected override string _GetTemplateForLabelPublicSource()
	{
		return "Fonte pública";
	}

	protected override string _GetTemplateForLabelPublicSourceDescription()
	{
		return "A fonte desse jogo é pública";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "Denunciar abuso";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "Servidores";
	}

	protected override string _GetTemplateForLabelStore()
	{
		return "Loja";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "Atualizado";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "Visitas";
	}
}
