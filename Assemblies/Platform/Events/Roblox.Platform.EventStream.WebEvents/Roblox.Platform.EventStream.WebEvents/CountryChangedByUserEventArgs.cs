using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class CountryChangedByUserEventArgs : WebEventArgs
{
	/// <summary>
	/// The Id of the user's new country.
	/// </summary>
	public int NewCountryId { get; set; }

	/// <summary>
	/// The Id of the user's old country.
	/// </summary>
	public int? PreviousCountryId { get; set; }

	/// <summary>
	/// The user Id of the account which activated the change in country setting. This
	/// could be a CS agent.
	/// </summary>
	public long ActorId { get; set; }

	/// <summary>
	/// The time the user changed countries.
	/// </summary>
	public DateTime EventTime { get; set; }
}
