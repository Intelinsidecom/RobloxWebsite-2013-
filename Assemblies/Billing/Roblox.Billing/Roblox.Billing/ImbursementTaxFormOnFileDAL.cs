using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class ImbursementTaxFormOnFileDAL
{
	internal int ID { get; set; }

	internal long UserID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.BillingConnectionString;

	internal ImbursementTaxFormOnFileDAL()
	{
	}

	private static ImbursementTaxFormOnFileDAL GetDALFromReader(SqlDataReader reader)
	{
		ImbursementTaxFormOnFileDAL dal = new ImbursementTaxFormOnFileDAL
		{
			ID = (int)reader["ID"],
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

	private static ImbursementTaxFormOnFileDAL BuildDAL(SqlDataReader reader)
	{
		ImbursementTaxFormOnFileDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<ImbursementTaxFormOnFileDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<ImbursementTaxFormOnFileDAL> dals = new List<ImbursementTaxFormOnFileDAL>();
		while (reader.Read())
		{
			ImbursementTaxFormOnFileDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "ImbursementTaxFormsOnFile_DeleteImbursementTaxFormsOnFileByID", queryParameters));
	}

	internal static ImbursementTaxFormOnFileDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ImbursementTaxFormsOnFile_GetImbursementTaxFormsOnFileByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "ImbursementTaxFormsOnFile_InsertImbursementTaxFormsOnFile", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "ImbursementTaxFormsOnFile_UpdateImbursementTaxFormsOnFileByID", queryParameters));
	}

	internal static ICollection<ImbursementTaxFormOnFileDAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "ImbursementTaxFormsOnFile_GetImbursementTaxFormsOnFileByIDs"), ids, BuildDALCollection);
	}

	public static ImbursementTaxFormOnFileDAL GetImbursementTaxFormOnFileByUserID(long userID)
	{
		if (userID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ImbursementTaxFormsOnFile_GetImbursementTaxFormsOnFileByUserID", queryParameters), BuildDAL);
	}
}
