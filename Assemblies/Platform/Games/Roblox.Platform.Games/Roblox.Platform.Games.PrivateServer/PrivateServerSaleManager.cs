using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Economy;
using Roblox.EventLog;
using Roblox.Marketplace.Client;
using Roblox.Platform.Games.Entities;
using Roblox.Platform.VirtualCurrency;

namespace Roblox.Platform.Games.PrivateServer;

internal class PrivateServerSaleManager : IPrivateServerSaleManager
{
	private readonly MarketplaceAuthority _MarketplaceAuthority;

	private readonly IRecurringTransactionFactory _RecurringTransactionFactory;

	private readonly ILogger _Logger;

	public PrivateServerSaleManager(MarketplaceAuthority marketplaceAuthority, IRecurringTransactionFactory recurringTransactionFactory, ILogger logger)
	{
		_MarketplaceAuthority = marketplaceAuthority;
		_RecurringTransactionFactory = recurringTransactionFactory;
		_Logger = logger;
	}

	public bool CancelRecurringSaleForPrivateServer(IPrivateServer privateServer)
	{
		Roblox.Platform.Games.Entities.PrivateServerSale newestPrivateServerSale;
		Roblox.Platform.Games.Entities.PrivateServerSale activeSale = GetActivePrivateServerSale(privateServer, out newestPrivateServerSale);
		if (activeSale == null)
		{
			return false;
		}
		return _MarketplaceAuthority.CancelRecurringSale(activeSale.SaleID);
	}

	public bool CancelAllRecurringSalesForPrivateServer(IPrivateServer privateServer)
	{
		IReadOnlyCollection<Roblox.Platform.Games.Entities.PrivateServerSale> activeSales = GetAllActivePrivateServerSalesWithRecurringCurrencyProfile(privateServer);
		if (!activeSales.Any())
		{
			return false;
		}
		foreach (Roblox.Platform.Games.Entities.PrivateServerSale activeSale in activeSales)
		{
			try
			{
				_MarketplaceAuthority.CancelRecurringSale(activeSale.SaleID);
			}
			catch (Exception e)
			{
				_Logger.Error(e);
			}
		}
		return true;
	}

	/// <summary>
	/// Gets the private server sale with an active recurring sale profile (if one exists) or else returns null
	/// </summary>
	/// <param name="privateServer"></param>
	/// <param name="newestPrivateServerSale">The newest private server sale, which may also be active</param>
	/// <returns></returns>
	public Roblox.Platform.Games.Entities.PrivateServerSale GetActivePrivateServerSale(IPrivateServer privateServer, out Roblox.Platform.Games.Entities.PrivateServerSale newestPrivateServerSale)
	{
		newestPrivateServerSale = null;
		long totalPrivateServerSales = Roblox.Platform.Games.Entities.PrivateServerSale.GetTotalNumberOfPrivateServerSalesByPrivateServerId(privateServer.Id);
		long i = Math.Max(0L, totalPrivateServerSales - 20);
		while (true)
		{
			foreach (Roblox.Platform.Games.Entities.PrivateServerSale privateServerSale in Roblox.Platform.Games.Entities.PrivateServerSale.GetPrivateServerSalesByPrivateServerIDPaged(privateServer.Id, i, 20L).Reverse())
			{
				if (newestPrivateServerSale == null || newestPrivateServerSale.Created < privateServerSale.Created)
				{
					newestPrivateServerSale = privateServerSale;
				}
				SaleMetadata saleMetadata = SaleMetadata.GetBySaleID(privateServerSale.SaleID);
				if (saleMetadata != null && saleMetadata.RecurringTransactionIsActive.HasValue && saleMetadata.RecurringTransactionIsActive.Value)
				{
					return privateServerSale;
				}
			}
			if (i == 0L)
			{
				break;
			}
			i = Math.Max(0L, i - 20);
		}
		return null;
	}

