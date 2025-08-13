using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

public class AffiliateSaleSourceTypeDAL
{
	private byte _ID;

	public string Name;

	public DateTime Created = DateTime.MinValue;

	public DateTime Updated = DateTime.MinValue;

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

	private static string dbConnectionString_AffiliateSaleSourceTypeDAL => Helper.DBConnectionString;

	private static AffiliateSaleSourceTypeDAL BuildDAL(SqlDataReader reader)
	{
		AffiliateSaleSourceTypeDAL dal = new AffiliateSaleSourceTypeDAL();
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
		if (Name.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Name.");
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
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(dbConnectionString_AffiliateSaleSourceTypeDAL, "AffiliateSaleSourceTypes_InsertAffiliateSaleSourceType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (Name.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Name.");
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
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_AffiliateSaleSourceTypeDAL, "AffiliateSaleSourceTypes_UpdateAffiliateSaleSourceTypeByID", queryParameters));
	}

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_AffiliateSaleSourceTypeDAL, "AffiliateSaleSourceTypes_DeleteAffiliateSaleSourceTypeByID", queryParameters));
	}

	public static AffiliateSaleSourceTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_AffiliateSaleSourceTypeDAL, "AffiliateSaleSourceTypes_GetAffiliateSaleSourceTypeByID", queryParameters), BuildDAL);
	}

	public static AffiliateSaleSourceTypeDAL Get(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", name));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[AffiliateSaleSourceTypes_GetAffiliateSaleSourceTypeByName]", queryParameters), BuildDAL);
	}
}
