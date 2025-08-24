using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Notifications.Push.Entities.BLL;
using Roblox.Platform.Notifications.Push.Properties;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class DestinationEntityFactory : IDestinationEntityFactory
{
	private const int _MaxMatchingHashesToGet = 100;

	public IDestinationEntity Get(long id)
	{
		return CalToCachedMssql(Destination.Get(id));
	}

	public IDestinationEntity GetByDestinationTypeIdAndExternalServiceDestinationId(int destinationTypeId, string externalServiceDestinationId)
	{
		if (Settings.Default.IsDestinationLookupByHashEnabled)
		{
			byte[] hash = DestinationUtilities.ComputeDestinationServiceIDHash(externalServiceDestinationId);
			return GetByDestinationTypeIdAndExternalServiceDestinationIdHashEnumerative(destinationTypeId, hash, 100, 0L).FirstOrDefault((IDestinationEntity destination) => destination.ExternalServiceDestinationId == externalServiceDestinationId);
		}
		return CalToCachedMssql(Destination.GetByDestinationTypeIDAndExternalServiceDestinationID(destinationTypeId, externalServiceDestinationId));
	}

	private IEnumerable<IDestinationEntity> GetByDestinationTypeIdAndExternalServiceDestinationIdHashEnumerative(int destinationTypeId, byte[] externalServiceDestinationIdHash, int count, long exclusiveStartDestinationId)
	{
		if (count < 1)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "count"));
		}
		if (destinationTypeId < 1)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "destinationTypeId"));
		}
		if (externalServiceDestinationIdHash == null || externalServiceDestinationIdHash.Length == 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must not be null or empty", "externalServiceDestinationIdHash"));
		}
		return Destination.GetDestinationsByDestinationTypeIDAndExternalServiceDestinationIDHash(destinationTypeId, externalServiceDestinationIdHash, count, exclusiveStartDestinationId).Select(CalToCachedMssql);
	}

	public IDestinationEntity Create(int destinationTypeId, string externalServiceDestinationId, byte[] externalServiceDestinationIDHash, string notificationDeliveryEndpoint)
	{
		return CalToCachedMssql(Destination.Create(destinationTypeId, externalServiceDestinationId, externalServiceDestinationIDHash, notificationDeliveryEndpoint));
	}

	private static IDestinationEntity CalToCachedMssql(Destination cal)
	{
		if (cal != null)
		{
			return new DestinationCachedMssqlEntity
			{
				Id = cal.ID,
				DestinationTypeId = cal.DestinationTypeID,
				ExternalServiceDestinationId = cal.ExternalServiceDestinationID,
				NotificationDeliveryEndpoint = cal.NotificationDeliveryEndpoint,
				Created = cal.Created,
				Updated = cal.Updated,
				ExternalServiceDestinationIdHash = cal.ExternalServiceDestinationIDHash
			};
		}
		return null;
	}
}
