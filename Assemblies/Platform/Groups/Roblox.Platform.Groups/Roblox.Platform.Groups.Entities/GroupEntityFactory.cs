using System.Diagnostics.CodeAnalysis;

namespace Roblox.Platform.Groups.Entities;

[ExcludeFromCodeCoverage]
internal class GroupEntityFactory : IGroupEntityFactory
{
	public IGroupEntity GetById(long id)
	{
		Roblox.Group dbObject = Roblox.Group.Get(id);
		if (dbObject != null)
		{
			return new GroupEntity(dbObject);
		}
		return null;
	}

	public IGroupEntity GetByName(string name)
	{
		Roblox.Group dbObject = Roblox.Group.Get(name);
		if (dbObject != null)
		{
			return new GroupEntity(dbObject);
		}
		return null;
	}
}
