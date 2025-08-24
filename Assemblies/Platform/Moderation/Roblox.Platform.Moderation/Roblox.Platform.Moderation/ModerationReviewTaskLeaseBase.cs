using System;

namespace Roblox.Platform.Moderation;

public abstract class ModerationReviewTaskLeaseBase<TEntityFactory, TEntity> : IReviewTaskLease_Internal, IReviewTaskLease where TEntityFactory : IReviewTaskLeaseEntityFactory<TEntity> where TEntity : IReviewTaskLeaseEntity
{
	private readonly TEntityFactory _EntityFactory;

	internal long Id { get; }

	public long ReviewTaskId { get; }

	public long ModeratorId { get; }

	public DateTime Expiration { get; }

	protected ModerationReviewTaskLeaseBase(TEntityFactory entityFactory, TEntity entity)
	{
		if (entityFactory == null)
		{
			throw new ArgumentNullException("entityFactory");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		_EntityFactory = entityFactory;
		Id = entity.Id;
		ReviewTaskId = entity.ReviewTaskId;
		ModeratorId = entity.ModeratorId;
		Expiration = entity.Expiration;
	}

	public void Delete()
	{
		TEntityFactory entityFactory = _EntityFactory;
		TEntity entity = entityFactory.Get(Id);
		if (entity == null)
		{
			throw new InvalidOperationException();
		}
		entity.Delete();
	}
}
