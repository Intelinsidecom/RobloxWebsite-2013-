using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class SupportedLocaleChangedByUserEventArgs : WebEventArgs
{
	/// <summary>
	/// The Id of the user's new supported locale setting.
	/// </summary>
	public int? NewSupportedLocaleId { get; set; }

	/// <summary>
	/// The Id of the user's old supported locale setting.
	/// </summary>
	public int? PreviousSupportedLocaleId { get; set; }

	/// <summary>
	/// The user Id of the account which activated the change in supported locale. This
	/// could be a CS agent.
	/// </summary>
	public long ActorId { get; set; }

	/// <summary>
	/// The time the user changed languages.
	/// </summary>
	public DateTime EventTime { get; set; }
}
