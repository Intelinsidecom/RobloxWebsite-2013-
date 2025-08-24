namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FeedResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FeedResources_de_de : FeedResources_en_us, IFeedResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingBuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public override string HeadingBuildSomething => "Baue etwas";

	/// <summary>
	/// Key: "HeadingCustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public override string HeadingCustomizeAvatar => "Passe deinen Avatar an";

	/// <summary>
	/// Key: "HeadingForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public override string HeadingForumHelp => "Besuche Roblox-Foren für Hilfe";

	/// <summary>
	/// Key: "HeadingMakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public override string HeadingMakeFriends => "Finde Freunde";

	/// <summary>
	/// Key: "HeadingPlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string HeadingPlayGames => "Spielen";

	/// <summary>
	/// Key: "LabelNoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public override string LabelNoFeedLink => "Schließe jetzt neue Freundschaften.";

	/// <summary>
	/// Key: "LabelNoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public override string LabelNoFeedText => "Es gibt nichts Neues von deinen besten Freunden\u00a0... Möchtest du wissen, was deine besten Freunde so machen?";

	/// <summary>
	/// Key: "LabelPlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public override string LabelPlayGames => "Fast alle Roblox-Spiele wurden von Spielern wie dir entwickelt. Hier findest du ein paar unserer Lieblingsspiele:";

	public FeedResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingBuildSomething()
	{
		return "Baue etwas";
	}

	protected override string _GetTemplateForHeadingCustomizeAvatar()
	{
		return "Passe deinen Avatar an";
	}

	protected override string _GetTemplateForHeadingForumHelp()
	{
		return "Besuche Roblox-Foren für Hilfe";
	}

	protected override string _GetTemplateForHeadingMakeFriends()
	{
		return "Finde Freunde";
	}

	protected override string _GetTemplateForHeadingPlayGames()
	{
		return "Spielen";
	}

	/// <summary>
	/// Key: "LabelBuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public override string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"Entwickler werden unser Mehrspieler-Entwicklerspiel lieben. Und professionelle Entwickler sollten unsere Spielentwicklungsumgebung Roblox Studio unter {linkStart}Erstellen{linkEnd} ausprobieren.";
	}

	protected override string _GetTemplateForLabelBuildSomething()
	{
		return "Entwickler werden unser Mehrspieler-Entwicklerspiel lieben. Und professionelle Entwickler sollten unsere Spielentwicklungsumgebung Roblox Studio unter {linkStart}Erstellen{linkEnd} ausprobieren.";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart} Avatar page {avatarLinkEnd} to customize your avatar. Get new clothing in the {catalogLinkStart}catalog{catalogLinkEnd}."
	/// </summary>
	public override string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"Rufe die {avatarLinkStart}Avatarseite{avatarLinkEnd} auf, um deinen Avatar anzupassen. Hol dir neue Kleidung im {catalogLinkStart}Katalog{catalogLinkEnd}.";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "Rufe die {avatarLinkStart}Avatarseite{avatarLinkEnd} auf, um deinen Avatar anzupassen. Hol dir neue Kleidung im {catalogLinkStart}Katalog{catalogLinkEnd}.";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public override string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"Hol dir neue Kleidung im {linkStart}Katalog{linkEnd} und passe deinen Avatar an.";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "Hol dir neue Kleidung im {linkStart}Katalog{linkEnd} und passe deinen Avatar an.";
	}

	/// <summary>
	/// Key: "LabelForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public override string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"Was auch immer dich interessiert, solange es etwas mit Roblox zu tun hat, findest du {linkStart}hier{linkEnd} Leute, die sich darüber unterhalten.";
	}

	protected override string _GetTemplateForLabelForumHelp()
	{
		return "Was auch immer dich interessiert, solange es etwas mit Roblox zu tun hat, findest du {linkStart}hier{linkEnd} Leute, die sich darüber unterhalten.";
	}

	/// <summary>
	/// Key: "LabelMakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public override string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"Lerne beim Spielen andere Spieler kennen und sende ihnen Freundesanfragen. Wenn du das versäumst, kannst du ihnen auch später noch eine Anfrage senden, indem du nach ihren Benutzerprofilen {linkStart}suchst{linkEnd}.";
	}

	protected override string _GetTemplateForLabelMakeFriends()
	{
		return "Lerne beim Spielen andere Spieler kennen und sende ihnen Freundesanfragen. Wenn du das versäumst, kannst du ihnen auch später noch eine Anfrage senden, indem du nach ihren Benutzerprofilen {linkStart}suchst{linkEnd}.";
	}

	protected override string _GetTemplateForLabelNoFeedLink()
	{
		return "Schließe jetzt neue Freundschaften.";
	}

	protected override string _GetTemplateForLabelNoFeedText()
	{
		return "Es gibt nichts Neues von deinen besten Freunden\u00a0... Möchtest du wissen, was deine besten Freunde so machen?";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "Fast alle Roblox-Spiele wurden von Spielern wie dir entwickelt. Hier findest du ein paar unserer Lieblingsspiele:";
	}
}
