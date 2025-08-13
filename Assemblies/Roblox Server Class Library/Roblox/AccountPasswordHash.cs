using System;
using Roblox.Instrumentation;
using Roblox.Passwords.Client;
using Roblox.Properties;

namespace Roblox;

[Serializable]
[Obsolete("Please use IPasswordsClient instead.")]
public class AccountPasswordHash
{
	public static IPasswordsClient PasswordsClient = new PasswordsClient(StaticCounterRegistry.Instance, () => Settings.Default.PasswordsClientMasterApiKey);

	public long ID { get; }

	public long AccountID { get; }

	private AccountPasswordHash(long id, long accountId)
	{
		ID = id;
		AccountID = accountId;
	}

	internal static void CreateNew(long accountId, string newPassword)
	{
		PasswordsClient.SetPassword(PasswordOwnerType.Account, accountId, newPassword);
	}

	public static AccountPasswordHash GetCurrent(long accountId)
	{
		if (accountId <= 0)
		{
			return null;
		}
		PasswordStatusResult passwordStatus = PasswordsClient.GetPasswordStatus(PasswordOwnerType.Account, accountId);
		if (passwordStatus.Id.HasValue)
		{
			return new AccountPasswordHash(passwordStatus.Id.Value, accountId);
		}
		return null;
	}
}
