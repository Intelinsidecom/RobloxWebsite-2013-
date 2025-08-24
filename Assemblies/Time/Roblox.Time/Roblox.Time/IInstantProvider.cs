namespace Roblox.Time;

/// <summary>
/// Returns the current UtcInstant, according to some time source
/// </summary>
public interface IInstantProvider
{
	/// <summary>
	/// The current time as a UtcInstant
	/// </summary>
	/// <returns></returns>
	UtcInstant GetCurrentUtcInstant();
}
