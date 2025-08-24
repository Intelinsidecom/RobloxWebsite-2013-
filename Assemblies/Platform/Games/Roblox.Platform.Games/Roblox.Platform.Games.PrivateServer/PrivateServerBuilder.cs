using System;
using System.Data.SqlClient;
using Roblox.Platform.Games.Entities;
using Roblox.Platform.Games.Properties;

namespace Roblox.Platform.Games.PrivateServer;

public class PrivateServerBuilder : IPrivateServerBuilder
{
	private const PrivateServerStatusType _NewServerDefaultStatusType = PrivateServerStatusType.Active;

	public IPrivateServer CreatePrivateServer(long universeId, long ownerUserId, string serverName)
	{
		try
		{
			return Roblox.Platform.Games.Entities.PrivateServer.CreateNew(universeId, ownerUserId, serverName, 1, Guid.NewGuid(), GetExpirationDateStartingNow()).Translate();
		}
		catch (SqlException ex)
		{
			if (ex.Number == -2)
			{
				throw;
			}
			return Roblox.Platform.Games.Entities.PrivateServer.CreateNew(universeId, ownerUserId, serverName, 1, Guid.NewGuid(), GetExpirationDateStartingNow()).Translate();
		}
	}

	public IPrivateServerRenewal RenewExpiredPrivateServer(long privateServerId)
	{
		Roblox.Platform.Games.Entities.PrivateServer privateServer = Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerId);
		DateTime existingExpirateDate = privateServer.ExpirationDate;
		privateServer.ExpirationDate = GetExpirationDateStartingNow();
		byte existingStatus = privateServer.PrivateServerStatusTypeID;
		bool statusChanged = false;
		if (privateServer.PrivateServerStatusTypeID == 3)
		{
			privateServer.PrivateServerStatusTypeID = 2;
			statusChanged = true;
		}
		privateServer.Save();
		if (statusChanged)
		{
			PrivateServerStatusChange.CreateNew(privateServer.ID, 2, 3, Roblox.Platform.Games.Entities.PrivateServerStatusChangeReasonType.RenewalSuccess.ID);
		}
		return new PrivateServerRenewal(privateServer.Translate(), existingExpirateDate, (PrivateServerStatusType)existingStatus);
	}

	public IPrivateServer RollbackPrivateServerRenewal(IPrivateServerRenewal privateServerRenewal)
	{
		Roblox.Platform.Games.Entities.PrivateServer privateServer = Roblox.Platform.Games.Entities.PrivateServer.Get(privateServerRenewal.PrivateServer.Id);
		bool expirationDateChanged = false;
		if (privateServer.ExpirationDate != privateServerRenewal.PreRenewalExpiryDate)
		{
			privateServer.ExpirationDate = privateServerRenewal.PreRenewalExpiryDate;
			expirationDateChanged = true;
		}
		bool statusChanged = false;
		byte? rolledBackStatus = null;
		if (privateServer.PrivateServerStatusTypeID != (byte)privateServerRenewal.PreRenewalStatus)
		{
			rolledBackStatus = privateServer.PrivateServerStatusTypeID;
			privateServer.PrivateServerStatusTypeID = (byte)privateServerRenewal.PreRenewalStatus;
			statusChanged = true;
		}
		if (expirationDateChanged || statusChanged)
		{
			privateServer.Save();
		}
		if (statusChanged)
		{
			PrivateServerStatusChange.CreateNew(privateServer.ID, (byte)privateServerRenewal.PreRenewalStatus, rolledBackStatus.Value, Roblox.Platform.Games.Entities.PrivateServerStatusChangeReasonType.RenewalRollback.ID);
		}
		return privateServer.Translate();
	}

	public void DeletePrivateServer(IPrivateServer privateServer)
	{
		Roblox.Platform.Games.Entities.PrivateServer.Get(privateServer.Id).Delete();
	}

	public IPrivateServerSale CreatePrivateServerSaleEntry(IPrivateServer privateServer, long saleId)
	{
		try
		{
			return Roblox.Platform.Games.Entities.PrivateServerSale.CreateNew(privateServer.Id, saleId).Translate();
		}
		catch (SqlException ex)
		{
			if (ex.Number == -2)
			{
				throw;
			}
			return Roblox.Platform.Games.Entities.PrivateServerSale.CreateNew(privateServer.Id, saleId).Translate();
		}
	}

	public void DeletePrivateServerSale(IPrivateServerSale privateServerSale)
	{
		Roblox.Platform.Games.Entities.PrivateServerSale.Get(privateServerSale.Id).Delete();
	}

	private DateTime GetNow()
	{
		return DateTime.Now;
	}

	private DateTime GetExpirationDateStartingNow()
	{
		return GetNow().AddMonths(Settings.Default.PrivateServerDefaultExpirationMonths).AddHours(Settings.Default.PrivateServerRecurringBufferHours);
	}
}
