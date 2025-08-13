using System;

namespace Roblox.Platform.Membership.Entities;

internal class RoleSetEntity : IRoleSetEntity
{
	private readonly RoleSet _Entity;

	public int Id => _Entity.ID;

	public string Name => _Entity.Name;

	public int Rank => _Entity.Rank;

	public RoleSetEntity(RoleSet entity)
	{
		_Entity = entity ?? throw new ArgumentNullException("entity");
	}
}
