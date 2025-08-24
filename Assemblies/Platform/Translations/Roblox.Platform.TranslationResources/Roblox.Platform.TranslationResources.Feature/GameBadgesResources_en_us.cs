using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class GameBadgesResources_en_us : TranslationResourcesBase, IGameBadgesResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "HeadingGameBadges"
	/// English String: "Game Badges"
	/// </summary>
	public virtual string HeadingGameBadges => "Game Badges";

	/// <summary>
	/// Key: "Label.RarityCakeWalk"
	/// It would be extremely easy for the user to accomplish this goal.
	/// English String: "Cake Walk"
	/// </summary>
	public virtual string LabelRarityCakeWalk => "Cake Walk";

	/// <summary>
	/// Key: "Label.RarityChallenging"
	/// It would be somewhat difficult for the user to accomplish this goal.
	/// English String: "Challenging"
	/// </summary>
	public virtual string LabelRarityChallenging => "Challenging";

	/// <summary>
	/// Key: "Label.RarityEasy"
	/// It would be easy for the user to accomplish this goal.
	/// English String: "Easy"
	/// </summary>
	public virtual string LabelRarityEasy => "Easy";

	/// <summary>
	/// Key: "Label.RarityExtreme"
	/// It would be extremely difficult for the user to accomplish this goal.
	/// English String: "Extreme"
	/// </summary>
	public virtual string LabelRarityExtreme => "Extreme";

	/// <summary>
	/// Key: "Label.RarityFreebie"
	/// The user will get this badge for free.
	/// English String: "Freebie"
	/// </summary>
	public virtual string LabelRarityFreebie => "Freebie";

	/// <summary>
	/// Key: "Label.RarityHard"
	/// It would be difficult for the user to accomplish this goal.
	/// English String: "Hard"
	/// </summary>
	public virtual string LabelRarityHard => "Hard";

	/// <summary>
	/// Key: "Label.RarityImpossible"
	/// It is impossible for the user to accomplish this goal.
	/// English String: "Impossible"
	/// </summary>
	public virtual string LabelRarityImpossible => "Impossible";

	/// <summary>
	/// Key: "Label.RarityInsane"
	/// It is nearly impossible for the user to accomplish this goal.
	/// English String: "Insane"
	/// </summary>
	public virtual string LabelRarityInsane => "Insane";

	/// <summary>
	/// Key: "Label.RarityModerate"
	/// It would be moderate for the user to accomplish this goal. It is neither easy nor hard.
	/// English String: "Moderate"
	/// </summary>
	public virtual string LabelRarityModerate => "Moderate";

	/// <summary>
	/// Key: "LabelRarity"
	/// English String: "Rarity"
	/// </summary>
	public virtual string LabelRarity => "Rarity";

	/// <summary>
	/// Key: "LabelSeeMore"
	/// English String: "See More"
	/// </summary>
	public virtual string LabelSeeMore => "See More";

	/// <summary>
	/// Key: "LabelWonEver"
	/// English String: "Won Ever"
	/// </summary>
	public virtual string LabelWonEver => "Won Ever";

	/// <summary>
	/// Key: "LabelWonYesterday"
	/// English String: "Won Yesterday"
	/// </summary>
	public virtual string LabelWonYesterday => "Won Yesterday";

	public GameBadgesResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"HeadingGameBadges",
				_GetTemplateForHeadingGameBadges()
			},
			{
				"Label.RarityCakeWalk",
				_GetTemplateForLabelRarityCakeWalk()
			},
			{
				"Label.RarityChallenging",
				_GetTemplateForLabelRarityChallenging()
			},
			{
				"Label.RarityEasy",
				_GetTemplateForLabelRarityEasy()
			},
			{
				"Label.RarityExtreme",
				_GetTemplateForLabelRarityExtreme()
			},
			{
				"Label.RarityFreebie",
				_GetTemplateForLabelRarityFreebie()
			},
			{
				"Label.RarityHard",
				_GetTemplateForLabelRarityHard()
			},
			{
				"Label.RarityImpossible",
				_GetTemplateForLabelRarityImpossible()
			},
			{
				"Label.RarityInsane",
				_GetTemplateForLabelRarityInsane()
			},
			{
				"Label.RarityModerate",
				_GetTemplateForLabelRarityModerate()
			},
			{
				"LabelRarity",
				_GetTemplateForLabelRarity()
			},
			{
				"LabelSeeMore",
				_GetTemplateForLabelSeeMore()
			},
			{
				"LabelWonEver",
				_GetTemplateForLabelWonEver()
			},
			{
				"LabelWonYesterday",
				_GetTemplateForLabelWonYesterday()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.GameBadges";
	}

	protected virtual string _GetTemplateForHeadingGameBadges()
	{
		return "Game Badges";
	}

	protected virtual string _GetTemplateForLabelRarityCakeWalk()
	{
		return "Cake Walk";
	}

	protected virtual string _GetTemplateForLabelRarityChallenging()
	{
		return "Challenging";
	}

	protected virtual string _GetTemplateForLabelRarityEasy()
	{
		return "Easy";
	}

	protected virtual string _GetTemplateForLabelRarityExtreme()
	{
		return "Extreme";
	}

	protected virtual string _GetTemplateForLabelRarityFreebie()
	{
		return "Freebie";
	}

	protected virtual string _GetTemplateForLabelRarityHard()
	{
		return "Hard";
	}

	protected virtual string _GetTemplateForLabelRarityImpossible()
	{
		return "Impossible";
	}

	protected virtual string _GetTemplateForLabelRarityInsane()
	{
		return "Insane";
	}

	protected virtual string _GetTemplateForLabelRarityModerate()
	{
		return "Moderate";
	}

	protected virtual string _GetTemplateForLabelRarity()
	{
		return "Rarity";
	}

	protected virtual string _GetTemplateForLabelSeeMore()
	{
		return "See More";
	}

	protected virtual string _GetTemplateForLabelWonEver()
	{
		return "Won Ever";
	}

	protected virtual string _GetTemplateForLabelWonYesterday()
	{
		return "Won Yesterday";
	}
}
