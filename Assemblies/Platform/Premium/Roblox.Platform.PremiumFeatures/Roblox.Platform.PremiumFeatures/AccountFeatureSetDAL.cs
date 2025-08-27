using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

[Serializable]
public class AccountFeatureSetDAL
{
	internal long ID { get; set; }

	internal long AccountID { get; set; }

	internal bool CanCreateContent { get; set; }

	internal bool CanSellContent { get; set; }

	internal byte ShowcaseAllotment { get; set; } = 1;


	internal bool SuppressAds { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxPremiumFeatures.GetConnectionString();

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@CanCreateContent", CanCreateContent),
			new SqlParameter("@CanSellContent", CanSellContent),
			new SqlParameter("@ShowcaseAllotment", ShowcaseAllotment),
			new SqlParameter("@SuppressAds", SuppressAds),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "AccountFeatureSetsV2_InsertAccountFeatureSet", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[AccountFeatureSetsV2_DeleteAccountFeatureSetByID]", queryParameters));
	}

	internal static AccountFeatureSetDAL Get(long id)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AccountFeatureSetsV2_GetAccountFeatureSetByID]", queryParameters), BuildDAL);
	}

	internal void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@CanCreateContent", CanCreateContent),
			new SqlParameter("@CanSellContent", CanSellContent),
			new SqlParameter("@ShowcaseAllotment", ShowcaseAllotment),
			new SqlParameter("@SuppressAds", SuppressAds),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[AccountFeatureSetsV2_UpdateAccountFeatureSetByID]", queryParameters));
	}

	private static AccountFeatureSetDAL BuildDAL(SqlDataReader reader)
	{
		AccountFeatureSetDAL dal = new AccountFeatureSetDAL();
		while (reader.Read())
		{
			dal.ID = Convert.ToInt64(reader["ID"]);
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.CanCreateContent = (bool)reader["CanCreateContent"];
			dal.CanSellContent = (bool)reader["CanSellContent"];
			dal.ShowcaseAllotment = (byte)reader["ShowcaseAllotment"];
			dal.SuppressAds = (bool)reader["SuppressAds"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AccountFeatureSetDAL> GetOrCreate(long accountId)
	{
		if (accountId == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AccountID", accountId)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[AccountFeatureSetsV2_GetOrCreateAccountFeatureSet]", queryParameters), BuildDAL);
	}

	internal static AccountFeatureSetDAL GetByAccountId(long accountId)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AccountID", accountId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AccountFeatureSetsV2_GetAccountFeatureSetByAccountID]", queryParameters), BuildDAL);
	}
}
