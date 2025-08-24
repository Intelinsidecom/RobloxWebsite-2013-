using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class AccountPromotionDAL
{
	private int _ID;

	public short PromotionID;

	public long AccountID;

	public DateTime Expires;

	public DateTime Created;

	public DateTime Updated;

	public DateTime? RedemptionDate = default(DateTime);

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

	private static string dbConnectionString_AccountPromotionDAL => Settings.Default.BillingConnectionString;

	private static AccountPromotionDAL BuildDAL(SqlDataReader reader)
	{
		AccountPromotionDAL dal = new AccountPromotionDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.PromotionID = (short)reader["PromotionID"];
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.Expires = (DateTime)reader["Expires"];
			dal.RedemptionDate = (reader["RedemptionDate"].Equals(DBNull.Value) ? null : ((DateTime?)reader["RedemptionDate"]));
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
		queryParameters.Add(new SqlParameter("@PromotionID", PromotionID));
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@Expires", Expires));
		queryParameters.Add(new SqlParameter("@RedemptionDate", (!RedemptionDate.HasValue) ? DBNull.Value : ((object)RedemptionDate)));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_AccountPromotionDAL, "AccountPromotions_InsertAccountPromotion", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@PromotionID", PromotionID));
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@Expires", Expires));
		queryParameters.Add(new SqlParameter("@RedemptionDate", (!RedemptionDate.HasValue) ? DBNull.Value : ((object)RedemptionDate)));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_AccountPromotionDAL, "AccountPromotions_UpdateAccountPromotionByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_AccountPromotionDAL, "AccountPromotions_DeleteAccountPromotionByID", queryParameters));
	}

	public static AccountPromotionDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_AccountPromotionDAL, "AccountPromotions_GetAccountPromotionByID", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetAccountPromotionIDsByPromotionID(short PromotionID)
	{
		if (PromotionID == 0)
		{
			throw new ApplicationException("Required value not specified: PromotionID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PromotionID", PromotionID));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_AccountPromotionDAL, "AccountPromotions_GetAccountPromotionIDsByPromotionID", queryParameters));
	}

	public static ICollection<int> GetAccountPromotionIDsByAccountID(long accountID)
	{
		if (accountID == 0L)
		{
			throw new ApplicationException("Required value not specified: PromotionID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountID", accountID));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_AccountPromotionDAL, "AccountPromotions_GetAccountPromotionIDsByAccountID", queryParameters));
	}

	public static ICollection<int> GetAccountPromotionIDsByAccountIDAndPromotionID(long accountID, short promotionID)
	{
		if (promotionID == 0)
		{
			throw new ApplicationException("Required value not specified: PromotionID.");
		}
		if (accountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountID", accountID));
		queryParameters.Add(new SqlParameter("@PromotionID", promotionID));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(dbConnectionString_AccountPromotionDAL, "AccountPromotions_GetAccountPromotionIDsByAccountIDAndPromotionID", queryParameters));
	}
}
