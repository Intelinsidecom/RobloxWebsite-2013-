using Roblox.Platform.Authentication.AccountSecurityTickets;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication.AccountSecurity;

public interface IAccountSecurityFactory : IDomainObject<AccountSecurityDomainFactories>
{
	/// <summary>
	/// Reverts the account from the AccountSecurityTicketItems linked to the AccountSecurityTickets
	/// </summary>
	/// <param name="accountSecurityTicketsV2"><see cref="N:Roblox.Platform.Authentication.AccountSecurityTickets" /></param>
	/// <param name="accountSecurityTicket"><see cref="T:Roblox.AccountSecurityTicket" /></param>
	/// <param name="targetUser"><see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="accountSecurityTicketsV2" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="accountSecurityTicket" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="targetUser" /> is null.</exception>
	void RevertAccountFromAccountSecurityTickets(Roblox.Platform.Authentication.AccountSecurityTickets.AccountSecurityTickets accountSecurityTicketsV2, AccountSecurityTicket accountSecurityTicket, IUser targetUser);
}
