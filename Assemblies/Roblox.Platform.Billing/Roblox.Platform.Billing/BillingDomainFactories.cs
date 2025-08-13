using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

public class BillingDomainFactories : DomainFactoriesBase
{
	internal virtual ISaleEntityFactory SaleEntityFactory { get; private set; }

	internal virtual ISaleProductEntityFactory SaleProductEntityFactory { get; private set; }

	internal virtual ISaleStatusTypeEntityFactory SaleStatusTypeEntityFactory { get; private set; }

	internal virtual IPaymentStatusTypeEntityFactory PaymentStatusTypeEntityFactory { get; private set; }

	internal virtual IPaymentProviderTypeEntityFactory PaymentProviderTypeEntityFactory { get; private set; }

	public virtual ISaleFactory SaleFactory { get; private set; }

	protected BillingDomainFactories()
	{
	}

	public static BillingDomainFactories Build()
	{
		BillingDomainFactories billingDomainFactories = new BillingDomainFactories();
		billingDomainFactories.SaleEntityFactory = new SaleEntityFactory(billingDomainFactories);
		billingDomainFactories.SaleProductEntityFactory = new SaleProductEntityFactory(billingDomainFactories);
		billingDomainFactories.SaleStatusTypeEntityFactory = new SaleStatusTypeEntityFactory(billingDomainFactories);
		billingDomainFactories.PaymentStatusTypeEntityFactory = new PaymentStatusTypeEntityFactory(billingDomainFactories);
		billingDomainFactories.PaymentProviderTypeEntityFactory = new PaymentProviderTypeEntityFactory(billingDomainFactories);
		billingDomainFactories.SaleFactory = new SaleFactory(billingDomainFactories);
		return billingDomainFactories;
	}
}
