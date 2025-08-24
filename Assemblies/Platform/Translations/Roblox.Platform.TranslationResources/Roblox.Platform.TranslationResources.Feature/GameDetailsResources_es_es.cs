namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameDetailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameDetailsResources_es_es : GameDetailsResources_en_us, IGameDetailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ShareGameToChat"
	/// English String: "Share to chat"
	/// </summary>
	public override string ActionShareGameToChat => "Compartir en el chat";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "Descripción";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public override string HeadingRecommendedGames => "Juegos recomendados";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Info.";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopyingCheckbox => "Permitir copiar";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public override string LabelAllowedGear => "Equip. permitido";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public override string LabelBy => "De";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public override string LabelCopyingTitle => "Copia";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "Creado";

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
	public override string LabelGameCopyLocked => "Este juego tiene bloqueo anticopia";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public override string LabelGameDoesNotSell => "No hay objetos virtuales o potenciadores disponibles.";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public override string LabelGameRequiresBuildersClub => "Este juego requiere Builders Club";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelGenre => "Género";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public override string LabelLeaderboards => "Clasificación";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public override string LabelMaxPlayers => "Máx. de jugadores";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public override string LabelNoRunningGames => "En este momento no hay partidas en curso.";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public override string LabelPlaceCopyingAllowed => "La fuente de este juego se puede copiar.";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "Jugando";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public override string LabelPrivateSource => "Fuente privada";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public override string LabelPrivateSourceDescription => "La fuente de este juego es privada";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public override string LabelPublicPrivateSourceCheckBox => "Al dejar activada esta casilla, permitirás que todos los usuarios de Roblox utilicen (de varias maneras) el contenido que pones a disposición, como se describe en los términos. Si no quieres otorgar este derecho, desactiva la casilla.";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public override string LabelPublicSource => "Fuente pública";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public override string LabelPublicSourceDescription => "La fuente de este juego es pública";

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
	public override string LabelStore => "Tienda";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "Actualizado";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "Visitas";

	public GameDetailsResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShareGameToChat()
	{
		return "Compartir en el chat";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"Al activar esta casilla, {boldTagStart}otorgarás a todos los usuarios de Roblox el derecho a utilizar{boldTagEnd} (de varias maneras) el contenido que compartes. {boldTagStart2}Si no quieres otorgarlo, no la actives{boldTagEnd2}. Para obtener más información sobre cómo se comparte el contenido, revisa los {linkStart}Términos de uso{linkEnd} de Roblox.";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "Al activar esta casilla, {boldTagStart}otorgarás a todos los usuarios de Roblox el derecho a utilizar{boldTagEnd} (de varias maneras) el contenido que compartes. {boldTagStart2}Si no quieres otorgarlo, no la actives{boldTagEnd2}. Para obtener más información sobre cómo se comparte el contenido, revisa los {linkStart}Términos de uso{linkEnd} de Roblox.";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "Descripción";
	}

	protected override string _GetTemplateForHeadingRecommendedGames()
	{
		return "Juegos recomendados";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Info.";
	}

	protected override string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "Permitir copiar";
	}

	protected override string _GetTemplateForLabelAllowedGear()
	{
		return "Equip. permitido";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "De";
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
		return "Copia";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "Creado";
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
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}Este juego puede que no funcione como previsto.{aTagEnd} El desarrollador necesita actualizarlo.";
	}

	protected override string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}Este juego puede que no funcione como previsto.{aTagEnd} El desarrollador necesita actualizarlo.";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "Favoritos";
	}

	protected override string _GetTemplateForLabelGameCopyLocked()
	{
		return "Este juego tiene bloqueo anticopia";
	}

	protected override string _GetTemplateForLabelGameDoesNotSell()
	{
		return "No hay objetos virtuales o potenciadores disponibles.";
	}

	protected override string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "Este juego requiere Builders Club";
	}

	protected override string _GetTemplateForLabelGenre()
	{
		return "Género";
	}

	protected override string _GetTemplateForLabelLeaderboards()
	{
		return "Clasificación";
	}

	protected override string _GetTemplateForLabelMaxPlayers()
	{
		return "Máx. de jugadores";
	}

	protected override string _GetTemplateForLabelNoRunningGames()
	{
		return "En este momento no hay partidas en curso.";
	}

	protected override string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "La fuente de este juego se puede copiar.";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "Jugando";
	}

	protected override string _GetTemplateForLabelPrivateSource()
	{
		return "Fuente privada";
	}

	protected override string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "La fuente de este juego es privada";
	}

	protected override string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "Al dejar activada esta casilla, permitirás que todos los usuarios de Roblox utilicen (de varias maneras) el contenido que pones a disposición, como se describe en los términos. Si no quieres otorgar este derecho, desactiva la casilla.";
	}

	protected override string _GetTemplateForLabelPublicSource()
	{
		return "Fuente pública";
	}

	protected override string _GetTemplateForLabelPublicSourceDescription()
	{
		return "La fuente de este juego es pública";
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
		return "Tienda";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "Actualizado";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "Visitas";
	}
}
