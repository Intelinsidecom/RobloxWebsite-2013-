using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.FloodCheckers.Redis;
using Roblox.Instrumentation;
using Roblox.Instrumentation.LegacySupport;

namespace Roblox.Platform.Infractions;

public class InfractionTracker<T> : IInfractionTracker<T>
{
	private readonly string _InfractionType;

	private readonly IInfractionTrackerSpec _TrackerSpec;

	private readonly Func<T, long> _IdentifierAccessor;

	private readonly ILogger _Logger;

	private readonly IFloodCheckerFactory<IExpiringFloodChecker> _ExpandingFloodCheckerFactory;

	private readonly IFloodCheckerFactory<IFloodChecker> _RollingFloodCheckerFactory;

	private readonly ISimpleCounterCategory _CounterCategory;

	private const string _CategoryBase = "Roblox.Platform.Infractions.Activity";

	private const string _InfractionEventName = "InfractionEvent";

	private const string _ConsequenceEnforcementEventName = "ConsequencesNowEnforced";

	private readonly string _InfractionsCategory;

	private readonly string _ConsequenceEnforcementCategory;

	public InfractionTracker(ICounterRegistry counterRegistry, string infractionType, IInfractionTrackerSpec trackerSpec, Func<T, long> identifierAccessor, ILogger logger)
		: this(infractionType, trackerSpec, identifierAccessor, logger, (ISimpleCounterCategoryFactory)new SimpleCounterCategoryFactory(counterRegistry), (IFloodCheckerFactory<IExpiringFloodChecker>)new RedisExpandingWindowFloodCheckerFactory(), (IFloodCheckerFactory<IFloodChecker>)new RedisRollingWindowFloodCheckerFactory())
	{
	}

	internal InfractionTracker(string infractionType, IInfractionTrackerSpec trackerSpec, Func<T, long> identifierAccessor, ILogger logger, ISimpleCounterCategoryFactory simpleCounterCategoryFactory, IFloodCheckerFactory<IExpiringFloodChecker> expandingFloodCheckerFactory, IFloodCheckerFactory<IFloodChecker> rollingFloodCheckerFactory)
	{
		_InfractionType = infractionType;
		_TrackerSpec = trackerSpec;
		_IdentifierAccessor = identifierAccessor;
		_Logger = logger;
		_ExpandingFloodCheckerFactory = expandingFloodCheckerFactory;
		_RollingFloodCheckerFactory = rollingFloodCheckerFactory;
		_InfractionsCategory = string.Format("{0}.{1}.{2}", "Roblox.Platform.Infractions.Activity", "InfractionEvent", infractionType);
		_ConsequenceEnforcementCategory = string.Format("{0}.{1}.{2}", "Roblox.Platform.Infractions.Activity", "ConsequencesNowEnforced", infractionType);
		_CounterCategory = simpleCounterCategoryFactory.CreateSimpleCounterCategory(string.Format("{0}.RateOfActivity", "Roblox.Platform.Infractions.Activity"), new List<string> { "InfractionEvent", "ConsequencesNowEnforced" });
	}

	/// <summary>
	/// Increment the number of infractions the actor has incurred.
	/// </summary>
	/// <param name="actor"></param>
	/// <returns>True if the infraction results in a ban, false otherwise</returns>
	public bool RecordInfraction(T actor)
	{
		IFloodChecker infractionFloodChecker = GetInfractionFloodChecker(actor);
		infractionFloodChecker.UpdateCount();
		_CounterCategory.IncrementTotalAndInstance("InfractionEvent", _InfractionType);
		if (infractionFloodChecker.IsFlooded())
		{
			return AttemptToRecordThatConsequencesShouldBeEnforced(actor);
		}
		return false;
	}

	private bool AttemptToRecordThatConsequencesShouldBeEnforced(T actor)
	{
		IFloodChecker actorConsequencesEnforcedFloodChecker = GetConesequencesEnforcedFloodChecker(actor);
		if (actorConsequencesEnforcedFloodChecker.IsFlooded())
		{
			ResetInfractionCountIfRequired(actor);
			return true;
		}
		IFloodChecker globalBanFloodChecker = GetGlobalConsequenceEnforcementFloodChecker();
		if (!globalBanFloodChecker.IsFlooded())
		{
			actorConsequencesEnforcedFloodChecker.UpdateCount();
			globalBanFloodChecker.UpdateCount();
			_CounterCategory.IncrementTotalAndInstance("ConsequencesNowEnforced", _InfractionType);
			ResetInfractionCountIfRequired(actor);
			return true;
		}
		return false;
	}

	private void ResetInfractionCountIfRequired(T actor)
	{
		if (_TrackerSpec.ResetInfractionCountWhenConsequencesEnforced())
		{
			GetInfractionFloodChecker(actor).Reset();
		}
	}

	public bool ShouldConsequencesBeEnforced(T actor)
	{
		return GetConesequencesEnforcedFloodChecker(actor).IsFlooded();
	}

	private IFloodChecker GetInfractionFloodChecker(T actor)
	{
		long actorId = _IdentifierAccessor(actor);
		return _ExpandingFloodCheckerFactory.GetFloodChecker(_InfractionsCategory, $"{_InfractionsCategory}.{actorId}", _TrackerSpec.InfractionConsequenceThreshold, _TrackerSpec.InfractionConsequenceTimespan, () => true, () => false, _Logger);
	}

	private IFloodChecker GetConesequencesEnforcedFloodChecker(T actor)
	{
		long actorId = _IdentifierAccessor(actor);
		return _ExpandingFloodCheckerFactory.GetFloodChecker(_ConsequenceEnforcementCategory, $"{_ConsequenceEnforcementCategory}.{actorId}", () => 1, _TrackerSpec.InfractionConsequenceEnforcementTimespan, () => true, () => false, _Logger);
	}

	private IFloodChecker GetGlobalConsequenceEnforcementFloodChecker()
	{
		return _RollingFloodCheckerFactory.GetFloodChecker($"{_ConsequenceEnforcementCategory}.Overall", $"{_ConsequenceEnforcementCategory}.Overall", _TrackerSpec.GlobalEnforcementLimit, _TrackerSpec.GlobalEnforcementLimitTimespan, () => true, () => false, _Logger);
	}
}
