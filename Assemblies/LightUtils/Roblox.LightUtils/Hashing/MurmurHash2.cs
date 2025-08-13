using System.Runtime.InteropServices;

namespace Roblox.LightUtils
{
	public class MurmurHash2
	{
		public static uint Hash(byte[] data)
		{
			return Hash(data, 3314489979U);
		}
		public static uint Hash(byte[] data, uint seed)
		{
			var length = data.Length;
			if (length == 0)
			{
				return 0U;
			}
			var computedSeed = seed ^ (uint)length;
			int idx = 0;
			var uints = new BytetoUInt32Converter
			{
				Bytes = data
			}.UInts;
			while (length >= 4)
			{
				uint uintAtIndex = uints[idx++];
				uintAtIndex *= _M;
				uintAtIndex ^= uintAtIndex >> _R;
				uintAtIndex *= _M;
				computedSeed *= _M;
				computedSeed ^= uintAtIndex;
				length -= 4;
			}
			idx *= 4;
			switch (length)
			{
				case 1:
					computedSeed ^= data[idx];
					computedSeed *= _M;
					break;
				case 2:
					computedSeed ^= (ushort)(data[idx++] | data[idx] << 8);
					computedSeed *= _M;
					break;
				case 3:
					computedSeed ^= (ushort)(data[idx++] | data[idx++] << 8);
					computedSeed ^= (uint)data[idx] << 16;
					computedSeed *= _M;
					break;
			}
			computedSeed ^= computedSeed >> 13;
			computedSeed *= _M;
			return computedSeed ^ computedSeed >> 15;
		}

		private const uint _M = 1540483477U;
		private const int _R = 24;

		[StructLayout(LayoutKind.Explicit)]
		private struct BytetoUInt32Converter
		{
			[FieldOffset(0)]
			public byte[] Bytes;
			[FieldOffset(0)]
			public readonly uint[] UInts;
		}
	}
}
