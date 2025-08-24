using Roblox.Billing.Client;
using Roblox.Common;
using Roblox.EphemeralCounters;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Locking;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Billing.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

/// <inheritdoc cref="T:Roblox.Platform.Billing.ICreditProviderFactory" />
public class CreditProviderFactory : ICreditProviderFactory
{
	protected const int InCommPinMinLength = 10;

	protected const int InCommPinMaxLength = 10;

	protected const int GiftCardPinMinLength = 12;

	protected const int GiftCardPinMaxLength = 12;

	protected const int BlackhawkPinMinLength = 16;

	protected const int BlackhawkPinMaxLength = 16;

	protected readonly Range InCommPinLengthRange;

	protected readonly Range GiftCardPinLengthRange;

	protected readonly Range BlackhawkPinLengthRange;

	protected readonly ISettings Settings;

	protected readonly IBillingClient BillingClient;

	protected readonly ILogger Logger;

	protected readonly IEphemeralCounterFactory EphemeralCounterFactory;

	protected readonly IThrowingLeasedLockFactory LeasedLockFactory;

	protected readonly IFloodCheckerFactory<IFloodChecker> FloodCheckerFactory;

	protected readonly IAssetOwnershipAuthority AssetOwnershipAuthority;

	/// <summary>
	/// Creates a credit provider factory. Creates credit providers
	/// </summary>
	/// <param name="settings">Settings as per <see cref="T:Roblox.Platform.Billing.Properties.Settings" /></param>
	/// <param name="billingClient">billing client for making calls to billing service</param>
	/// <param name="logger">logger</param>
	/// <param name="counterFactory">ephemeral counter factory</param>
	/// <param name="leasedLockFactory">throwing leased lock factory</param>
	/// <param name="floodCheckerFactory">flood checker factory</param>
	/// <param name="assetOwnershipAuthority">asset ownership client</param>
	public CreditProviderFactory(ISettings settings, IBillingClient billingClient, ILogger logger, IEphemeralCounterFactory counterFactory, IThrowingLeasedLockFactory leasedLockFactory, IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, IAssetOwnershipAuthority assetOwnershipAuthority)
	{
		InCommPinLengthRange = new Range
		{
			Max = 10,
			Min = 10
		};
		GiftCardPinLengthRange = new Range
		{
			Max = 12,
			Min = 12
		};
		BlackhawkPinLengthRange = new Range
		{
			Max = 16,
			Min = 16
		};
		Settings = settings.AssignOrThrowIfNull("settings");
		BillingClient = billingClient.AssignOrThrowIfNull<IBillingClient>("billingClient");
		Logger = logger.AssignOrThrowIfNull("logger");
		EphemeralCounterFactory = counterFactory.AssignOrThrowIfNull("counterFactory");
		LeasedLockFactory = leasedLockFactory.AssignOrThrowIfNull("leasedLockFactory");
		FloodCheckerFactory = floodCheckerFactory.AssignOrThrowIfNull("floodCheckerFactory");
		AssetOwnershipAuthority = assetOwnershipAuthority.AssignOrThrowIfNull("assetOwnershipAuthority");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Billing.ICreditProviderFactory.GetFromPinCode(System.String)" />
	public ICreditProvider GetFromPinCode(string pinCode)
	{
		if (pinCode == null)
		{
			return null;
		}
		if (BlackhawkPinLengthRange.Contains(pinCode.Length))
		{
			return new BlackhawkCreditProvider(Settings, BillingClient, Logger, EphemeralCounterFactory, LeasedLockFactory, FloodCheckerFactory, AssetOwnershipAuthority);
		}
		return null;
	}
}
