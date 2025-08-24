using System;

namespace Roblox.Platform.Assets;

public static class CreatorTypeExtensions
{
	public static CreatorType Translate(this Roblox.CreatorType type)
	{
		return type switch
		{
			Roblox.CreatorType.Group => CreatorType.Group, 
			Roblox.CreatorType.User => CreatorType.User, 
			_ => throw new InvalidCastException($"Cannot convert {type}"), 
		};
	}
}
