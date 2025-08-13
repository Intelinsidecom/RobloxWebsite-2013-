using Roblox.Platform.Authentication.AccountSecurityTickets.Properties;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

/// <summary>
/// Represents a set of factories for the account security tickets domain.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Core.DomainFactoriesBase" />
public class AccountSecurityTicketsDomainFactories : DomainFactoriesBase
{
	internal virtual ISettings Settings { get; }

	internal virtual IAccountSecurityTicketItemEntityFactory AccountSecurityTicketItemEntityFactory { get; }

	internal virtual IAccountSecurityTicketsV2EntityFactory AccountSecurityTicketsV2EntityFactory { get; }

	internal virtual IAccountSecurityTypeEntityFactory AccountSecurityTypeEntityFactory { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityTicketsDomainFactories" /> class.
	/// </summary>
	public AccountSecurityTicketsDomainFactories()
	{
		Settings = Roblox.Platform.Authentication.AccountSecurityTickets.Properties.Settings.Default;
		AccountSecurityTicketItemEntityFactory = new AccountSecurityTicketItemEntityFactory(this);
		AccountSecurityTicketsV2EntityFactory = new AccountSecurityTicketsV2EntityFactory(this);
		AccountSecurityTypeEntityFactory = new AccountSecurityTypeEntityFactory(this);
	}
}
