using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Roblox.CachingV2.Core;

public class BinaryFormattedSerializer : ISerializer
{
	public T Deserialize<T>(byte[] bytes)
	{
		NullChecker.ThrowIfNull(bytes, "bytes");
		object obj;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			memoryStream.Write(bytes, 0, bytes.Length);
			memoryStream.Position = 0L;
			obj = new BinaryFormatter().Deserialize(memoryStream);
		}
		try
		{
			return (T)obj;
		}
		catch (InvalidCastException innerException)
		{
			throw new SerializationException($"Could not convert type {obj.GetType().Name} to {typeof(T).Name}.", innerException);
		}
	}

	public byte[] Serialize<T>(T value)
	{
		using MemoryStream memoryStream = new MemoryStream();
		try
		{
			new BinaryFormatter().Serialize(memoryStream, value);
		}
		catch (Exception innerException)
		{
			throw new SerializationException($"BinaryFormatter failed to serialize type {typeof(T).Name}.", innerException);
		}
		return memoryStream.ToArray();
	}
}
