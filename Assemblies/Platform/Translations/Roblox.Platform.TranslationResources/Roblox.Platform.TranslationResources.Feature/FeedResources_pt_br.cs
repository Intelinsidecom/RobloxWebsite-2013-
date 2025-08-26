namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides FeedResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FeedResources_pt_br : FeedResources_en_us, IFeedResources, ITranslationResources
{
	/// <summary>
	/// Key: "HeadingBuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public override string HeadingBuildSomething => "Construa algo";

	/// <summary>
	/// Key: "HeadingCustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public override string HeadingCustomizeAvatar => "Personalize seu avatar";

	/// <summary>
	/// Key: "HeadingForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public override string HeadingForumHelp => "Visite os fÃ³runs Roblox para obter ajuda";

	/// <summary>
	/// Key: "HeadingMakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public override string HeadingMakeFriends => "FaÃ§a amizades";

	/// <summary>
	/// Key: "HeadingPlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string HeadingPlayGames => "Jogar";

	/// <summary>
	/// Key: "LabelNoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public override string LabelNoFeedLink => "FaÃ§a alguns amigos agora.";

	/// <summary>
	/// Key: "LabelNoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public override string LabelNoFeedText => "Nenhuma notÃ­cia sobre seus melhores amigos... quer saber o que eles estÃ£o fazendo?";

	/// <summary>
	/// Key: "LabelPlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public override string LabelPlayGames => "Quase todos os jogos Roblox sÃ£o feitos por jogadores como vocÃª. Aqui estÃ£o alguns dos nossos favoritos:";

	public FeedResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingBuildSomething()
	{
		return "Construa algo";
	}

	protected override string _GetTemplateForHeadingCustomizeAvatar()
	{
		return "Personalize seu avatar";
	}

	protected override string _GetTemplateForHeadingForumHelp()
	{
		return "Visite os fÃ³runs Roblox para obter ajuda";
	}

	protected override string _GetTemplateForHeadingMakeFriends()
	{
		return "FaÃ§a amizades";
	}

	protected override string _GetTemplateForHeadingPlayGames()
	{
		return "Jogar";
	}

	/// <summary>
	/// Key: "LabelBuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public override string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"Construtores vÃ£o adorar jogar nosso jogo de construÃ§Ã£o multijogador. Construtores profissionais nÃ£o podem deixar de conferir o Roblox Studio, nosso ambiente de desenvolvimento de jogo, na {linkStart}pÃ¡gina de Desenvolvimento{linkEnd}.";
	}

	protected override string _GetTemplateForLabelBuildSomething()
	{
		return "Construtores vÃ£o adorar jogar nosso jogo de construÃ§Ã£o multijogador. Construtores profissionais nÃ£o podem deixar de conferir o Roblox Studio, nosso ambiente de desenvolvimento de jogo, na {linkStart}pÃ¡gina de Desenvolvimento{linkEnd}.";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart} Avatar page {avatarLinkEnd} to customize your avatar. Get new clothing in the {catalogLinkStart}catalog{catalogLinkEnd}."
	/// </summary>
	public override string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"Visite a {avatarLinkStart}pÃ¡gina de Avatar{avatarLinkEnd} para personalizar seu avatar. Obtenha novas roupas no {catalogLinkStart}catÃ¡logo{catalogLinkEnd}.";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "Visite a {avatarLinkStart}pÃ¡gina de Avatar{avatarLinkEnd} para personalizar seu avatar. Obtenha novas roupas no {catalogLinkStart}catÃ¡logo{catalogLinkEnd}.";
	}

	/// <summary>
	/// Key: "LabelCustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public override string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"Obtenha novas roupas no {linkStart} catÃ¡logo {linkEnd} e personalize seu avatar.";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "Obtenha novas roupas no {linkStart} catÃ¡logo {linkEnd} e personalize seu avatar.";
	}

	/// <summary>
	/// Key: "LabelForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public override string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"NÃ£o importa qual seja o assunto, se for relacionado ao Roblox, tem gente falando sobre ele {linkStart}aqui{linkEnd}.";
	}

	protected override string _GetTemplateForLabelForumHelp()
	{
		return "NÃ£o importa qual seja o assunto, se for relacionado ao Roblox, tem gente falando sobre ele {linkStart}aqui{linkEnd}.";
	}

	/// <summary>
	/// Key: "LabelMakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public override string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"Encontre outros jogadores no jogo e envie para eles uma solicitaÃ§Ã£o de amizade. Se perder a oportunidade, vocÃª pode enviar uma solicitaÃ§Ã£o mais tarde {linkStart}pesquisando{linkEnd} seu perfil de usuÃ¡rio.";
	}

	protected override string _GetTemplateForLabelMakeFriends()
	{
		return "Encontre outros jogadores no jogo e envie para eles uma solicitaÃ§Ã£o de amizade. Se perder a oportunidade, vocÃª pode enviar uma solicitaÃ§Ã£o mais tarde {linkStart}pesquisando{linkEnd} seu perfil de usuÃ¡rio.";
	}

	protected override string _GetTemplateForLabelNoFeedLink()
	{
		return "FaÃ§a alguns amigos agora.";
	}

	protected override string _GetTemplateForLabelNoFeedText()
	{
		return "Nenhuma notÃ­cia sobre seus melhores amigos... quer saber o que eles estÃ£o fazendo?";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "Quase todos os jogos Roblox sÃ£o feitos por jogadores como vocÃª. Aqui estÃ£o alguns dos nossos favoritos:";
	}
}


}
