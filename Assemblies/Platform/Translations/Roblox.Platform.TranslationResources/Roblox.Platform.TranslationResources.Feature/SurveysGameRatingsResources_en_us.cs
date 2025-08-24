using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class SurveysGameRatingsResources_en_us : TranslationResourcesBase, ISurveysGameRatingsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Description.AnswerToDoesThisGameContain.Frequently"
	/// A recurring possible answer choice to questions formatted as "Does this game contain ____?"
	/// English String: "Frequently"
	/// </summary>
	public virtual string DescriptionAnswerToDoesThisGameContainFrequently => "Frequently";

	/// <summary>
	/// Key: "Description.AnswerToDoesThisGameContain.Infrequently"
	/// A recurring possible answer choice to questions formatted as "Does this game contain ____?"
	/// English String: "Infrequently"
	/// </summary>
	public virtual string DescriptionAnswerToDoesThisGameContainInfrequently => "Infrequently";

	/// <summary>
	/// Key: "Description.AnswerToDoesThisGameContain.No"
	/// A recurring possible answer choice to questions formatted as "Does this game contain ____ ?"
	/// English String: "No"
	/// </summary>
	public virtual string DescriptionAnswerToDoesThisGameContainNo => "No";

	/// <summary>
	/// Key: "Description.AnswerToDoesThisGameContain.Yes"
	/// A recurring possible answer choice to questions formatted as "Does this game contain ____ ?"
	/// English String: "Yes"
	/// </summary>
	public virtual string DescriptionAnswerToDoesThisGameContainYes => "Yes";

	/// <summary>
	/// Key: "Description.CanUsersWagerRobuxInGameCurrencyPurchasedWithRobuxOrOtherItemsOfRealValue"
	/// Answer choices are "No", "Yes"
	/// English String: "Can users wager Robux, in game currency purchased with Robux or other items of real value?"
	/// </summary>
	public virtual string DescriptionCanUsersWagerRobuxInGameCurrencyPurchasedWithRobuxOrOtherItemsOfRealValue => "Can users wager Robux, in game currency purchased with Robux or other items of real value?";

	/// <summary>
	/// Key: "Description.DefenselessViolenceQuestion"
	/// Answer choices are "No", "Yes"
	/// English String: "Does this game contain violence directed towards defenseless characters?"
	/// </summary>
	public virtual string DescriptionDefenselessViolenceQuestion => "Does this game contain violence directed towards defenseless characters?";

	/// <summary>
	/// Key: "Description.DoesThisGameContainBathroomHumor"
	/// Answer choices are "No", "Infrequently", "Frequently"
	/// English String: "Does this game contain bathroom humor?"
	/// </summary>
	public virtual string DescriptionDoesThisGameContainBathroomHumor => "Does this game contain bathroom humor?";

	/// <summary>
	/// Key: "Description.DoesThisGameContainCrudeHumor"
	/// Answer choices are "No", "Infrequently", "Frequently"
	/// English String: "Does this game contain crude humor?"
	/// </summary>
	public virtual string DescriptionDoesThisGameContainCrudeHumor => "Does this game contain crude humor?";

	/// <summary>
	/// Key: "Description.DoesThisGameContainNudityOrDepictionsOfSex"
	/// Answer choices are "No", "Yes"
	/// English String: "Does this game contain nudity or depictions of sex?"
	/// </summary>
	public virtual string DescriptionDoesThisGameContainNudityOrDepictionsOfSex => "Does this game contain nudity or depictions of sex?";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs"
	/// This question has four possible answer choices: "No", "Infrequent references", "Frequent references", "Characters are shown using alcohol, tobacco or drugs"
	/// English String: "Does this game contain references to alcohol, tobacco or drugs?"
	/// </summary>
	public virtual string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugs => "Does this game contain references to alcohol, tobacco or drugs?";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.CharactersAreShownUsingAlcoholTobac"
	/// One of four possible answers to "Does this game contain references to alcohol, tobacco or drugs?", with an implied "Yes"
	/// English String: "Characters are shown using alcohol, tobacco or drugs"
	/// </summary>
	public virtual string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsCharactersAreShownUsingAlcoholTobac => "Characters are shown using alcohol, tobacco or drugs";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.FrequentReferences"
	/// One of four possible answers to "Does this game contain references to alcohol, tobacco or drugs?", with an implied "Yes"
	/// English String: "Frequent references"
	/// </summary>
	public virtual string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsFrequentReferences => "Frequent references";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.InfrequentReferences"
	/// One of four possible answers to "Does this game contain references to alcohol, tobacco or drugs?", with an implied "Yes"
	/// English String: "Infrequent references"
	/// </summary>
	public virtual string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsInfrequentReferences => "Infrequent references";

	/// <summary>
	/// Key: "Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.No"
	/// One of four possible answers to "Does this game contain references to alcohol, tobacco or drugs?"
	/// English String: "No"
	/// </summary>
	public virtual string DescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsNo => "No";

	/// <summary>
	/// Key: "Description.DoesThisGameContainSimulatedGamblingOrPaidLootBoxes"
	/// Answer choices are "No", "Yes"
	/// English String: "Does this game contain simulated gambling or paid loot boxes?"
	/// </summary>
	public virtual string DescriptionDoesThisGameContainSimulatedGamblingOrPaidLootBoxes => "Does this game contain simulated gambling or paid loot boxes?";

	/// <summary>
	/// Key: "Description.DoesThisGameContainSuggestiveSexualThemes"
	/// Answer choices are "No", "Yes"
	/// English String: "Does this game contain suggestive sexual themes?"
	/// </summary>
	public virtual string DescriptionDoesThisGameContainSuggestiveSexualThemes => "Does this game contain suggestive sexual themes?";

	/// <summary>
	/// Key: "Description.DoesThisGameFollowTheCommunityRules"
	/// Answer choices are "No, "Yes"
	/// English String: "Does this game follow the the community rules? "
	/// </summary>
	public virtual string DescriptionDoesThisGameFollowTheCommunityRules => "Does this game follow the the community rules? ";

	/// <summary>
	/// Key: "Description.DoesThisGameFollowTheCommunityRules.No"
	/// This game does not follow community rules
	/// English String: "No"
	/// </summary>
	public virtual string DescriptionDoesThisGameFollowTheCommunityRulesNo => "No";

	/// <summary>
	/// Key: "Description.DoesThisGameFollowTheCommunityRules.Yes"
	/// This game does follow community rules
	/// English String: "Yes"
	/// </summary>
	public virtual string DescriptionDoesThisGameFollowTheCommunityRulesYes => "Yes";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity"
	/// This question has four possible answer choices: "No", "Some mild bad language", "Infrequenty profanity", "Frequent profanity"
	/// English String: "Does this game use profanity?"
	/// </summary>
	public virtual string DescriptionDoesThisGameUseProfanity => "Does this game use profanity?";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity.FrequentProfanity"
	/// One of four possible answers to "Does this game use profanity?", with an implied "Yes"
	/// English String: "Frequent profanity"
	/// </summary>
	public virtual string DescriptionDoesThisGameUseProfanityFrequentProfanity => "Frequent profanity";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity.InfrequentProfanity"
	/// One of four possible answers to "Does this game use profanity?", with an implied "Yes"
	/// English String: "Infrequent profanity"
	/// </summary>
	public virtual string DescriptionDoesThisGameUseProfanityInfrequentProfanity => "Infrequent profanity";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity.No"
	/// One of four possible answers to "Does this game use profanity?"
	/// English String: "No"
	/// </summary>
	public virtual string DescriptionDoesThisGameUseProfanityNo => "No";

	/// <summary>
	/// Key: "Description.DoesThisGameUseProfanity.SomeMildBadLanguage"
	/// One of four possible answers to "Does this game use profanity?", with an implied "Yes"
	/// English String: "Some mild bad language"
	/// </summary>
	public virtual string DescriptionDoesThisGameUseProfanitySomeMildBadLanguage => "Some mild bad language";

	/// <summary>
	/// Key: "Description.ScaryForChildUnderEightQuestion"
	/// Answer choices are "No", "Infrequently", "Frequently"
	/// English String: "Does this game contain content that might be scary for a young child under 8 years old?"
	/// </summary>
	public virtual string DescriptionScaryForChildUnderEightQuestion => "Does this game contain content that might be scary for a young child under 8 years old?";

	/// <summary>
	/// Key: "Description.ScaryForChildUnderTwelveQuestion"
	/// Answer choices are "No", "Infrequently", "Frequently"
	/// English String: "Does this game contain content that might be scary for a young child under 12 years old?"
	/// </summary>
	public virtual string DescriptionScaryForChildUnderTwelveQuestion => "Does this game contain content that might be scary for a young child under 12 years old?";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.ComicalViolence"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?", with an implied "Yes"
	/// English String: "Comical violence"
	/// </summary>
	public virtual string DescriptionViolenceQuestionComicalViolence => "Comical violence";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.DoesThisGameContainViolentContent"
	/// Note: This survey question lets user pick one of five possible responses, as opposed to being just a "Yes/No" question.
	/// English String: "Does this game contain violent content?"
	/// </summary>
	public virtual string DescriptionViolenceQuestionDoesThisGameContainViolentContent => "Does this game contain violent content?";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.EasilyDistinguishableFromRealLife"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?", with an implied "Yes"
	/// English String: "Easily distinguishable from real life"
	/// </summary>
	public virtual string DescriptionViolenceQuestionEasilyDistinguishableFromRealLife => "Easily distinguishable from real life";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.ExtremeRealisticViolence"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?", with an implied "Yes"
	/// English String: "Extreme, realistic violence"
	/// </summary>
	public virtual string DescriptionViolenceQuestionExtremeRealisticViolence => "Extreme, realistic violence";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.No"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?"
	/// English String: "No"
	/// </summary>
	public virtual string DescriptionViolenceQuestionNo => "No";

	/// <summary>
	/// Key: "Description.ViolenceQuestion.SomeRealisticViolence"
	/// Note: This is one out of five possible answers to the question "Does this game contain violent content?", with an implied "Yes"
	/// English String: "Some realistic violence"
	/// </summary>
	public virtual string DescriptionViolenceQuestionSomeRealisticViolence => "Some realistic violence";

	public SurveysGameRatingsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Description.AnswerToDoesThisGameContain.Frequently",
				_GetTemplateForDescriptionAnswerToDoesThisGameContainFrequently()
			},
			{
				"Description.AnswerToDoesThisGameContain.Infrequently",
				_GetTemplateForDescriptionAnswerToDoesThisGameContainInfrequently()
			},
			{
				"Description.AnswerToDoesThisGameContain.No",
				_GetTemplateForDescriptionAnswerToDoesThisGameContainNo()
			},
			{
				"Description.AnswerToDoesThisGameContain.Yes",
				_GetTemplateForDescriptionAnswerToDoesThisGameContainYes()
			},
			{
				"Description.CanUsersWagerRobuxInGameCurrencyPurchasedWithRobuxOrOtherItemsOfRealValue",
				_GetTemplateForDescriptionCanUsersWagerRobuxInGameCurrencyPurchasedWithRobuxOrOtherItemsOfRealValue()
			},
			{
				"Description.DefenselessViolenceQuestion",
				_GetTemplateForDescriptionDefenselessViolenceQuestion()
			},
			{
				"Description.DoesThisGameContainBathroomHumor",
				_GetTemplateForDescriptionDoesThisGameContainBathroomHumor()
			},
			{
				"Description.DoesThisGameContainCrudeHumor",
				_GetTemplateForDescriptionDoesThisGameContainCrudeHumor()
			},
			{
				"Description.DoesThisGameContainNudityOrDepictionsOfSex",
				_GetTemplateForDescriptionDoesThisGameContainNudityOrDepictionsOfSex()
			},
			{
				"Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs",
				_GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugs()
			},
			{
				"Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.CharactersAreShownUsingAlcoholTobac",
				_GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsCharactersAreShownUsingAlcoholTobac()
			},
			{
				"Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.FrequentReferences",
				_GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsFrequentReferences()
			},
			{
				"Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.InfrequentReferences",
				_GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsInfrequentReferences()
			},
			{
				"Description.DoesThisGameContainReferencesToAlcoholTobaccoOrDrugs.No",
				_GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsNo()
			},
			{
				"Description.DoesThisGameContainSimulatedGamblingOrPaidLootBoxes",
				_GetTemplateForDescriptionDoesThisGameContainSimulatedGamblingOrPaidLootBoxes()
			},
			{
				"Description.DoesThisGameContainSuggestiveSexualThemes",
				_GetTemplateForDescriptionDoesThisGameContainSuggestiveSexualThemes()
			},
			{
				"Description.DoesThisGameFollowTheCommunityRules",
				_GetTemplateForDescriptionDoesThisGameFollowTheCommunityRules()
			},
			{
				"Description.DoesThisGameFollowTheCommunityRules.No",
				_GetTemplateForDescriptionDoesThisGameFollowTheCommunityRulesNo()
			},
			{
				"Description.DoesThisGameFollowTheCommunityRules.Yes",
				_GetTemplateForDescriptionDoesThisGameFollowTheCommunityRulesYes()
			},
			{
				"Description.DoesThisGameUseProfanity",
				_GetTemplateForDescriptionDoesThisGameUseProfanity()
			},
			{
				"Description.DoesThisGameUseProfanity.FrequentProfanity",
				_GetTemplateForDescriptionDoesThisGameUseProfanityFrequentProfanity()
			},
			{
				"Description.DoesThisGameUseProfanity.InfrequentProfanity",
				_GetTemplateForDescriptionDoesThisGameUseProfanityInfrequentProfanity()
			},
			{
				"Description.DoesThisGameUseProfanity.No",
				_GetTemplateForDescriptionDoesThisGameUseProfanityNo()
			},
			{
				"Description.DoesThisGameUseProfanity.SomeMildBadLanguage",
				_GetTemplateForDescriptionDoesThisGameUseProfanitySomeMildBadLanguage()
			},
			{
				"Description.ScaryForChildUnderEightQuestion",
				_GetTemplateForDescriptionScaryForChildUnderEightQuestion()
			},
			{
				"Description.ScaryForChildUnderTwelveQuestion",
				_GetTemplateForDescriptionScaryForChildUnderTwelveQuestion()
			},
			{
				"Description.ViolenceQuestion.ComicalViolence",
				_GetTemplateForDescriptionViolenceQuestionComicalViolence()
			},
			{
				"Description.ViolenceQuestion.DoesThisGameContainViolentContent",
				_GetTemplateForDescriptionViolenceQuestionDoesThisGameContainViolentContent()
			},
			{
				"Description.ViolenceQuestion.EasilyDistinguishableFromRealLife",
				_GetTemplateForDescriptionViolenceQuestionEasilyDistinguishableFromRealLife()
			},
			{
				"Description.ViolenceQuestion.ExtremeRealisticViolence",
				_GetTemplateForDescriptionViolenceQuestionExtremeRealisticViolence()
			},
			{
				"Description.ViolenceQuestion.No",
				_GetTemplateForDescriptionViolenceQuestionNo()
			},
			{
				"Description.ViolenceQuestion.SomeRealisticViolence",
				_GetTemplateForDescriptionViolenceQuestionSomeRealisticViolence()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.SurveysGameRatings";
	}

	protected virtual string _GetTemplateForDescriptionAnswerToDoesThisGameContainFrequently()
	{
		return "Frequently";
	}

	protected virtual string _GetTemplateForDescriptionAnswerToDoesThisGameContainInfrequently()
	{
		return "Infrequently";
	}

	protected virtual string _GetTemplateForDescriptionAnswerToDoesThisGameContainNo()
	{
		return "No";
	}

	protected virtual string _GetTemplateForDescriptionAnswerToDoesThisGameContainYes()
	{
		return "Yes";
	}

	protected virtual string _GetTemplateForDescriptionCanUsersWagerRobuxInGameCurrencyPurchasedWithRobuxOrOtherItemsOfRealValue()
	{
		return "Can users wager Robux, in game currency purchased with Robux or other items of real value?";
	}

	protected virtual string _GetTemplateForDescriptionDefenselessViolenceQuestion()
	{
		return "Does this game contain violence directed towards defenseless characters?";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameContainBathroomHumor()
	{
		return "Does this game contain bathroom humor?";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameContainCrudeHumor()
	{
		return "Does this game contain crude humor?";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameContainNudityOrDepictionsOfSex()
	{
		return "Does this game contain nudity or depictions of sex?";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugs()
	{
		return "Does this game contain references to alcohol, tobacco or drugs?";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsCharactersAreShownUsingAlcoholTobac()
	{
		return "Characters are shown using alcohol, tobacco or drugs";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsFrequentReferences()
	{
		return "Frequent references";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsInfrequentReferences()
	{
		return "Infrequent references";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameContainReferencesToAlcoholTobaccoOrDrugsNo()
	{
		return "No";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameContainSimulatedGamblingOrPaidLootBoxes()
	{
		return "Does this game contain simulated gambling or paid loot boxes?";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameContainSuggestiveSexualThemes()
	{
		return "Does this game contain suggestive sexual themes?";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameFollowTheCommunityRules()
	{
		return "Does this game follow the the community rules? ";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameFollowTheCommunityRulesNo()
	{
		return "No";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameFollowTheCommunityRulesYes()
	{
		return "Yes";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameUseProfanity()
	{
		return "Does this game use profanity?";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameUseProfanityFrequentProfanity()
	{
		return "Frequent profanity";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameUseProfanityInfrequentProfanity()
	{
		return "Infrequent profanity";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameUseProfanityNo()
	{
		return "No";
	}

	protected virtual string _GetTemplateForDescriptionDoesThisGameUseProfanitySomeMildBadLanguage()
	{
		return "Some mild bad language";
	}

	protected virtual string _GetTemplateForDescriptionScaryForChildUnderEightQuestion()
	{
		return "Does this game contain content that might be scary for a young child under 8 years old?";
	}

	protected virtual string _GetTemplateForDescriptionScaryForChildUnderTwelveQuestion()
	{
		return "Does this game contain content that might be scary for a young child under 12 years old?";
	}

	protected virtual string _GetTemplateForDescriptionViolenceQuestionComicalViolence()
	{
		return "Comical violence";
	}

	protected virtual string _GetTemplateForDescriptionViolenceQuestionDoesThisGameContainViolentContent()
	{
		return "Does this game contain violent content?";
	}

	protected virtual string _GetTemplateForDescriptionViolenceQuestionEasilyDistinguishableFromRealLife()
	{
		return "Easily distinguishable from real life";
	}

	protected virtual string _GetTemplateForDescriptionViolenceQuestionExtremeRealisticViolence()
	{
		return "Extreme, realistic violence";
	}

	protected virtual string _GetTemplateForDescriptionViolenceQuestionNo()
	{
		return "No";
	}

	protected virtual string _GetTemplateForDescriptionViolenceQuestionSomeRealisticViolence()
	{
		return "Some realistic violence";
	}
}
