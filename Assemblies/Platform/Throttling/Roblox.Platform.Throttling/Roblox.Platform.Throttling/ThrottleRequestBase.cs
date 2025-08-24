using System;
using Roblox.Platform.Throttling.Entities;
using Roblox.Platform.Throttling.Properties;

namespace Roblox.Platform.Throttling;

internal abstract class ThrottleRequestBase : IRequest
{
	protected readonly string RequestIdentifier;

	protected readonly string Namespace;

	protected readonly string ActionType;

	internal abstract string ActionSuffix { get; }

	/// <summary>
	/// In some cases we do not want to apply a default rate limit and track counts of
	/// requests.
	/// </summary>
	public virtual bool IsEnabled()
	{
		return true;
	}

	protected ThrottleRequestBase(string requestIdentifier, string nameSpace, string actionType)
	{
		RequestIdentifier = requestIdentifier;
		Namespace = nameSpace;
		ActionType = actionType;
	}

	protected internal virtual Roblox.Platform.Throttling.Entities.RateLimit GetRateLimitEntity()
	{
		Roblox.Platform.Throttling.Entities.Namespace namespaceEntity = Roblox.Platform.Throttling.Entities.Namespace.GetOrCreate(Namespace);
		Roblox.Platform.Throttling.Entities.ActionType actionTypeEntity = Roblox.Platform.Throttling.Entities.ActionType.GetOrCreate($"{ActionType}_{ActionSuffix}");
		if (actionTypeEntity == null || namespaceEntity == null)
		{
			return null;
		}
		return Roblox.Platform.Throttling.Entities.RateLimit.GetByNamespaceIDActionTypeID(namespaceEntity.ID, actionTypeEntity.ID);
	}

	public virtual string GetKey()
	{
		return $"{Namespace}_{ActionType}_{ActionSuffix}_{RequestIdentifier}";
	}

	public virtual TimeSpan GetExpirationInterval()
	{
		Roblox.Platform.Throttling.Entities.RateLimit rateLimitEntity = GetRateLimitEntity();
		if (rateLimitEntity == null)
		{
			return Settings.Default.DefaultRequestDuration;
		}
		return TimeSpan.FromTicks(rateLimitEntity.IntervalInTicks);
	}

	public virtual long GetBudget()
	{
		return GetRateLimitEntity()?.NumberOfRequests ?? Settings.Default.DefaultRequestAmount;
	}
}
