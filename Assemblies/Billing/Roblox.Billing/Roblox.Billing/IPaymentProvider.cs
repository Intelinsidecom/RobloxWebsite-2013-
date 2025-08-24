namespace Roblox.Billing;

public interface IPaymentProvider
{
	bool Enabled { get; }

	Payment InitialCharge { get; }

	bool NetSuccessOrFailure { get; }

	Sale Sale { get; }

	bool SupportsRecurringBilling { get; }
}
