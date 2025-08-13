using System.Threading;
using System.Threading.Tasks;

namespace Roblox.Passwords.Client;

/// <summary>
/// Default interface for passwords client.
/// </summary>
public interface IPasswordsClient
{
	/// <summary>
	/// Set the password for the specified password owner.
	/// </summary>
	/// <param name="passwordOwner">The <see cref="T:Roblox.Passwords.Client.PasswordOwnerType" /></param>
	/// <param name="passwordOwnerId">The ID of the password owner.</param>
	/// <param name="password">The password.</param>
	/// <returns>The result of the operation.</returns>
	SetPasswordResult SetPassword(PasswordOwnerType passwordOwner, long passwordOwnerId, string password);

	/// <summary>
	/// Set the password for the specified password owner.
	/// </summary>
	/// <param name="passwordOwner">The <see cref="T:Roblox.Passwords.Client.PasswordOwnerType" /></param>
	/// <param name="passwordOwnerId">The ID of the password owner.</param>
	/// <param name="password">The password.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The result of the operation.</returns>
	Task<SetPasswordResult> SetPasswordAsync(PasswordOwnerType passwordOwner, long passwordOwnerId, string password, CancellationToken cancellationToken);

	/// <summary>
	/// Verify the password for the specified password owner.
	/// </summary>
	/// <param name="passwordOwner">The <see cref="T:Roblox.Passwords.Client.PasswordOwnerType" /></param>
	/// <param name="passwordOwnerId">The ID of the password owner.</param>
	/// <param name="password">The password.</param>
	/// <returns>The result of the operation.</returns>
	VerifyPasswordResult VerifyPassword(PasswordOwnerType passwordOwner, long passwordOwnerId, string password);

	/// <summary>
	/// Verify the password for the specified password owner.
	/// </summary>
	/// <param name="passwordOwner">The <see cref="T:Roblox.Passwords.Client.PasswordOwnerType" /></param>
	/// <param name="passwordOwnerId">The ID of the password owner.</param>
	/// <param name="password">The password.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The result of the operation.</returns>
	Task<VerifyPasswordResult> VerifyPasswordAsync(PasswordOwnerType passwordOwner, long passwordOwnerId, string password, CancellationToken cancellationToken);

	/// <summary>
	/// Get the password status for the specified password owner.
	/// </summary>
	/// <param name="passwordOwner">The <see cref="T:Roblox.Passwords.Client.PasswordOwnerType" /></param>
	/// <param name="passwordOwnerId">The ID of the password owner.</param>
	/// <returns>The result of the operation.</returns>
	PasswordStatusResult GetPasswordStatus(PasswordOwnerType passwordOwner, long passwordOwnerId);

	/// <summary>
	/// Verify the password for the specified password owner.
	/// </summary>
	/// <param name="passwordOwner">The <see cref="T:Roblox.Passwords.Client.PasswordOwnerType" /></param>
	/// <param name="passwordOwnerId">The ID of the password owner.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The result of the operation.</returns>
	Task<PasswordStatusResult> GetPasswordStatusAsync(PasswordOwnerType passwordOwner, long passwordOwnerId, CancellationToken cancellationToken);

	/// <summary>
	/// Set the password needing reset.
	/// </summary>
	/// <param name="passwordOwner">The <see cref="T:Roblox.Passwords.Client.PasswordOwnerType" /></param>
	/// <param name="passwordOwnerId">The ID of the password owner.</param>
	/// <param name="needsReset">Needs reset.</param>
	/// <returns>The result of the operation.</returns>
	SetPasswordResetRequiredResult SetPasswordResetRequired(PasswordOwnerType passwordOwner, long passwordOwnerId, bool needsReset);

	/// <summary>
	/// Set the password needing reset.
	/// </summary>
	/// <param name="passwordOwner">The <see cref="T:Roblox.Passwords.Client.PasswordOwnerType" /></param>
	/// <param name="passwordOwnerId">The ID of the password owner.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <param name="needsReset">Needs reset.</param>
	/// <returns>The result of the operation.</returns>
	Task<SetPasswordResetRequiredResult> SetPasswordResetRequiredAsync(PasswordOwnerType passwordOwner, long passwordOwnerId, bool needsReset, CancellationToken cancellationToken);
}
