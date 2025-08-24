using Roblox.Friends.Client;
using Roblox.Platform.Core;

namespace Roblox.Platform.Social;

public class FriendshipOperationException : PlatformException
{
	public FriendshipOperationErrorType ErrorType { get; private set; }

	public override bool ShouldSkipLogging => true;

	public FriendshipOperationException(FriendsErrorMetadata errorMetadata)
		: base(errorMetadata.ErrorMessage)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected I4, but got Unknown
		ErrorType = (FriendshipOperationErrorType)errorMetadata.ErrorType;
	}

	public FriendshipOperationException(FriendshipOperationErrorType errorType, string ErrorMessage)
		: base(ErrorMessage)
	{
		ErrorType = errorType;
	}
}
