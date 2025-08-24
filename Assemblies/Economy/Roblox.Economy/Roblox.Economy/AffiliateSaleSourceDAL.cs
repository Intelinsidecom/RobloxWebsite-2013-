using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

public class AffiliateSaleSourceDAL
{
	private long _ID;

	public byte SourceTypeID;

	public long SourceID;

	public DateTime Created = DateTime.MinValue;

	public DateTime Updated = DateTime.MinValue;

	public long ID
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

	private static string dbConnectionString_AffiliateSaleSourceDAL => Helper.DBConnectionString;

	private static AffiliateSaleSourceDAL BuildDAL(SqlDataReader reader)
	{
		AffiliateSaleSourceDAL dal = new AffiliateSaleSourceDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.SourceTypeID = (byte)reader["SourceTypeID"];
			dal.SourceID = (long)reader["SourceID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		if (SourceTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: SourceTypeID.");
		}
		if (SourceID == 0L)
		{
			throw new ApplicationException("Required value not specified: SourceID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SourceTypeID", SourceTypeID));
		queryParameters.Add(new SqlParameter("@SourceID", SourceID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_AffiliateSaleSourceDAL, "AffiliateSaleSources_InsertAffiliateSaleSource", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (SourceTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: SourceTypeID.");
		}
		if (SourceID == 0L)
		{
			throw new ApplicationException("Required value not specified: SourceID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@SourceTypeID", SourceTypeID));
		queryParameters.Add(new SqlParameter("@SourceID", SourceID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_AffiliateSaleSourceDAL, "AffiliateSaleSources_UpdateAffiliateSaleSourceByID", queryParameters));
	}

	public void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_AffiliateSaleSourceDAL, "AffiliateSaleSources_DeleteAffiliateSaleSourceByID", queryParameters));
	}

	public static AffiliateSaleSourceDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_AffiliateSaleSourceDAL, "AffiliateSaleSources_GetAffiliateSaleSourceByID", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<AffiliateSaleSourceDAL> GetOrCreate(long sourceId, byte sourceTypeId)
	{
		if (sourceId == 0L)
		{
			throw new ApplicationException("Required value not specified: sourceID.");
		}
		if (sourceTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: sourceTypeID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SourceID", sourceId));
		queryParameters.Add(new SqlParameter("@SourceTypeID", sourceTypeId));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(dbConnectionString_AffiliateSaleSourceDAL, "AffiliateSaleSources_GetOrCreateAffiliateSaleSourceBySourceIDAndSourceTypeID", queryParameters), BuildDAL);
	}
}
