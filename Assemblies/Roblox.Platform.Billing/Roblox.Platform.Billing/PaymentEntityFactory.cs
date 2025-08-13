using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;
using Roblox.Platform.Billing.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

/// <summary>
/// </summary>
/// <seealso cref="T:Roblox.Platform.Billing.IPaymentEntityFactory" />
internal class PaymentEntityFactory : IPaymentEntityFactory, IDomainFactory<BillingDomainFactories>, IDomainObject<BillingDomainFactories>
{
	public BillingDomainFactories DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Billing.PaymentEntityFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="domainFactories" /></exception>
	public PaymentEntityFactory(BillingDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}

	public IPaymentEntity Create(int saleId, byte paymentProviderTypeId, byte paymentStatusTypeId, DateTime paymentDate, decimal amount, byte? currencyTypeId)
	{
		return CalToCachedMssql(Payment.CreateNew(saleId, paymentProviderTypeId, paymentStatusTypeId, paymentDate, amount, currencyTypeId));
	}

	public IPaymentEntity Get(long id)
	{
		return CalToCachedMssql(Payment.Get(id));
	}

	public IEnumerable<IPaymentEntity> GetBySaleIdPaged(int saleId, long startRowIndex, long maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException("'startRowIndex' cannot be negative");
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException("'maxRows' must be positive");
		}
		if (saleId == 0)
		{
			return Enumerable.Empty<IPaymentEntity>();
		}
		return Payment.GetPaymentsBySaleIDPaged(saleId, startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	public long GetTotalBySaleId(int saleId)
	{
		return Payment.GetTotalNumberOfPaymentsBySaleId(saleId);
	}

	private static IPaymentEntity CalToCachedMssql(Payment cal)
	{
		if (cal != null)
		{
			return new PaymentCachedMssqlEntity
			{
				Id = cal.ID,
				SaleID = cal.SaleID,
				PaymentProviderTypeID = cal.PaymentProviderTypeID,
				PaymentStatusTypeID = cal.PaymentStatusTypeID,
				PaymentDate = cal.PaymentDate,
				Amount = cal.Amount,
				Created = cal.Created,
				Updated = cal.Updated,
				CurrencyTypeID = cal.CurrencyTypeID
			};
		}
		return null;
	}
}
