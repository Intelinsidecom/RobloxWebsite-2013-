namespace Roblox.Platform.EventStream.WebEvents;

public class BotScoreCheckEventArgs : WebEventArgs
{
	/// <summary>
	/// The reason for the score given. Note, reason currently doesn't exist.
	/// </summary>
	public string Reason { get; set; }

	/// <summary>
	/// The score given by the service 0 - 1.
	/// </summary>
	public double? Score { get; set; }

	/// <summary>
	/// The service that we use to get the score. e.g. Google.
	/// </summary>
	public string Context { get; set; }
}
