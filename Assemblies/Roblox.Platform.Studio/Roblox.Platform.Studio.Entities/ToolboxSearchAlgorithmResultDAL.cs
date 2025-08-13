using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Studio.Entities;

internal class ToolboxSearchAlgorithmResultDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxStudio;

	internal long ID { get; set; }

	internal int AlgorithmID { get; set; }

	internal string Keyword { get; set; }

	internal long[] Results { get; set; }

	internal DateTime Created { get; set; }

	private static ToolboxSearchAlgorithmResultDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ToolboxSearchAlgorithmResultDAL
		{
			ID = (long)record["ID"],
			AlgorithmID = (int)record["AlgorithmID"],
			Keyword = (string)record["Keyword"],
			Results = ConvertDoublePrecision((byte[])record["Results"], BitConverter.ToInt64),
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxStudio.Delete("ToolboxSearchAlgorithmResults_DeleteAlgorithmResultByID", ID);
	}

	internal static ToolboxSearchAlgorithmResultDAL Get(long id)
	{
		return RobloxDatabase.RobloxStudio.Get("ToolboxSearchAlgorithmResults_GetAlgorithmResultByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AlgorithmID", AlgorithmID),
			new SqlParameter("@Keyword", Keyword),
			new SqlParameter("@Results", ConvertDoublePrecision(Results, BitConverter.GetBytes)),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxStudio.Insert<long>("ToolboxSearchAlgorithmResults_InsertAlgorithmResult", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AlgorithmID", AlgorithmID),
			new SqlParameter("@Keyword", Keyword),
			new SqlParameter("@Results", ConvertDoublePrecision(Results, BitConverter.GetBytes)),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxStudio.Update("ToolboxSearchAlgorithmResults_UpdateAlgorithmResultByID", queryParameters);
	}

	internal static ICollection<ToolboxSearchAlgorithmResultDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxStudio.MultiGet("ToolboxSearchAlgorithmResults_GetAlgorithmResultsByIDs", ids, BuildDAL);
	}

	internal static ToolboxSearchAlgorithmResultDAL GetAlgorithmResultByAlgorithmIDAndKeyword(int algorithmID, string keyword)
	{
		if (algorithmID == 0 || string.IsNullOrEmpty(keyword))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@AlgorithmID", algorithmID),
			new SqlParameter("@Keyword", keyword)
		};
		return RobloxDatabase.RobloxStudio.Lookup("ToolboxSearchAlgorithmResults_GetAlgorithmResultByAlgorithmIDAndKeyword", BuildDAL, queryParameters);
	}

	private static T[] ConvertDoublePrecision<T>(byte[] bytes, Func<byte[], int, T> converter)
	{
		int numberOfResults = bytes.Length / 8;
		T[] results = new T[numberOfResults];
		for (int i = 0; i < numberOfResults; i++)
		{
			int startIndex = i * 8;
			T result = converter(bytes, startIndex);
			results[i] = result;
		}
		return results;
	}

	private static byte[] ConvertDoublePrecision<T>(T[] values, Func<T, byte[]> converter)
	{
		byte[] bytes = new byte[values.Length * 8];
		for (int i = 0; i < values.Length; i++)
		{
			byte[] valueBytes = converter(values[i]);
			for (int j = 0; j < 8; j++)
			{
				bytes[i * 8 + j] = valueBytes[j];
			}
		}
		return bytes;
	}
}
