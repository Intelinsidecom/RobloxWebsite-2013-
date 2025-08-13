namespace Roblox.Entities.Mssql;

public static class DictionaryDeserializerCache<T> where T : class, new()
{
	public static readonly DictionaryDeserializer<T> Default = new DictionaryDeserializer<T>();
}
