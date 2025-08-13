using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Diagnostics;

namespace Roblox.TextFilter;

internal class TextFilterMetricsTracker : ITextFilterMetricsTracker
{
	private const string _DefaultClient = "Unspecified";

	private readonly ISimpleCounterCategoryFactory _SimpleCounterCategoryFactory;

	private readonly ISimpleCounterCategory _ModerationLevelCounters;

	private readonly ISimpleCounterCategory _ModerationCategoryCounters;

	private readonly Dictionary<string, ISimpleCounterCategory> _ClientCounterCategories = new Dictionary<string, ISimpleCounterCategory>();

	private readonly object _ClientCounterCategoryCreationLock = new object();

	public TextFilterMetricsTracker()
		: this(new SimpleCounterCategoryFactory())
	{
	}

	internal TextFilterMetricsTracker(ISimpleCounterCategoryFactory simpleCounterCategoryFactory)
	{
		_SimpleCounterCategoryFactory = simpleCounterCategoryFactory;
		_ModerationLevelCounters = _SimpleCounterCategoryFactory.CreateSimplePerfmonCounterCategory("Roblox.TextFilter.ModerationLevelByClient", GenerateAllModerationLevelCounterNames());
		_ModerationCategoryCounters = _SimpleCounterCategoryFactory.CreateSimplePerfmonCounterCategory("Roblox.TextFilter.ModerationCategories", GenerateAllModerationCategoryCounterNames());
	}

	public void RecordTextFilterResult(IModeratedTextRequest request, ITextFilterResultModerationDetails result, TextAudience? audience)
	{
		string client = request.Client ?? "Unspecified";
		RecordModerationLevelResultForAudience(null, result.ModerationLevel, client);
		RecordModerationCategoryResultForAudience(_ModerationCategoryCounters, null, result.TriggeredModerationCategories);
		if (audience.HasValue)
		{
			RecordModerationLevelResultForAudience(audience, result.ModerationLevel, client);
			RecordModerationCategoryResultForAudience(_ModerationCategoryCounters, audience, result.TriggeredModerationCategories);
		}
		if (request.TrackDetailedClientStatistics)
		{
			ISimpleCounterCategory clientCounters = GetClientCounterCategory(client);
			RecordModerationCategoryResultForAudience(clientCounters, null, result.TriggeredModerationCategories);
			if (audience.HasValue)
			{
				RecordModerationCategoryResultForAudience(clientCounters, audience, result.TriggeredModerationCategories);
			}
		}
	}

	private ISimpleCounterCategory GetClientCounterCategory(string client)
	{
		if (_ClientCounterCategories.ContainsKey(client))
		{
			return _ClientCounterCategories[client];
		}
		lock (_ClientCounterCategoryCreationLock)
		{
			if (_ClientCounterCategories.ContainsKey(client))
			{
				return _ClientCounterCategories[client];
			}
			ISimpleCounterCategory counters = _SimpleCounterCategoryFactory.CreateSimplePerfmonCounterCategory($"Roblox.TextFilter.Clients.{client}", GenerateAllModerationCategoryCounterNames());
			_ClientCounterCategories[client] = counters;
			return counters;
		}
	}

	private static void RecordModerationCategoryResultForAudience(ISimpleCounterCategory counters, TextAudience? textAudience, HashSet<ModerationCategory> resultTriggeredModerationCategories)
	{
		if (resultTriggeredModerationCategories == null || !resultTriggeredModerationCategories.Any())
		{
			return;
		}
		foreach (ModerationCategory category in resultTriggeredModerationCategories)
		{
			counters.IncrementInstance(GetModerationCategoryCounterName(textAudience), category.ToString());
		}
	}

	private void RecordModerationLevelResultForAudience(TextAudience? audience, ModerationLevel moderationLevel, string client)
	{
		string overallCounter = GetModerationLevelCounterName(audience, null);
		_ModerationLevelCounters.IncrementTotal(overallCounter);
		_ModerationLevelCounters.IncrementInstance(overallCounter, client);
		string moderationCounter = GetModerationLevelCounterName(audience, moderationLevel);
		_ModerationLevelCounters.IncrementTotal(moderationCounter);
		_ModerationLevelCounters.IncrementInstance(moderationCounter, client);
	}

	private static ICollection<string> GenerateAllModerationLevelCounterNames()
	{
		List<string> counters = new List<string>();
		foreach (TextAudience? audience in GetAllEnumValuesPlusNull<TextAudience>())
		{
			foreach (ModerationLevel? moderationLevel in GetAllEnumValuesPlusNull<ModerationLevel>())
			{
				counters.Add(GetModerationLevelCounterName(audience, moderationLevel));
			}
		}
		return counters;
	}

	private static ICollection<string> GenerateAllModerationCategoryCounterNames()
	{
		List<string> counters = new List<string>();
		foreach (TextAudience? audience in GetAllEnumValuesPlusNull<TextAudience>())
		{
			counters.Add(GetModerationCategoryCounterName(audience));
		}
		return counters;
	}

	private static string GetModerationLevelCounterName(TextAudience? audience, ModerationLevel? moderationLevel)
	{
		return string.Format("{0}_{1}", audience?.ToString() ?? "Total", moderationLevel?.ToString() ?? "Total");
	}

	private static string GetModerationCategoryCounterName(TextAudience? audience)
	{
		return string.Format("{0}", audience?.ToString() ?? "Total");
	}

	private static List<T?> GetAllEnumValuesPlusNull<T>() where T : struct
	{
		return new List<T?>(((T[])Enum.GetValues(typeof(T))).Cast<T?>()) { null };
	}
}
