using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

internal class PinHasher : IPinHasher
{
	public string HashUserPin(IUser user, string pin)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (string.IsNullOrWhiteSpace(pin))
		{
			throw new PlatformArgumentException("pin");
		}
		return HashGenerator.HashPassword(MakeString(user, pin));
	}

	public bool IsValidateUserPin(IUser user, string inputPin, string correctHash)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (string.IsNullOrWhiteSpace(inputPin))
		{
			throw new PlatformArgumentException("inputPin");
		}
		if (string.IsNullOrWhiteSpace(correctHash))
		{
			throw new PlatformArgumentException("correctHash");
		}
		return HashGenerator.ValidatePassword(MakeString(user, inputPin), correctHash);
	}

	private string MakeString(IUser user, string pin)
	{
		return user.Id + pin + user.AccountId;
	}
}
