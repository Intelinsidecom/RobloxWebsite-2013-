using System;
using Roblox.Caching.Shared;
using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification.Properties;

namespace Roblox.Platform.TwoStepVerification;

internal class TwoStepVerificationChallengePersister : ITwoStepVerificationChallengePersister
{
	private readonly ISharedCacheClient _SharedCacheClient;

	private TimeSpan _DefaultExpiration => Settings.Default.TwoStepVerificationCodeExpiration;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengePersister" />
	/// </summary>
	/// <param name="sharedCacheClient">An <see cref="T:Roblox.Caching.Shared.ISharedCacheClient" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="sharedCacheClient" /> is null.</exception>
	public TwoStepVerificationChallengePersister(ISharedCacheClient sharedCacheClient)
	{
		_SharedCacheClient = sharedCacheClient.AssignOrThrowIfNull("sharedCacheClient");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallengePersister.GetByUserAndActionType(Roblox.Platform.MembershipCore.IUserIdentifier,Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType)" />
	public TwoStepVerificationCode GetByUserAndActionType(IUserIdentifier user, TwoStepVerificationActionType actionType)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		string key = ConstructKey(user.Id, actionType);
		if (_SharedCacheClient.Query(key, out TwoStepVerificationCode cacheableChallenge))
		{
			return cacheableChallenge;
		}
		return null;
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallengePersister.Persist(Roblox.Platform.TwoStepVerification.TwoStepVerificationCode)" />
	public bool Persist(TwoStepVerificationCode cacheableChallenge)
	{
		if (cacheableChallenge == null)
		{
			throw new PlatformArgumentNullException("cacheableChallenge");
		}
		string key = ConstructKey(cacheableChallenge.UserId, cacheableChallenge.TwoStepVerificationActionType);
		return _SharedCacheClient.Set(key, cacheableChallenge, _DefaultExpiration);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallengePersister.Delete(Roblox.Platform.MembershipCore.IUserIdentifier,Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType)" />
	public void Delete(IUserIdentifier user, TwoStepVerificationActionType actionType)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		string cacheKey = ConstructKey(user.Id, actionType);
		_SharedCacheClient.Delete(cacheKey);
	}

	/// <summary>
	/// Gets the cache key for a given <paramref name="userId" /> and <paramref name="actionType" />.
	/// </summary>
	/// <remarks>
	/// DO NOT CHANGE THIS METHOD -- Modifying this can cause cache misses during rollout and will impact 2SV users.
	/// </remarks>
	/// <param name="userId">An <see cref="!:IUserIdentifier.Id" /></param>
	/// <param name="actionType">A <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationActionType" /></param>
	/// <returns>The cache key.</returns>
	protected virtual string ConstructKey(long userId, TwoStepVerificationActionType actionType)
	{
		return $"TwoStepVerificationCode_UserID:{userId}_ActionTypeID:{(byte)actionType}";
	}
}
