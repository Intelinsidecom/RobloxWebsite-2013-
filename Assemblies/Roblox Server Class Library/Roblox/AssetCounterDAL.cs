using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class AssetCounterDAL
{
	public long ID { get; set; }

	public long AssetID { get; set; }

	public byte AssetCounterTypeID { get; set; }

	public long Value { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxAssetCounters.GetConnectionString();

	public void Increment(long amount)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		SqlParameter outputValue = new SqlParameter("@Value", SqlDbType.BigInt)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter outputUpdated = new SqlParameter("@Updated", SqlDbType.DateTime)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Amount", amount),
			outputValue,
			outputUpdated
		};
		EntityHelper.DoEntityDALAction(new DbInfo(ConnectionString, "[dbo].[AssetCounters_IncrementAssetCounterByID]", queryParameters));
		Value = (long)outputValue.Value;
		Updated = (DateTime)outputUpdated.Value;
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
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[AssetCounters_DeleteAssetCounterByID]", queryParameters));
	}

	public void Decrement(long amount)
	{
		if (amount < 1)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		SqlParameter outputValue = new SqlParameter("@Value", SqlDbType.BigInt)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter outputUpdated = new SqlParameter("@Updated", SqlDbType.DateTime)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Amount", amount),
			outputValue,
			outputUpdated
		};
		EntityHelper.DoEntityDALAction(new DbInfo(ConnectionString, "[dbo].[AssetCounters_DecrementAssetCounterByID]", queryParameters));
		Value = (long)outputValue.Value;
		Updated = (DateTime)outputUpdated.Value;
	}

	private static AssetCounterDAL BuildDAL(SqlDataReader reader)
	{
		AssetCounterDAL dal = new AssetCounterDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AssetID = (long)reader["AssetID"];
			dal.AssetCounterTypeID = (byte)reader["AssetCounterTypeID"];
			dal.Value = (long)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static EntityHelper.GetOrCreateDALWrapper<AssetCounterDAL> GetOrCreate(long assetId, byte assetCounterTypeId)
	{
		if (assetId == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		if (assetCounterTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: AssetCounterTypeID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@AssetID", assetId),
			new SqlParameter("@AssetCounterTypeID", assetCounterTypeId)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetCounters_GetOrCreateAssetCounter]", queryParameters), BuildDAL);
	}

	public static AssetCounterDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AssetCounters_GetAssetCounterByID]", queryParameters), BuildDAL);
	}
}
