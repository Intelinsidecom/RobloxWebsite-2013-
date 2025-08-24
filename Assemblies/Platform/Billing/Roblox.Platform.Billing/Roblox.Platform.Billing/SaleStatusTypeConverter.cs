using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

public class SaleStatusTypeConverter : DomainObjectBase<BillingDomainFactories>, ISaleStatusTypeConverter, IDomainObject<BillingDomainFactories>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Billing.SaleStatusTypeConverter" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="domainFactories" /></exception>
	public SaleStatusTypeConverter(BillingDomainFactories domainFactories)
		: base(domainFactories)
	{
	}

	public byte GetIdByType(SaleStatusType saleStatusType)
	{
		return (base.DomainFactories.SaleStatusTypeEntityFactory.GetByValue(saleStatusType.ToString()) ?? throw new PlatformDataIntegrityException($"Attempted lookup of unpersisted SaleStatusType '{saleStatusType}'")).Id;
	}

	public SaleStatusType? GetTypeById(byte id)
	{
		ISaleStatusTypeEntity cal = base.DomainFactories.SaleStatusTypeEntityFactory.Get(id);
		if (cal == null)
		{
			return null;
		}
		return (SaleStatusType)Enum.Parse(typeof(SaleStatusType), cal.Value);
	}
}
