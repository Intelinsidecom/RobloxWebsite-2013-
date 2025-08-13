namespace Roblox.Data;

public interface IDBHelperFactory
{
	DbHelper GetDBHelper(string connectionString);
}
