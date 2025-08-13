using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Text;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Studio.Entities;

internal class AssetSearchKeywordStatisticDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxStudio;

	internal long ID { get; set; }

	internal long AssetID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AssetSearchKeywordStatisticDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AssetSearchKeywordStatisticDAL
		{
			ID = (long)record["ID"],
			AssetID = (long)record["AssetID"],
			Value = ((record["Value"] == null) ? null : GetString((byte[])record["Value"])),
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxStudio.Delete("AssetSearchKeywordStatistics_DeleteAssetSearchKeywordStatisticByID", ID);
	}

	internal static AssetSearchKeywordStatisticDAL Get(long id)
	{
		return RobloxDatabase.RobloxStudio.Get("AssetSearchKeywordStatistics_GetAssetSearchKeywordStatisticByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@Value", SqlDbType.VarBinary)
			{
				Value = (string.IsNullOrEmpty(Value) ? SqlBinary.Null : ((SqlBinary)GetBytes(Value)))
			},
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxStudio.Insert<long>("AssetSearchKeywordStatistics_InsertAssetSearchKeywordStatistic", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@Value", SqlDbType.VarBinary)
			{
				Value = (string.IsNullOrEmpty(Value) ? SqlBinary.Null : ((SqlBinary)GetBytes(Value)))
			},
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxStudio.Update("AssetSearchKeywordStatistics_UpdateAssetSearchKeywordStatisticByID", queryParameters);
	}

	internal static ICollection<AssetSearchKeywordStatisticDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxStudio.MultiGet("AssetSearchKeywordStatistics_GetAssetSearchKeywordStatisticsByIDs", ids, BuildDAL);
	}

	internal static AssetSearchKeywordStatisticDAL GetAssetSearchKeywordStatisticByAssetID(long AssetID)
	{
		if (AssetID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AssetID", AssetID)
		};
		return RobloxDatabase.RobloxStudio.Lookup("AssetSearchKeywordStatistics_GetAssetSearchKeywordStatisticByAssetID", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetAssetSearchKeywordStatisticIDs(long exclusiveStartID, int count)
	{
		if (exclusiveStartID < 0)
		{
			throw new ArgumentException("Parameter 'exclusiveStartID' cannot less than zero.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@ExclusiveStartID", exclusiveStartID),
			new SqlParameter("@MaximumRows", count)
		};
		return RobloxDatabase.RobloxStudio.GetIDCollection<long>("AssetSearchKeywordStatistics_GetAssetSearchKeywordStatisticIDs", queryParameters);
	}

	private static string GetString(byte[] bytes)
	{
		return Encoding.UTF8.GetString(bytes);
	}

	private static byte[] GetBytes(string value)
	{
		return Encoding.UTF8.GetBytes(value);
	}
}