	/// <summary>
	/// Gets all the private server sales with an active recurring sale profile (if one exists)
	/// </summary>
	/// <param name="privateServer"></param>
	/// <returns></returns>
	internal IReadOnlyCollection<Roblox.Platform.Games.Entities.PrivateServerSale> GetAllActivePrivateServerSalesWithRecurringCurrencyProfile(IPrivateServer privateServer)
	{
		List<Roblox.Platform.Games.Entities.PrivateServerSale> activePrivateServerSales = new List<Roblox.Platform.Games.Entities.PrivateServerSale>();
		long totalPrivateServerSales = Roblox.Platform.Games.Entities.PrivateServerSale.GetTotalNumberOfPrivateServerSalesByPrivateServerId(privateServer.Id);
		for (int startRowIndex = 0; startRowIndex < totalPrivateServerSales + 20; startRowIndex += 20)
		{
			ICollection<Roblox.Platform.Games.Entities.PrivateServerSale> privateServerSales = Roblox.Platform.Games.Entities.PrivateServerSale.GetPrivateServerSalesByPrivateServerIDPaged(privateServer.Id, startRowIndex, 20L);
			if (privateServerSales.Count == 0)
			{
				break;
			}
			foreach (Roblox.Platform.Games.Entities.PrivateServerSale privateServerSale in privateServerSales)
			{
				SaleMetadata saleMetadata = SaleMetadata.GetBySaleID(privateServerSale.SaleID);
				if (saleMetadata == null)
				{
					continue;
				}
				if (saleMetadata.RecurringTransactionIsActive.HasValue && saleMetadata.RecurringTransactionIsActive.Value)
				{
					activePrivateServerSales.Add(privateServerSale);
					continue;
				}
				IRecurringTransactionProfile recurringTransactionProfile = _RecurringTransactionFactory.GetRecurringTransactionProfile(saleMetadata.RecurringTransactionProfileID);
				if (recurringTransactionProfile != null && recurringTransactionProfile.RecurrenceEndDate > DateTime.UtcNow)
				{
					activePrivateServerSales.Add(privateServerSale);
				}
			}
		}
		return activePrivateServerSales;
	}

	/// <summary>
	/// Gets all the private server sales with either an active sale metadata and an inactive recurring sale profile or vice versa
	/// </summary>
	/// <param name="privateServer"></param>
	/// <returns></returns>
	internal IReadOnlyCollection<Roblox.Platform.Games.Entities.PrivateServerSale> GetOutOfSyncSalesWithRecurrencyTransactionProfile(IPrivateServer privateServer)
	{
		List<Roblox.Platform.Games.Entities.PrivateServerSale> outOfSyncPrivateServerSales = new List<Roblox.Platform.Games.Entities.PrivateServerSale>();
		long totalPrivateServerSales = Roblox.Platform.Games.Entities.PrivateServerSale.GetTotalNumberOfPrivateServerSalesByPrivateServerId(privateServer.Id);
		for (int startRowIndex = 0; startRowIndex < totalPrivateServerSales + 20; startRowIndex += 20)
		{
			ICollection<Roblox.Platform.Games.Entities.PrivateServerSale> privateServerSales = Roblox.Platform.Games.Entities.PrivateServerSale.GetPrivateServerSalesByPrivateServerIDPaged(privateServer.Id, startRowIndex, 20L);
			if (privateServerSales.Count == 0)
			{
				break;
			}
			foreach (Roblox.Platform.Games.Entities.PrivateServerSale privateServerSale in privateServerSales)
			{
				SaleMetadata saleMetadata = SaleMetadata.GetBySaleID(privateServerSale.SaleID);
				if (saleMetadata != null && saleMetadata.RecurringTransactionIsActive.HasValue)
				{
					IRecurringTransactionProfile recurringTransactionProfile = _RecurringTransactionFactory.GetRecurringTransactionProfile(saleMetadata.RecurringTransactionProfileID);
					if (recurringTransactionProfile != null && ((saleMetadata.RecurringTransactionIsActive.Value && recurringTransactionProfile.RecurrenceEndDate <= DateTime.Now) || (!saleMetadata.RecurringTransactionIsActive.Value && recurringTransactionProfile.RecurrenceEndDate > DateTime.Now)))
					{
						outOfSyncPrivateServerSales.Add(privateServerSale);
					}
				}
			}
		}
		return outOfSyncPrivateServerSales;
	}

	/// <summary>
	/// Gets the newest private server sale, can be active or inactive
	/// </summary>
	/// <param name="privateServer"></param>
	/// <returns></returns>
	public Roblox.Platform.Games.Entities.PrivateServerSale GetNewestPrivateServerSale(IPrivateServer privateServer)
	{
		long totalPrivateServerSales = Roblox.Platform.Games.Entities.PrivateServerSale.GetTotalNumberOfPrivateServerSalesByPrivateServerId(privateServer.Id);
		if (totalPrivateServerSales == 0L)
		{
			return null;
		}
		return Roblox.Platform.Games.Entities.PrivateServerSale.GetPrivateServerSalesByPrivateServerIDPaged(privateServer.Id, totalPrivateServerSales - 1, 1L).FirstOrDefault();
	}
}
