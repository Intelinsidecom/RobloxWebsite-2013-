using System;

namespace Roblox.Platform.Membership;

public interface IAutomaticAgeUpFactory
{
	bool AutomaticAgeUpAfter(long id, DateTime birthday);
}
