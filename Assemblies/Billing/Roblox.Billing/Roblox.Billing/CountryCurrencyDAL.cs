using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Billing;

public class CountryCurrencyDAL
{
	public int ID;

	public byte CountryTypeID;

	public byte CurrencyTypeID;

	public DateTime Created;

	public DateTime Updated;

	private static string ConnectionString => RobloxDatabase.RobloxBilling.GetConnectionString();

	private static CountryCurrencyDAL BuildDAL(SqlDataReader reader)
	{
		CountryCurrencyDAL dal = new CountryCurrencyDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.CountryTypeID = (byte)reader["CountryTypeID"];
			dal.CurrencyTypeID = (byte)reader["CurrencyTypeID"];
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
		queryParameters.Add(new SqlParameter("@CountryTypeID", CountryTypeID));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "CountryCurrencies_InsertCountryCurrency", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@CountryTypeID", CountryTypeID));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "CountryCurrencies_UpdateCountryCurrencyByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "CountryCurrencies_DeleteCountryCurrencyByID", queryParameters));
	}

	public static CountryCurrencyDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "CountryCurrencies_GetCountryCurrencyByID", queryParameters), BuildDAL);
	}

	public static CountryCurrencyDAL GetByCountryIDAndCurrencyID(int countryTypeID, byte currencyTypeID)
	{
		if (countryTypeID == 0 || countryTypeID > 255)
		{
			return null;
		}
		if (currencyTypeID == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@CountryID", Convert.ToByte(countryTypeID)));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", currencyTypeID));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "CountryCurrencies_GetCountryCurrencyByCountryIDAndCurrencyTypeID", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<CountryCurrencyDAL> GetOrCreateCountryCurrency(int countryTypeID, byte currencyTypeID)
	{
		if (countryTypeID == 0 || countryTypeID > 255)
		{
			return null;
		}
		if (currencyTypeID == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@CountryTypeID", Convert.ToByte(countryTypeID)));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", currencyTypeID));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "CountryCurrencies_GetOrCreateCountryCurrency", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetCountryCurrencyIDs_Paged(int startIndex, int maxRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[CountryCurrencies_GetCountryCurrencyIDs_Paged]", queryParameters));
	}

	public static ICollection<int> GetCountryCurrencyIDsByCountryID_Paged(int startIndex, int maxRows, int countryTypeID)
	{
		if (countryTypeID == 0 || countryTypeID > 255)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		queryParameters.Add(new SqlParameter("@CountryTypeID", countryTypeID));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[CountryCurrencies_GetCountryCurrencyIDsByCountryTypeID_Paged]", queryParameters));
	}
}
