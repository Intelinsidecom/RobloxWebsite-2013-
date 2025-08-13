using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Outfits;

public class UserOutfitDAL
{
	public long ID { get; set; }

	public long OutfitID { get; set; }

	public long UserID { get; set; }

	public string Name { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public bool IsEditable { get; set; }

	private static string _DbConnectionString => RobloxDatabase.RobloxAvatars.GetConnectionString();

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "UserOutfits_DeleteUserOutfitByID", queryParameters));
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@OutfitID", OutfitID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@IsEditable", IsEditable)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "UserOutfits_InsertUserOutfit", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@OutfitID", OutfitID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@IsEditable", IsEditable)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "UserOutfits_UpdateUserOutfitByID", queryParameters));
	}

	public static ICollection<long> GetUserOutfitIDsByUserIDPaged(long userId, int startRowIndex, int maxRows)
	{
		if (userId == 0L || startRowIndex == 0 || maxRows == 0)
		{
			return (ICollection<long>)Enumerable.Empty<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maxRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "UserOutfits_GetUserOutfitIDsByUserID_Paged", queryParameters));
	}

	public static ICollection<long> GetUserOutfitIDsByUserIDIsEditablePaged(long userId, bool isEditable, int startRowIndex, int maxRows)
	{
		if (userId == 0L || startRowIndex == 0 || maxRows == 0)
		{
			return (ICollection<long>)Enumerable.Empty<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@IsEditable", isEditable),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maxRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "UserOutfits_GetUserOutfitIDsByUserIDIsEditable_Paged", queryParameters));
	}

	public static int GetTotalNumberOfUserOutfitsByUserID(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "[dbo].[UserOutfits_GetTotalNumberOfUserOutfitsByUserID]", queryParameters));
	}

	public static int GetTotalNumberOfEditableUserOutfitsByUserID(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "[dbo].[UserOutfits_GetTotalNumberOfEditableUserOutfitsByUserID]", queryParameters));
	}

	private static UserOutfitDAL GetDALFromReader(SqlDataReader reader)
	{
		UserOutfitDAL dal = new UserOutfitDAL();
		dal.ID = (long)reader["ID"];
		dal.OutfitID = (long)reader["OutfitID"];
		dal.UserID = Convert.ToInt64(reader["UserID"]);
		dal.Name = (string)reader["Name"];
		dal.Created = (DateTime)reader["Created"];
		dal.Updated = (DateTime)reader["Updated"];
		if (reader["IsEditable"].Equals(DBNull.Value))
		{
			dal.IsEditable = true;
		}
		else
		{
			dal.IsEditable = (bool)reader["IsEditable"];
		}
		return dal;
	}

	private static UserOutfitDAL BuildDAL(SqlDataReader reader)
	{
		UserOutfitDAL dal = new UserOutfitDAL();
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static UserOutfitDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "UserOutfits_GetUserOutfitByID", queryParameters), BuildDAL);
	}

	private static List<UserOutfitDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<UserOutfitDAL> dals = new List<UserOutfitDAL>();
		while (reader.Read())
		{
			UserOutfitDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal static ICollection<UserOutfitDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "UserOutfits_GetUserOutfitsByIDs"), ids, BuildDALCollection);
	}
}
