using System;

namespace Roblox.Data;

/// <summary>
/// SecurityNotary is responsible for signing strings using our private key
/// </summary>
[Obsolete("Please contact core team before using this class", false)]
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

	public static string CreateSignature(string message)
	{
		return SharedSecurityNotary.CreateSignature(message, _Blob);
	}

	public static string SignScript(string script, SharedSecurityNotary.FormatVersion version = SharedSecurityNotary.FormatVersion.V1)
	{
		return SharedSecurityNotary.SignScript(script, _Blob, version);
	}
}
