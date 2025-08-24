using System;
using Newtonsoft.Json;

namespace Roblox.CachingV2.Core;

[Serializable]
public struct CacheVersionToken : IEquatable<CacheVersionToken>
{
	internal class CacheVersionTokenJsonConverter : JsonConverter
	{
		public static CacheVersionTokenJsonConverter Instance { get; } = new CacheVersionTokenJsonConverter();


		private CacheVersionTokenJsonConverter()
		{
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			serializer.Serialize(writer, ((CacheVersionToken)value)._Fence);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return new CacheVersionToken(serializer.Deserialize<Guid>(reader));
		}

		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(CacheVersionToken);
		}
	}

	private readonly Guid _Fence;

	public CacheVersionToken(Guid fence)
	{
		_Fence = fence;
	}

	public bool Equals(CacheVersionToken other)
	{
		return other._Fence == _Fence;
	}

	public override int GetHashCode()
	{
		Guid fence = _Fence;
		return fence.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (obj is CacheVersionToken)
		{
			return Equals((CacheVersionToken)obj);
		}
		return false;
	}

	public static bool operator ==(CacheVersionToken cvt1, CacheVersionToken cvt2)
	{
		return cvt1._Fence == cvt2._Fence;
	}

	public static bool operator !=(CacheVersionToken cvt1, CacheVersionToken cvt2)
	{
		return !(cvt1 == cvt2);
	}
}
