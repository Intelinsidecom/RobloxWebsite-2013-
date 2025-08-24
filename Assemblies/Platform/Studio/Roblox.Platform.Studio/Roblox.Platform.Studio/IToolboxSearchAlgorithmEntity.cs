using Roblox.Entities;

namespace Roblox.Platform.Studio;

internal interface IToolboxSearchAlgorithmEntity : IUpdateableEntity<int>, IEntity<int>
{
	string Name { get; set; }

	string Description { get; set; }
}
