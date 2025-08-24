using Roblox.EphemeralCounters;
using Roblox.Platform.Authentication.AccountSecurityTickets;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.TwoStepVerification;

namespace Roblox.Platform.Authentication.AccountSecurity;

/// <summary>
/// Represents a set of factories for the account security tickets domain.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.DomainFactoriesBase" />
public class AccountSecurityDomainFactories : DomainFactoriesBase
{
	/// <summary>
	/// Gets the account security ticket item factory.
	/// </summary>
	/// <value>the account security ticket item factory.</value>
	public AccountSecurityTicketItemFactory AccountSecurityTicketItemFactory { get; }

	/// <summary>
	/// Gets the two step verification configuration provider.
	/// </summary>
	/// <value>The two step verification configuration provider.</value>
	public ITwoStepVerificationConfigurationProvider TwoStepVerificationConfigurationProvider { get; }

	/// <summary>
	/// Gets the account phone number factory.
	/// </summary>
	/// <value>The account phone number factory.</value>
	public IAccountPhoneNumberFactory AccountPhoneNumberFactory { get; }

	/// <summary>
	/// Gets the phone number factory.
	/// </summary>
	/// <value>The phone number factory.</value>
	public IPhoneNumberFactory PhoneNumberFactory { get; }

	/// <summary>
	/// Gets the ephemeral counter factory.
	/// </summary>
	/// <value>The ephemeral counter factory.</value>
	public IEphemeralCounterFactory EphemeralCounterFactory { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityTicketsDomainFactories" /> class.
	/// </summary>
	public AccountSecurityDomainFactories(AccountSecurityTicketItemFactory accountSecurityTicketItemFactory, ITwoStepVerificationConfigurationProvider twoStepVerificationConfigurationProvider, IAccountPhoneNumberFactory accountPhoneNumberFactory, IPhoneNumberFactory phoneNumberFactory, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		AccountSecurityTicketItemFactory = accountSecurityTicketItemFactory.AssignOrThrowIfNull("accountSecurityTicketItemFactory");
		TwoStepVerificationConfigurationProvider = twoStepVerificationConfigurationProvider.AssignOrThrowIfNull("twoStepVerificationConfigurationProvider");
		AccountPhoneNumberFactory = accountPhoneNumberFactory.AssignOrThrowIfNull("accountPhoneNumberFactory");
		PhoneNumberFactory = phoneNumberFactory.AssignOrThrowIfNull("phoneNumberFactory");
		EphemeralCounterFactory = ephemeralCounterFactory.AssignOrThrowIfNull("ephemeralCounterFactory");
	}
}
