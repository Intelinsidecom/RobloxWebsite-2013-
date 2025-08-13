using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionPurger" />
/// </summary>
internal class TwoStepVerificationSessionPurger : ITwoStepVerificationSessionPurger
{
	private readonly ITwoStepVerificationSessionCollectionFactory _TwoStepVerificationSessionCollectionFactory;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationSessionPurger" />
	/// </summary>
	/// <param name="sessionCollectionFactory">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionCollectionFactory" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="sessionCollectionFactory" /> is null.</exception>
	public TwoStepVerificationSessionPurger(ITwoStepVerificationSessionCollectionFactory sessionCollectionFactory)
	{
		_TwoStepVerificationSessionCollectionFactory = sessionCollectionFactory.AssignOrThrowIfNull("sessionCollectionFactory");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionPurger.DeleteSessionsForUser(Roblox.Platform.Membership.IUser)" />
	public void DeleteSessionsForUser(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		foreach (ITwoStepVerificationSession item in _TwoStepVerificationSessionCollectionFactory.GetSessionsByUser(user))
		{
			item.Delete();
		}
	}
}
