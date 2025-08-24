using System;
using Roblox.Platform.Groups.Entities;
using Roblox.Platform.Groups.Interfaces;

namespace Roblox.Platform.Groups;

/// <inheritdoc />
public class StatusAccessor : IStatusAccessor
{
	private readonly IStatusEntityFactory _StatusEntityFactory;

	public StatusAccessor()
		: this(new StatusEntityFactory())
	{
	}

	internal StatusAccessor(IStatusEntityFactory statusEntityFactory)
	{
		_StatusEntityFactory = statusEntityFactory ?? throw new ArgumentNullException("statusEntityFactory");
	}

	/// <inheritdoc />
	public IStatus GetStatus(IGroup group)
	{
		if (group == null)
		{
			throw new ArgumentNullException("group");
		}
		IStatusEntity statusEntity = _StatusEntityFactory.GetByGroupId(group.Id);
		if (statusEntity == null)
		{
			return null;
		}
		return new Status(statusEntity);
	}
}
