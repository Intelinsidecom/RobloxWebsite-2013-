using System;

namespace Roblox.Common;

public struct ShortGuid : IEquatable<ShortGuid>
{
	public static readonly ShortGuid Empty = new ShortGuid(Guid.Empty);

	public Guid Guid { get; }

	public string Value { get; }

	public ShortGuid(string value)
	{
		Value = value;
		Guid = Decode(value);
	}

	public ShortGuid(Guid guid)
	{
		Value = Encode(guid);
		Guid = guid;
	}

	public override int GetHashCode()
	{
		return (Guid.GetHashCode() * 397) ^ ((Value != null) ? Value.GetHashCode() : 0);
	}

	public override string ToString()
	{
		return Value;
	}

	public static Guid Decode(string value)
	{
		value = value.Replace("_", "/").Replace("-", "+");
		return new Guid(Convert.FromBase64String(value + "=="));
	}

	public static bool TryParse(string value, out ShortGuid shortGuid)
	{
		try
		{
			Guid guid = Decode(value);
			shortGuid = new ShortGuid(guid);
			return true;
		}
		catch (Exception)
		{
			shortGuid = new ShortGuid(Guid.Empty);
			return false;
		}
	}

	public static string Encode(string value)
	{
		return Encode(new Guid(value));
	}

	public static string Encode(Guid guid)
	{
		return Convert.ToBase64String(guid.ToByteArray()).Replace("/", "_").Replace("+", "-")
			.Substring(0, 22);
	}

	public static ShortGuid NewGuid()
	{
		return new ShortGuid(Guid.NewGuid());
	}

	public static implicit operator string(ShortGuid shortGuid)
	{
		return shortGuid.Value;
	}

	public static implicit operator Guid(ShortGuid shortGuid)
	{
		return shortGuid.Guid;
	}

	public static implicit operator ShortGuid(string shortGuid)
	{
		return new ShortGuid(shortGuid);
	}

	public static implicit operator ShortGuid(Guid guid)
	{
		return new ShortGuid(guid);
	}

	public override bool Equals(object obj)
	{
		if (obj is ShortGuid)
		{
			return Equals((ShortGuid)obj);
		}
		return false;
	}

	public bool Equals(ShortGuid shortGuid)
	{
		return Guid.Equals(shortGuid.Guid);
	}
}
