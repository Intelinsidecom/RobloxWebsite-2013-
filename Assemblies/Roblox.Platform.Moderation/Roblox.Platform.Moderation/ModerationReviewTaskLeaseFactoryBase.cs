using System;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.Moderation.Properties;

namespace Roblox.Platform.Moderation;

internal abstract class ModerationReviewTaskLeaseFactoryBase<TIReviewTask, TReviewTaskLease, TIReviewTaskLease_Internal, TIReviewTaskLease, TIReviewTaskLeaseEntity> where TIReviewTask : IReviewTask where TReviewTaskLease : TIReviewTaskLease_Internal, TIReviewTaskLease where TIReviewTaskLease_Internal : IReviewTaskLease_Internal, TIReviewTaskLease where TIReviewTaskLease : IReviewTaskLease where TIReviewTaskLeaseEntity : IReviewTaskLeaseEntity
{
	private readonly Func<DateTime> _NowFunc;

	private ISettings _Settings;

	protected ModerationReviewTaskLeaseFactoryBase(Func<DateTime> nowFunc, ISettings settings)
	{
		_NowFunc = nowFunc ?? throw new ArgumentNullException("nowFunc");
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	internal abstract TReviewTaskLease GetLeaseFromNonNullEntity(TIReviewTaskLeaseEntity entity);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Moderation.IReviewTaskLeaseEntity" /> with the given review task or creates an <see cref="T:Roblox.Platform.Moderation.IReviewTaskLeaseEntity" /> with the given review task, moderator, and expiration.
	/// </summary>
	/// <param name="reviewTask">The <see cref="T:Roblox.Platform.Moderation.IReviewTask" /> of the lease to get or create by.  This parameter is guaranteed to not be null.</param>
	/// <param name="moderatorIdentity">The moderator to be leased to, if a lease is created.  This parameter is guaranteed to not be null.</param>
	/// <param name="expiration">The expiration to set the lease to, if a lease is created</param>
	internal abstract TIReviewTaskLeaseEntity GetLeaseEntityByReviewTaskOrCreate(TIReviewTask reviewTask, IUserIdentifier moderatorIdentity, DateTime expiration);

	public TIReviewTaskLease_Internal GetOrCreateByReviewTaskWithDefaultModerator_Internal(TIReviewTask reviewTask, IUserIdentifier moderatorIdentity, DateTime expiration)
	{
		if (reviewTask == null)
		{
			throw new ArgumentNullException("reviewTask");
		}
		if (moderatorIdentity == null)
		{
			throw new ArgumentNullException("moderatorIdentity");
		}
		TIReviewTaskLeaseEntity leaseEntity = GetOrCreateNonExpiredEntity(reviewTask, moderatorIdentity, expiration);
		return (TIReviewTaskLease_Internal)(object)GetLeaseFromNonNullEntity(leaseEntity);
	}

	public TIReviewTaskLease GetOrCreateByReviewTaskWithDefaultModerator(TIReviewTask reviewTask, IUserIdentifier moderatorIdentity, DateTime expiration)
	{
		return (TIReviewTaskLease)(object)GetOrCreateByReviewTaskWithDefaultModerator_Internal(reviewTask, moderatorIdentity, expiration);
	}

	internal virtual TIReviewTaskLeaseEntity GetOrCreateNonExpiredEntity(TIReviewTask reviewTask, IUserIdentifier moderatorIdentity, DateTime expiration)
	{
		for (int i = 0; i < _Settings.GetOrCreateUnexpiredEntityAttempts; i++)
		{
			TIReviewTaskLeaseEntity leaseEntity = TryGetOrCreateNonExpired(reviewTask, moderatorIdentity, expiration);
			if (leaseEntity != null)
			{
				return leaseEntity;
			}
		}
		throw new InvalidOperationException($"Unable to GetOrCreate a non-expired lease entity for asset review task {reviewTask.Id}");
	}

	internal virtual TIReviewTaskLeaseEntity TryGetOrCreateNonExpired(TIReviewTask reviewTask, IUserIdentifier moderatorIdentity, DateTime expiration)
	{
		TIReviewTaskLeaseEntity leaseEntity = GetLeaseEntityByReviewTaskOrCreate(reviewTask, moderatorIdentity, expiration);
		if (_NowFunc() < leaseEntity.Expiration)
		{
			return leaseEntity;
		}
		try
		{
			leaseEntity.Delete();
		}
		catch (InvalidOperationException)
		{
		}
		return default(TIReviewTaskLeaseEntity);
	}
}
