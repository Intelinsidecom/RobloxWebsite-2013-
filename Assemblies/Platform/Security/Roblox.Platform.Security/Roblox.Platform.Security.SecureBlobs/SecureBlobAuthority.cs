using System;
using System.Text;
using Newtonsoft.Json;
using Roblox.Hashing;
using Roblox.Platform.Core;

namespace Roblox.Platform.Security.SecureBlobs;

/// <inheritdoc cref="T:Roblox.Platform.Security.SecureBlobs.ISecureBlobAuthority`1" />
public class SecureBlobAuthority<TModel> : ISecureBlobAuthority<TModel>
{
	private readonly Func<TModel, string> _GetBlobSecret;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Security.SecureBlobs.SecureBlobAuthority`1" />
	/// </summary>
	/// <example>
	/// new SecureBlobAuthority((model) =&gt; {
	///        // model = { userId = 123 };
	///        // Secret includes purpose of blob by prepending PasswordReset
	///        // Secret includes static information tied to a piece of the model that can be replicated, but won't mix with another model
	///        return $"PasswordReset_{getCreationTicks(model.userId)}";
	/// });
	/// </example>
	/// <param name="getBlobSecret">
	/// Gets a secret to add to every blob hash.
	/// This secret must be unique to every blob that's specific to the model, and the purpose of the blob.
	/// This is for security against two blobs with the same model, but a different purpose getting mixed.
	/// </param>
	public SecureBlobAuthority(Func<TModel, string> getBlobSecret)
	{
		_GetBlobSecret = getBlobSecret.AssignOrThrowIfNull("getBlobSecret");
	}

	[Obsolete]
	public string GenerateSecureBlob(TModel model, TimeSpan? expiration = null)
	{
		return GenerateSecureBlob(model, EncryptionKey.Classic, expiration);
	}

	[Obsolete]
	public TModel GetModelFromSecureBlob(string secureBlob)
	{
		return GetModelFromSecureBlob(secureBlob, new EncryptionKey[1]);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Security.SecureBlobs.ISecureBlobAuthority`1.GenerateSecureBlob(`0,System.Nullable{System.TimeSpan})" />
	public string GenerateSecureBlob(TModel model, EncryptionKey encryptionKey, TimeSpan? expiration = null)
	{
		if (model == null)
		{
			throw new PlatformArgumentNullException("model");
		}
		string json = JsonConvert.SerializeObject(model);
		long expirationTicks = GetExpirationTicksFromTimeSpan(expiration);
		string hash = GenerateSecureBlobHash(json, expirationTicks, _GetBlobSecret(model), encryptionKey);
		return Convert.ToBase64String(Encoding.UTF8.GetBytes($"{expirationTicks}\n{json}\n{hash}"));
	}

	/// <inheritdoc cref="M:Roblox.Platform.Security.SecureBlobs.ISecureBlobAuthority`1.GetModelFromSecureBlob(System.String)" />
	public TModel GetModelFromSecureBlob(string secureBlob, EncryptionKey[] encryptionKeys)
	{
		if (string.IsNullOrEmpty(secureBlob))
		{
			throw new PlatformArgumentNullException("secureBlob");
		}
		SecureBlobDataModel blobData;
		TModel model;
		try
		{
			blobData = GetBlobData(secureBlob);
			model = JsonConvert.DeserializeObject<TModel>(blobData.Json);
		}
		catch (Exception e)
		{
			throw new FormatException(e.Message, e);
		}
		if (model == null)
		{
			throw new FormatException("Failed to parse TModel.");
		}
		bool isValid = false;
		foreach (EncryptionKey key in encryptionKeys)
		{
			isValid = GenerateSecureBlobHash(blobData.Json, blobData.ExpirationTicks, _GetBlobSecret(model), key) == blobData.Hash;
			if (isValid)
			{
				break;
			}
		}
		if (!isValid)
		{
			throw new FormatException("Failed to validate blob hash.");
		}
		if (blobData.ExpirationTicks > 0 && blobData.ExpirationTicks < DateTime.Now.Ticks)
		{
			throw new SecureBlobExpiredException();
		}
		return model;
	}

	internal virtual long GetExpirationTicksFromTimeSpan(TimeSpan? expiration)
	{
		return ((expiration.HasValue && expiration.Value.Ticks > 0) ? new DateTime?(DateTime.Now + expiration.Value) : null)?.Ticks ?? 0;
	}

	private SecureBlobDataModel GetBlobData(string blob)
	{
		try
		{
			byte[] bytes = Convert.FromBase64String(blob);
			string[] splitTicket = Encoding.UTF8.GetString(bytes).Split('\n');
			if (!long.TryParse(splitTicket[0], out var expiration))
			{
				throw new FormatException();
			}
			return new SecureBlobDataModel
			{
				ExpirationTicks = expiration,
				Json = splitTicket[1],
				Hash = splitTicket[2]
			};
		}
		catch (Exception)
		{
			throw new FormatException();
		}
	}

	private string GenerateSecureBlobHash(string json, long expirationTicks, string secret, EncryptionKey encryptionKey)
	{
		StringBuilder secretBuilder = new StringBuilder($"Blob:{json}");
		secretBuilder.AppendLine($"Expiration:{expirationTicks}");
		secretBuilder.AppendLine(SHA256Hasher.BuildSHA256HashString($"Secret:{secret}"));
		return CreateBlobSignature(secretBuilder.ToString(), encryptionKey);
	}

	internal virtual string CreateBlobSignature(string blob, EncryptionKey encryptionKey)
	{
		return SecurityNotary.CreateSignature(blob, encryptionKey);
	}
}
