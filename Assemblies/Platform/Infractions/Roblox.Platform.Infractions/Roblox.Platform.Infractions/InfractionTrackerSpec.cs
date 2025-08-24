using System;

namespace Roblox.Platform.Infractions;

public class InfractionTrackerSpec : IInfractionTrackerSpec
{
	public Func<int> InfractionConsequenceThreshold { get; set; }

	public Func<TimeSpan> InfractionConsequenceTimespan { get; set; }

	public Func<TimeSpan> InfractionConsequenceEnforcementTimespan { get; set; }

	public Func<int> GlobalEnforcementLimit { get; set; }

	public Func<TimeSpan> GlobalEnforcementLimitTimespan { get; set; }

	public Func<bool> ResetInfractionCountWhenConsequencesEnforced { get; set; }
}
