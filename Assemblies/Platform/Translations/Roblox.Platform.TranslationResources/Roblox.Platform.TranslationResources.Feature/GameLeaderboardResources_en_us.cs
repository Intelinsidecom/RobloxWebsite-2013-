using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class GameLeaderboardResources_en_us : TranslationResourcesBase, IGameLeaderboardResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Heading.Clans"
	/// English String: "Clans"
	/// </summary>
	public virtual string HeadingClans => "Clans";

	/// <summary>
	/// Key: "Heading.Players"
	/// English String: "Players"
	/// </summary>
	public virtual string HeadingPlayers => "Players";

	/// <summary>
	/// Key: "Label.AllTime"
	/// English String: "All Time"
	/// </summary>
	public virtual string LabelAllTime => "All Time";

	/// <summary>
	/// Key: "Label.Clan"
	/// English String: "Clan"
	/// </summary>
	public virtual string LabelClan => "Clan";

	/// <summary>
	/// Key: "Label.Clans"
	/// English String: "Clans"
	/// </summary>
	public virtual string LabelClans => "Clans";

	/// <summary>
	/// Key: "Label.ErrorLoading"
	/// English String: "Error loading rows..."
	/// </summary>
	public virtual string LabelErrorLoading => "Error loading rows...";

	/// <summary>
	/// Key: "Label.ErrorLoadingRows"
	/// English String: "Error loading rows."
	/// </summary>
	public virtual string LabelErrorLoadingRows => "Error loading rows.";

	/// <summary>
	/// Key: "Label.GoGetPoints"
	/// English String: "You are not yet ranked for this time period. Go earn some Points!"
	/// </summary>
	public virtual string LabelGoGetPoints => "You are not yet ranked for this time period. Go earn some Points!";

	/// <summary>
	/// Key: "Label.Leader"
	/// English String: "Leader"
	/// </summary>
	public virtual string LabelLeader => "Leader";

	/// <summary>
	/// Key: "Label.Loading"
	/// English String: "Loading..."
	/// </summary>
	public virtual string LabelLoading => "Loading...";

	/// <summary>
	/// Key: "Label.NoResults"
	/// English String: "No results found"
	/// </summary>
	public virtual string LabelNoResults => "No results found";

	/// <summary>
	/// Key: "Label.Owner"
	/// English String: "Owner"
	/// </summary>
	public virtual string LabelOwner => "Owner";

	/// <summary>
	/// Key: "Label.PastMonth"
	/// English String: "Past Month"
	/// </summary>
	public virtual string LabelPastMonth => "Past Month";

	/// <summary>
	/// Key: "Label.PastWeek"
	/// English String: "Past Week"
	/// </summary>
	public virtual string LabelPastWeek => "Past Week";

	/// <summary>
	/// Key: "Label.Points"
	/// English String: "Points"
	/// </summary>
	public virtual string LabelPoints => "Points";

	/// <summary>
	/// Key: "Label.PrimaryGroup"
	/// English String: "Primary Group"
	/// </summary>
	public virtual string LabelPrimaryGroup => "Primary Group";

	/// <summary>
	/// Key: "Label.Rank"
	/// English String: "Rank"
	/// </summary>
	public virtual string LabelRank => "Rank";

	/// <summary>
	/// Key: "Label.SeeMore"
	/// English String: "See More"
	/// </summary>
	public virtual string LabelSeeMore => "See More";

	/// <summary>
	/// Key: "Label.Today"
	/// English String: "Today"
	/// </summary>
	public virtual string LabelToday => "Today";

	/// <summary>
	/// Key: "Label.UpdatedOneHour"
	/// English String: "Updated approx. 1 hour ago"
	/// </summary>
	public virtual string LabelUpdatedOneHour => "Updated approx. 1 hour ago";

	/// <summary>
	/// Key: "Label.UpdatedTenMinutes"
	/// English String: "Updated approx. 10 minutes ago"
	/// </summary>
	public virtual string LabelUpdatedTenMinutes => "Updated approx. 10 minutes ago";

	public GameLeaderboardResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Heading.Clans",
				_GetTemplateForHeadingClans()
			},
			{
				"Heading.Players",
				_GetTemplateForHeadingPlayers()
			},
			{
				"Label.AllTime",
				_GetTemplateForLabelAllTime()
			},
			{
				"Label.Clan",
				_GetTemplateForLabelClan()
			},
			{
				"Label.Clans",
				_GetTemplateForLabelClans()
			},
			{
				"Label.ErrorLoading",
				_GetTemplateForLabelErrorLoading()
			},
			{
				"Label.ErrorLoadingRows",
				_GetTemplateForLabelErrorLoadingRows()
			},
			{
				"Label.GoGetPoints",
				_GetTemplateForLabelGoGetPoints()
			},
			{
				"Label.Leader",
				_GetTemplateForLabelLeader()
			},
			{
				"Label.Loading",
				_GetTemplateForLabelLoading()
			},
			{
				"Label.NoResults",
				_GetTemplateForLabelNoResults()
			},
			{
				"Label.Owner",
				_GetTemplateForLabelOwner()
			},
			{
				"Label.PastMonth",
				_GetTemplateForLabelPastMonth()
			},
			{
				"Label.PastWeek",
				_GetTemplateForLabelPastWeek()
			},
			{
				"Label.Points",
				_GetTemplateForLabelPoints()
			},
			{
				"Label.PrimaryGroup",
				_GetTemplateForLabelPrimaryGroup()
			},
			{
				"Label.Rank",
				_GetTemplateForLabelRank()
			},
			{
				"Label.SeeMore",
				_GetTemplateForLabelSeeMore()
			},
			{
				"Label.Today",
				_GetTemplateForLabelToday()
			},
			{
				"Label.UpdatedOneHour",
				_GetTemplateForLabelUpdatedOneHour()
			},
			{
				"Label.UpdatedTenMinutes",
				_GetTemplateForLabelUpdatedTenMinutes()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.GameLeaderboard";
	}

	protected virtual string _GetTemplateForHeadingClans()
	{
		return "Clans";
	}

	protected virtual string _GetTemplateForHeadingPlayers()
	{
		return "Players";
	}

	protected virtual string _GetTemplateForLabelAllTime()
	{
		return "All Time";
	}

	protected virtual string _GetTemplateForLabelClan()
	{
		return "Clan";
	}

	protected virtual string _GetTemplateForLabelClans()
	{
		return "Clans";
	}

	protected virtual string _GetTemplateForLabelErrorLoading()
	{
		return "Error loading rows...";
	}

	protected virtual string _GetTemplateForLabelErrorLoadingRows()
	{
		return "Error loading rows.";
	}

	protected virtual string _GetTemplateForLabelGoGetPoints()
	{
		return "You are not yet ranked for this time period. Go earn some Points!";
	}

	protected virtual string _GetTemplateForLabelLeader()
	{
		return "Leader";
	}

	protected virtual string _GetTemplateForLabelLoading()
	{
		return "Loading...";
	}

	protected virtual string _GetTemplateForLabelNoResults()
	{
		return "No results found";
	}

	protected virtual string _GetTemplateForLabelOwner()
	{
		return "Owner";
	}

	protected virtual string _GetTemplateForLabelPastMonth()
	{
		return "Past Month";
	}

	protected virtual string _GetTemplateForLabelPastWeek()
	{
		return "Past Week";
	}

	protected virtual string _GetTemplateForLabelPoints()
	{
		return "Points";
	}

	protected virtual string _GetTemplateForLabelPrimaryGroup()
	{
		return "Primary Group";
	}

	protected virtual string _GetTemplateForLabelRank()
	{
		return "Rank";
	}

	protected virtual string _GetTemplateForLabelSeeMore()
	{
		return "See More";
	}

	protected virtual string _GetTemplateForLabelToday()
	{
		return "Today";
	}

	protected virtual string _GetTemplateForLabelUpdatedOneHour()
	{
		return "Updated approx. 1 hour ago";
	}

	protected virtual string _GetTemplateForLabelUpdatedTenMinutes()
	{
		return "Updated approx. 10 minutes ago";
	}
}
