using Roblox.Entities;

namespace Roblox.Platform.Outfits;

public interface IScaleEntity : IEntity<int>
{
	decimal Height { get; }

	decimal Width { get; }

	decimal Head { get; }

	decimal Proportion { get; }

	decimal BodyType { get; }
}
