using System;
using Roblox.Platform.Core;
using Roblox.Platform.Membership.Properties;

namespace Roblox.Platform.Membership.Commands;

public class UsernameFactory : IUsernameFactory
{
	private IUsernameValidator UsernameValidator { get; }

	public UsernameFactory(IUsernameValidator usernameValidator)
	{
		UsernameValidator = usernameValidator ?? throw new PlatformArgumentNullException("usernameValidator");
	}

	public bool GenerateUserName(string username, AgeBracket ageBracket, bool mustUsePiiFiltersForU13Usernames, out string generatedUsername)
	{
		if (string.IsNullOrWhiteSpace(username))
		{
			throw new PlatformArgumentNullException("username");
		}
		IUsernameValidationResult usernameValidationResult = UsernameValidator.ValidateUsername(username, ageBracket, mustUsePiiFiltersForU13Usernames);
		if (usernameValidationResult.IsValid)
		{
			generatedUsername = username;
			return false;
		}
		if (usernameValidationResult.ResultCode != UsernameValidatorResultCode.UserNameAlreadyInUseErrorCode)
		{
			throw new ArgumentException("Username is not legal.");
		}
		int count = 0;
		while (!usernameValidationResult.IsValid)
		{
			count++;
			string suggestedUsername = username + count;
			if (suggestedUsername.Length > Settings.Default.MaxAllowedUsernameLength || count > Settings.Default.MaxCountToAppendToUsername)
			{
				throw new ArgumentException("Suggested username length is too long to generate.");
			}
			usernameValidationResult = UsernameValidator.ValidateUsername(suggestedUsername, ageBracket, mustUsePiiFiltersForU13Usernames);
		}
		generatedUsername = username + count;
		return true;
	}
}
