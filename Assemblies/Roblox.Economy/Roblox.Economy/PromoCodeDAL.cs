using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

public class PromoCodeDAL
{
	internal int ID { get; set; }

	internal string Code { get; set; }

	internal int PremiumFeatureID { get; set; }

	internal DateTime StartDate { get; set; }

	internal DateTime EndDate { get; set; }

	internal bool IsEnabled { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Helper.DBConnectionString;

	private static PromoCodeDAL GetDALFromReader(SqlDataReader reader)
	{
		PromoCodeDAL dal = new PromoCodeDAL
		{
			ID = (int)reader["ID"],
			Code = (string)reader["Code"],
			PremiumFeatureID = (int)reader["PremiumFeatureID"],
			StartDate = (DateTime)reader["StartDate"],
			EndDate = (DateTime)reader["EndDate"],
			IsEnabled = (bool)reader["IsEnabled"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static PromoCodeDAL BuildDAL(SqlDataReader reader)
	{
		PromoCodeDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PromoCodeDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PromoCodeDAL> dals = new List<PromoCodeDAL>();
		while (reader.Read())
		{
			PromoCodeDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PromoCodes_DeletePromoCodeByID", queryParameters));
	}

	internal static PromoCodeDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PromoCodes_GetPromoCodeByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@Code", Code),
			new SqlParameter("@PremiumFeatureID", PremiumFeatureID),
			new SqlParameter("@StartDate", StartDate),
			new SqlParameter("@EndDate", EndDate),
			new SqlParameter("@IsEnabled", IsEnabled),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PromoCodes_InsertPromoCode", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Code", Code),
			new SqlParameter("@PremiumFeatureID", PremiumFeatureID),
			new SqlParameter("@StartDate", StartDate),
			new SqlParameter("@EndDate", EndDate),
			new SqlParameter("@IsEnabled", IsEnabled),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PromoCodes_UpdatePromoCodeByID", queryParameters));
	}

	internal static ICollection<PromoCodeDAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "PromoCodes_GetPromoCodesByIDs"), ids, BuildDALCollection);
	}

	internal static PromoCodeDAL GetPromoCodeByCode(string code)
	{
		if (string.IsNullOrEmpty(code))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Code", code)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PromoCodes_GetPromoCodeByCode", queryParameters), BuildDAL);
	}

	internal static ICollection<int> GetPromoCodeIDsPaged(int startRow, int maxRows)
	{
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRow));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString, "PromoCodes_GetPromoCodes_Paged", queryParameters));
	}

	internal static int GetTotalNumberOfPromoCodes()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "PromoCodes_GetTotalNumberOfPromoCodes", queryParameters));
	}
}
