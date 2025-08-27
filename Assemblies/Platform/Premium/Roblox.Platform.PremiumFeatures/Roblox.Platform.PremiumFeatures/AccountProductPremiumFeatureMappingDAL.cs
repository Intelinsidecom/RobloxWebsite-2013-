using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Properties;

namespace Roblox.PremiumFeatures;

public class AccountProductPremiumFeatureMappingDAL
{
	private int _ID;

	private int _AccountProductID;

	private int _PremiumFeatureID;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

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

	public int AccountProductID
	{
		get
		{
			return _AccountProductID;
		}
		set
		{
			_AccountProductID = value;
		}
	}

	public int PremiumFeatureID
	{
		get
		{
			return _PremiumFeatureID;
		}
		set
		{
			_PremiumFeatureID = value;
		}
	}

	public DateTime Created
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

	public DateTime Updated
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

	private static string _DbConnectionString_AccountManagement => Settings.Default.AccountManagementConnectionStringForTesting;

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString_AccountManagement, "[dbo].[AccountProductPremiumFeatureMappings_DeleteAccountProductPremiumFeatureMappingByID]", queryParameters));
	}

	public void Insert()
	{
		if (_AccountProductID == 0)
		{
			throw new ApplicationException("Required value not specified: AccountProductID.");
		}
		if (_PremiumFeatureID == 0)
		{
			throw new ApplicationException("Required value not specified: PremiumFeatureID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountProductID", _AccountProductID));
		queryParameters.Add(new SqlParameter("@PremiumFeatureID", _PremiumFeatureID));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(_DbConnectionString_AccountManagement, "[dbo].[AccountProductPremiumFeatureMappings_InsertAccountProductPremiumFeatureMapping]", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (_AccountProductID == 0)
		{
			throw new ApplicationException("Required value not specified: AccountProductID.");
		}
		if (_PremiumFeatureID == 0)
		{
			throw new ApplicationException("Required value not specified: PremiumFeatureID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AccountProductID", _AccountProductID));
		queryParameters.Add(new SqlParameter("@PremiumFeatureID", _PremiumFeatureID));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString_AccountManagement, "[dbo].[AccountProductPremiumFeatureMappings_UpdateAccountProductPremiumFeatureMappingByID]", queryParameters));
	}

	private static AccountProductPremiumFeatureMappingDAL BuildDAL(SqlDataReader reader)
	{
		AccountProductPremiumFeatureMappingDAL dal = new AccountProductPremiumFeatureMappingDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.AccountProductID = (int)reader["AccountProductID"];
			dal.PremiumFeatureID = (int)reader["PremiumFeatureID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static AccountProductPremiumFeatureMappingDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString_AccountManagement, "[dbo].[AccountProductPremiumFeatureMappings_GetAccountProductPremiumFeatureMappingByID]", queryParameters), BuildDAL);
	}

	public static AccountProductPremiumFeatureMappingDAL GetByAccountProductID(int accountProductId)
	{
		if (accountProductId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountProductID", accountProductId));
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString_AccountManagement, "[dbo].[AccountProductPremiumFeatureMappings_GetAccountProductPremiumFeatureMappingByAccountProductID]", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetAllIDs()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString_AccountManagement, "[dbo].[AccountProductPremiumFeatureMappings_GetAllIDs]", queryParameters));
	}
}
