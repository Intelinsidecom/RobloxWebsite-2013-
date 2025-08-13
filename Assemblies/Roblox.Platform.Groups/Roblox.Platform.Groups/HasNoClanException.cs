using Roblox.Platform.Core;

namespace Roblox.Platform.Groups;

public class HasNoClanException : PlatformException
{
	public HasNoClanException()
		: base("This group has no Clan!")
	{
	}
}
