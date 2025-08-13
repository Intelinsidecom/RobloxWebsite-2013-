using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class AssetAwardListDAL
{
	private int _ID;

	public byte MerchantID;

	public DateTime ActivationDate;

	public DateTime Created;

	public DateTime Updated;

	public int ID
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

	private static string dbConnectionString_AssetAwardListDAL => Settings.Default.BillingConnectionString;

	private static AssetAwardListDAL BuildDAL(SqlDataReader reader)
	{
		AssetAwardListDAL dal = new AssetAwardListDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.MerchantID = (byte)reader["MerchantID"];
			dal.ActivationDate = (DateTime)reader["ActivationDate"];
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
		queryParameters.Add(new SqlParameter("@MerchantID", MerchantID));
		queryParameters.Add(new SqlParameter("@ActivationDate", ActivationDate));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_AssetAwardListDAL, "AssetAwardLists_InsertAssetAwardList", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@MerchantID", MerchantID));
		queryParameters.Add(new SqlParameter("@ActivationDate", ActivationDate));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_AssetAwardListDAL, "AssetAwardLists_UpdateAssetAwardListByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_AssetAwardListDAL, "AssetAwardLists_DeleteAssetAwardListByID", queryParameters));
	}

	public static AssetAwardListDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_AssetAwardListDAL, "AssetAwardLists_GetAssetAwardListByID", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetAssetAwardListIDsByMerchantID(byte MerchantID)
	{
		if (MerchantID == 0)
		{
			throw new ApplicationException("Required value not specified: MerchantID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MerchantID", MerchantID));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_AssetAwardListDAL, "AssetAwardLists_GetAssetAwardListIDsByMerchantID", queryParameters));
	}

	public static ICollection<int> GetAssetAwardListIDsByMerchantIDActivationDateAfter(byte MerchantID, DateTime ActivationDate)
	{
		if (MerchantID == 0)
		{
			throw new ApplicationException("Required value not specified: MerchantID.");
		}
		if (ActivationDate == default(DateTime))
		{
			throw new ApplicationException("Required value not specified: ActivationDate.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MerchantID", MerchantID));
		queryParameters.Add(new SqlParameter("@ActivationDate", ActivationDate));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_AssetAwardListDAL, "AssetAwardLists_GetAssetAwardListIDsByMerchantIDActivationDateAfter", queryParameters));
	}

	public static ICollection<int> GetAssetAwardListIDsByMerchantIDActivationDateBefore(byte MerchantID, DateTime ActivationDate)
	{
		if (MerchantID == 0)
		{
			throw new ApplicationException("Required value not specified: MerchantID.");
		}
		if (ActivationDate == default(DateTime))
		{
			throw new ApplicationException("Required value not specified: ActivationDate.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MerchantID", MerchantID));
		queryParameters.Add(new SqlParameter("@ActivationDate", ActivationDate));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_AssetAwardListDAL, "AssetAwardLists_GetAssetAwardListIDsByMerchantIDActivationDateBefore", queryParameters));
	}
}
