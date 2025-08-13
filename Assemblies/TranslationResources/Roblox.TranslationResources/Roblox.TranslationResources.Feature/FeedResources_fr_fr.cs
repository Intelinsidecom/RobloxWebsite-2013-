namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FeedResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FeedResources_fr_fr : FeedResources_en_us, IFeedResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingBuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public override string HeadingBuildSomething => "Construire quelque chose";

	/// <summary>
	/// Key: "HeadingCustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public override string HeadingCustomizeAvatar => "Personnalise ton avatar";

	/// <summary>
	/// Key: "HeadingForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public override string HeadingForumHelp => "Aide sur les forums de Roblox";

	/// <summary>
	/// Key: "HeadingMakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public override string HeadingMakeFriends => "Rencontrer des amis";

	/// <summary>
	/// Key: "HeadingPlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string HeadingPlayGames => "Jouer";

	/// <summary>
	/// Key: "LabelNoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public override string LabelNoFeedLink => "Rencontrez de nouveaux amis dès maintenant.";

	/// <summary>
	/// Key: "LabelNoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public override string LabelNoFeedText => "Aucune nouvelle de vos meilleurs amis... Vous voulez savoir ce qu'ils deviennent\u00a0?";

	/// <summary>
	/// Key: "LabelPlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public override string LabelPlayGames => "La quasi-totalité des jeux sur Roblox ont été réalisés par des joueurs tels que vous. Voici quelques-uns de nos favoris\u00a0:";

	public FeedResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingBuildSomething()
	{
		return "Construire quelque chose";
	}

	protected override string _GetTemplateForHeadingCustomizeAvatar()
	{
		return "Personnalise ton avatar";
	}

	protected override string _GetTemplateForHeadingForumHelp()
	{
		return "Aide sur les forums de Roblox";
	}

	protected override string _GetTemplateForHeadingMakeFriends()
	{
		return "Rencontrer des amis";
	}

	protected override string _GetTemplateForHeadingPlayGames()
	{
		return "Jouer";
	}

	/// <summary>
	/// Key: "LabelBuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public override string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"Les constructeurs adoreront notre jeu de construction multijoueur en ligne. Les constructeurs professionnels seront peut-être plutôt intéressés par Roblox Studio, notre environnement de développement présenté sur ta {linkStart}page dédiée au développement.{linkEnd}.";
	}

	protected override string _GetTemplateForLabelBuildSomething()
	{
		return "Les constructeurs adoreront notre jeu de construction multijoueur en ligne. Les constructeurs professionnels seront peut-être plutôt intéressés par Roblox Studio, notre environnement de développement présenté sur ta {linkStart}page dédiée au développement.{linkEnd}.";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart} Avatar page {avatarLinkEnd} to customize your avatar. Get new clothing in the {catalogLinkStart}catalog{catalogLinkEnd}."
	/// </summary>
	public override string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"Visite la {avatarLinkStart} page des avatars {avatarLinkEnd} pour personnaliser ton avatar. Obtiens de nouveaux vêtements dans le {catalogLinkStart} catalogue {catalogLinkEnd}.";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "Visite la {avatarLinkStart} page des avatars {avatarLinkEnd} pour personnaliser ton avatar. Obtiens de nouveaux vêtements dans le {catalogLinkStart} catalogue {catalogLinkEnd}.";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public override string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"Obtiens de nouveaux vêtements dans le {linkStart} catalogue {linkEnd} et personnalise ton avatar.";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "Obtiens de nouveaux vêtements dans le {linkStart} catalogue {linkEnd} et personnalise ton avatar.";
	}

	/// <summary>
	/// Key: "LabelForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public override string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"Peu importe ce que vous cherchez, si c'est au sujet de Roblox, on en parle {linkStart}ici{linkEnd}.";
	}

	protected override string _GetTemplateForLabelForumHelp()
	{
		return "Peu importe ce que vous cherchez, si c'est au sujet de Roblox, on en parle {linkStart}ici{linkEnd}.";
	}

	/// <summary>
	/// Key: "LabelMakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public override string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"Rencontrez d'autres utilisateurs en jeu et envoyez-leur une demande d'amitié. Si vous avez raté l'occasion, vous avez toujours la possibilité d'en envoyer une plus tard en {linkStart}recherchant{linkEnd} leur profil d'utilisateur.";
	}

	protected override string _GetTemplateForLabelMakeFriends()
	{
		return "Rencontrez d'autres utilisateurs en jeu et envoyez-leur une demande d'amitié. Si vous avez raté l'occasion, vous avez toujours la possibilité d'en envoyer une plus tard en {linkStart}recherchant{linkEnd} leur profil d'utilisateur.";
	}

	protected override string _GetTemplateForLabelNoFeedLink()
	{
		return "Rencontrez de nouveaux amis dès maintenant.";
	}

	protected override string _GetTemplateForLabelNoFeedText()
	{
		return "Aucune nouvelle de vos meilleurs amis... Vous voulez savoir ce qu'ils deviennent\u00a0?";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "La quasi-totalité des jeux sur Roblox ont été réalisés par des joueurs tels que vous. Voici quelques-uns de nos favoris\u00a0:";
	}
}
