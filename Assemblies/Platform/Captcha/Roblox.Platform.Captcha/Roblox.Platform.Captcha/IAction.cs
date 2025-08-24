using System;

namespace Roblox.Platform.Captcha;

/// <summary>
/// Represents an action that is protected by Captcha.
/// </summary>
public interface IAction
{
	/// <summary>
	/// Records that the <see cref="T:Roblox.Platform.Captcha.IAction" /> has been passed.
	/// </summary>
	/// <param name="currentTime">The current time.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformInvalidOperationException">Thrown if the <see cref="T:Roblox.Platform.Captcha.IAction" /> could not be passed in its state.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if the operation could not be performed.</exception>
	void Pass(DateTime currentTime);

	/// <summary>
	/// Determines whether or not the <see cref="T:Roblox.Platform.Captcha.IAction" /> has been passed.
	/// </summary>
	/// <param name="currentTime">The current time.</param>
	/// <returns>Whether or not the <see cref="T:Roblox.Platform.Captcha.IAction" /> has been passed.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if the operation could not be performed.</exception>
	bool HasPassed(DateTime currentTime);

	/// <summary>
	/// Invalidates any record that the <see cref="T:Roblox.Platform.Captcha.IAction" /> has been passed.
	/// </summary>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Thrown if the operation could not be performed.</exception>
	void Invalidate();
}
