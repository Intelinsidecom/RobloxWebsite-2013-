using System;

namespace Roblox.Platform.Authentication;

/// <summary>
/// Contains static events related to authentication.
/// </summary>
public static class AuthenticationEvents
{
	/// <summary>
	/// Represents a delegate that handle an <see cref="E:Roblox.Platform.Authentication.AuthenticationEvents.Authenticated" /> event.
	/// </summary>
	/// <param name="sender">The object that raised the event.</param>
	/// <param name="e">The <see cref="T:System.EventArgs" /> containing data of the event.</param>
	public delegate void AuthenticatedHandler(object sender, EventArgs e);

	/// <summary>
	/// Triggered after a user's credentials have been authenticated.
	/// </summary>
	public static event AuthenticatedHandler Authenticated;

	/// <summary>
	/// Raises the <see cref="E:Roblox.Platform.Authentication.AuthenticationEvents.Authenticated" /> event.
	/// </summary>
	/// <param name="sender">The object that raised the event.</param>
	/// <param name="e">The <see cref="T:System.EventArgs" /> containing data of the event.</param>
	internal static void RaiseAuthenticated(object sender, EventArgs e)
	{
		AuthenticationEvents.Authenticated?.Invoke(sender, e);
	}
}
