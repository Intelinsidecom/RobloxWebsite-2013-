using System;

namespace Roblox.Platform.Throttling;

internal class RateLimit : IRateLimit
{
	public long Id { get; private set; }

	public INamespace Namespace { get; private set; }

	public IActionType ActionType { get; private set; }

	public long NumberOfRequests { get; private set; }

	public TimeSpan Interval { get; private set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	internal RateLimit(long id, long namespaceId, long actionTypeId, long numberOfRequests, long intervalInTicks, DateTime created, DateTime updated)
	{
		Updated = updated;
		Created = created;
		Interval = TimeSpan.FromTicks(intervalInTicks);
		NumberOfRequests = numberOfRequests;
		ActionType = ThrottlingConfigurationFactory.GetActionTypeById(actionTypeId);
		Namespace = ThrottlingConfigurationFactory.GetNamespaceById(namespaceId);
		Id = id;
	}
}
