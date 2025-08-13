namespace Roblox.Platform.EventStream.WebEvents;

public class FormValidationFailedEventArgs : WebEventArgs
{
	/// <summary>
	/// The field (e.g., username, password) which failed validation.
	/// </summary>
	public string Field { get; set; }

	/// <summary>
	/// The user's input into the field. May be redacted or empty.
	/// </summary>
	public string Input { get; set; }

	/// <summary>
	/// The context in which the form was presented.
	/// </summary>
	public string Context { get; set; }

	/// <summary>
	/// If IsVisible is true, the exact message presented to the user, else a description.
	/// </summary>
	public string Message { get; set; }

	/// <summary>
	/// Whether Message was displayed verbatim to the user.
	/// </summary>
	public bool IsVisible { get; set; }
}
