using System;
using System.Security.Cryptography;
using System.Text;

namespace Roblox.Redis;

public static class LuaScriptHasher
{
	public static byte[] GetScriptHash(string script)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		SHA1Managed val = new SHA1Managed();
		try
		{
			byte[] bytes = Encoding.UTF8.GetBytes(script);
			return ((HashAlgorithm)(object)val).ComputeHash(bytes);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
