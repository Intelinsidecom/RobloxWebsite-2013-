using System;

namespace Roblox.Platform.Infractions;

public interface IInfractionTrackerSpec
{
	/// <summary>
	/// The number of infractions that need to be recorded within the specified timespan for consequences to be enforced
	/// </summary>
	Func<int> InfractionConsequenceThreshold { get; }

	/// <summary>
	/// The rolling period of time that infractions will be counted for the purposes of enforcing consequences
	/// </summary>
	Func<TimeSpan> InfractionConsequenceTimespan { get; }

	/// <summary>
	/// The period of time that consequences should be enforced once the InfractionConsequenceThreshold is reached
	/// </summary>
	Func<TimeSpan> InfractionConsequenceEnforcementTimespan { get; }

	/// <summary>
	/// A limit to the number of infracting entities that can have consequences enforced for a given period of time.
	/// This is intended to be used as a safety valve to prevnt over-enforcement if infraction rates suddenly increase
	/// </summary>
	Func<int> GlobalEnforcementLimit { get; }

	/// <summary>
	/// The rolling period of time to count consequence threshold exceedances for the Global Enforcement Limit
	/// </summary>
	Func<TimeSpan> GlobalEnforcementLimitTimespan { get; }

	/// <summary>
	/// Whether or not the infraction count should be reset to zero when the count reaches the InfractionConsequenceThreshold and consequences are enforced
	/// </summary>
	Func<bool> ResetInfractionCountWhenConsequencesEnforced { get; }
}
