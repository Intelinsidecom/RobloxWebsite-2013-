namespace Roblox.Platform.Groups.Entities;

internal interface IGroupEntityFactory
{
	IGroupEntity GetById(long id);

	IGroupEntity GetByName(string name);
}
