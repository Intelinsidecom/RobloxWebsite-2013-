using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class MerchantDAL
{
	private byte _ID;

	public string Name;

	public bool Active;

	internal bool IsHidden;

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

	private static string dbConnectionString_MerchantDAL => Settings.Default.BillingConnectionString;

	private static MerchantDAL BuildDAL(SqlDataReader reader)
	{
		MerchantDAL dal = new MerchantDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Name = (string)reader["Name"];
			dal.Active = (bool)reader["Active"];
			dal.IsHidden = (bool)reader["IsHidden"];
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
		queryParameters.Add(new SqlParameter("@Active", Active));
		queryParameters.Add(new SqlParameter("@IsHidden", IsHidden));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(dbConnectionString_MerchantDAL, "Merchants_InsertMerchant", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Active", Active));
		queryParameters.Add(new SqlParameter("@IsHidden", IsHidden));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_MerchantDAL, "Merchants_UpdateMerchantByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_MerchantDAL, "Merchants_DeleteMerchantByID", queryParameters));
	}

	public static MerchantDAL Get(string name)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", name));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_MerchantDAL, "[dbo].[Merchants_GetMerchantByName]", queryParameters), BuildDAL);
	}

	public static MerchantDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_MerchantDAL, "Merchants_GetMerchantByID", queryParameters), BuildDAL);
	}

	public static int GetTotalNumberOfMerchants()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(dbConnectionString_MerchantDAL, "Merchants_GetTotalNumberOfMerchants", queryParameters));
	}

	public static ICollection<byte> GetMerchantIDsPaged(int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(dbConnectionString_MerchantDAL, "Merchants_GetMerchantIDs_Paged", queryParameters));
	}
}
