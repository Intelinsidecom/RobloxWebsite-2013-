using System.IO;
using Roblox.Common.NetStandard;

namespace Roblox;

public static class HashFunctions
{
	public static string HashToString(byte[] rawHash)
	{
		return Roblox.Common.NetStandard.HashFunctions.HashToString(rawHash);
	}

	public static byte[] ComputeHash(Stream buffer)
	{
		return Roblox.Common.NetStandard.HashFunctions.ComputeHash(buffer);
	}

	public static byte[] ComputeHash(byte[] data)
	{
		return Roblox.Common.NetStandard.HashFunctions.ComputeHash(data);
	}

	public static string ComputeHashString(byte[] data)
	{
		return HashToString(ComputeHash(data));
	}

	public static string ComputeHashString(Stream buffer)
	{
		return HashToString(ComputeHash(buffer));
	}

	public static string ComputeMd5HashString(string input)
	{
		return Roblox.Common.NetStandard.HashFunctions.ComputeMd5HashString(input);
	}
}
