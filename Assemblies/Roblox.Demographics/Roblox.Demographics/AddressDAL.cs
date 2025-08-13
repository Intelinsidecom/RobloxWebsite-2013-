using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Demographics;

public class AddressDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxDemographics.GetConnectionString();

	internal int ID { get; set; }

	internal string AddressLine1 { get; set; }

	internal string AddressLine2 { get; set; }

	internal string City { get; set; }

	internal string StateProvince { get; set; }

	internal byte CountryID { get; set; }

	internal string ZipPostal { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal AddressDAL()
	{
	}

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
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "Addresses_DeleteAddressByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AddressLine1", AddressLine1),
			new SqlParameter("@AddressLine2", AddressLine2),
			new SqlParameter("@City", City),
			new SqlParameter("@StateProvince", StateProvince),
			new SqlParameter("@CountryID", CountryID),
			new SqlParameter("@ZipPostal", ZipPostal),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "Addresses_InsertAddress", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AddressLine1", AddressLine1),
			new SqlParameter("@AddressLine2", AddressLine2),
			new SqlParameter("@City", City),
			new SqlParameter("@StateProvince", StateProvince),
			new SqlParameter("@CountryID", CountryID),
			new SqlParameter("@ZipPostal", ZipPostal),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "Addresses_UpdateAddressByID", queryParameters));
	}

	private static AddressDAL BuildDAL(SqlDataReader reader)
	{
		AddressDAL dal = new AddressDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.AddressLine1 = (string)reader["AddressLine1"];
			dal.AddressLine2 = (string)reader["AddressLine2"];
			dal.City = (string)reader["City"];
			dal.StateProvince = (string)reader["StateProvince"];
			dal.CountryID = (byte)reader["CountryID"];
			dal.ZipPostal = (string)reader["ZipPostal"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static AddressDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "Addresses_GetAddressByID", queryParameters), BuildDAL);
	}

	internal static AddressDAL GetByAddress1Address2CityStateProvinceCountryIDZipPostal(string address1, string address2, string city, string stateProvince, int countryId, string zipPostal)
	{
		if (string.IsNullOrEmpty(address1) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(stateProvince) || string.IsNullOrEmpty(zipPostal) || countryId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AddressLine1", address1),
			new SqlParameter("@AddressLine2", address2),
			new SqlParameter("@City", city),
			new SqlParameter("@StateProvince", stateProvince),
			new SqlParameter("@CountryID", countryId),
			new SqlParameter("@ZipPostal", zipPostal)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "Addresses_GetAddressByAddressLine1AddressLine2CityStateProvinceCountryIDZipPostal", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<AddressDAL> GetOrCreateAddress(string address1, string address2, string city, string stateProvince, int countryId, string zipPostal)
	{
		if (string.IsNullOrEmpty(address1) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(stateProvince) || string.IsNullOrEmpty(zipPostal) || countryId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AddressLine1", address1),
			new SqlParameter("@AddressLine2", address2),
			new SqlParameter("@City", city),
			new SqlParameter("@StateProvince", stateProvince),
			new SqlParameter("@CountryID", countryId),
			new SqlParameter("@ZipPostal", zipPostal)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "Addresses_GetOrCreateAddress", queryParameters), BuildDAL);
	}
}
