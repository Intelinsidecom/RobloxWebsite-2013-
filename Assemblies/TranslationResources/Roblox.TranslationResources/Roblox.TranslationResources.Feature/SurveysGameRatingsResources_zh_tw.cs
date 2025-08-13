namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides SurveysGameRatingsResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class SurveysGameRatingsResources_zh_tw : SurveysGameRatingsResources_en_us, ISurveysGameRatingsResources, ITranslationResources
{
	/// <summary>
	/// Key: "Description.AnswerToDoesThisGameContain.Frequently"
	/// A recurring possible answer choice to questions formatted as "Does this game contain ____?"
	/// English String: "Frequently"
	/// </summary>
	public override string DescriptionAnswerToDoesThisGameContainFrequently => "大量";

	/// <summary>
	/// Key: "Description.AnswerToDoesThisGameContain.Infrequently"
	/// A recurring possible answer choice to questions formatted as "Does this game contain ____?"
	/// English String: "Infrequently"
	/// </summary>
	public override string DescriptionAnswerToDoesThisGameContainInfrequently => "少量";

	/// <summary>
	/// Key: "Description.AnswerToDoesThisGameContain.No"
	/// A recurring possible answer choice to questions formatted as "Does this game contain ____ ?"
	/// English String: "No"
	/// </summary>
	public override string DescriptionAnswerToDoesThisGameContainNo => "否";

	/// <summary>
	/// Key: "Description.AnswerToDoesThisGameContain.Yes"
	/// A recurring possible answer choice to questions formatted as "Does this game contain ____ ?"
	/// English String: "Yes"
	/// </summary>
	public override string DescriptionAnswerToDoesThisGameContainYes => "是";

	/// <summary>
	/// Key: "Description.CanUsersWagerRobuxInGameCurrencyPurchasedWithRobuxOrOtherItemsOfRealValue"
	/// Answer choices are "No", "Yes"
	/// English String: "Can users wager Robux, in game currency purchased with Robux or other items of real value?"
	/// </summary>
	public override string DescriptionCanUsersWagerRobuxInGameCurrencyPurchasedWithRobuxOrOtherItemsOfRealValue => "使用者能否以 Robux、使用 Robux 購買的遊戲內貨幣或有實際價值的物品下注？";

	/// <summary>
	/// Key: "Description.DefenselessViolenceQuestion"
	/// Answer choices are "No", "Yes"
	/// English String: "Does this game contain violence directed towards defenseless characters?"
	/// </summary>
	public override string DescriptionDefenselessViolenceQuestion => "此遊戲是否含有針對普通角色的暴力內容？";

	/// <summary>
	/// Key: "Description.DoesThisGameContainBathroomHumor"
	/// Answer choices are "No", "Infrequently", "Frequently"
	/// English String: "Does this game contain bathroom humor?"
	/// </summary>
	public override string DescriptionDoesThisGameContainBathroomHumor => "此遊戲是否含有和排泄物相關的內容？";

	/// <summary>
	/// Key: "Description.DoesThisGameContainCrudeHumor"
	/// Answer choices are "No", "Infrequently", "Frequently"
	/// English String: "Does this game contain crude humor?"
	/// </summary>
	public override string DescriptionDoesThisGameContainCrudeHumor => "此遊戲是否含有低級內容？";

	/// <summary>
	/// Key: "Description.DoesThisGameContainNudityOrDepictionsOfSex"
	/// Answer choices are "No", "Yes"
	/// English String: "Does this game contain nudity or depictions of sex?"
	/// </summary>
	public override string DescriptionDoesThisGameContainNudityOrDepictionsOfSex => "此遊戲是否含有和裸體或性愛相關的內容？";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs"
	/// This question has four possible answer choices: "No", "Infrequent references", "Frequent references", "Characters are shown using alcohol, tobacco or drugs"
	/// English String: "Does this game contain references to alcohol, tobacco or drugs?"
	/// </summary>
	public override string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugs => "此遊戲是否含有和酒精、菸草或毒品相關的內容？";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.CharactersAreShownUsingAlcoholTobac"
	/// One of four possible answers to "Does this game contain references to alcohol, tobacco or drugs?", with an implied "Yes"
	/// English String: "Characters are shown using alcohol, tobacco or drugs"
	/// </summary>
	public override string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsCharactersAreShownUsingAlcoholTobac => "角色顯示使用酒精、菸草或毒品";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.FrequentReferences"
	/// One of four possible answers to "Does this game contain references to alcohol, tobacco or drugs?", with an implied "Yes"
	/// English String: "Frequent references"
	/// </summary>
	public override string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsFrequentReferences => "大量內容";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.InfrequentReferences"
	/// One of four possible answers to "Does this game contain references to alcohol, tobacco or drugs?", with an implied "Yes"
	/// English String: "Infrequent references"
	/// </summary>
	public override string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsInfrequentReferences => "少量內容";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.No"
	/// One of four possible answers to "Does this game contain references to alcohol, tobacco or drugs?"
	/// English String: "No"
	/// </summary>
	public override string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsNo => "否";

	/// <summary>
	/// Key: "Description.DoesThisGameContainSimulatedGamblingOrPaidLootBoxes"
	/// Answer choices are "No", "Yes"
	/// English String: "Does this game contain simulated gambling or paid loot boxes?"
	/// </summary>
	public override string DescriptionDoesThisGameContainSimulatedGamblingOrPaidLootBoxes => "此遊戲是否含有虛擬賭博或戰利品箱？";

	/// <summary>
	/// Key: "Description.DoesThisGameContainSuggestiveSexualThemes"
	/// Answer choices are "No", "Yes"
	/// English String: "Does this game contain suggestive sexual themes?"
	/// </summary>
	public override string DescriptionDoesThisGameContainSuggestiveSexualThemes => "此遊戲是否含有性暗示？";

	/// <summary>
	/// Key: "Description.DoesThisGameFollowTheCommunityRules"
	/// Answer choices are "No, "Yes"
	/// English String: "Does this game follow the the community rules? "
	/// </summary>
	public override string DescriptionDoesThisGameFollowTheCommunityRules => "此遊戲是否遵守社群規則？ ";

	/// <summary>
	/// Key: "Description.DoesThisGameFollowTheCommunityRules.No"
	/// This game does not follow community rules
	/// English String: "No"
	/// </summary>
	public override string DescriptionDoesThisGameFollowTheCommunityRulesNo => "否";

	/// <summary>
	/// Key: "Description.DoesThisGameFollowTheCommunityRules.Yes"
	/// This game does follow community rules
	/// English String: "Yes"
	/// </summary>
	public override string DescriptionDoesThisGameFollowTheCommunityRulesYes => "是";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity"
	/// This question has four possible answer choices: "No", "Some mild bad language", "Infrequenty profanity", "Frequent profanity"
	/// English String: "Does this game use profanity?"
	/// </summary>
	public override string DescriptionDoesThisGameUseProfanity => "此遊戲是否使用髒話？";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity.FrequentProfanity"
	/// One of four possible answers to "Does this game use profanity?", with an implied "Yes"
	/// English String: "Frequent profanity"
	/// </summary>
	public override string DescriptionDoesThisGameUseProfanityFrequentProfanity => "大量髒話";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity.InfrequentProfanity"
	/// One of four possible answers to "Does this game use profanity?", with an implied "Yes"
	/// English String: "Infrequent profanity"
	/// </summary>
	public override string DescriptionDoesThisGameUseProfanityInfrequentProfanity => "少量髒話";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity.No"
	/// One of four possible answers to "Does this game use profanity?"
	/// English String: "No"
	/// </summary>
	public override string DescriptionDoesThisGameUseProfanityNo => "否";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity.SomeMildBadLanguage"
	/// One of four possible answers to "Does this game use profanity?", with an implied "Yes"
	/// English String: "Some mild bad language"
	/// </summary>
	public override string DescriptionDoesThisGameUseProfanitySomeMildBadLanguage => "程度輕微的髒話";

	/// <summary>
	/// Key: "Description.ScaryForChildUnderEightQuestion"
	/// Answer choices are "No", "Infrequently", "Frequently"
	/// English String: "Does this game contain content that might be scary for a young child under 8 years old?"
	/// </summary>
	public override string DescriptionScaryForChildUnderEightQuestion => "此遊戲是否含有可能會讓 8 歲以下兒童感到恐懼的內容？";

	/// <summary>
	/// Key: "Description.ScaryForChildUnderTwelveQuestion"
	/// Answer choices are "No", "Infrequently", "Frequently"
	/// English String: "Does this game contain content that might be scary for a young child under 12 years old?"
	/// </summary>
	public override string DescriptionScaryForChildUnderTwelveQuestion => "此遊戲是否含有可能會讓 12 歲以下兒童感到恐懼的內容？";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.ComicalViolence"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?", with an implied "Yes"
	/// English String: "Comical violence"
	/// </summary>
	public override string DescriptionViolenceQuestionComicalViolence => "趣味性暴力";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.DoesThisGameContainViolentContent"
	/// Note: This survey question lets user pick one of five possible responses, as opposed to being just a "Yes/No" question.
	/// English String: "Does this game contain violent content?"
	/// </summary>
	public override string DescriptionViolenceQuestionDoesThisGameContainViolentContent => "此遊戲是否含有暴力內容？";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.EasilyDistinguishableFromRealLife"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?", with an implied "Yes"
	/// English String: "Easily distinguishable from real life"
	/// </summary>
	public override string DescriptionViolenceQuestionEasilyDistinguishableFromRealLife => "容易與現實區分的暴力";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.ExtremeRealisticViolence"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?", with an implied "Yes"
	/// English String: "Extreme, realistic violence"
	/// </summary>
	public override string DescriptionViolenceQuestionExtremeRealisticViolence => "極度逼真的暴力";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.No"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?"
	/// English String: "No"
	/// </summary>
	public override string DescriptionViolenceQuestionNo => "否";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.SomeRealisticViolence"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?", with an implied "Yes"
	/// English String: "Some realistic violence"
	/// </summary>
	public override string DescriptionViolenceQuestionSomeRealisticViolence => "一些逼真的暴力";

	public SurveysGameRatingsResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForDescriptionAnswerToDoesThisGameContainFrequently()
	{
		return "大量";
	}

	protected override string _GetTemplateForDescriptionAnswerToDoesThisGameContainInfrequently()
	{
		return "少量";
	}

	protected override string _GetTemplateForDescriptionAnswerToDoesThisGameContainNo()
	{
		return "否";
	}

	protected override string _GetTemplateForDescriptionAnswerToDoesThisGameContainYes()
	{
		return "是";
	}

	protected override string _GetTemplateForDescriptionCanUsersWagerRobuxInGameCurrencyPurchasedWithRobuxOrOtherItemsOfRealValue()
	{
		return "使用者能否以 Robux、使用 Robux 購買的遊戲內貨幣或有實際價值的物品下注？";
	}

	protected override string _GetTemplateForDescriptionDefenselessViolenceQuestion()
	{
		return "此遊戲是否含有針對普通角色的暴力內容？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainBathroomHumor()
	{
		return "此遊戲是否含有和排泄物相關的內容？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainCrudeHumor()
	{
		return "此遊戲是否含有低級內容？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainNudityOrDepictionsOfSex()
	{
		return "此遊戲是否含有和裸體或性愛相關的內容？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugs()
	{
		return "此遊戲是否含有和酒精、菸草或毒品相關的內容？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsCharactersAreShownUsingAlcoholTobac()
	{
		return "角色顯示使用酒精、菸草或毒品";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsFrequentReferences()
	{
		return "大量內容";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsInfrequentReferences()
	{
		return "少量內容";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsNo()
	{
		return "否";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainSimulatedGamblingOrPaidLootBoxes()
	{
		return "此遊戲是否含有虛擬賭博或戰利品箱？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameContainSuggestiveSexualThemes()
	{
		return "此遊戲是否含有性暗示？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameFollowTheCommunityRules()
	{
		return "此遊戲是否遵守社群規則？ ";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameFollowTheCommunityRulesNo()
	{
		return "否";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameFollowTheCommunityRulesYes()
	{
		return "是";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameUseProfanity()
	{
		return "此遊戲是否使用髒話？";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameUseProfanityFrequentProfanity()
	{
		return "大量髒話";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameUseProfanityInfrequentProfanity()
	{
		return "少量髒話";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameUseProfanityNo()
	{
		return "否";
	}

	protected override string _GetTemplateForDescriptionDoesThisGameUseProfanitySomeMildBadLanguage()
	{
		return "程度輕微的髒話";
	}

	protected override string _GetTemplateForDescriptionScaryForChildUnderEightQuestion()
	{
		return "此遊戲是否含有可能會讓 8 歲以下兒童感到恐懼的內容？";
	}

	protected override string _GetTemplateForDescriptionScaryForChildUnderTwelveQuestion()
	{
		return "此遊戲是否含有可能會讓 12 歲以下兒童感到恐懼的內容？";
	}

	protected override string _GetTemplateForDescriptionViolenceQuestionComicalViolence()
	{
		return "趣味性暴力";
	}

	protected override string _GetTemplateForDescriptionViolenceQuestionDoesThisGameContainViolentContent()
	{
		return "此遊戲是否含有暴力內容？";
	}

	protected override string _GetTemplateForDescriptionViolenceQuestionEasilyDistinguishableFromRealLife()
	{
		return "容易與現實區分的暴力";
	}

	protected override string _GetTemplateForDescriptionViolenceQuestionExtremeRealisticViolence()
	{
		return "極度逼真的暴力";
	}

	protected override string _GetTemplateForDescriptionViolenceQuestionNo()
	{
		return "否";
	}

	protected override string _GetTemplateForDescriptionViolenceQuestionSomeRealisticViolence()
	{
		return "一些逼真的暴力";
	}
}
