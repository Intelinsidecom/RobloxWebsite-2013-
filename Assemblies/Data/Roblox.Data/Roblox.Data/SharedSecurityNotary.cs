using System;
using System.Security.Cryptography;
using System.Text;
using Roblox.EventLog;

namespace Roblox.Data;

/// <summary>
/// SharedSecurityNotary does the actual signing of scripts, but does not load the private key
/// </summary>
public static class SharedSecurityNotary
{
	public enum FormatVersion
	{
		V1 = 1,
		V2,
		V3,
		V4
	}

	public static string CreateSignature(string message, byte[] blob)
	{
		CspParameters parameters = new CspParameters
		{
			Flags = CspProviderFlags.UseMachineKeyStore
		};
		byte[] asciiMessage = Encoding.ASCII.GetBytes(message);
		RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(parameters);
		byte[] signature;
		try
		{
			rsaCryptoServiceProvider.ImportCspBlob(blob);
			SHA1CryptoServiceProvider sha1CryptoServiceProvider = new SHA1CryptoServiceProvider();
			try
			{
				byte[] hash = ((HashAlgorithm)(object)sha1CryptoServiceProvider).ComputeHash(asciiMessage);
				signature = rsaCryptoServiceProvider.SignHash(hash, null);
			}
			finally
			{
				((IDisposable)(object)sha1CryptoServiceProvider)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)(object)rsaCryptoServiceProvider)?.Dispose();
		}
		return Convert.ToBase64String(signature);
	}

	public static string SignScript(string script, byte[] blob, FormatVersion version = FormatVersion.V1)
	{
		string signature;
		switch (version)
		{
		case FormatVersion.V4:
			script = "\r\n" + script;
			signature = CreateSignature(script, blob);
			return $"--rbxsig4%{signature}%{script}";
		case FormatVersion.V3:
			script = "\r\n" + script;
			signature = CreateSignature(script, blob);
			return $"--rbxsig2%{signature}%{script}";
		case FormatVersion.V2:
			script = "\r\n" + script;
			signature = CreateSignature(script, blob);
			return $"--rbxsig%{signature}%{script}";
		default:
			StaticLoggerRegistry.Instance.Error("Unimplemented signature format in SharedSecurityNotary.cs, defaulting to V1");
			break;
		case FormatVersion.V1:
			break;
		}
		signature = CreateSignature(script, blob);
		return $"%{signature}%{script}";
	}
}
