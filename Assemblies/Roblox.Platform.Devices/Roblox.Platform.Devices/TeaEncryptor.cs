using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Devices;

internal static class TeaEncryptor
{
	internal static ulong TeaEncrypt(ulong inTag, string privateKey)
	{
		if (string.IsNullOrEmpty(privateKey))
		{
			throw new PlatformArgumentException(string.Format("{0} argument is null or empty", "privateKey"));
		}
		uint v0 = (uint)(inTag & 0xFFFFFFFFu);
		uint v1 = (uint)(inTag >> 32);
		uint delta = 3523417902u;
		uint k0 = Convert.ToUInt32(privateKey.Substring(0, 10), 16);
		uint k1 = Convert.ToUInt32(privateKey.Substring(10, 10), 16);
		uint k2 = Convert.ToUInt32(privateKey.Substring(20, 10), 16);
		uint k3 = Convert.ToUInt32(privateKey.Substring(30, 10), 16);
		uint sum = 0u;
		for (int i = 0; i < 32; i++)
		{
			sum += delta;
			v0 += ((v1 << 9) + k0) ^ (v1 + sum) ^ ((v1 >> 5) + k1);
			v1 += ((v0 << 9) + k2) ^ (v0 + sum) ^ ((v0 >> 5) + k3);
		}
		return ((ulong)v1 << 32) | v0;
	}

	internal static ulong TeaDecrypt(ulong inTag, string privateKey)
	{
		if (string.IsNullOrEmpty(privateKey))
		{
			throw new PlatformArgumentException(string.Format("{0} argument is null or empty", "privateKey"));
		}
		uint v0 = (uint)(inTag & 0xFFFFFFFFu);
		uint v1 = (uint)(inTag >> 32);
		uint delta = 3523417902u;
		uint k0 = Convert.ToUInt32(privateKey.Substring(0, 10), 16);
		uint k1 = Convert.ToUInt32(privateKey.Substring(10, 10), 16);
		uint k2 = Convert.ToUInt32(privateKey.Substring(20, 10), 16);
		uint k3 = Convert.ToUInt32(privateKey.Substring(30, 10), 16);
		uint sum = 1080223168u;
		for (int i = 0; i < 32; i++)
		{
			v1 -= ((v0 << 9) + k2) ^ (v0 + sum) ^ ((v0 >> 5) + k3);
			v0 -= ((v1 << 9) + k0) ^ (v1 + sum) ^ ((v1 >> 5) + k1);
			sum -= delta;
		}
		return ((ulong)v1 << 32) | v0;
	}
}
