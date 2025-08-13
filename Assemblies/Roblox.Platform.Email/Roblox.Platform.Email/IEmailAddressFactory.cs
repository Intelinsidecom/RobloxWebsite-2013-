namespace Roblox.Platform.Email;

/// <summary>
/// Interface for factories producing <see cref="T:Roblox.Platform.Email.IEmailAddress" />es
/// </summary>
public interface IEmailAddressFactory
{
	/// <summary>
	/// Returns the <see cref="T:Roblox.Platform.Email.IEmailAddress" /> with the provided id, or null if it doesn't exist.
	/// </summary>
	///             <exception cref="T:System.OverflowException"><paramref name="id" /> cannot be cast to the data type used by the underlying data storage. </exception>
	IEmailAddress GetById(int id);

	/// <summary>
	/// Returns an <see cref="T:Roblox.Platform.Email.IEmailAddress" /> with the email address, or null if it doesn't exist.
	/// </summary>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="emailAddress" /> is null.</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="emailAddress" /> is the empty string.</exception>
	IEmailAddress GetByEmailAddress(string emailAddress);

	/// <summary>
	/// Returns an <see cref="T:Roblox.Platform.Email.IEmailAddress" /> with the email address, creating one if one didn't exist.
	/// </summary>
	/// <remarks>This method does not perform email address validation.  The argument should be validated before calling this method.</remarks>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="emailAddress" /> is null.</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="emailAddress" /> is the empty string.</exception>
	IEmailAddress GetOrCreateByEmailAddress(string emailAddress);
}
