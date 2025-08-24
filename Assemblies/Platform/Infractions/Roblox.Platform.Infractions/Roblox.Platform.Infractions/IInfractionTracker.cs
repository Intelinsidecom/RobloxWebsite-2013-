namespace Roblox.Platform.Infractions;

public interface IInfractionTracker<in T>
{
	bool RecordInfraction(T actor);

	bool ShouldConsequencesBeEnforced(T actor);
}
