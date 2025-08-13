using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Economy.Common;

public class TransactionHistoryDAL
{
	internal long ID { get; set; }

	internal byte TransactionTypeID { get; set; }

	internal byte TransactionOriginTypeID { get; set; }

	internal byte CurrencyTypeID { get; set; }

	internal long UserID { get; set; }

	internal long? OriginID { get; set; }

	internal long Amount { get; set; }

	internal bool IsProcessed { get; set; }

	internal DateTime Created { get; set; } = DateTime.MinValue;


	internal DateTime Updated { get; set; } = DateTime.MinValue;


	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_DeleteTransactionHistoryByID]", queryParameters));
	}

	public void Insert()
	{
		if (TransactionTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: TransactionTypeID.");
		}
		if (TransactionOriginTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: TransactionOriginTypeID.");
		}
		if (CurrencyTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: CurrencyTypeID.");
		}
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
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
		queryParameters.Add(new SqlParameter("@TransactionTypeID", TransactionTypeID));
		queryParameters.Add(new SqlParameter("@TransactionOriginTypeID", TransactionOriginTypeID));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID));
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@SaleID", (OriginID.HasValue && OriginID > 0) ? ((object)OriginID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Amount", Amount));
		queryParameters.Add(new SqlParameter("@IsProcessed", IsProcessed));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_InsertTransactionHistory]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (TransactionTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: TransactionTypeID.");
		}
		if (TransactionOriginTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: TransactionOriginTypeID.");
		}
		if (CurrencyTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: CurrencyTypeID.");
		}
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
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
		queryParameters.Add(new SqlParameter("@TransactionTypeID", TransactionTypeID));
		queryParameters.Add(new SqlParameter("@TransactionOriginTypeID", TransactionOriginTypeID));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID));
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@SaleID", (OriginID.HasValue && OriginID > 0) ? ((object)OriginID.Value) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Amount", Amount));
		queryParameters.Add(new SqlParameter("@IsProcessed", IsProcessed));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_UpdateTransactionHistoryByID]", queryParameters));
	}

	private static TransactionHistoryDAL BuildDAL(SqlDataReader reader)
	{
		TransactionHistoryDAL dal = new TransactionHistoryDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.TransactionTypeID = (byte)reader["TransactionTypeID"];
			dal.TransactionOriginTypeID = (byte)reader["TransactionOriginTypeID"];
			dal.CurrencyTypeID = (byte)reader["CurrencyTypeID"];
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.OriginID = (reader["SaleID"].Equals(DBNull.Value) ? null : ((long?)reader["SaleID"]));
			dal.Amount = (long)reader["Amount"];
			dal.IsProcessed = (bool)reader["IsProcessed"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static TransactionHistoryDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTransactionHistoryByID]", queryParameters), BuildDAL);
	}

	public static long GetRobuxEarnedCount(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxEarned]", queryParameters));
	}

	public static long GetRobuxEarnedFromLoginAwardsCount(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxEarnedFromLoginAwards]", queryParameters));
	}

	public static long GetRobuxEarnedFromPlaceTrafficAwardsCount(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxEarnedFromPlaceTrafficAwards]", queryParameters));
	}

	public static long GetRobuxEarnedFromSaleOfGoodsCount(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxEarnedFromSaleOfGoods]", queryParameters));
	}

	public static long GetTransactionsTotalAmountByCriteria(long userId, int transactionTypeId, int transactionOriginTypeId, int currencyTypeId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", currencyTypeId));
		queryParameters.Add(new SqlParameter("@TransactionOriginTypeID", transactionOriginTypeId));
		queryParameters.Add(new SqlParameter("@TransactionTypeID", transactionTypeId));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTransactionsTotalAmountByTransactionOriginTypeIDTransactionTypeIDAndCurrencyTypeID]", queryParameters));
	}

	public static long GetRobuxCreditedFromTradeSystem(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxCreditedFromTradeSystem]", queryParameters));
	}

	public static long GetRobuxEarnedFromCurrencyPurchaseCount(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxEarnedFromCurrencyPurchase]", queryParameters));
	}

	public static long GetRobuxEarnedFromSignupBonusCount(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxEarnedFromSignupBonusCount]", queryParameters));
	}

	public static long GetRobuxAdjustedFromAdjustments(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxAdjustedFromAdjustments]", queryParameters));
	}

	public static long GetRobuxCreditedFromAdjustments(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxCreditedFromAdjustments]", queryParameters));
	}

	public static long GetRobuxDebitedFromAdjustments(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxDebitedFromAdjustments]", queryParameters));
	}

	public static long GetRobuxCreditedFromCurrencyTrade(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxCreditedFromCurrencyTrade]", queryParameters));
	}

	public static long GetRobuxDebitedFromCurrencyTrade(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxDebitedFromCurrencyTrade]", queryParameters));
	}

	public static long GetRobuxDebitedFromSaleOfGoods(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalRobuxDebitedFromSaleOfGoods]", queryParameters));
	}

	public static long GetRobuxEarnedFromBCStipendBonusCount(long userId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyType.RobuxID));
		queryParameters.Add(new SqlParameter("@TransactionOriginTypeID", TransactionOriginType.BuildersClubStipendBonusID));
		queryParameters.Add(new SqlParameter("@UserID", (userId > 0) ? ((object)userId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalEarnedByCurrencyTypeIDAndTransactionOriginTypeID]", queryParameters));
	}

	public static long GetRobuxEarnedFromGroupPayouts(long agentId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyType.RobuxID));
		queryParameters.Add(new SqlParameter("@TransactionOriginTypeID", TransactionOriginType.GroupRevenuePayoutID));
		queryParameters.Add(new SqlParameter("@UserID", (agentId > 0) ? ((object)agentId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalEarnedByCurrencyTypeIDAndTransactionOriginTypeID]", queryParameters));
	}

	public static long GetRobuxDebitedFromGroupPayouts(long agentId, DateTime fromDateTime)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", (agentId > 0) ? ((object)agentId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@FromDateTime", (!fromDateTime.Equals(DateTime.MinValue)) ? ((object)fromDateTime) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyType.RobuxID));
		queryParameters.Add(new SqlParameter("@TransactionOriginTypeID", TransactionOriginType.GroupRevenuePayoutID));
		queryParameters.Add(new SqlParameter("@TransactionTypeID", TransactionType.DebitID));
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTotalByTransactionTypeIDCurrencyTypeIDTransactionOriginTypeIDAndUserID]", queryParameters));
	}

	public static ICollection<long> GetTransactionHistoryIDsByCriteriaPaged(long userId, byte currencyTypeId, byte transactionTypeId, byte transactionOriginTypeId, int startRowIndex, int maximumRows)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		queryParameters.Add(new SqlParameter("@TransactionOriginTypeID", transactionOriginTypeId));
		queryParameters.Add(new SqlParameter("@TransactionTypeID", transactionTypeId));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", currencyTypeId));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString_TransactionHistory, "[dbo].[TransactionHistory_GetTransactionHistoryIDsByCriteria_Paged]", queryParameters));
	}
}
