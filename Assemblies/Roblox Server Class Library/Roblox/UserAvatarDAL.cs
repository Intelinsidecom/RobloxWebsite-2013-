using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class UserAvatarDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAvatars;

	private string _AvatarHash = string.Empty;

	public int ID { get; set; }

	public long UserID { get; set; }

	public long NewAvatarAssetHashID { get; set; }

	public string AvatarHash
	{
		get
		{
			return _AvatarHash;
		}
		set
		{
			_AvatarHash = value;
		}
	}

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public long? BodyColorSetID { get; set; }

	public byte? PlayerAvatarTypeID { get; set; }

	public int? ScaleID { get; set; }

	public void Delete()
	{
		RobloxDatabase.RobloxAvatars.Delete("UserAvatars_DeleteUserAvatarByID", ID);
	}

	public void Update()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value was not specified: ID.");
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
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@AvatarHash", string.IsNullOrEmpty(_AvatarHash) ? ((IConvertible)DBNull.Value) : ((IConvertible)_AvatarHash)));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@NewAvatarAssetHashID", NewAvatarAssetHashID));
		queryParameters.Add(new SqlParameter("@BodyColorSetID", BodyColorSetID));
		queryParameters.Add(new SqlParameter("@PlayerAvatarTypeID", PlayerAvatarTypeID));
		queryParameters.Add(new SqlParameter("@ScaleID", ScaleID));
		RobloxDatabase.RobloxAvatars.Update("UserAvatars_UpdateUserAvatarByID", queryParameters.ToArray());
	}

	private static UserAvatarDAL BuildDAL(IDictionary<string, object> record)
	{
		UserAvatarDAL dal = new UserAvatarDAL();
		dal.ID = (int)record["ID"];
		dal.UserID = Convert.ToInt64(record["UserID"]);
		dal.AvatarHash = ((string)record["AvatarHash"]) ?? string.Empty;
		dal.Created = (DateTime)record["Created"];
		dal.Updated = (DateTime)record["Updated"];
		dal.NewAvatarAssetHashID = ((long?)record["NewAvatarAssetHashID"]) ?? 0;
		dal.BodyColorSetID = (long?)record["BodyColorSetID"];
		dal.PlayerAvatarTypeID = (byte?)record["PlayerAvatarTypeID"];
		dal.ScaleID = (int?)record["ScaleID"];
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static UserAvatarDAL Get(int id)
	{
		return RobloxDatabase.RobloxAvatars.Get("UserAvatars_GetUserAvatarByID", id, BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<UserAvatarDAL> GetOrCreate(long userId, byte? playerAvatarTypeId, int? scaleId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", userId),
			new SqlParameter("@PlayerAvatarTypeID", ((object)playerAvatarTypeId) ?? DBNull.Value),
			new SqlParameter("@ScaleID", ((object)scaleId) ?? DBNull.Value)
		};
		return RobloxDatabase.RobloxAvatars.GetOrCreate("UserAvatars_GetOrCreateUserAvatar", BuildDAL, queryParameters);
	}

	/// <summary>
	/// This method is intended to be used by migrators that need to iterate over UserAvatars table.
	/// There's no method in UserAvatar.cs for this.
	/// Call this DAL method directly, but use UserAvatar.MultiGet on the IDs that you get back.
	/// </summary>
	/// <param name="exclusiveStartId"></param>
	/// <param name="count"></param>
	/// <returns></returns>
	public static ICollection<int> GetUserAvatarIDs(int exclusiveStartId, int count)
	{
		if (exclusiveStartId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartID.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@ExclusiveStartID", exclusiveStartId),
			new SqlParameter("@Count", count)
		};
		return RobloxDatabase.RobloxAvatars.GetIDCollection<int>("UserAvatars_GetUserAvatarIDs", queryParameters);
	}

	internal static ICollection<UserAvatarDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxAvatars.MultiGet("UserAvatars_GetUserAvatarsByIDs", ids, BuildDAL);
	}
}
