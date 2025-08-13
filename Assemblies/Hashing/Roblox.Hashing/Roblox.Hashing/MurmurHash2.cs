using System.Runtime.InteropServices;

namespace Roblox.Hashing;

public class MurmurHash2
{
	[StructLayout(LayoutKind.Explicit)]
	private struct BytetoUInt32Converter
	{
		[FieldOffset(0)]
		public byte[] Bytes;

		[FieldOffset(0)]
		public uint[] UInts;
	}

	private const uint m = 1540483477u;

	private const int r = 24;

	public static uint Hash(byte[] data)
	{
		return Hash(data, 3314489979u);
	}

	public static uint Hash(byte[] data, uint seed)
	{
		int num = data.Length;
		if (num == 0)
		{
			return 0u;
		}
		uint num2 = seed ^ (uint)num;
		int num3 = 0;
		BytetoUInt32Converter bytetoUInt32Converter = default(BytetoUInt32Converter);
		bytetoUInt32Converter.Bytes = data;
		uint[] uInts = bytetoUInt32Converter.UInts;
		while (num >= 4)
		{
			uint num4 = uInts[num3++];
			num4 *= 1540483477;
			num4 ^= num4 >> 24;
			num4 *= 1540483477;
			num2 *= 1540483477;
			num2 ^= num4;
			num -= 4;
		}
		num3 *= 4;
		switch (num)
		{
		case 3:
			num2 ^= (ushort)(data[num3++] | (data[num3++] << 8));
			num2 ^= (uint)(data[num3] << 16);
			num2 *= 1540483477;
			break;
		case 2:
			num2 ^= (ushort)(data[num3++] | (data[num3] << 8));
			num2 *= 1540483477;
			break;
		case 1:
			num2 ^= data[num3];
			num2 *= 1540483477;
			break;
		}
		num2 ^= num2 >> 13;
		num2 *= 1540483477;
		return num2 ^ (num2 >> 15);
	}
}
