using System.Collections.Generic;

namespace Roblox.Web.ElevatedActions.Base;

public interface IRobloxElevatedActionAuthorizationChecker
{
	bool IsUserMemberOfRolesetThatIsAuthorizedToExecuteElevatedAction(long userID, string elevatedActionName, IErrorAggregator<string, IEnumerable<string>> errorAggregator);
}
