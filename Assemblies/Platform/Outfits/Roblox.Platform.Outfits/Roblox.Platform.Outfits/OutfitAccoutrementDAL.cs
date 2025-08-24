using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Outfits.Properties;

namespace Roblox.Outfits;

public class OutfitAccoutrementDAL
{
	public long ID { get; set; }

	public long OutfitID { get; set; }

	public long AssetID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.RobloxOutfits;

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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "OutfitAccoutrements_DeleteOutfitAccoutrementByID", queryParameters));
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@OutfitID", OutfitID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "OutfitAccoutrements_InsertOutfitAccoutrement", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@OutfitID", OutfitID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "OutfitAccoutrements_UpdateOutfitAccoutrementByID", queryParameters));
	}

	public static ICollection<long> GetOutfitAccoutrementIDsByOutfitIDPaged(long outfitId, int startRowIndex, int maxRows)
	{
		if (outfitId == 0L)
		{
			throw new ApplicationException("Required value not specified: OutfitID.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: MaxRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@OutfitID", outfitId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maxRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "OutfitAccoutrements_GetOutfitAccoutrementIDsByOutfitID_Paged", queryParameters));
	}

	public static int GetTotalNumberOfOutfitAccoutrementsByOutfitID(long outfitId)
	{
		if (outfitId == 0L)
		{
			throw new ApplicationException("Required value not specified: OutfitID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@OutfitID", outfitId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "[dbo].[OutfitAccoutrements_GetTotalNumberOfOutfitAccoutrementsByOutfitID]", queryParameters));
	}

	private static OutfitAccoutrementDAL BuildDAL(SqlDataReader reader)
	{
		OutfitAccoutrementDAL dal = new OutfitAccoutrementDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.OutfitID = (long)reader["OutfitID"];
			dal.AssetID = (long)reader["AssetID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static OutfitAccoutrementDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "OutfitAccoutrements_GetOutfitAccoutrementByID", queryParameters), BuildDAL);
	}
}
