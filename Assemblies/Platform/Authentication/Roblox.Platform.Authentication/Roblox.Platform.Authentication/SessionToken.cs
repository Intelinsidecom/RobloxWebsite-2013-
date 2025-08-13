using System;
using System.Threading.Tasks;
using Roblox.Platform.Authentication.Entities;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

internal class SessionToken : ISessionToken
{
	public string Value { get; }

	internal SessionToken(string value)
	{
		Value = value;
	}

	public AuthenticationSessionValidationStatus IsValid(IUser user)
	{
		if (user == null)
		{
			return AuthenticationSessionValidationStatus.InvalidUser;
		}
		if (string.IsNullOrWhiteSpace(Value))
		{
			return AuthenticationSessionValidationStatus.InvalidSessionToken;
		}
		if (!Guid.TryParse(Value, out var sessionTokenGuid))
		{
			return AuthenticationSessionValidationStatus.InvalidSessionToken;
		}
		Roblox.Platform.Authentication.Entities.SessionToken sessionTokenEntity = Roblox.Platform.Authentication.Entities.SessionToken.GetByToken(sessionTokenGuid);
		if (sessionTokenEntity == null)
		{
			return AuthenticationSessionValidationStatus.SessionTokenMissing;
		}
		if (user.AccountId != sessionTokenEntity.AccountID)
		{
			return AuthenticationSessionValidationStatus.InvalidSessionForUser;
		}
		return VerifySessionToken(sessionTokenEntity);
	}

	public AuthenticationSessionValidationStatus Extend(TimeSpan timeToLive, out bool wasExtended)
	{
		wasExtended = false;
		if (!Guid.TryParse(Value, out var sessionTokenGuid))
		{
			return AuthenticationSessionValidationStatus.InvalidSessionToken;
		}
		Roblox.Platform.Authentication.Entities.SessionToken sessionTokenEntity = Roblox.Platform.Authentication.Entities.SessionToken.GetByToken(sessionTokenGuid);
		if (sessionTokenEntity == null)
		{
			return AuthenticationSessionValidationStatus.SessionTokenMissingOnExtend;
		}
		DateTime now = DateTime.Now;
		if (!sessionTokenEntity.Expiration.HasValue || sessionTokenEntity.Expiration < now)
		{
			DeleteInBackground(sessionTokenEntity);
			return AuthenticationSessionValidationStatus.SessionTokenExpired;
		}
		DateTime extensionDate = (now + timeToLive).AddDays(-1.0);
		if (timeToLive <= TimeSpan.FromDays(1.0))
		{
			TimeSpan halfInterval = new TimeSpan(timeToLive.Ticks / 2);
			extensionDate = now + halfInterval;
		}
		if (sessionTokenEntity.Expiration < extensionDate)
		{
			sessionTokenEntity.Expiration = now.Add(timeToLive);
			sessionTokenEntity.Save();
			wasExtended = true;
		}
		return AuthenticationSessionValidationStatus.Success;
	}

	private static void DeleteInBackground(Roblox.Platform.Authentication.Entities.SessionToken sessionTokenEntity)
	{
		Task.Factory.StartNew(delegate
		{
			try
			{
				sessionTokenEntity.Delete();
			}
			catch (Exception)
			{
			}
		});
	}

	private AuthenticationSessionValidationStatus VerifySessionToken(Roblox.Platform.Authentication.Entities.SessionToken sessionTokenEntity)
	{
		if (sessionTokenEntity.Expiration.HasValue && sessionTokenEntity.Expiration >= DateTime.Now)
		{
			return AuthenticationSessionValidationStatus.Success;
		}
		DeleteInBackground(sessionTokenEntity);
		return AuthenticationSessionValidationStatus.SessionTokenExpired;
	}
}
