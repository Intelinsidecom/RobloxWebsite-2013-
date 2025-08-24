namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides GameDetailsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class GameDetailsResources_de_de : GameDetailsResources_en_us, IGameDetailsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ShareGameToChat"
	/// English String: "Share to chat"
	/// </summary>
	public override string ActionShareGameToChat => "Im Chat teilen";

	/// <summary>
	/// Key: "Heading.Description"
	/// English String: "Description"
	/// </summary>
	public override string HeadingDescription => "Beschreibung";

	/// <summary>
	/// Key: "Heading.RecommendedGames"
	/// English String: "Recommended Games"
	/// </summary>
	public override string HeadingRecommendedGames => "Empfohlene Spiele";

	/// <summary>
	/// Key: "Label.About"
	/// English String: "About"
	/// </summary>
	public override string LabelAbout => "Info";

	/// <summary>
	/// Key: "Label.AllowCopyingCheckbox"
	/// Text for checkboxes configuring copying settings.
	/// English String: "Allow Copying"
	/// </summary>
	public override string LabelAllowCopyingCheckbox => "Kopieren erlauben";

	/// <summary>
	/// Key: "Label.AllowedGear"
	/// English String: "Allowed Gear"
	/// </summary>
	public override string LabelAllowedGear => "Erlaubte Ausrüstung";

	/// <summary>
	/// Key: "Label.By"
	/// English String: "By"
	/// </summary>
	public override string LabelBy => "Von";

	/// <summary>
	/// Key: "Label.CopyingTitle"
	/// Title applied to configuring copying settings.
	/// English String: "Copying"
	/// </summary>
	public override string LabelCopyingTitle => "Kopieren";

	/// <summary>
	/// Key: "Label.Created"
	/// English String: "Created"
	/// </summary>
	public override string LabelCreated => "Erstellt";

	/// <summary>
	/// Key: "Label.ExperimentalMode"
	/// English String: "Experimental Mode"
	/// </summary>
	public override string LabelExperimentalMode => "Experimentalmodus";

	/// <summary>
	/// Key: "Label.Favorites"
	/// Number users who added this game to favorites
	/// English String: "Favorites"
	/// </summary>
	public override string LabelFavorites => "Spielerfavoriten";

	/// <summary>
	/// Key: "Label.GameCopyLocked"
	/// English String: "This game is copylocked"
	/// </summary>
	public override string LabelGameCopyLocked => "Dieses Spiel ist kopiergeschützt.";

	/// <summary>
	/// Key: "Label.GameDoesNotSell"
	/// English String: "No virtual items or power-ups available."
	/// </summary>
	public override string LabelGameDoesNotSell => "Keine virtuellen Artikel oder Power-ups verfügbar.";

	/// <summary>
	/// Key: "Label.GameRequiresBuildersClub"
	/// English String: "This Game requires Builders Club"
	/// </summary>
	public override string LabelGameRequiresBuildersClub => "Für dieses Spiel ist eine „Builders Club“-Mitgliedschaft erforderlich.";

	/// <summary>
	/// Key: "Label.Genre"
	/// English String: "Genre"
	/// </summary>
	public override string LabelGenre => "Genre";

	/// <summary>
	/// Key: "Label.Leaderboards"
	/// English String: "Leaderboards"
	/// </summary>
	public override string LabelLeaderboards => "Bestenlisten";

	/// <summary>
	/// Key: "Label.MaxPlayers"
	/// English String: "Max Players"
	/// </summary>
	public override string LabelMaxPlayers => "Max. Spieler";

	/// <summary>
	/// Key: "Label.NoRunningGames"
	/// English String: "There are currently no running games."
	/// </summary>
	public override string LabelNoRunningGames => "Derzeit laufen keine Spiele.";

	/// <summary>
	/// Key: "Label.PlaceCopyingAllowed"
	/// Message displayed on a place details page if the place allows copying.
	/// English String: "This game's source can be copied."
	/// </summary>
	public override string LabelPlaceCopyingAllowed => "Das Quellmaterial dieses Spiels kann kopiert werden.";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public override string LabelPlaying => "Spieler";

	/// <summary>
	/// Key: "Label.PrivateSource"
	/// Name of the option to set a game's source as private.
	/// English String: "Private Source"
	/// </summary>
	public override string LabelPrivateSource => "Privates Quellmaterial";

	/// <summary>
	/// Key: "Label.PrivateSourceDescription"
	/// Player-facing description for a game with private source. This shows up under a game's description.
	/// English String: "This game's source is private"
	/// </summary>
	public override string LabelPrivateSourceDescription => "Das Quellmaterial dieses Spiels ist privat.";

	/// <summary>
	/// Key: "Label.PublicPrivateSourceCheckBox"
	/// Details the effects of making a game's source public.
	/// English String: "By leaving this checkbox checked, you are agreeing to allow every other user of Roblox the right to use (in various ways) the content you are now making available, as set out in the Terms. If you do not want to grant this right, please uncheck this box."
	/// </summary>
	public override string LabelPublicPrivateSourceCheckBox => "Wenn du dieses Kontrollkästchen aktiviert lässt, gewährst du allen anderen Roblox-Benutzern das Recht, die Inhalte, die du gerade zur Verfügung stellst, auf unterschiedliche Art und Weise und gemäß der Nutzungsbedingungen zu verwenden. Wenn du dieses Recht nicht gewähren möchtest, deaktiviere dieses Kontrollkästchen bitte.";

	/// <summary>
	/// Key: "Label.PublicSource"
	/// Name of the option to set a game's source as public.
	/// English String: "Public Source"
	/// </summary>
	public override string LabelPublicSource => "Öffentliches Quellmaterial";

	/// <summary>
	/// Key: "Label.PublicSourceDescription"
	/// Player-facing description for a game with public source. This shows up under a game's description.
	/// English String: "This game's source is public"
	/// </summary>
	public override string LabelPublicSourceDescription => "Das Quellmaterial dieses Spiels ist öffentlich.";

	/// <summary>
	/// Key: "Label.ReportAbuse"
	/// English String: "Report Abuse"
	/// </summary>
	public override string LabelReportAbuse => "Verstoß melden";

	/// <summary>
	/// Key: "Label.Servers"
	/// English String: "Servers"
	/// </summary>
	public override string LabelServers => "Server";

	/// <summary>
	/// Key: "Label.Store"
	/// English String: "Store"
	/// </summary>
	public override string LabelStore => "Shop";

	/// <summary>
	/// Key: "Label.Updated"
	/// English String: "Updated"
	/// </summary>
	public override string LabelUpdated => "Aktualisiert";

	/// <summary>
	/// Key: "Label.Visits"
	/// English String: "Visits"
	/// </summary>
	public override string LabelVisits => "Besuche";

	public GameDetailsResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionShareGameToChat()
	{
		return "Im Chat teilen";
	}

	/// <summary>
	/// Key: "Description.AllowCopyingDisclaimer"
	/// English String: "By checking this box, {boldTagStart}you are granting every other user of Roblox the right to use{boldTagEnd} (in various ways) the content you are now sharing. {boldTagStart2}If you do not want to grant this right, please do not check this box{boldTagEnd2}. For more information about sharing content, please review the Roblox {linkStart}Terms of Use{linkEnd}."
	/// </summary>
	public override string DescriptionAllowCopyingDisclaimer(string boldTagStart, string boldTagEnd, string boldTagStart2, string boldTagEnd2, string linkStart, string linkEnd)
	{
		return $"Wenn du dieses Kontrollkästchen aktivierst, {boldTagStart}gewährst du allen anderen Roblox-Benutzern das Recht{boldTagEnd}, die Inhalte, die du gerade teilst, auf unterschiedliche Art und Weise zu verwenden. {boldTagStart2}Wenn du dieses Recht nicht gewähren möchtest, aktiviere dieses Kontrollkästchen bitte nicht{boldTagEnd2}. Weitere Informationen zum Teilen von Inhalten findest du in den {linkStart}Nutzungsbedingungen{linkEnd} von Roblox.";
	}

	protected override string _GetTemplateForDescriptionAllowCopyingDisclaimer()
	{
		return "Wenn du dieses Kontrollkästchen aktivierst, {boldTagStart}gewährst du allen anderen Roblox-Benutzern das Recht{boldTagEnd}, die Inhalte, die du gerade teilst, auf unterschiedliche Art und Weise zu verwenden. {boldTagStart2}Wenn du dieses Recht nicht gewähren möchtest, aktiviere dieses Kontrollkästchen bitte nicht{boldTagEnd2}. Weitere Informationen zum Teilen von Inhalten findest du in den {linkStart}Nutzungsbedingungen{linkEnd} von Roblox.";
	}

	protected override string _GetTemplateForHeadingDescription()
	{
		return "Beschreibung";
	}

	protected override string _GetTemplateForHeadingRecommendedGames()
	{
		return "Empfohlene Spiele";
	}

	protected override string _GetTemplateForLabelAbout()
	{
		return "Info";
	}

	protected override string _GetTemplateForLabelAllowCopyingCheckbox()
	{
		return "Kopieren erlauben";
	}

	protected override string _GetTemplateForLabelAllowedGear()
	{
		return "Erlaubte Ausrüstung";
	}

	protected override string _GetTemplateForLabelBy()
	{
		return "Von";
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
		return "Kopieren";
	}

	protected override string _GetTemplateForLabelCreated()
	{
		return "Erstellt";
	}

	protected override string _GetTemplateForLabelExperimentalMode()
	{
		return "Experimentalmodus";
	}

	/// <summary>
	/// Key: "Label.ExperimentalWarning"
	/// English String: "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}This game may not function as intended.{aTagEnd} The developer needs to update the game."
	/// </summary>
	public override string LabelExperimentalWarning(string aTagStartWithHref, string ExperimentalGamesInfoLink, string hrefEnd, string aTagEnd)
	{
		return $"{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}Dieses Spiel funktioniert möglicherweise nicht wie geplant.{aTagEnd} Der Entwickler muss das Spiel aktualisieren.";
	}

	protected override string _GetTemplateForLabelExperimentalWarning()
	{
		return "{aTagStartWithHref}{ExperimentalGamesInfoLink}{hrefEnd}Dieses Spiel funktioniert möglicherweise nicht wie geplant.{aTagEnd} Der Entwickler muss das Spiel aktualisieren.";
	}

	protected override string _GetTemplateForLabelFavorites()
	{
		return "Spielerfavoriten";
	}

	protected override string _GetTemplateForLabelGameCopyLocked()
	{
		return "Dieses Spiel ist kopiergeschützt.";
	}

	protected override string _GetTemplateForLabelGameDoesNotSell()
	{
		return "Keine virtuellen Artikel oder Power-ups verfügbar.";
	}

	protected override string _GetTemplateForLabelGameRequiresBuildersClub()
	{
		return "Für dieses Spiel ist eine „Builders Club“-Mitgliedschaft erforderlich.";
	}

	protected override string _GetTemplateForLabelGenre()
	{
		return "Genre";
	}

	protected override string _GetTemplateForLabelLeaderboards()
	{
		return "Bestenlisten";
	}

	protected override string _GetTemplateForLabelMaxPlayers()
	{
		return "Max. Spieler";
	}

	protected override string _GetTemplateForLabelNoRunningGames()
	{
		return "Derzeit laufen keine Spiele.";
	}

	protected override string _GetTemplateForLabelPlaceCopyingAllowed()
	{
		return "Das Quellmaterial dieses Spiels kann kopiert werden.";
	}

	protected override string _GetTemplateForLabelPlaying()
	{
		return "Spieler";
	}

	protected override string _GetTemplateForLabelPrivateSource()
	{
		return "Privates Quellmaterial";
	}

	protected override string _GetTemplateForLabelPrivateSourceDescription()
	{
		return "Das Quellmaterial dieses Spiels ist privat.";
	}

	protected override string _GetTemplateForLabelPublicPrivateSourceCheckBox()
	{
		return "Wenn du dieses Kontrollkästchen aktiviert lässt, gewährst du allen anderen Roblox-Benutzern das Recht, die Inhalte, die du gerade zur Verfügung stellst, auf unterschiedliche Art und Weise und gemäß der Nutzungsbedingungen zu verwenden. Wenn du dieses Recht nicht gewähren möchtest, deaktiviere dieses Kontrollkästchen bitte.";
	}

	protected override string _GetTemplateForLabelPublicSource()
	{
		return "Öffentliches Quellmaterial";
	}

	protected override string _GetTemplateForLabelPublicSourceDescription()
	{
		return "Das Quellmaterial dieses Spiels ist öffentlich.";
	}

	protected override string _GetTemplateForLabelReportAbuse()
	{
		return "Verstoß melden";
	}

	protected override string _GetTemplateForLabelServers()
	{
		return "Server";
	}

	protected override string _GetTemplateForLabelStore()
	{
		return "Shop";
	}

	protected override string _GetTemplateForLabelUpdated()
	{
		return "Aktualisiert";
	}

	protected override string _GetTemplateForLabelVisits()
	{
		return "Besuche";
	}
}
