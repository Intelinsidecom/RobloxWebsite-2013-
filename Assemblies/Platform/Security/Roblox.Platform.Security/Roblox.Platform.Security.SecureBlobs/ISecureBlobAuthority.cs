using System;

namespace Roblox.Platform.Security.SecureBlobs;

/// <summary>
/// An authority used to create secure blobs of models that can be passed to consumers, and passed back unchanged and validated.
/// </summary>
public interface ISecureBlobAuthority<TModel>
{
	/// <summary>
	/// Generates a Base64 encoded blob of a model with validation hash
	/// </summary>
	/// <param name="model">The model to create the blob from.</param>
	/// <param name="expiration">When the blob becomes invalid. If <c>null</c> no expiration.</param>
	/// <returns>An expirable secure blob string.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="model" /> is null.</exception>
	string GenerateSecureBlob(TModel model, TimeSpan? expiration = null);

	/// <summary>
	/// Gets a model from a secure blob as long as the blob is not expired, and valid.
	/// </summary>
	/// <param name="secureBlob">Gets a <typeparamref name="TModel" /> from a secure blob.</param>
	/// <returns><typeparamref name="TModel" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="secureBlob" /> is null or empty.</exception>
	/// <exception cref="T:System.FormatException"><paramref name="secureBlob" /> is not in a valid format.</exception>
	/// <exception cref="T:Roblox.Platform.Security.SecureBlobs.SecureBlobExpiredException">The secure blob is in a valid format but is expired.</exception>
	TModel GetModelFromSecureBlob(string secureBlob);

	/// <summary>
	/// Generates a Base64 encoded blob of a model with validation hash
	/// </summary>
	/// <param name="model">The model to create the blob from.</param>
	/// <param name="encryptionKey">Encryption key to be used by SecurityNotary</param>
	/// <param name="expiration">When the blob becomes invalid. If <c>null</c> no expiration.</param>
	/// <returns>An expirable secure blob string.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="model" /> is null.</exception>
	string GenerateSecureBlob(TModel model, EncryptionKey encryptionKey, TimeSpan? expiration = null);

	/// <summary>
	/// Gets a model from a secure blob as long as the blob is not expired, and valid.
	/// </summary>
	/// <param name="secureBlob">Gets a <typeparamref name="TModel" /> from a secure blob.</param>
	/// <param name="encryptionKey">Encryption key to be used by SecurityNotary</param>
	/// <returns><typeparamref name="TModel" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="secureBlob" /> is null or empty.</exception>
	/// <exception cref="T:System.FormatException"><paramref name="secureBlob" /> is not in a valid format.</exception>
	/// <exception cref="T:Roblox.Platform.Security.SecureBlobs.SecureBlobExpiredException">The secure blob is in a valid format but is expired.</exception>
	TModel GetModelFromSecureBlob(string secureBlob, EncryptionKey[] encryptionKeys);
}
