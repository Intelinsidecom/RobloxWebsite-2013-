using System;

namespace Roblox.Platform.Membership;

public static class AccountStatusExtensions
{
	/// <exception cref="T:System.ArgumentException">No account status matches the input parameter.</exception>
	internal static AccountStatus TranslateAccountStatus(byte accountStatusId)
	{
		if (accountStatusId == Roblox.AccountStatus.OkId)
		{
			return AccountStatus.Ok;
		}
		if (accountStatusId == Roblox.AccountStatus.DeletedId)
		{
			return AccountStatus.Deleted;
		}
		if (accountStatusId == Roblox.AccountStatus.MustValidateEmailId)
		{
			return AccountStatus.MustValidateEmail;
		}
		if (accountStatusId == Roblox.AccountStatus.PoisonedId)
		{
			return AccountStatus.Poisoned;
		}
		if (accountStatusId == Roblox.AccountStatus.SuppressedId)
		{
			return AccountStatus.Suppressed;
		}
		if (accountStatusId == Roblox.AccountStatus.ForgottenId)
		{
			return AccountStatus.Forgotten;
		}
		throw new ArgumentException("Invalid account status Id:" + accountStatusId);
	}

	internal static byte GetId(this AccountStatus status)
	{
		return status switch
		{
			AccountStatus.Ok => Roblox.AccountStatus.OkId, 
			AccountStatus.Deleted => Roblox.AccountStatus.DeletedId, 
			AccountStatus.Forgotten => Roblox.AccountStatus.ForgottenId, 
			AccountStatus.MustValidateEmail => Roblox.AccountStatus.MustValidateEmailId, 
			AccountStatus.Poisoned => Roblox.AccountStatus.PoisonedId, 
			AccountStatus.Suppressed => Roblox.AccountStatus.SuppressedId, 
			_ => throw new ArgumentException($"No database value found for Account Status enum {status}"), 
		};
	}
}
