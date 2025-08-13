using System;
using Roblox.Data;
using Roblox.Platform.Security.Properties;

namespace Roblox.Platform.Security;

/// <summary>
/// This class is used to sign client join tickets and game join scripts.
/// The key used to sign depends on the encryption key argument passed in.
/// Work in progress. Please contact webcore team for more details.
/// </summary>
public class SecurityNotary
{
	private static readonly byte[] _Blob;

	private SecurityNotary()
	{
	}

	static SecurityNotary()
	{
		_Blob = Resources.RbxPrivate;
	}

	public static string CreateSignature(string message, EncryptionKey encryptionKey = EncryptionKey.Classic)
	{
		return SharedSecurityNotary.CreateSignature(message, GetKey(encryptionKey));
	}

	public static string SignScript(string script, SharedSecurityNotary.FormatVersion version = SharedSecurityNotary.FormatVersion.V1, EncryptionKey encryptionKey = EncryptionKey.Classic)
	{
		return SharedSecurityNotary.SignScript(script, GetKey(encryptionKey), version);
	}

	private static byte[] GetKey(EncryptionKey encryptionKey)
	{
		return encryptionKey switch
		{
			EncryptionKey.Classic => _Blob, 
			EncryptionKey.ClientSignatureKeyForRcc => Convert.FromBase64String(Keys.Default.ClientSignatureKeyForRccBase64), 
			EncryptionKey.ClientSignature => Convert.FromBase64String(Keys.Default.ClientSignatureKeyBase64), 
			EncryptionKey.ClientSignatureV2 => Convert.FromBase64String(Keys.Default.ClientSignatureKeyV2Base64), 
			EncryptionKey.GameJoinTicketSignature => Convert.FromBase64String(Keys.Default.GameJoinTicketSignatureBase64), 
			EncryptionKey.GameJoinTicketSignatureV2 => Convert.FromBase64String(Keys.Default.GameJoinTicketSignatureV2Base64), 
			EncryptionKey.PasswordReset => Convert.FromBase64String(Keys.Default.PasswordResetSignatureKeyBase64), 
			EncryptionKey.Signup => Convert.FromBase64String(Keys.Default.SignupKeyBase64), 
			_ => _Blob, 
		};
	}
}
