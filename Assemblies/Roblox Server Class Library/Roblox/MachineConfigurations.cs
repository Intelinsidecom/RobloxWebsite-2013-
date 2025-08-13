using Roblox.DataAccess;

namespace Roblox;

public class MachineConfigurations
{
	public static void Insert(User user, string configuration)
	{
		Roblox.DataAccess.MachineConfigurations.Insert(user.ID, configuration);
	}
}
