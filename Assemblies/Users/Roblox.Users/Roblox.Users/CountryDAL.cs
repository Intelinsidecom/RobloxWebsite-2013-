using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Users;

public class CountryDAL
{
	private byte _ID;

	public string Value;

	public string Code;

	public bool Active;

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

	private static string dbConnectionString_CountryDAL => RobloxDatabase.RobloxUsers.GetConnectionString();

	private static CountryDAL BuildDAL(SqlDataReader reader)
	{
		CountryDAL dal = new CountryDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.Value = (string)reader["Value"];
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
		queryParameters.Add(new SqlParameter("@Code", Code));
		queryParameters.Add(new SqlParameter("@Active", Active));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(dbConnectionString_CountryDAL, "Countries_InsertCountry", new SqlParameter("@ID", SqlDbType.TinyInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@Code", Code));
		queryParameters.Add(new SqlParameter("@Active", Active));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_CountryDAL, "Countries_UpdateCountryByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_CountryDAL, "Countries_DeleteCountryByID", queryParameters));
	}

	public static CountryDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_CountryDAL, "Countries_GetCountryByID", queryParameters), BuildDAL);
	}

	public static ICollection<byte> GetCountriesByID_Paged(int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(dbConnectionString_CountryDAL, "dbo.Countries_GetCountryIDs_Paged", queryParameters));
	}

	public static CountryDAL GetByCode(string code)
	{
		if (string.IsNullOrEmpty(code))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@Code", code)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_CountryDAL, "Countries_GetCountryByCode", queryParameters), BuildDAL);
	}

	public static ICollection<byte> GetActiveCountryIDs_Paged(int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(dbConnectionString_CountryDAL, "dbo.Countries_GetActiveCountryIDs_Paged", queryParameters));
	}
}
