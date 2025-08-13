using System;

namespace Roblox.Web.Authentication.Passwords;

internal class SendPasswordChangeEmailResult : ISendPasswordChangeEmailResult
{
	public bool Success { get; }

	public PasswordResponseCodes Result { get; }

	public SendPasswordChangeEmailResult(bool success, PasswordResponseCodes result = PasswordResponseCodes.Ok)
	{
		if ((success && result != PasswordResponseCodes.Ok) || (!success && result == PasswordResponseCodes.Ok))
		{
			throw new ArgumentException(string.Format("Malformed {0}! {1} is {2} but {3} is {4}.", "SendPasswordChangeEmailResult", "success", success, "result", result));
		}
		Success = success;
		Result = result;
	}
}
