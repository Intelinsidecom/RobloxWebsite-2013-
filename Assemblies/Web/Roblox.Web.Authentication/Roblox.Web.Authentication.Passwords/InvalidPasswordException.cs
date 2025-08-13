using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;

namespace Roblox.Web.Authentication.Passwords;

[ExcludeFromCodeCoverage]
public class InvalidPasswordException : PlatformException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Authentication.Passwords.InvalidPasswordException" /> class.
	/// </summary>
	public InvalidPasswordException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Authentication.Passwords.InvalidPasswordException" /> class with the given error message.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public InvalidPasswordException(string message)
		: base(message)
	{
	}
}
