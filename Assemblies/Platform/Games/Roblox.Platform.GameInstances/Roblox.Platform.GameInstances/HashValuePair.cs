namespace Roblox.Platform.GameInstances;

/// <summary>
/// Calculate and store the MD5 hash value for an object in advance to avoid expensive calculation.
/// </summary>
/// <typeparam name="T"></typeparam>
public class HashValuePair<T>
{
	private readonly T _Value;

	private readonly string _HashCode;

	public HashValuePair(T value, string hashCode)
	{
		_Value = value;
		_HashCode = hashCode;
	}

	public void GetValueWithHashCode(out T value, out string hashCode)
	{
		value = _Value;
		hashCode = _HashCode;
	}
}
