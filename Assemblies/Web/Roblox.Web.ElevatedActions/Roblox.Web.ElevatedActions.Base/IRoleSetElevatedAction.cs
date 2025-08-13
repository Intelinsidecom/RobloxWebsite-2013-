using System;

namespace Roblox.Web.ElevatedActions.Base;

public interface IRoleSetElevatedAction
{
	int ID { get; }

	int RoleSetID { get; }

	int ElevatedActionID { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}
