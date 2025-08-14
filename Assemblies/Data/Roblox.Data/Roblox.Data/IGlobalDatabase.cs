namespace Roblox.Data
{
    public interface IGlobalDatabase
    {
        DatabaseType DbType { get; }
        string ConnectionString { get; }
    }

    public enum DatabaseType
    {
        Mssql,
        Sqlite,
        MySql
    }
}
