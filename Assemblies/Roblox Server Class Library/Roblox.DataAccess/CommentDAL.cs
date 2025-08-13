using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class CommentDAL
{
	public enum SelectFilter
	{
		ID
	}

	private string _Value = string.Empty;

	private static string ConnectionString => RobloxDatabase.RobloxComments.GetConnectionString();

	public long ID { get; set; }

	public long UserID { get; set; }

	public long AssetID { get; set; }

	public string Value
	{
		get
		{
			return _Value;
		}
		set
		{
			_Value = value.Substring(0, (value.Length < 500) ? value.Length : 500);
		}
	}

	public DateTime Created { get; set; } = DateTime.MinValue;


	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", ID);
		dbHelper.ExecuteSQLScalar("[dbo].[CommentsV2_DeleteCommentV2ByID]", CommandType.StoredProcedure);
	}

	public void Insert()
	{
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (AssetID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@UserID", UserID);
		dbHelper.SQLParameters.AddWithValue("@AssetID", AssetID);
		dbHelper.SQLParameters.AddWithValue("@Value", _Value);
		dbHelper.SQLParameters.AddWithValue("@Created", Created);
		SqlParameter id = dbHelper.SQLParameters.Add("@ID", SqlDbType.BigInt);
		id.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[CommentsV2_InsertCommentV2]", CommandType.StoredProcedure);
		ID = Convert.ToInt64(id.Value);
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (AssetID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		if (_Value.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Value.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", ID);
		dbHelper.SQLParameters.AddWithValue("@UserID", UserID);
		dbHelper.SQLParameters.AddWithValue("@AssetID", AssetID);
		dbHelper.SQLParameters.AddWithValue("@Value", _Value);
		dbHelper.SQLParameters.AddWithValue("@Created", Created);
		dbHelper.ExecuteSQLScalar("[dbo].[CommentsV2_UpdateCommentV2ByID]", CommandType.StoredProcedure);
	}

	private static CommentDAL BuildDAL(SqlDataReader reader)
	{
		CommentDAL dal = new CommentDAL();
		while (reader.Read())
		{
			dal.ID = Convert.ToInt64(reader["ID"]);
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.AssetID = (long)reader["AssetID"];
			dal.Value = (string)reader["Value"];
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.Created == DateTime.MinValue)
		{
			return null;
		}
		return dal;
	}

	public static CommentDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		using DbHelper dbHelper = DBHelperFactory.GetDBHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[CommentsV2_GetCommentV2ByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static ICollection<long> GetAssetCommentIDsPaged(long assetId, int startRowIndex, int maximumRows)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetID", assetId);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[CommentsV2_GetCommentV2IDsByAssetID_Paged]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}

	internal static ICollection<long> GetAssetCommentIDsByAssetId(long assetId, long? exclusiveStartId, int count, SortOrder sortOrder)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetID", assetId);
		SqlParameterCollection sQLParameters = dbHelper.SQLParameters;
		long? num = exclusiveStartId;
		sQLParameters.AddWithValue("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		dbHelper.SQLParameters.AddWithValue("@Count", count);
		dbHelper.SQLParameters.AddWithValue("@IsAscendingOrder", sortOrder == SortOrder.Ascending);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[CommentsV2_GetCommentV2IDsByAssetID]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}

	public static int GetTotalNumberOfAssetComments(long assetId)
	{
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetID", assetId);
		return Convert.ToInt32(dbHelper.ExecuteSQLScalar("[dbo].[CommentsV2_GetTotalNumberOfCommentsV2ByAssetID]", CommandType.StoredProcedure));
	}
}
