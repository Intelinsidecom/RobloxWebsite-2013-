using System;
using System.Data;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
internal class MachineConfigurations
{
	private static string ConnectionString => RobloxDatabase.Roblox.GetConnectionString();

	public static void Insert(long userId, string configuration)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@UserID", userId);
		dbHelper.SQLParameters.AddWithValue("@Configuration", configuration);
		dbHelper.ExecuteSQLNonQuery("[dbo].[MachineConfigurations_Insert]", CommandType.StoredProcedure);
	}
}
