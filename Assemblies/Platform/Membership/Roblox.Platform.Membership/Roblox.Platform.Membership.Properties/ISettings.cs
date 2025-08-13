namespace Roblox.Platform.Membership.Properties;

public interface ISettings
{
	string AccountAgeChangeEventsSnsAwsAccessKeyAndSecretCSV { get; }

	string AccountAgeChangeEventsSnsTopicArn { get; }

	string BadPasswordHashes { get; }

	string BadPasswords { get; }

	bool IsUsersTableAuditingEnabled { get; }

	int MaxAllowedUsernameLength { get; }

	int MaxCountToAppendToUsername { get; }

	int MinAllowedUsernameLength { get; }

	int PrivilegedUserRolesetRankThreshold { get; }

	bool PublishAccountAgeChangeEventsEnabled { get; }

	int RobloxUserId { get; }

	bool UserFactoryReturnsNullForForgottenUsers { get; }

	string ReservedUsernamePrefix { get; }

	int MinGeneratedUsernameSuffixLength { get; }

	int MaxGeneratedUsernameSuffixLength { get; }

	int UserFactoryReadByIdViaUsersServiceEnabledPermyriad { get; }

	int UserFactoryReadByMultiGetViaUsersServiceEnabledPermyriad { get; }

	int UserFactoryReadByNameViaUsersServiceEnabledPermyriad { get; }

	int UserFactoryReadByAccountIdViaUsersServiceEnabledPermyriad { get; }
}
