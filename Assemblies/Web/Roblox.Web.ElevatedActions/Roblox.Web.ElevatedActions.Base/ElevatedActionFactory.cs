using System;
using Roblox.Web.ElevatedActions.BLL;

namespace Roblox.Web.ElevatedActions.Base;

public class ElevatedActionFactory : IElevatedActionFactory
{
	public IElevatedAction Get(string elevatedActionName)
	{
		if (string.IsNullOrEmpty(elevatedActionName))
		{
			throw new ArgumentException("message", "elevatedActionName");
		}
		return ElevatedAction.Get(elevatedActionName);
	}
}
