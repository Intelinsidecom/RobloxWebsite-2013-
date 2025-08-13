using System;
using System.Security.Cryptography;

namespace BeIT.MemCached;

internal class FNV1_32 : HashAlgorithm
{
	private static readonly uint FNV_prime = 16777619u;

	private static readonly uint offset_basis = 2166136261u;

	protected uint hash;

	public FNV1_32()
	{
		HashSizeValue = 32;
	}

	public override void Initialize()
	{
		hash = offset_basis;
	}

	protected override void HashCore(byte[] array, int ibStart, int cbSize)
	{
		int num = ibStart + cbSize;
		for (int i = ibStart; i < num; i++)
		{
			hash = (hash * FNV_prime) ^ array[i];
		}
	}

	protected override byte[] HashFinal()
	{
		return BitConverter.GetBytes(hash);
	}
}
