namespace Roblox.Web.ElevatedActions.Base;

public interface IElevatedActionFactory
{
	IElevatedAction Get(string elevatedActionName);
}
