namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SurveysGameRatingsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SurveysGameRatingsResources_ja_jp : SurveysGameRatingsResources_en_us, ISurveysGameRatingsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.AnswerToDoesThisGameContain.Frequently"
	/// A recurring possible answer choice to questions formatted as "Does this game contain ____?"
	/// English String: "Frequently"
	/// </summary>
	public override string DescriptionAnswerToDoesThisGameContainFrequently => "かなりある";

	/// <summary>
	/// Key: "Description.AnswerToDoesThisGameContain.Infrequently"
	/// A recurring possible answer choice to questions formatted as "Does this game contain ____?"
	/// English String: "Infrequently"
	/// </summary>
	public override string DescriptionAnswerToDoesThisGameContainInfrequently => "まれにある";

	/// <summary>
	/// Key: "Description.AnswerToDoesThisGameContain.No"
	/// A recurring possible answer choice to questions formatted as "Does this game contain ____ ?"
	/// English String: "No"
	/// </summary>
	public override string DescriptionAnswerToDoesThisGameContainNo => "いいえ";

	/// <summary>
	/// Key: "Description.AnswerToDoesThisGameContain.Yes"
	/// A recurring possible answer choice to questions formatted as "Does this game contain ____ ?"
	/// English String: "Yes"
	/// </summary>
	public override string DescriptionAnswerToDoesThisGameContainYes => "はい";

	/// <summary>
	/// Key: "Description.CanUsersWagerRobuxInGameCurrencyPurchasedWithRobuxOrOtherItemsOfRealValue"
	/// Answer choices are "No", "Yes"
	/// English String: "Can users wager Robux, in game currency purchased with Robux or other items of real value?"
	/// </summary>
	public override string DescriptionCanUsersWagerRobuxInGameCurrencyPurchasedWithRobuxOrOtherItemsOfRealValue => "Robux、Robuxで購入したゲーム内通貨、現金と同等の価値のあるアイテムなどを、ユーザーが賭けに使うことはできますか？";

	/// <summary>
	/// Key: "Description.DefenselessViolenceQuestion"
	/// Answer choices are "No", "Yes"
	/// English String: "Does this game contain violence directed towards defenseless characters?"
	/// </summary>
	public override string DescriptionDefenselessViolenceQuestion => "このゲームには、無防備なキャラクターへの直接的な暴力表現はありますか？";

	/// <summary>
	/// Key: "Description.DoesThisGameContainBathroomHumor"
	/// Answer choices are "No", "Infrequently", "Frequently"
	/// English String: "Does this game contain bathroom humor?"
	/// </summary>
	public override string DescriptionDoesThisGameContainBathroomHumor => "このゲームには、下ネタはありますか？";

	/// <summary>
	/// Key: "Description.DoesThisGameContainCrudeHumor"
	/// Answer choices are "No", "Infrequently", "Frequently"
	/// English String: "Does this game contain crude humor?"
	/// </summary>
	public override string DescriptionDoesThisGameContainCrudeHumor => "このゲームには、下品な表現はありますか？";

	/// <summary>
	/// Key: "Description.DoesThisGameContainNudityOrDepictionsOfSex"
	/// Answer choices are "No", "Yes"
	/// English String: "Does this game contain nudity or depictions of sex?"
	/// </summary>
	public override string DescriptionDoesThisGameContainNudityOrDepictionsOfSex => "このゲームには、裸体や性交表現が含まれていますか？";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs"
	/// This question has four possible answer choices: "No", "Infrequent references", "Frequent references", "Characters are shown using alcohol, tobacco or drugs"
	/// English String: "Does this game contain references to alcohol, tobacco or drugs?"
	/// </summary>
	public override string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugs => "このゲームには、アルコールやたばこ、薬物に関係する表現が含まれていますか？";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.CharactersAreShownUsingAlcoholTobac"
	/// One of four possible answers to "Does this game contain references to alcohol, tobacco or drugs?", with an implied "Yes"
	/// English String: "Characters are shown using alcohol, tobacco or drugs"
	/// </summary>
	public override string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsCharactersAreShownUsingAlcoholTobac => "キャラクターが、アルコールやたばこ、薬物を使っている場面がある";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.FrequentReferences"
	/// One of four possible answers to "Does this game contain references to alcohol, tobacco or drugs?", with an implied "Yes"
	/// English String: "Frequent references"
	/// </summary>
	public override string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsFrequentReferences => "かなりある";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.InfrequentReferences"
	/// One of four possible answers to "Does this game contain references to alcohol, tobacco or drugs?", with an implied "Yes"
	/// English String: "Infrequent references"
	/// </summary>
	public override string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsInfrequentReferences => "まれにある";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.No"
	/// One of four possible answers to "Does this game contain references to alcohol, tobacco or drugs?"
	/// English String: "No"
	/// </summary>
	public override string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsNo => "いいえ";

	/// <summary>
	/// Key: "Description.DoesThisGameContainSimulatedGamblingOrPaidLootBoxes"
	/// Answer choices are "No", "Yes"
	/// English String: "Does this game contain simulated gambling or paid loot boxes?"
	/// </summary>
	public override string DescriptionDoesThisGameContainSimulatedGamblingOrPaidLootBoxes => "このゲームには、シミュレートされたギャンブル要素や有料ガチャがありますか？";

	/// <summary>
	/// Key: "Description.DoesThisGameContainSuggestiveSexualThemes"
	/// Answer choices are "No", "Yes"
	/// English String: "Does this game contain suggestive sexual themes?"
	/// </summary>
	public override string DescriptionDoesThisGameContainSuggestiveSexualThemes => "このゲームには、性を連想させる内容が含まれていますか？";

	/// <summary>
	/// Key: "Description.DoesThisGameFollowTheCommunityRules"
	/// Answer choices are "No, "Yes"
	/// English String: "Does this game follow the the community rules? "
	/// </summary>
	public override string DescriptionDoesThisGameFollowTheCommunityRules => "このゲームはコミュニティルールに従っていますか？ ";

	/// <summary>
	/// Key: "Description.DoesThisGameFollowTheCommunityRules.No"
	/// This game does not follow community rules
	/// English String: "No"
	/// </summary>
	public override string DescriptionDoesThisGameFollowTheCommunityRulesNo => "いいえ";

	/// <summary>
	/// Key: "Description.DoesThisGameFollowTheCommunityRules.Yes"
	/// This game does follow community rules
	/// English String: "Yes"
	/// </summary>
	public override string DescriptionDoesThisGameFollowTheCommunityRulesYes => "はい";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity"
	/// This question has four possible answer choices: "No", "Some mild bad language", "Infrequenty profanity", "Frequent profanity"
	/// English String: "Does this game use profanity?"
	/// </summary>
	public override string DescriptionDoesThisGameUseProfanity => "このゲームには、暴言が使われていますか？";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity.FrequentProfanity"
	/// One of four possible answers to "Does this game use profanity?", with an implied "Yes"
	/// English String: "Frequent profanity"
	/// </summary>
	public override string DescriptionDoesThisGameUseProfanityFrequentProfanity => "かなり汚い言葉がある";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity.InfrequentProfanity"
	/// One of four possible answers to "Does this game use profanity?", with an implied "Yes"
	/// English String: "Infrequent profanity"
	/// </summary>
	public override string DescriptionDoesThisGameUseProfanityInfrequentProfanity => "汚い言葉がある";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity.No"
	/// One of four possible answers to "Does this game use profanity?"
	/// English String: "No"
	/// </summary>
	public override string DescriptionDoesThisGameUseProfanityNo => "いいえ";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity.SomeMildBadLanguage"
	/// One of four possible answers to "Does this game use profanity?", with an implied "Yes"
	/// English String: "Some mild bad language"
	/// </summary>
	public override string DescriptionDoesThisGameUseProfanitySomeMildBadLanguage => "少し汚い言葉がある";

	/// <summary>
	/// Key: "Description.ScaryForChildUnderEightQuestion"
	/// Answer choices are "No", "Infrequently", "Frequently"
	/// English String: "Does this game contain content that might be scary for a young child under 8 years old?"
	/// </summary>
	public override string DescriptionScaryForChildUnderEightQuestion => "このゲームは8歳未満のお子様に不適切なコンテンツを含んでいますか？";

	/// <summary>
	/// Key: "Description.ScaryForChildUnderTwelveQuestion"
	/// Answer choices are "No", "Infrequently", "Frequently"
	/// English String: "Does this game contain content that might be scary for a young child under 12 years old?"
	/// </summary>
	public override string DescriptionScaryForChildUnderTwelveQuestion => "このゲームは12歳未満のお子様に不適切なコンテンツを含んでいますか？";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.ComicalViolence"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?", with an implied "Yes"
	/// English String: "Comical violence"
	/// </summary>
	public override string DescriptionViolenceQuestionComicalViolence => "コミカルな暴力表現";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.DoesThisGameContainViolentContent"
	/// Note: This survey question lets user pick one of five possible responses, as opposed to being just a "Yes/No" question.
	/// English String: "Does this game contain violent content?"
	/// </summary>
	public override string DescriptionViolenceQuestionDoesThisGameContainViolentContent => "このゲームは暴力コンテンツを含んでいますか？";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.EasilyDistinguishableFromRealLife"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?", with an implied "Yes"
	/// English String: "Easily distinguishable from real life"
	/// </summary>
	public override string DescriptionViolenceQuestionEasilyDistinguishableFromRealLife => "現実との区別が容易";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.ExtremeRealisticViolence"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?", with an implied "Yes"
	/// English String: "Extreme, realistic violence"
	/// </summary>
	public override string DescriptionViolenceQuestionExtremeRealisticViolence => "極端でリアルな暴力表現";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.No"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?"
	/// English String: "No"
	/// </summary>
	public override string DescriptionViolenceQuestionNo => "いいえ";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.SomeRealisticViolence"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?", with an implied "Yes"
	/// English String: "Some realistic violence"
	/// </summary>
	public override string DescriptionViolenceQuestionSomeRealisticViolence => "リアルな暴力表現を含む";

	public SurveysGameRatingsResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionAnswerToDoesThisGameContainFrequently()
	{
		return "かなりある";
	}

	protected override string _GetTemplateForDescriptionAnswerToDoesThisGameContainInfrequently()
	{
		return "まれにある";
	}

	protected override string _GetTemplateForDescriptionAnswerToDoesThisGameContainNo()
	{
		return "いいえ";
	}

	protected override string _GetTemplateForDescriptionAnswerToDoesThisGameContainYes()
	{
		return "はい";
	}

	protected override string _GetTemplateForDescriptionCanUsersWagerRobuxInGameCurrencyPurchasedWithRobuxOrOtherItemsOfRealValue()
	{
		return "Robux、Robuxで購入したゲーム内通貨、現金と同等の価値のあるアイテムなどを、ユーザーが賭けに使うことはできますか？";
	}

	protected override string _GetTemplateForDescriptionDefenselessViolenceQuestion()
	{
		return "このゲームには、無防備なキャラクターへの直接的な暴力表現はありますか？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainBathroomHumor()
	{
		return "このゲームには、下ネタはありますか？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainCrudeHumor()
	{
		return "このゲームには、下品な表現はありますか？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainNudityOrDepictionsOfSex()
	{
		return "このゲームには、裸体や性交表現が含まれていますか？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugs()
	{
		return "このゲームには、アルコールやたばこ、薬物に関係する表現が含まれていますか？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsCharactersAreShownUsingAlcoholTobac()
	{
		return "キャラクターが、アルコールやたばこ、薬物を使っている場面がある";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsFrequentReferences()
	{
		return "かなりある";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsInfrequentReferences()
	{
		return "まれにある";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsNo()
	{
		return "いいえ";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainSimulatedGamblingOrPaidLootBoxes()
	{
		return "このゲームには、シミュレートされたギャンブル要素や有料ガチャがありますか？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainSuggestiveSexualThemes()
	{
		return "このゲームには、性を連想させる内容が含まれていますか？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameFollowTheCommunityRules()
	{
		return "このゲームはコミュニティルールに従っていますか？ ";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameFollowTheCommunityRulesNo()
	{
		return "いいえ";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameFollowTheCommunityRulesYes()
	{
		return "はい";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameUseProfanity()
	{
		return "このゲームには、暴言が使われていますか？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameUseProfanityFrequentProfanity()
	{
		return "かなり汚い言葉がある";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameUseProfanityInfrequentProfanity()
	{
		return "汚い言葉がある";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameUseProfanityNo()
	{
		return "いいえ";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameUseProfanitySomeMildBadLanguage()
	{
		return "少し汚い言葉がある";
	}

	protected override string _GetTemplateForDescriptionScaryForChildUnderEightQuestion()
	{
		return "このゲームは8歳未満のお子様に不適切なコンテンツを含んでいますか？";
	}

	protected override string _GetTemplateForDescriptionScaryForChildUnderTwelveQuestion()
	{
		return "このゲームは12歳未満のお子様に不適切なコンテンツを含んでいますか？";
	}

	protected override string _GetTemplateForDescriptionViolenceQuestionComicalViolence()
	{
		return "コミカルな暴力表現";
	}

	protected override string _GetTemplateForDescriptionViolenceQuestionDoesThisGameContainViolentContent()
	{
		return "このゲームは暴力コンテンツを含んでいますか？";
	}

	protected override string _GetTemplateForDescriptionViolenceQuestionEasilyDistinguishableFromRealLife()
	{
		return "現実との区別が容易";
	}

	protected override string _GetTemplateForDescriptionViolenceQuestionExtremeRealisticViolence()
	{
		return "極端でリアルな暴力表現";
	}

	protected override string _GetTemplateForDescriptionViolenceQuestionNo()
	{
		return "いいえ";
	}

	protected override string _GetTemplateForDescriptionViolenceQuestionSomeRealisticViolence()
	{
		return "リアルな暴力表現を含む";
	}
}
