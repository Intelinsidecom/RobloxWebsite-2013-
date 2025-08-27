using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

public class PremiumFeatureDAL
{
	internal int ID;

	internal string Name = string.Empty;

	internal byte AccountAddOnTypeID;

	internal byte DurationTypeID;

	internal bool IsRenewal;

	internal byte RobuxCreditQuantityTypeID;

	internal byte RobuxStipendQuantityTypeID;

	internal byte? RobuxStipendFrequencyTypeID;

	internal byte ShowcaseAllotmentTypeID;

	internal byte ContentPrivilegeTypeID;

	internal byte AdvertisingSuppressionTypeID;

	internal int GrantedAssetListID;

	internal byte GrantedBadgeListID;

	internal long? GrantedItemListID;

	internal DateTime Created = DateTime.MinValue;

	internal DateTime Updated = DateTime.MinValue;

	private static string ConnectionString => RobloxDatabase.RobloxPremiumFeatures.GetConnectionString();

	internal PremiumFeatureDAL()
	{
	}

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[PremiumFeatures_DeletePremiumFeatureByID]", queryParameters));
	}

	internal void Insert()
	{
		if (Name.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Name.");
		}
		if (DurationTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: DurationTypeID.");
		}
		if (RobuxCreditQuantityTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: RobuxCreditQuantityTypeID.");
		}
		if (RobuxStipendQuantityTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: RobuxStipendQuantityTypeID.");
		}
		if (ShowcaseAllotmentTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: ShowcaseAllotmentTypeID.");
		}
		if (ContentPrivilegeTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: ContentPrivilegeTypeID.");
		}
		if (AdvertisingSuppressionTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AdvertisingSuppressionTypeID.");
		}
		if (GrantedAssetListID == 0)
		{
			throw new ApplicationException("Required value not specified: GrantedAssetListID.");
		}
		if (GrantedBadgeListID == 0)
		{
			throw new ApplicationException("Required value not specified: GrantedBadgeListID.");
		}
		if (AccountAddOnTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AccountAddOnTypeID.");
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
		queryParameters.Add(new SqlParameter("@DurationTypeID", DurationTypeID));
		queryParameters.Add(new SqlParameter("@IsRenewal", IsRenewal));
		queryParameters.Add(new SqlParameter("@RobuxCreditQuantityTypeID", RobuxCreditQuantityTypeID));
		queryParameters.Add(new SqlParameter("@RobuxStipendQuantityTypeID", RobuxStipendQuantityTypeID));
		queryParameters.Add(new SqlParameter("@RobuxStipendFrequencyTypeID", RobuxStipendFrequencyTypeID));
		queryParameters.Add(new SqlParameter("@ShowcaseAllotmentTypeID", ShowcaseAllotmentTypeID));
		queryParameters.Add(new SqlParameter("@ContentPrivilegeTypeID", ContentPrivilegeTypeID));
		queryParameters.Add(new SqlParameter("@AdvertisingSuppressionTypeID", AdvertisingSuppressionTypeID));
		queryParameters.Add(new SqlParameter("@GrantedAssetListID", GrantedAssetListID));
		queryParameters.Add(new SqlParameter("@GrantedBadgeListID", GrantedBadgeListID));
		queryParameters.Add(new SqlParameter("@GrantedItemListID", GrantedItemListID));
		queryParameters.Add(new SqlParameter("@AccountAddOnTypeID", AccountAddOnTypeID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "[dbo].[PremiumFeatures_InsertPremiumFeature]", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	internal void Update()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (Name.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Name.");
		}
		if (DurationTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: DurationTypeID.");
		}
		if (RobuxCreditQuantityTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: RobuxCreditQuantityTypeID.");
		}
		if (RobuxStipendQuantityTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: RobuxStipendQuantityTypeID.");
		}
		if (ShowcaseAllotmentTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: ShowcaseAllotmentTypeID.");
		}
		if (ContentPrivilegeTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: ContentPrivilegeTypeID.");
		}
		if (AdvertisingSuppressionTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AdvertisingSuppressionTypeID.");
		}
		if (GrantedAssetListID == 0)
		{
			throw new ApplicationException("Required value not specified: GrantedAssetListID.");
		}
		if (GrantedBadgeListID == 0)
		{
			throw new ApplicationException("Required value not specified: GrantedBadgeListID.");
		}
		if (GrantedItemListID == 0)
		{
			throw new ApplicationException("Required value not specified: GrantedItemListID.");
		}
		if (AccountAddOnTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: AccountAddOnTypeID.");
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
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@Name", Name));
		queryParameters.Add(new SqlParameter("@DurationTypeID", DurationTypeID));
		queryParameters.Add(new SqlParameter("@IsRenewal", IsRenewal));
		queryParameters.Add(new SqlParameter("@RobuxCreditQuantityTypeID", RobuxCreditQuantityTypeID));
		queryParameters.Add(new SqlParameter("@RobuxStipendQuantityTypeID", RobuxStipendQuantityTypeID));
		queryParameters.Add(new SqlParameter("@RobuxStipendFrequencyTypeID", RobuxStipendFrequencyTypeID));
		queryParameters.Add(new SqlParameter("@ShowcaseAllotmentTypeID", ShowcaseAllotmentTypeID));
		queryParameters.Add(new SqlParameter("@ContentPrivilegeTypeID", ContentPrivilegeTypeID));
		queryParameters.Add(new SqlParameter("@AdvertisingSuppressionTypeID", AdvertisingSuppressionTypeID));
		queryParameters.Add(new SqlParameter("@GrantedAssetListID", GrantedAssetListID));
		queryParameters.Add(new SqlParameter("@GrantedBadgeListID", GrantedBadgeListID));
		queryParameters.Add(new SqlParameter("@GrantedItemListID", GrantedItemListID));
		queryParameters.Add(new SqlParameter("@AccountAddOnTypeID", AccountAddOnTypeID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[PremiumFeatures_UpdatePremiumFeatureByID]", queryParameters));
	}

	private static PremiumFeatureDAL BuildDAL(SqlDataReader reader)
	{
		PremiumFeatureDAL dal = new PremiumFeatureDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Name = (string)reader["Name"];
			dal.AccountAddOnTypeID = (byte)reader["AccountAddOnTypeID"];
			dal.IsRenewal = (bool)reader["IsRenewal"];
			dal.DurationTypeID = (byte)reader["DurationTypeID"];
			dal.RobuxCreditQuantityTypeID = (byte)reader["RobuxCreditQuantityTypeID"];
			dal.RobuxStipendQuantityTypeID = (byte)reader["RobuxStipendQuantityTypeID"];
			dal.RobuxStipendFrequencyTypeID = (reader["RobuxStipendFrequencyTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["RobuxStipendFrequencyTypeID"]));
			dal.ShowcaseAllotmentTypeID = (byte)reader["ShowcaseAllotmentTypeID"];
			dal.ContentPrivilegeTypeID = (byte)reader["ContentPrivilegeTypeID"];
			dal.AdvertisingSuppressionTypeID = (byte)reader["AdvertisingSuppressionTypeID"];
			dal.GrantedAssetListID = (int)reader["GrantedAssetListID"];
			dal.GrantedBadgeListID = (byte)reader["GrantedBadgeListID"];
			dal.GrantedItemListID = (reader["GrantedItemListID"].Equals(DBNull.Value) ? null : new long?((long)reader["GrantedItemListID"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static PremiumFeatureDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[PremiumFeatures_GetPremiumFeatureByID]", queryParameters), BuildDAL);
	}

	internal static PremiumFeatureDAL GetByName(string name)
	{
		if (name == string.Empty)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Name", name));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[PremiumFeatures_GetPremiumFeatureByName]", queryParameters), BuildDAL);
	}

	internal static ICollection<int> GetPremiumFeatureIDsPaged(int startRowIndex, int maximumRows)
	{
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<int>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[PremiumFeatures_GetPremiumFeatureIDs_Paged]", queryParameters));
	}

	internal static int GetTotalNumberOfPremiumFeatures()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "[dbo].[PremiumFeatures_GetTotalNumberOfPremiumFeatures]", queryParameters));
	}

	internal static ICollection<int> GetPremiumFeaturesByAccountAddOnTypeIdPaged(int accountAddOnTypeId, int startRowIndex, int maximumRows)
	{
		if (accountAddOnTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: AccountAddOnTypeID.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<int>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountAddOnTypeID", accountAddOnTypeId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[PremiumFeatures_GetPremiumFeatureIDsByAccountAddOnTypeID_Paged]", queryParameters));
	}
}
