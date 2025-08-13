using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;

namespace Roblox.Economy.Common;

public class ExchangeRateDAL
{
	public long ID { get; set; }

	public decimal Value { get; set; }

	public DateTime Created { get; set; }

	private static string _DbConnectionString => Helper.DBConnectionString_CurrencyExchange;

	public ExchangeRateDAL()
	{
		Created = default(DateTime);
		Value = 0m;
	}

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "ExchangeRates_DeleteExchangeRateByID", queryParameters));
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "ExchangeRates_InsertExchangeRate", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "ExchangeRates_UpdateExchangeRateByID", queryParameters));
	}

	private static ExchangeRateDAL BuildDAL(SqlDataReader reader)
	{
		ExchangeRateDAL dal = new ExchangeRateDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.Value = (decimal)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static ExchangeRateDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ExchangeRates_GetExchangeRateByID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetLatestExchangeRateIDs_Paged(int startRowIndex, int maxRows)
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maxRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "ExchangeRates_GetLatestExchangeRateIDs_Paged", queryParameters));
	}
}
