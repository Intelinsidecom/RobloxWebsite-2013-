namespace Roblox.Platform.Email;

/// <summary>
/// Deletes email entities from the system. Intended for use only with CS tools and the purge processor.
/// </summary>
public interface IEmailAddressDeleter
{
	/// <summary>
	/// Deletes the email address entity with the given id
	/// </summary>
	/// <param name="emailAddressId"></param>
	void Delete(int emailAddressId);
}
