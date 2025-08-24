namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameDetailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameDetailsResources_fr_fr : GameDetailsResources_en_us, IGameDetailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ShareGameToChat"
	/// English String: "Share to chat"
	/// </summary>
	public override string ActionShareGameToChat => "Partager dans le chat";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "Description";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public override string HeadingRecommendedGames => "Jeux recommandés";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "À propos";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopyingCheckbox => "Autoriser la copie";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public override string LabelAllowedGear => "Équipement autorisé";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public override string LabelBy => "Par";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public override string LabelCopyingTitle => "Copie";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "Créé";

	/// <summary>
	/// Key: "Label.ExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public override string LabelExperimentalMode => "Mode expérimental";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Number users who added this game to favorites
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "En favoris";

	/// <summary>
	/// Key: "Label.GameCopyLocked"
	/// English String: "This game is copylocked"
	/// </summary>
	public override string LabelGameCopyLocked => "Impossible de copier ce jeu";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public override string LabelGameDoesNotSell => "Aucun objet virtuel ou power-up disponible.";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public override string LabelGameRequiresBuildersClub => "Ce jeu nécessite le Builders Club.";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelGenre => "Genre";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public override string LabelLeaderboards => "Classements";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public override string LabelMaxPlayers => "Joueurs max.";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public override string LabelNoRunningGames => "Aucun jeu actuellement en cours.";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public override string LabelPlaceCopyingAllowed => "La source de ce jeu peut être copiée.";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "En jeu";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public override string LabelPrivateSource => "Source privée";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public override string LabelPrivateSourceDescription => "La source de ce jeu est privée.";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public override string LabelPublicPrivateSourceCheckBox => "En cochant cette case, vous autorisez tous les autres utilisateurs de Roblox à utiliser (de plusieurs façons) le contenu que vous rendez disponible, tel qu'indiqué dans les Conditions d'utilisation. Si vous ne souhaitez pas leur accorder ce droit, veuillez décocher cette case.";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public override string LabelPublicSource => "Source publique";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public override string LabelPublicSourceDescription => "La source de ce jeu est publique.";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "Signaler un comportement abusif";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "Serveurs";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public override string LabelStore => "Boutique";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "Mis à jour";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "Visites";

	public GameDetailsResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShareGameToChat()
	{
		return "Partager dans le chat";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"En cochant cette case, {boldTagStart}vous autorisez tous les autres utilisateurs de Roblox à utiliser{boldTagEnd} (de plusieurs façons) le contenu que vous rendez disponible. {boldTagStart2}Si vous ne souhaitez pas leur accorder ce droit, veuillez décocher cette case{boldTagEnd2}. Pour plus d'informations à propos du partage de contenu, veuillez consulter les {linkStart}Conditions d'utilisation{linkEnd} de Roblox.";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "En cochant cette case, {boldTagStart}vous autorisez tous les autres utilisateurs de Roblox à utiliser{boldTagEnd} (de plusieurs façons) le contenu que vous rendez disponible. {boldTagStart2}Si vous ne souhaitez pas leur accorder ce droit, veuillez décocher cette case{boldTagEnd2}. Pour plus d'informations à propos du partage de contenu, veuillez consulter les {linkStart}Conditions d'utilisation{linkEnd} de Roblox.";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "Description";
	}

	protected override string _GetTemplateForHeadingRecommendedGames()
	{
		return "Jeux recommandés";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "À propos";
	}

	protected override string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "Autoriser la copie";
	}

	protected override string _GetTemplateForLabelAllowedGear()
	{
		return "Équipement autorisé";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "Par";
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
		return "Copie";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "Créé";
	}

	protected override string _GetTemplateForLabelExperimentalMode()
	{
		return "Mode expérimental";
	}

	/// <summary>
	/// Key: "Label.ExperimentalWarning"
	/// English String: "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game."
	/// </summary>
	public override string LabelExperimentalWarning(string aTagStartWithHref, string ExperimentalGamesInfoLink, string hrefEnd, string aTagEnd)
	{
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}Ce jeu peut comporter des erreurs.{aTagEnd} Le développeur doit mettre à jour sa version du jeu.";
	}

	protected override string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}Ce jeu peut comporter des erreurs.{aTagEnd} Le développeur doit mettre à jour sa version du jeu.";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "En favoris";
	}

	protected override string _GetTemplateForLabelGameCopyLocked()
	{
		return "Impossible de copier ce jeu";
	}

	protected override string _GetTemplateForLabelGameDoesNotSell()
	{
		return "Aucun objet virtuel ou power-up disponible.";
	}

	protected override string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "Ce jeu nécessite le Builders Club.";
	}

	protected override string _GetTemplateForLabelGenre()
	{
		return "Genre";
	}

	protected override string _GetTemplateForLabelLeaderboards()
	{
		return "Classements";
	}

	protected override string _GetTemplateForLabelMaxPlayers()
	{
		return "Joueurs max.";
	}

	protected override string _GetTemplateForLabelNoRunningGames()
	{
		return "Aucun jeu actuellement en cours.";
	}

	protected override string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "La source de ce jeu peut être copiée.";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "En jeu";
	}

	protected override string _GetTemplateForLabelPrivateSource()
	{
		return "Source privée";
	}

	protected override string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "La source de ce jeu est privée.";
	}

	protected override string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "En cochant cette case, vous autorisez tous les autres utilisateurs de Roblox à utiliser (de plusieurs façons) le contenu que vous rendez disponible, tel qu'indiqué dans les Conditions d'utilisation. Si vous ne souhaitez pas leur accorder ce droit, veuillez décocher cette case.";
	}

	protected override string _GetTemplateForLabelPublicSource()
	{
		return "Source publique";
	}

	protected override string _GetTemplateForLabelPublicSourceDescription()
	{
		return "La source de ce jeu est publique.";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "Signaler un comportement abusif";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "Serveurs";
	}

	protected override string _GetTemplateForLabelStore()
	{
		return "Boutique";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "Mis à jour";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "Visites";
	}
}
