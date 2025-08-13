using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

public class PromoCodeRedemptionDAL
{
	internal long ID { get; set; }

	internal int PromoCodeID { get; set; }

	internal long UserID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Helper.DBConnectionString;

	private static PromoCodeRedemptionDAL GetDALFromReader(SqlDataReader reader)
	{
		PromoCodeRedemptionDAL dal = new PromoCodeRedemptionDAL
		{
			ID = (long)reader["ID"],
			PromoCodeID = (int)reader["PromoCodeID"],
			UserID = Convert.ToInt64(reader["UserID"]),
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static PromoCodeRedemptionDAL BuildDAL(SqlDataReader reader)
	{
		PromoCodeRedemptionDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PromoCodeRedemptionDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PromoCodeRedemptionDAL> dals = new List<PromoCodeRedemptionDAL>();
		while (reader.Read())
		{
			PromoCodeRedemptionDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PromoCodeRedemptionsV2_DeletePromoCodeRedemptionByID", queryParameters));
	}

	internal static PromoCodeRedemptionDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PromoCodeRedemptionsV2_GetPromoCodeRedemptionByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@PromoCodeID", PromoCodeID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PromoCodeRedemptionsV2_InsertPromoCodeRedemption", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PromoCodeID", PromoCodeID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PromoCodeRedemptionsV2_UpdatePromoCodeRedemptionByID", queryParameters));
	}

	internal static ICollection<PromoCodeRedemptionDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "PromoCodeRedemptionsV2_GetPromoCodeRedemptionsByIDs"), ids, BuildDALCollection);
	}

	internal static PromoCodeRedemptionDAL GetPromoCodeRedemptionByPromoCodeIDAndUserID(int promoCodeId, long userId)
	{
		if (promoCodeId == 0)
		{
			return null;
		}
		if (userId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@PromoCodeID", promoCodeId),
			new SqlParameter("@UserID", userId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PromoCodeRedemptionsV2_GetPromoCodeRedemptionByPromoCodeIDAndUserID", queryParameters), BuildDAL);
	}

	internal static long GetTotalNumberOfPromoCodeRedemptionsByPromoCodeID(int promoCodeId)
	{
		if (promoCodeId == 0)
		{
			throw new ApplicationException("Required value not specified: promoCodeID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PromoCodeID", promoCodeId));
		return EntityHelper.GetDataCount<long>(new DbInfo(_DbConnectionString, "PromoCodeRedemptionsV2_GetTotalNumberOfPromoCodeRedemptionsByPromoCodeID", queryParameters));
	}
}
