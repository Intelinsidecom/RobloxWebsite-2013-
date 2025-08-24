using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Billing;

public class GamecardRedemptionLogDAL
{
	public long AccountID;

	public byte MerchantID;

	public decimal CardValue;

	public string CardPIN = string.Empty;

	public DateTime Created;

	public DateTime Updated;

	private static string ConnectionString => RobloxDatabase.RobloxBilling.GetConnectionString();

	public int ID { get; set; }

	private static GamecardRedemptionLogDAL BuildDAL(SqlDataReader reader)
	{
		GamecardRedemptionLogDAL dal = new GamecardRedemptionLogDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.MerchantID = (byte)reader["MerchantID"];
			dal.CardValue = (decimal)reader["CardValue"];
			dal.CardPIN = (string)reader["CardPIN"];
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
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@MerchantID", MerchantID));
		queryParameters.Add(new SqlParameter("@CardValue", CardValue));
		queryParameters.Add(new SqlParameter("@CardPIN", CardPIN));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "GamecardRedemptionLog_InsertGamecardRedemptionLog", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		throw new NotImplementedException();
	}

	public void Delete()
	{
		throw new NotImplementedException();
	}

	public static GamecardRedemptionLogDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "GamecardRedemptionLog_GetGamecardRedemptionLogByID", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetGamecardRedemptionLogIDsByMerchantID(byte MerchantID)
	{
		if (MerchantID == 0)
		{
			throw new ApplicationException("Required value not specified: MerchantID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MerchantID", MerchantID));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "GamecardRedemptionLog_GetGamecardRedemptionLogIDsByMerchantID", queryParameters));
	}

	public static int GetLogCountByPin(string cardPIN)
	{
		if (string.IsNullOrEmpty(cardPIN))
		{
			throw new ApplicationException("Required value not specified: CardPin.");
		}
		List<SqlParameter> queryParamters = new List<SqlParameter>();
		queryParamters.Add(new SqlParameter("@CardPIN", cardPIN));
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "GamecardRedemptionLog_GetLogCountByCardPin", queryParamters));
	}

	public static ICollection<int> GetGamecardRedemptionLogIDsByCardPIN(string cardPIN)
	{
		if (string.IsNullOrEmpty(cardPIN))
		{
			throw new ApplicationException("Required value not specified: CardPin.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@CardPIN", cardPIN));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "GamecardRedemptionLog_GetIDsByCardPIN", queryParameters));
	}

	public static ICollection<int> GetGamecardRedemptionLogIDsByAccountID(int count, long accountID)
	{
		if (count <= 0)
		{
			return new int[0];
		}
		if (accountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountID", accountID));
		queryParameters.Add(new SqlParameter("@Count", count));
		queryParameters.Add(new SqlParameter("@ExclusiveStartID", DBNull.Value));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "GamecardRedemptionLog_GetGamecardRedemptionLogIDsByAccountID_Desc", queryParameters));
	}
}
