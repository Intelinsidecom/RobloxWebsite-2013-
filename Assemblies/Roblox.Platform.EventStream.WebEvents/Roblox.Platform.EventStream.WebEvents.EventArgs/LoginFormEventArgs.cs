namespace Roblox.Platform.EventStream.WebEvents.EventArgs;

public class LoginFormEventArgs : WebEventArgs
{
	/// <summary>
	/// The email entered if any
	/// </summary>
	public string Email { get; set; }

	/// <summary>
	/// The username entered if any
	/// </summary>
	public string Username { get; set; }

	/// <summary>
	/// The phone entered if any
	/// </summary>
	public string Phone { get; set; }

	/// <summary>
	/// The context for the event
	/// </summary>
	public string Context { get; set; }
}
