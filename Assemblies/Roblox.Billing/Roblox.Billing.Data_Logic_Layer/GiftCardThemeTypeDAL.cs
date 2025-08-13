using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing.Data_Logic_Layer;

public class GiftCardThemeTypeDAL
{
	private byte _ID;

	public string Name;

	public DateTime Created;

	public DateTime Updated;

	public byte ID
	{
		get
		{
			return _ID;
		}
		set
		{
			_ID = value;
		}
	}

	private static string dbConnectionString_GiftCardThemeTypeDAL => Settings.Default.BillingConnectionString;

	private static GiftCardThemeTypeDAL BuildDAL(SqlDataReader reader)
	{
		GiftCardThemeTypeDAL dal = new GiftCardThemeTypeDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Name = (string)reader["Name"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(dbConnectionString_GiftCardThemeTypeDAL, "GiftCardThemeTypes_InsertGiftCardThemeType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_GiftCardThemeTypeDAL, "GiftCardThemeTypes_UpdateGiftCardThemeTypeByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_GiftCardThemeTypeDAL, "GiftCardThemeTypes_DeleteGiftCardThemeTypeByID", queryParameters));
	}

	public static GiftCardThemeTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_GiftCardThemeTypeDAL, "GiftCardThemeTypes_GetGiftCardThemeTypeByID", queryParameters), BuildDAL);
	}

	public static GiftCardThemeTypeDAL GetByName(string name)
	{
		if (name == null)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", name));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_GiftCardThemeTypeDAL, "GiftCardThemeTypes_GetGiftCardThemeTypeByName", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<GiftCardThemeTypeDAL> GetOrCreateByName(string name)
	{
		if (name == null)
		{
			throw new ApplicationException("Required value not specified: Name.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", name));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(dbConnectionString_GiftCardThemeTypeDAL, "[dbo].[GiftCardThemeTypes_GetOrCreateGiftCardThemeTypeByName]", queryParameters), BuildDAL);
	}
}
