using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Notifications.Push.Entities.BLL;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class ReceiverDestinationEntityFactory : IReceiverDestinationEntityFactory
{
	public IReceiverDestinationEntity Get(long id)
	{
		return CalToCachedMssql(ReceiverDestination.Get(id));
	}

	public IReceiverDestinationEntity GetByReceiverTypeIdReceiverTargetIdAndDestinationId(int receiverTypeId, long receiverTargetId, long destinationId)
	{
		return CalToCachedMssql(ReceiverDestination.GetByReceiverTypeIDReceiverTargetIDAndDestinationID(receiverTypeId, receiverTargetId, destinationId));
	}

	public IEnumerable<IReceiverDestinationEntity> GetByDestinationIdAndIsActivePaged(long destinationId, bool isActive, long startRowIndex, long maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		return ReceiverDestination.GetReceiverDestinationsByDestinationIDAndIsActivePaged(destinationId, isActive, startRowIndex, maxRows).Select(CalToCachedMssql).ToList();
	}

	public IEnumerable<IReceiverDestinationEntity> GetByReceiverTypeIdReceiverTargetIdAndIsActivePaged(int receiverTypeId, long receiverTargetId, bool isActive, long startRowIndex, long maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		return ReceiverDestination.GetReceiverDestinationsByReceiverTypeIDReceiverTargetIDAndIsActivePaged(receiverTypeId, receiverTargetId, isActive, startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	public IEnumerable<IReceiverDestinationEntity> GetByReceiverTypeIdReceiverTargetIdIsAuthorizedByReceiverAndIsActivePaged(int receiverTypeId, long receiverTargetId, bool isAuthorizedByReceiver, bool isActive, long startRowIndex, long maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		return ReceiverDestination.GetReceiverDestinationsByReceiverTypeIDReceiverTargetIDIsAuthorizedByReceiverAndIsActivePaged(receiverTypeId, receiverTargetId, isAuthorizedByReceiver, isActive, startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	public IEnumerable<IReceiverDestinationEntity> GetByReceiverTypeIdReceiverTargetIdAuthenticationTypeIdAndAuthenticationValuePaged(int receiverTypeId, long receiverTargetId, int authenticationTypeId, string authenticationValue, long startRowIndex, long maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		return ReceiverDestination.GetReceiverDestinationsByReceiverTypeIDReceiverTargetIDAuthenticationTypeIDAndAuthenticationValuePaged(receiverTypeId, receiverTargetId, authenticationTypeId, authenticationValue, startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	public IReceiverDestinationEntity Create(int receiverTypeId, long receiverTargetId, long destinationId, int authenticationTypeId, string authenticationValue, string name, bool isActive, bool isAuthorizedByReceiver)
	{
		return CalToCachedMssql(ReceiverDestination.Create(receiverTypeId, receiverTargetId, destinationId, authenticationTypeId, authenticationValue, name, isActive, isAuthorizedByReceiver));
	}

	private static IReceiverDestinationEntity CalToCachedMssql(ReceiverDestination cal)
	{
		if (cal != null)
		{
			return new ReceiverDestinationCachedMssqlEntity
			{
				Id = cal.ID,
				ReceiverTypeId = cal.ReceiverTypeID,
				ReceiverTargetId = cal.ReceiverTargetID,
				DestinationId = cal.DestinationID,
				IsAuthorizedByReceiver = cal.IsAuthorizedByReceiver,
				IsActive = cal.IsActive,
				AuthenticationTypeId = cal.AuthenticationTypeID,
				AuthenticationValue = cal.AuthenticationValue,
				Name = cal.Name,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}
}
