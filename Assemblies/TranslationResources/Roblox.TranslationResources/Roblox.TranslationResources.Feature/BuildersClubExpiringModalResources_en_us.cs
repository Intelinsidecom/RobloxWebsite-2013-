using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class BuildersClubExpiringModalResources_en_us : TranslationResourcesBase, IBuildersClubExpiringModalResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.NoThanks"
	/// button text
	/// English String: "No, thanks."
	/// </summary>
	public virtual string ActionNoThanks => "No, thanks.";

	/// <summary>
	/// Key: "Action.WantToRenew"
	/// button text
	/// English String: "I Want To Renew!"
	/// </summary>
	public virtual string ActionWantToRenew => "I Want To Renew!";

	/// <summary>
	/// Key: "Description.BuildersClubExpired"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership has expired!"
	/// </summary>
	public virtual string DescriptionBuildersClubExpired => "Oh, no! Your Builders Club membership has expired!";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringOneDay"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring in one day!"
	/// </summary>
	public virtual string DescriptionBuildersClubExpiringOneDay => "Oh, no! Your Builders Club membership is expiring in one day!";

	/// <summary>
	/// Key: "Description.BuildersClubExpiringToday"
	/// description
	/// English String: "Oh, no! Your Builders Club membership is expiring today!"
	/// </summary>
	public virtual string DescriptionBuildersClubExpiringToday => "Oh, no! Your Builders Club membership is expiring today!";

	/// <summary>
	/// Key: "Heading.DontMissRenewNow"
	/// modal heading
	/// English String: "Don't Miss Out - Renew Now!"
	/// </summary>
	public virtual string HeadingDontMissRenewNow => "Don't Miss Out - Renew Now!";

	public BuildersClubExpiringModalResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.NoThanks",
				_GetTemplateForActionNoThanks()
			},
			{
				"Action.WantToRenew",
				_GetTemplateForActionWantToRenew()
			},
			{
				"Description.BuildersClubExpired",
				_GetTemplateForDescriptionBuildersClubExpired()
			},
			{
				"Description.BuildersClubExpiringOneDay",
				_GetTemplateForDescriptionBuildersClubExpiringOneDay()
			},
			{
				"Description.BuildersClubExpiringSomeDays",
				_GetTemplateForDescriptionBuildersClubExpiringSomeDays()
			},
			{
				"Description.BuildersClubExpiringToday",
				_GetTemplateForDescriptionBuildersClubExpiringToday()
			},
			{
				"Heading.DontMissRenewNow",
				_GetTemplateForHeadingDontMissRenewNow()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.BuildersClubExpiringModal";
	}

	protected virtual string _GetTemplateForActionNoThanks()
	{
		return "No, thanks.";
	}

	protected virtual string _GetTemplateForActionWantToRenew()
	{
		return "I Want To Renew!";
	}

	protected virtual string _GetTemplateForDescriptionBuildersClubExpired()
	{
		return "Oh, no! Your Builders Club membership has expired!";
	}

	protected virtual string _GetTemplateForDescriptionBuildersClubExpiringOneDay()
	{
		return "Oh, no! Your Builders Club membership is expiring in one day!";
	}

	/// <summary>
	/// Key: "Description.BuildersClubExpiringSomeDays"
	/// description text
	/// English String: "Oh, no! Your Builders Club membership is expiring in {numDays} days!"
	/// </summary>
	public virtual string DescriptionBuildersClubExpiringSomeDays(string numDays)
	{
		return $"Oh, no! Your Builders Club membership is expiring in {numDays} days!";
	}

	protected virtual string _GetTemplateForDescriptionBuildersClubExpiringSomeDays()
	{
		return "Oh, no! Your Builders Club membership is expiring in {numDays} days!";
	}

	protected virtual string _GetTemplateForDescriptionBuildersClubExpiringToday()
	{
		return "Oh, no! Your Builders Club membership is expiring today!";
	}

	protected virtual string _GetTemplateForHeadingDontMissRenewNow()
	{
		return "Don't Miss Out - Renew Now!";
	}
}
