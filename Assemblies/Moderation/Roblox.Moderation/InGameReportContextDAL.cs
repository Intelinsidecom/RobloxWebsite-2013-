using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public class InGameReportContextDAL
{
	private long _ID;

	private long _PlaceID;

	private long _UniverseID;

	private Guid _GameInstanceID;

	private DateTime _Created;

	private DateTime _Updated;

	internal long ID
	{
		get
		{
			return _ID;
		}
		set
		{
			_ID = value;
		}
	}

	internal long PlaceID
	{
		get
		{
			return _PlaceID;
		}
		set
		{
			_PlaceID = value;
		}
	}

	internal long UniverseID
	{
		get
		{
			return _UniverseID;
		}
		set
		{
			_UniverseID = value;
		}
	}

	internal Guid GameInstanceID
	{
		get
		{
			return _GameInstanceID;
		}
		set
		{
			_GameInstanceID = value;
		}
	}

	internal DateTime Created
	{
		get
		{
			return _Created;
		}
		set
		{
			_Created = value;
		}
	}

	internal DateTime Updated
	{
		get
		{
			return _Updated;
		}
		set
		{
			_Updated = value;
		}
	}

	private static string _DbConnectionString => Settings.Default.dbConnectionString_RobloxModeration;

	internal InGameReportContextDAL()
	{
	}

	internal void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "InGameReportContexts_DeleteInGameReportContextByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@GameInstanceID", GameInstanceID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "InGameReportContexts_InsertInGameReportContext", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@PlaceID", PlaceID),
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@GameInstanceID", GameInstanceID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "InGameReportContexts_UpdateInGameReportContextByID", queryParameters));
	}

	private static InGameReportContextDAL BuildDAL(SqlDataReader reader)
	{
		InGameReportContextDAL dal = new InGameReportContextDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.PlaceID = (long)reader["PlaceID"];
			dal.UniverseID = (long)reader["UniverseID"];
			dal.GameInstanceID = (Guid)reader["GameInstanceID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static InGameReportContextDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "InGameReportContexts_GetInGameReportContextByID", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<InGameReportContextDAL> GetOrCreate(long placeID, long universeID, Guid gameinstanceID)
	{
		if (placeID == 0L)
		{
			throw new ApplicationException("Required value not specified: Place ID");
		}
		if (universeID == 0L)
		{
			throw new ApplicationException("Required value not specified: Universe ID");
		}
		if (gameinstanceID == default(Guid))
		{
			throw new ApplicationException("Required value not specified: Gameinstance ID");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PlaceID", placeID));
		queryParameters.Add(new SqlParameter("@UniverseID", universeID));
		queryParameters.Add(new SqlParameter("@GameinstanceID", gameinstanceID));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "InGameReportContexts_GetOrCreateInGameReportContextByUniverseIDAndPlaceIDAndGameInstanceID", queryParameters), BuildDAL);
	}
}
