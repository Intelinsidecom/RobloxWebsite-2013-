using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

internal class StaticFileDAL
{
	public string FileName;

	public string Hash;

	public byte CompressionTypeID;

	public DateTime Created;

	public DateTime Updated;

	public int ID { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxFiles.GetConnectionString();

	private static StaticFileDAL BuildDAL(SqlDataReader reader)
	{
		StaticFileDAL dal = new StaticFileDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.FileName = (string)reader["FileName"];
			dal.Hash = (string)reader["Hash"];
			dal.CompressionTypeID = (byte)reader["CompressionTypeID"];
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
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@FileName", FileName),
			new SqlParameter("@Hash", Hash),
			new SqlParameter("@CompressionTypeID", CompressionTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "StaticFiles_InsertStaticFile", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@FileName", FileName),
			new SqlParameter("@Hash", Hash),
			new SqlParameter("@CompressionTypeID", CompressionTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "StaticFiles_UpdateStaticFileByID", queryParameters));
	}

	public void Delete()
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "StaticFiles_DeleteStaticFileByID", queryParameters));
	}

	public static StaticFileDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "StaticFiles_GetStaticFileByID", queryParameters), BuildDAL);
	}

	public static StaticFileDAL GetStaticFileByFileNameAndCompressionType(string fileName, byte compressionTypeID)
	{
		if (fileName == null)
		{
			return null;
		}
		if (compressionTypeID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@FileName", fileName),
			new SqlParameter("@CompressionTypeID", compressionTypeID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "StaticFiles_GetStaticFileByFileNameAndCompressionTypeID", queryParameters), BuildDAL);
	}
}
