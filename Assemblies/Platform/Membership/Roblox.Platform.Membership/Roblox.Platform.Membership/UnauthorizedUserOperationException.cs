using Roblox.Platform.Core;

namespace Roblox.Platform.Membership;

/// <summary>
/// Exception thrown when a user is not authorized to perform an operation
/// </summary>
public class UnauthorizedUserOperationException : PlatformException
{
	public UnauthorizedUserOperationException()
		: base("User Not Authorized")
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Membership.UnauthorizedUserOperationException" /> class.
	/// </summary>
	/// <param name="userId">The userId that attempted to perform the operation</param>
	public UnauthorizedUserOperationException(long userId)
		: base("User Not Authorized: " + userId)
	{
	}
}
