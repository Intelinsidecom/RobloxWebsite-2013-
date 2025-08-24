using Roblox.Platform.Throttling.Entities;

namespace Roblox.Platform.Throttling;

internal static class Extensions
{
	public static ActionType Translate(this Roblox.Platform.Throttling.Entities.ActionType actionTypeEntity)
	{
		if (actionTypeEntity == null)
		{
			return null;
		}
		return new ActionType(actionTypeEntity.ID, actionTypeEntity.Value, actionTypeEntity.Created, actionTypeEntity.Updated);
	}

	public static Namespace Translate(this Roblox.Platform.Throttling.Entities.Namespace nameSpaceEntity)
	{
		if (nameSpaceEntity == null)
		{
			return null;
		}
		return new Namespace(nameSpaceEntity.ID, nameSpaceEntity.Value, nameSpaceEntity.Created, nameSpaceEntity.Updated);
	}

	public static RateLimit Translate(this Roblox.Platform.Throttling.Entities.RateLimit rateLimitEntity)
	{
		if (rateLimitEntity == null)
		{
			return null;
		}
		return new RateLimit(rateLimitEntity.ID, rateLimitEntity.NamespaceID, rateLimitEntity.ActionTypeID, rateLimitEntity.NumberOfRequests, rateLimitEntity.IntervalInTicks, rateLimitEntity.Created, rateLimitEntity.Updated);
	}
}
