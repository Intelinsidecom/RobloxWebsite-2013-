using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.TwoStepVerification.Entities;
using Roblox.Platform.TwoStepVerification.Properties;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionFactory" />
/// </summary>
internal class TwoStepVerificationSessionFactory : ITwoStepVerificationSessionFactory, ITwoStepVerificationSessionCollectionFactory
{
	private readonly IUserFactory _UserFactory;

	[ExcludeFromCodeCoverage]
	private TimeSpan _TwoStepVerificationSessionExpiry => Settings.Default.TwoStepVerificationSessionTokenExpiry;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationSessionFactory" />
	/// </summary>
	/// <param name="userFactory">An <see cref="T:Roblox.Platform.Membership.IUserFactory" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="userFactory" /> is null.</exception>
	public TwoStepVerificationSessionFactory(IUserFactory userFactory)
	{
		_UserFactory = userFactory.AssignOrThrowIfNull("userFactory");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionFactory.CreateNew(Roblox.Platform.Membership.IUser)" />
	[ExcludeFromCodeCoverage]
	public ITwoStepVerificationSession CreateNew(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		Guid token = Guid.NewGuid();
		DateTime expiration = DateTime.Now.Add(_TwoStepVerificationSessionExpiry);
		TwoStepVerificationSessionToken entity = TwoStepVerificationSessionToken.CreateNew(user.AccountId, token, expiration);
		return new TwoStepVerificationSession(_UserFactory, entity);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionFactory.GetByToken(System.Guid)" />
	[ExcludeFromCodeCoverage]
	public ITwoStepVerificationSession GetByToken(Guid token)
	{
		if (token == Guid.Empty)
		{
			throw new PlatformArgumentException("token");
		}
		TwoStepVerificationSessionToken entity = TwoStepVerificationSessionToken.GetByToken(token);
		if (entity == null)
		{
			return null;
		}
		if (entity.Expiration < DateTime.Now)
		{
			entity.Delete();
			return null;
		}
		return new TwoStepVerificationSession(_UserFactory, entity);
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionCollectionFactory.GetSessionsByUser(Roblox.Platform.Membership.IUser)" />
	[ExcludeFromCodeCoverage]
	public IEnumerable<ITwoStepVerificationSession> GetSessionsByUser(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		int startIndex = 0;
		int rowsFetched;
		do
		{
			ICollection<TwoStepVerificationSessionToken> entitiesPaged = TwoStepVerificationSessionToken.GetTwoStepVerificationSessionTokensByAccountIdPaged(user.AccountId, startIndex, 25L);
			rowsFetched = entitiesPaged.Count;
			foreach (TwoStepVerificationSessionToken entity in entitiesPaged)
			{
				if (entity.Expiration < DateTime.Now)
				{
					entity.Delete();
				}
				else
				{
					yield return new TwoStepVerificationSession(_UserFactory, entity);
				}
			}
			startIndex += 25;
		}
		while (rowsFetched == 25);
	}
}
