using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Outfits;

public class OutfitDAL
{
	public long ID { get; set; }

	public long AssetHashID { get; set; }

	public long BodyColorSetID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public int? ScaleID { get; set; }

	public byte? PlayerAvatarTypeID { get; set; }

	private static string _DbConnectionString => RobloxDatabase.RobloxAvatars.GetConnectionString();

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "Outfits_DeleteOutfitByID", queryParameters));
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@AssetHashID", AssetHashID),
			new SqlParameter("@BodyColorSetID", BodyColorSetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@ScaleID", ScaleID),
			new SqlParameter("@PlayerAvatarTypeID", PlayerAvatarTypeID)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "Outfits_InsertOutfit", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AssetHashID", AssetHashID),
			new SqlParameter("@BodyColorSetID", BodyColorSetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@ScaleID", ScaleID),
			new SqlParameter("@PlayerAvatarTypeID", PlayerAvatarTypeID)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "Outfits_UpdateOutfitByID", queryParameters));
	}

	internal static OutfitDAL GetByAssetHashID(long assetHashId)
	{
		if (assetHashId == 0L)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AssetHashID", assetHashId);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[Outfits_GetOutfitByAssetHashID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<OutfitDAL> GetOrCreateOutfit(long assetHashId, long bodyColorSetId, int? scaleId, byte? playerAvatarTypeId)
	{
		if (assetHashId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@AssetHashID", assetHashId),
			new SqlParameter("@BodyColorSetID", bodyColorSetId),
			new SqlParameter("@ScaleID", scaleId),
			new SqlParameter("@PlayerAvatarTypeID", playerAvatarTypeId)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "Outfits_GetOrCreateOutfit", queryParameters), BuildDAL);
	}

	private static OutfitDAL GetDALFromReader(SqlDataReader reader)
	{
		OutfitDAL dal = new OutfitDAL();
		dal.ID = (long)reader["ID"];
		dal.AssetHashID = (long)reader["AssetHashID"];
		dal.BodyColorSetID = (long)reader["BodyColorSetID"];
		dal.Created = (DateTime)reader["Created"];
		dal.Updated = (DateTime)reader["Updated"];
		if (reader["PlayerAvatarTypeID"].Equals(DBNull.Value))
		{
			dal.PlayerAvatarTypeID = null;
		}
		else
		{
			dal.PlayerAvatarTypeID = (byte)reader["PlayerAvatarTypeID"];
		}
		if (reader["ScaleID"].Equals(DBNull.Value))
		{
			dal.ScaleID = null;
		}
		else
		{
			dal.ScaleID = (int)reader["ScaleID"];
		}
		return dal;
	}

	private static OutfitDAL BuildDAL(SqlDataReader reader)
	{
		OutfitDAL dal = new OutfitDAL();
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

	internal static OutfitDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "Outfits_GetOutfitByID", queryParameters), BuildDAL);
	}

	private static List<OutfitDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<OutfitDAL> dals = new List<OutfitDAL>();
		while (reader.Read())
		{
			OutfitDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal static ICollection<OutfitDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "Outfits_GetOutfitsByIDs"), ids, BuildDALCollection);
	}
}
