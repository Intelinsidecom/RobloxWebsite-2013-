using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets.Entities;

internal class ContextTypeDAL
{
	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[ContextTypes_DeleteContextTypeByID]", queryParameters));
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		DbInfo dbInfo = new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[ContextTypes_InsertContextType]", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<byte>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[ContextTypes_UpdateContextTypeByID]", queryParameters));
	}

	private static ContextTypeDAL BuildDAL(SqlDataReader reader)
	{
		ContextTypeDAL dal = new ContextTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = reader["Value"] as string;
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static ContextTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[ContextTypes_GetContextTypeByID]", queryParameters), BuildDAL);
	}

	internal static ContextTypeDAL GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Settings.Default.DbConnectionString_RobloxAssetCreations, "[dbo].[ContextTypes_GetContextTypeByValue]", queryParameters), BuildDAL);
	}
}
