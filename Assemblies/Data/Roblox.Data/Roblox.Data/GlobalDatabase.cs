namespace Roblox.Data
{
    public abstract class GlobalDatabase<T> : IGlobalDatabase where T : GlobalDatabase<T>, new()
    {
        public abstract DatabaseType DbType { get; }
        public abstract string ConnectionString { get; }
    }
}
