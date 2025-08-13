using Roblox.Time;

namespace Roblox.Platform.EventStream.WebEvents;

public class MatchUserContactsByPhoneEventArgs : WebEventArgs
{
	/// <summary>
	/// The event time <see cref="T:Roblox.Time.UtcInstant" />.
	/// </summary>
	public UtcInstant EventTime { get; set; }

	/// <summary>
	/// The number of contacts received for matching.
	/// </summary>
	public int Contacts { get; set; }

	/// <summary>
	/// The number of contacts that matched.
	/// A contact is a match when at least one 
	/// of its phone numbers matched with an existing account.
	/// </summary>
	public int Matches { get; set; }
}
