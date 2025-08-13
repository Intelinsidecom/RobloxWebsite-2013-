using System;
using Roblox.Web.ElevatedActions.Properties;

namespace Roblox.Web.ElevatedActions.Base;

public abstract class ViewElevatedActionBase : RobloxElevatedActionBase
{
	protected override int _DefaultFloodCheckerLimit => Settings.Default.ViewElevatedActionFloodCheckerLimit;

	protected override TimeSpan _DefaultFloodCheckerExpiry => Settings.Default.ViewElevatedActionFloodCheckerExpiry;

	protected ViewElevatedActionBase(IElevatedActionFactories factories, long currentUserId)
		: base(factories, currentUserId)
	{
	}

	protected ViewElevatedActionBase(IElevatedActionFactories factories, long currentUserId, long targetUserId)
		: base(factories, currentUserId, targetUserId)
	{
	}

	protected ViewElevatedActionBase(IElevatedActionFactories factories, long currentUserId, long? targetUserId = null, bool floodCheckEnabled = true, int? floodCheckLimit = null, TimeSpan? floodCheckExpiry = null)
		: base(factories, currentUserId, targetUserId, floodCheckEnabled, floodCheckLimit, floodCheckExpiry)
	{
	}
}
