using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Demographics;

public class CountryDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxDemographics.GetConnectionString();

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal string Code { get; set; }

	internal bool IsActive { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "Countries_DeleteCountryByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Code", Code),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "Countries_InsertCountry", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Code", Code),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "Countries_UpdateCountryByID", queryParameters));
	}

	private static CountryDAL BuildDAL(SqlDataReader reader)
	{
		CountryDAL dal = new CountryDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Value = (string)reader["Value"];
			dal.Code = (string)reader["Code"];
			dal.IsActive = (bool)reader["IsActive"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static CountryDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "Countries_GetCountryByID", queryParameters), BuildDAL);
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
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "Countries_GetCountryByCode", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetCountriesByID_Paged(int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "dbo.Countries_GetCountryIDs_Paged", queryParameters));
	}
}
