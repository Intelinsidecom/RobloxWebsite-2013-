using System;

namespace Roblox.Platform.Email.Properties;

public interface ISettings
{
	string EmailValidationShadyEmailProvidersCsv { get; }

	TimeSpan EmailVerificationTicketExpiration { get; }

	bool IsEmailValidationIgnorePeriodsInBlacklistCheckEnabled { get; }

	bool IsEmailValidationShadyEmailProviderCheckEnabled { get; }

	bool IsUserEmailChangeEnabled { get; }

	bool IsUserEmailVerificationEnabled { get; }

	bool IsEmailDomainValidationEnabled { get; }

	string ValidEmailRegex { get; }

	int VerifyEmailFloodCheckLimit { get; }

	TimeSpan VerifyEmailFloodCheckExpiry { get; }

	bool AllowAcceptAll { get; }

	bool IsKickboxEmailValidationEnabled { get; }

	bool IsKickboxEmailDomainValidationEnabled { get; }
}
