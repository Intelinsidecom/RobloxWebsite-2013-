using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Users.DAL;

public class LanguageTypeDAL
{
	private short _ID;

	public string Value;

	public string NativeName;

	public string Code;

	public bool Active;

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

	private static string dbConnectionString_LanguageTypeDAL => RobloxDatabase.RobloxUsers.GetConnectionString();

	private static LanguageTypeDAL BuildDAL(SqlDataReader reader)
	{
		LanguageTypeDAL dal = new LanguageTypeDAL();
		while (reader.Read())
		{
			dal.ID = (short)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.NativeName = (string)reader["NativeName"];
			dal.Code = (string)reader["Code"];
			dal.Active = (bool)reader["Active"];
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
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@NativeName", NativeName));
		queryParameters.Add(new SqlParameter("@Code", Code));
		queryParameters.Add(new SqlParameter("@Active", Active));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<short>(new DbInfo(dbConnectionString_LanguageTypeDAL, "LanguageTypes_InsertLanguageType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@NativeName", NativeName));
		queryParameters.Add(new SqlParameter("@Code", Code));
		queryParameters.Add(new SqlParameter("@Active", Active));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_LanguageTypeDAL, "LanguageTypes_UpdateLanguageTypeByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_LanguageTypeDAL, "LanguageTypes_DeleteLanguageTypeByID", queryParameters));
	}

	public static LanguageTypeDAL Get(short id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_LanguageTypeDAL, "LanguageTypes_GetLanguageTypeByID", queryParameters), BuildDAL);
	}

	public static LanguageTypeDAL GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_LanguageTypeDAL, "LanguageTypes_GetLanguageTypeByValue", queryParameters), BuildDAL);
	}

	public static LanguageTypeDAL GetByCode(string code)
	{
		if (string.IsNullOrEmpty(code))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Code", code));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_LanguageTypeDAL, "LanguageTypes_GetLanguageTypeByCode", queryParameters), BuildDAL);
	}

	public static ICollection<short> GetActiveLanguageTypeIDs()
	{
		return EntityHelper.GetDataEntityIDCollection<short>(new DbInfo(dbConnectionString_LanguageTypeDAL, "LanguageTypes_GetActiveLanguageTypeIDs"));
	}
}
