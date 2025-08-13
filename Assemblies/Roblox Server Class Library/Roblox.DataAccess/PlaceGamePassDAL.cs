using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class PlaceGamePassDAL
{
	public long ID { get; set; }

	public long PassID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public long PlaceID { get; set; }

	public long ImageID { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxGamePasses.GetConnectionString();

	private static PlaceGamePassDAL BuildDAL(SqlDataReader reader)
	{
		PlaceGamePassDAL dal = new PlaceGamePassDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.PassID = (long)reader["PassID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.PlaceID = (long)reader["PlaceID"];
			dal.ImageID = (long)reader["ImageID"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@PassID", PassID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@ImageID", ImageID)
		};
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "PlaceGamePasses_InsertPlaceGamePass", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PassID", PassID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@ImageID", ImageID)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "PlaceGamePasses_UpdatePlaceGamePassByID", queryParameters));
	}

	public void Delete()
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "PlaceGamePasses_DeletePlaceGamePassByID", queryParameters));
	}

	public static PlaceGamePassDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "PlaceGamePasses_GetPlaceGamePassByID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetPlaceGamePassIDsByPassID(long passId, int startRowIndex, int maximumRows)
	{
		if (passId == 0L)
		{
			throw new ApplicationException("Required value not specified: passId.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@PassID", passId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "PlaceGamePasses_GetPlaceGamePassIDsByPassID_Paged", queryParameters));
	}

	public static ICollection<long> GetPlaceGamePassIDsByPlaceID(long placeId, int startRowIndex, int maximumRows)
	{
		if (placeId == 0L)
		{
			throw new ApplicationException("Required value not specified: placeId.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@PlaceId", placeId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "PlaceGamePasses_GetPlaceGamePassIDsByPlaceID_Paged", queryParameters));
	}

	public static int GetTotalNumberOfPlaceGamePassesByPlaceID(long placeId)
	{
		if (placeId == 0L)
		{
			throw new ApplicationException("Required value not specified: placeId.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PlaceID", placeId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "PlaceGamePasses_GetTotalNumberOfPlaceGamePassesByPlaceID", queryParameters));
	}

	public static int GetTotalNumberOfPlaceGamePassesByPassID(long passId)
	{
		if (passId == 0L)
		{
			throw new ApplicationException("Required value not specified: PassID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PlaceID", passId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(ConnectionString, "PlaceGamePasses_GetTotalNumberOfPlaceGamePassesByPassID", queryParameters));
	}
}
