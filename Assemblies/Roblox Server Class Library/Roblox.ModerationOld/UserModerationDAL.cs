using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.ModerationOld;

internal class UserModerationDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxUsers.GetConnectionString();

	public static ICollection<int> FindUserIDsByNameIDEmailIPAddress(int? userId, string userName, string email, int? ipAddress)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@userID", userId.HasValue ? ((object)userId) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@userName", (!string.IsNullOrEmpty(userName)) ? ((IConvertible)userName.ToQuery()) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@email", (!string.IsNullOrEmpty(email)) ? ((IConvertible)email) : ((IConvertible)DBNull.Value));
		dbHelper.SQLParameters.AddWithValue("@ipAddress", ipAddress.HasValue ? ((object)ipAddress) : DBNull.Value);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[UserModeration_FindUserIDsByNameIDEmailIPAddress]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<int>(reader);
	}
}
