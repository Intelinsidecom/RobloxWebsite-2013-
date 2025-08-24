namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides FeedsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class FeedsResources_pt_br : FeedsResources_en_us, IFeedsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.BuildSomething"
	/// English String: "Build Something"
	/// </summary>
	public override string HeadingBuildSomething => "Construa algo";

	/// <summary>
	/// Key: "Heading.CustomizeAvatar"
	/// English String: "Customize Your Avatar"
	/// </summary>
	public override string HeadingCustomizeAvatar => "Personalize seu avatar";

	/// <summary>
	/// Key: "Heading.ForumHelp"
	/// English String: "Roblox forums for help"
	/// </summary>
	public override string HeadingForumHelp => "Visite os fóruns Roblox para obter ajuda";

	/// <summary>
	/// Key: "Heading.MakeFriends"
	/// English String: "Make Friends"
	/// </summary>
	public override string HeadingMakeFriends => "Faça amizades";

	/// <summary>
	/// Key: "Heading.PlayGames"
	/// English String: "Play Games"
	/// </summary>
	public override string HeadingPlayGames => "Jogue";

	/// <summary>
	/// Key: "Label.NoFeedLink"
	/// English String: "make some best friends now."
	/// </summary>
	public override string LabelNoFeedLink => "Faça alguns amigos agora.";

	/// <summary>
	/// Key: "Label.NoFeedText"
	/// English String: "No news about your best friends... want to know what your best friends are up to?"
	/// </summary>
	public override string LabelNoFeedText => "Nenhuma notícia sobre seus melhores amigos... quer saber o que eles estão fazendo?";

	/// <summary>
	/// Key: "Label.PlayGames"
	/// English String: "Nearly all Roblox games are built by players like you. Here are some of our favorites:"
	/// </summary>
	public override string LabelPlayGames => "Quase todos os jogos Roblox são feitos por jogadores como você. Aqui estão alguns dos nossos favoritos:";

	public FeedsResources_pt_br(TranslationResourceState state)
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
		return "Visite os fóruns Roblox para obter ajuda";
	}

	protected override string _GetTemplateForHeadingMakeFriends()
	{
		return "Faça amizades";
	}

	protected override string _GetTemplateForHeadingPlayGames()
	{
		return "Jogue";
	}

	/// <summary>
	/// Key: "Label.BuildSomething"
	/// English String: "Builders will enjoy playing our multiplayer building game. Professional builders will want to check out Roblox Studio, our game development environment on your {linkStart}Develop page{linkEnd}."
	/// </summary>
	public override string LabelBuildSomething(string linkStart, string linkEnd)
	{
		return $"Construtores vão adorar jogar nosso jogo de construção multijogador. Construtores profissionais não podem deixar de conferir o Roblox Studio, nosso ambiente de desenvolvimento de jogo, na {linkStart}página de Desenvolvimento{linkEnd}.";
	}

	protected override string _GetTemplateForLabelBuildSomething()
	{
		return "Construtores vão adorar jogar nosso jogo de construção multijogador. Construtores profissionais não podem deixar de conferir o Roblox Studio, nosso ambiente de desenvolvimento de jogo, na {linkStart}página de Desenvolvimento{linkEnd}.";
	}

	/// <summary>
	/// Key: "Label.CustomizeAvatarDesktop"
	/// English String: "Visit the {avatarLinkStart}Avatar Editor{avatarLinkEnd} to customize your character. Shop for clothing items in the {catalogLinkStart}Catalog{catalogLinkEnd}."
	/// </summary>
	public override string LabelCustomizeAvatarDesktop(string avatarLinkStart, string avatarLinkEnd, string catalogLinkStart, string catalogLinkEnd)
	{
		return $"Visite o {avatarLinkStart}Editor de Avatar{avatarLinkEnd} para personalizar seu personagem. Compre peças de roupa no {catalogLinkStart}Catálogo{catalogLinkEnd}.";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarDesktop()
	{
		return "Visite o {avatarLinkStart}Editor de Avatar{avatarLinkEnd} para personalizar seu personagem. Compre peças de roupa no {catalogLinkStart}Catálogo{catalogLinkEnd}.";
	}

	/// <summary>
	/// Key: "Label.CustomizeAvatarPhone"
	/// English String: "Get new clothing in the {linkStart} catalog {linkEnd} and customize your avatar."
	/// </summary>
	public override string LabelCustomizeAvatarPhone(string linkStart, string linkEnd)
	{
		return $"Obtenha novas roupas no {linkStart} catálogo {linkEnd} e personalize seu avatar.";
	}

	protected override string _GetTemplateForLabelCustomizeAvatarPhone()
	{
		return "Obtenha novas roupas no {linkStart} catálogo {linkEnd} e personalize seu avatar.";
	}

	/// <summary>
	/// Key: "Label.ForumHelp"
	/// English String: "No matter what you're looking for, if it's Roblox related, there are people talking about it {linkStart}here{linkEnd}."
	/// </summary>
	public override string LabelForumHelp(string linkStart, string linkEnd)
	{
		return $"Não importa qual seja o assunto, se for relacionado ao Roblox, tem gente falando sobre ele {linkStart}aqui{linkEnd}.";
	}

	protected override string _GetTemplateForLabelForumHelp()
	{
		return "Não importa qual seja o assunto, se for relacionado ao Roblox, tem gente falando sobre ele {linkStart}aqui{linkEnd}.";
	}

	/// <summary>
	/// Key: "Label.MakeFriends"
	/// English String: "Meet other players in-game and send them a friend request. If you miss your opportunity you can always send a request later by {linkStart}searching{linkEnd} for their user profile."
	/// </summary>
	public override string LabelMakeFriends(string linkStart, string linkEnd)
	{
		return $"Encontre outros jogadores no jogo e envie para eles uma solicitação de amizade. Se perder a oportunidade, você pode enviar uma solicitação mais tarde {linkStart}pesquisando{linkEnd} seu perfil de usuário.";
	}

	protected override string _GetTemplateForLabelMakeFriends()
	{
		return "Encontre outros jogadores no jogo e envie para eles uma solicitação de amizade. Se perder a oportunidade, você pode enviar uma solicitação mais tarde {linkStart}pesquisando{linkEnd} seu perfil de usuário.";
	}

	protected override string _GetTemplateForLabelNoFeedLink()
	{
		return "Faça alguns amigos agora.";
	}

	protected override string _GetTemplateForLabelNoFeedText()
	{
		return "Nenhuma notícia sobre seus melhores amigos... quer saber o que eles estão fazendo?";
	}

	protected override string _GetTemplateForLabelPlayGames()
	{
		return "Quase todos os jogos Roblox são feitos por jogadores como você. Aqui estão alguns dos nossos favoritos:";
	}
}
