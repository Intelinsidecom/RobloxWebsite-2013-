using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
internal class FileDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxFilesV2;

	internal long ID { get; set; }

	internal string MD5Hash { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime? Updated { get; set; }

	internal byte[] Locations { get; set; }

	private static FileDAL BuildDAL(IDictionary<string, object> record)
	{
		return new FileDAL
		{
			ID = (long)record["ID"],
			MD5Hash = (string)record["MD5Hash"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime?)record["Updated"],
			Locations = (byte[])record["Locations"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxFilesV2.Delete("Files_DeleteFileByID", ID);
	}

	internal static FileDAL Get(long id)
	{
		return RobloxDatabase.RobloxFilesV2.Get("Files_GetFileByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@MD5Hash", MD5Hash),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@Locations", Locations)
		};
		ID = RobloxDatabase.RobloxFilesV2.Insert<long>("Files_InsertFile", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@MD5Hash", MD5Hash),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@Locations", Locations)
		};
		RobloxDatabase.RobloxFilesV2.Update("Files_UpdateFileByID", queryParameters);
	}

	internal static ICollection<FileDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxFilesV2.MultiGet("Files_GetFilesByIDs", ids, BuildDAL);
	}

	internal static FileDAL GetFileByMD5Hash(string mD5Hash)
	{
		if (string.IsNullOrEmpty(mD5Hash))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@MD5Hash", mD5Hash)
		};
		return RobloxDatabase.RobloxFilesV2.Lookup("Files_GetFileByMD5Hash", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<FileDAL> GetOrCreateFile(string mD5Hash)
	{
		if (string.IsNullOrEmpty(mD5Hash))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@MD5Hash", mD5Hash)
		};
		return RobloxDatabase.RobloxFilesV2.GetOrCreate("Files_GetOrCreateFile", BuildDAL, queryParameters);
	}
}
