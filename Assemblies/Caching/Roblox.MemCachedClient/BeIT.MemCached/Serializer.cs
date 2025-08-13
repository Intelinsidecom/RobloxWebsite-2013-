using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace BeIT.MemCached;

internal class Serializer
{
	internal static readonly byte[] Null = Array.Empty<byte>();

	private readonly MemcachedMonitor _MemcachedMonitor;

	public Serializer(MemcachedMonitor memcachedMonitor)
	{
		_MemcachedMonitor = memcachedMonitor ?? throw new ArgumentNullException("memcachedMonitor");
	}

	public byte[] Serialize<T>(T value, out SerializedType type, uint compressionThreshold)
	{
		byte[] array;
		T val;
		if (value as byte[] == Null || value == null)
		{
			array = Null;
			type = SerializedType.Null;
		}
		else if ((object)value is byte[] array2)
		{
			_MemcachedMonitor.SetValuesCompressedFraction.IncrementBase();
			array = array2;
			type = SerializedType.ByteArray;
			if (array.Length > compressionThreshold)
			{
				_MemcachedMonitor.SetValuesCompressedFraction.Increment();
				array = Compress(array);
				type = SerializedType.CompressedByteArray;
			}
		}
		else if ((object)value is string s)
		{
			_MemcachedMonitor.SetValuesCompressedFraction.IncrementBase();
			array = Encoding.UTF8.GetBytes(s);
			type = SerializedType.String;
			if (array.Length > compressionThreshold)
			{
				_MemcachedMonitor.SetValuesCompressedFraction.Increment();
				array = Compress(array);
				type = SerializedType.CompressedString;
			}
		}
		else if ((val = value) is DateTime)
		{
			array = BitConverter.GetBytes(((DateTime)(object)val).Ticks);
			type = SerializedType.Datetime;
		}
		else if ((val = value) is bool)
		{
			bool flag = (bool)(object)val;
			array = new byte[1] { (byte)(flag ? 1u : 0u) };
			type = SerializedType.Bool;
		}
		else if ((val = value) is byte)
		{
			byte b = (byte)(object)val;
			array = new byte[1] { b };
			type = SerializedType.Byte;
		}
		else if ((val = value) is short)
		{
			short value2 = (short)(object)val;
			array = BitConverter.GetBytes(value2);
			type = SerializedType.Short;
		}
		else if ((val = value) is ushort)
		{
			ushort value3 = (ushort)(object)val;
			array = BitConverter.GetBytes(value3);
			type = SerializedType.UShort;
		}
		else if ((val = value) is int)
		{
			int value4 = (int)(object)val;
			array = BitConverter.GetBytes(value4);
			type = SerializedType.Int;
		}
		else if ((val = value) is uint)
		{
			uint value5 = (uint)(object)val;
			array = BitConverter.GetBytes(value5);
			type = SerializedType.UInt;
		}
		else if ((val = value) is long)
		{
			long value6 = (long)(object)val;
			array = BitConverter.GetBytes(value6);
			type = SerializedType.Long;
		}
		else if ((val = value) is ulong)
		{
			ulong value7 = (ulong)(object)val;
			array = BitConverter.GetBytes(value7);
			type = SerializedType.ULong;
		}
		else if ((val = value) is float)
		{
			float value8 = (float)(object)val;
			array = BitConverter.GetBytes(value8);
			type = SerializedType.Float;
		}
		else if ((val = value) is double)
		{
			double value9 = (double)(object)val;
			array = BitConverter.GetBytes(value9);
			type = SerializedType.Double;
		}
		else
		{
			using MemoryStream memoryStream = new MemoryStream();
			new BinaryFormatter().Serialize(memoryStream, value);
			array = memoryStream.ToArray();
			type = SerializedType.Object;
			if (array.Length > compressionThreshold)
			{
				array = Compress(array);
				type = SerializedType.CompressedObject;
			}
		}
		return array;
	}

	public object DeSerialize(byte[] bytes, SerializedType type)
	{
		switch (type)
		{
		case SerializedType.String:
			_MemcachedMonitor.ReadValuesCompressedFraction.IncrementBase();
			return Encoding.UTF8.GetString(bytes);
		case SerializedType.Datetime:
			return new DateTime(BitConverter.ToInt64(bytes, 0));
		case SerializedType.Bool:
			return bytes[0] == 1;
		case SerializedType.Byte:
			return bytes[0];
		case SerializedType.Short:
			return BitConverter.ToInt16(bytes, 0);
		case SerializedType.UShort:
			return BitConverter.ToUInt16(bytes, 0);
		case SerializedType.Int:
			return BitConverter.ToInt32(bytes, 0);
		case SerializedType.UInt:
			return BitConverter.ToUInt32(bytes, 0);
		case SerializedType.Long:
			return BitConverter.ToInt64(bytes, 0);
		case SerializedType.ULong:
			return BitConverter.ToUInt64(bytes, 0);
		case SerializedType.Float:
			return BitConverter.ToSingle(bytes, 0);
		case SerializedType.Double:
			return BitConverter.ToDouble(bytes, 0);
		case SerializedType.Null:
			return Null;
		case SerializedType.Object:
		{
			_MemcachedMonitor.ReadValuesCompressedFraction.IncrementBase();
			using MemoryStream serializationStream = new MemoryStream(bytes);
			return new BinaryFormatter().Deserialize(serializationStream);
		}
		case SerializedType.CompressedByteArray:
			_MemcachedMonitor.ReadValuesCompressedFraction.Increment();
			return DeSerialize(Decompress(bytes), SerializedType.ByteArray);
		case SerializedType.CompressedString:
			_MemcachedMonitor.ReadValuesCompressedFraction.Increment();
			return DeSerialize(Decompress(bytes), SerializedType.String);
		case SerializedType.CompressedObject:
			_MemcachedMonitor.ReadValuesCompressedFraction.Increment();
			return DeSerialize(Decompress(bytes), SerializedType.Object);
		default:
			_MemcachedMonitor.ReadValuesCompressedFraction.IncrementBase();
			return bytes;
		}
	}

	private static byte[] Compress(byte[] bytes)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		using MemoryStream memoryStream = new MemoryStream();
		DeflateStream val = new DeflateStream((Stream)memoryStream, (CompressionMode)1, false);
		try
		{
			((Stream)(object)val).Write(bytes, 0, bytes.Length);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		memoryStream.Close();
		return memoryStream.ToArray();
	}

	private static byte[] Decompress(byte[] bytes)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		using MemoryStream memoryStream = new MemoryStream(bytes, writable: false);
		DeflateStream val = new DeflateStream((Stream)memoryStream, (CompressionMode)0, false);
		try
		{
			using MemoryStream memoryStream2 = new MemoryStream();
			byte[] array = new byte[bytes.Length];
			int count;
			while ((count = ((Stream)(object)val).Read(array, 0, array.Length)) != 0)
			{
				memoryStream2.Write(array, 0, count);
			}
			memoryStream2.Close();
			return memoryStream2.ToArray();
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
