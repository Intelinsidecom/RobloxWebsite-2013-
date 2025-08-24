using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication.AccountSecurityTickets;

internal interface IAccountSecurityTypeEntityFactory : IDomainFactory<AccountSecurityTicketsDomainFactories>, IDomainObject<AccountSecurityTicketsDomainFactories>
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTypeEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTypeEntity" /> with the given ID, or null if none existed.</returns>
	IAccountSecurityTypeEntity Get(short id);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTypeEntity" /> with the given value
	/// </summary>
	/// <param name="value">The value.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="value" /> is null.</exception>
	/// <returns>The <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTypeEntity" /> with the given the value</returns>
	IAccountSecurityTypeEntity GetByValue(string value);
}
