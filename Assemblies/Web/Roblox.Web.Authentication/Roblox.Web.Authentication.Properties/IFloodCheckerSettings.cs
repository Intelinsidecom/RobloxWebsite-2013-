using System;

namespace Roblox.Web.Authentication.Properties;

public interface IFloodCheckerSettings
{
	int ForgotUsernameSMSFloodCheckerLimit { get; }

	TimeSpan ForgotUsernameSMSFloodCheckerExpiry { get; }

	int ForgotUsernameSMSPhoneFloodCheckerLimit { get; }

	TimeSpan ForgotUsernameSMSPhoneFloodCheckerExpiry { get; }
}
