namespace Roblox.Platform.EventStream.WebEvents;

public class UserLoggedInEventArgs : WebEventArgs
{
	/// <summary>
	/// The username the user signed up with.
	/// </summary>
	public string Username { get; set; }
}
