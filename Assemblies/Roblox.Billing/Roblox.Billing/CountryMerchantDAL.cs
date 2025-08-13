using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class CountryMerchantDAL
{
	private int _ID;

	private byte _MerchantID;

	private byte _CountryTypeID;

	private DateTime _Created;

	private DateTime _Updated;

	internal int ID
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

	internal byte MerchantID
	{
		get
		{
			return _MerchantID;
		}
		set
		{
			_MerchantID = value;
		}
	}

	internal byte CountryTypeID
	{
		get
		{
			return _CountryTypeID;
		}
		set
		{
			_CountryTypeID = value;
		}
	}

	internal DateTime Created
	{
		get
		{
			return _Created;
		}
		set
		{
			_Created = value;
		}
	}

	internal DateTime Updated
	{
		get
		{
			return _Updated;
		}
		set
		{
			_Updated = value;
		}
	}

	private static string _DbConnectionString => Settings.Default.BillingConnectionString;

	internal CountryMerchantDAL()
	{
	}

	internal void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "CountryMerchants_DeleteCountryMerchantByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@MerchantID", MerchantID),
			new SqlParameter("@CountryTypeID", CountryTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "CountryMerchants_InsertCountryMerchant", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@MerchantID", MerchantID),
			new SqlParameter("@CountryTypeID", CountryTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "CountryMerchants_UpdateCountryMerchantByID", queryParameters));
	}

	private static CountryMerchantDAL BuildDAL(SqlDataReader reader)
	{
		CountryMerchantDAL dal = new CountryMerchantDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.MerchantID = (byte)reader["MerchantID"];
			dal.CountryTypeID = (byte)reader["CountryTypeID"];
			dal.ID = (int)reader["ID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static CountryMerchantDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "CountryMerchants_GetCountryMerchantByID", queryParameters), BuildDAL);
	}

	internal static CountryMerchantDAL GetByCountryTypeIDAndMerchantID(byte countryTypeID, byte merchantID)
	{
		if (countryTypeID == 0)
		{
			return null;
		}
		if (merchantID == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@CountryTypeID", countryTypeID));
		queryParameters.Add(new SqlParameter("@MerchantID", merchantID));
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "CountryMerchants_GetCountryMerchantByCountryTypeIDAndMerchantID", queryParameters), BuildDAL);
	}

	internal static ICollection<int> GetCountryMerchantIDsByMerchantID_Paged(int startIndex, int maxRows, byte merchantID)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		queryParameters.Add(new SqlParameter("@MerchantID", merchantID));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString, "[dbo].[CountryMerchants_GetCountryMerchantIDsByMerchantID_Paged]", queryParameters));
	}
}
