using Roblox.Platform.Notifications.Push.Entities.BLL;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class ReceiverTypeEntityFactory : IReceiverTypeEntityFactory
{
	public IReceiverTypeEntity Get(int id)
	{
		return CalToCachedMssql(ReceiverType.Get(id));
	}

	public IReceiverTypeEntity GetByValue(string value)
	{
		return CalToCachedMssql(ReceiverType.GetByValue(value));
	}

	public IReceiverTypeEntity GetOrCreate(string value)
	{
		return CalToCachedMssql(ReceiverType.GetOrCreate(value));
	}

	private static IReceiverTypeEntity CalToCachedMssql(ReceiverType cal)
	{
		if (cal != null)
		{
			return new ReceiverTypeCachedMssqlEntity
			{
				Id = cal.ID,
				Value = cal.Value,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
