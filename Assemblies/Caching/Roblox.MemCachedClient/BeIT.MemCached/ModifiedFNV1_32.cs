using System;

namespace BeIT.MemCached;

internal class ModifiedFNV1_32 : FNV1_32
{
	protected override byte[] HashFinal()
	{
		hash += hash << 13;
		hash ^= hash >> 7;
		hash += hash << 3;
		hash ^= hash >> 17;
		hash += hash << 5;
		return BitConverter.GetBytes(hash);
	}
}
