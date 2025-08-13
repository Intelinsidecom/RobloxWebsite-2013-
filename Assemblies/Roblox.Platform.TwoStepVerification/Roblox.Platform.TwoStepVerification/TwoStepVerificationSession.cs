using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification.Entities;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession" />
/// </summary>
[ExcludeFromCodeCoverage]
internal class TwoStepVerificationSession : ITwoStepVerificationSession
{
	private long _Id { get; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession.UserIdentifier" />
	public IUserIdentifier UserIdentifier { get; }

	/// <inheritdoc cref="P:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession.Token" />
	public Guid Token { get; }

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationSession" />
	/// </summary>
	/// <param name="userFactory">An <see cref="T:Roblox.Platform.Membership.IUserFactory" /></param>
	/// <param name="entity">A <see cref="T:Roblox.Platform.TwoStepVerification.Entities.TwoStepVerificationSessionToken" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="userFactory" /> or <paramref name="entity" /> is null.</exception>
	internal TwoStepVerificationSession(IUserFactory userFactory, TwoStepVerificationSessionToken entity)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		if (userFactory == null)
		{
			throw new PlatformArgumentNullException("userFactory");
		}
		IUser user = userFactory.GetUserByAccountId(entity.AccountId);
		if (user == null)
		{
			throw new PlatformDataIntegrityException("Unable to find user.");
		}
		UserIdentifier = user;
		Token = entity.Token;
		_Id = entity.ID;
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSession.Delete" />
	public void Delete()
	{
		(TwoStepVerificationSessionToken.Get(_Id) ?? throw new PlatformDataIntegrityException("Unable to find entity")).Delete();
	}
}
