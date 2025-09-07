namespace Roblox.Entities.Mssql;

internal static class SqlParameterSerializerCache<T>
{
	public static readonly SqlParameterSerializer<T> Default = new SqlParameterSerializer<T>();
}
