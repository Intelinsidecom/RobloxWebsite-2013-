using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing.Data_Logic_Layer;

public class InCommCardProductDAL
{
	private short _ID;

	public short InCommCardID;

	public byte AccountAddonTypeID;

	public int ProductID;

	public bool AccountAddonIsRenewal;

	public DateTime Created;

	public DateTime Updated;

	public short ID
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

	private static string dbConnectionString_InCommCardProductDAL => Settings.Default.BillingConnectionString;

	private static InCommCardProductDAL BuildDAL(SqlDataReader reader)
	{
		InCommCardProductDAL dal = new InCommCardProductDAL();
		while (reader.Read())
		{
			dal.ID = (short)reader["ID"];
			dal.InCommCardID = (short)reader["InCommCardID"];
			dal.AccountAddonTypeID = (byte)reader["AccountAddonTypeID"];
			dal.ProductID = (int)reader["ProductID"];
			dal.AccountAddonIsRenewal = (bool)reader["AccountAddonIsRenewal"];
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
		queryParameters.Add(new SqlParameter("@InCommCardID", InCommCardID));
		queryParameters.Add(new SqlParameter("@AccountAddonTypeID", AccountAddonTypeID));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@AccountAddonIsRenewal", AccountAddonIsRenewal));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<short>(new DbInfo(dbConnectionString_InCommCardProductDAL, "InCommCardProducts_InsertInCommCardProduct", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@InCommCardID", InCommCardID));
		queryParameters.Add(new SqlParameter("@AccountAddonTypeID", AccountAddonTypeID));
		queryParameters.Add(new SqlParameter("@ProductID", ProductID));
		queryParameters.Add(new SqlParameter("@AccountAddonIsRenewal", AccountAddonIsRenewal));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_InCommCardProductDAL, "InCommCardProducts_UpdateInCommCardProductByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_InCommCardProductDAL, "InCommCardProducts_DeleteInCommCardProductByID", queryParameters));
	}

	public static InCommCardProductDAL Get(short id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_InCommCardProductDAL, "InCommCardProducts_GetInCommCardProductByID", queryParameters), BuildDAL);
	}

	public static ICollection<short> GetInCommCardProductIDsByInCommCardID(short InCommCardID)
	{
		if (InCommCardID == 0)
		{
			throw new ApplicationException("Required value not specified: InCommCardID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@InCommCardID", InCommCardID));
		return EntityHelper.GetDataEntityIDCollection<short>(new DbInfo(dbConnectionString_InCommCardProductDAL, "InCommCardProducts_GetInCommCardProductIDsByInCommCardID", queryParameters));
	}
}
