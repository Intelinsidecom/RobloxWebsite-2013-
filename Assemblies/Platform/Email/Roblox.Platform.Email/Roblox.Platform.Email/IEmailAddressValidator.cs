namespace Roblox.Platform.Email;

/// <summary>
/// Represents an interface for validating an email address.
/// </summary>
public interface IEmailAddressValidator
{
	/// <summary>
	/// Gets regex to use for validating emails
	/// </summary>
	/// <returns>
	/// Regex for valid email
	/// </returns>
	string GetEmailRegex();

	/// <summary>
	/// Checks whether an email address is valid.
	/// </summary>
	/// <param name="emailAddress">The email address to test validity for.</param>
	/// <returns>
	/// True if the passed in email address is valid, false otherwise.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="emailAddress" /> is null.</exception>
	bool IsValidEmail(string emailAddress);

	/// <summary>
	/// Determines whether or not a given email address has a shady domain.
	/// </summary>
	/// <param name="emailAddress">The email address to check</param>
	/// <returns>True if the email address has a shady domain, false otherwise.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="emailAddress" /> is null.</exception>
	bool IsShadyProvider(string emailAddress);

	/// <summary>
	/// Determines whether or not a given email is blacklisted.
	/// We also check the email without periods. E.g., a.b@gmail.com is the same email as ab@gmail.com
	/// </summary>
	/// <param name="emailAddress">The email address to check</param>
	/// <returns>True if the email is blacklisted, false otherwise.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="emailAddress" /> is null.</exception>
	bool IsBlacklisted(string emailAddress);

	/// <summary>
	/// Determines if the domain of the e-mail address actually contains MX records or is resolvable in order to receive mail.
	/// </summary>
	/// <param name="emailAddress">The email address to validate.</param>
	/// <returns>True if the email domain is valid, false otherwise.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="emailAddress" /> is null.</exception>
	bool IsEmailDomainValid(string emailAddress);
}
