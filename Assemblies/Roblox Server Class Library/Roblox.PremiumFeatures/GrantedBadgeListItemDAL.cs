using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

public class GrantedBadgeListItemDAL
{
	private long _ID;

	private byte _GrantedBadgeListID;

	private int _BadgeTypeID;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

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

	internal byte GrantedBadgeListID
	{
		get
		{
			return _GrantedBadgeListID;
		}
		set
		{
			_GrantedBadgeListID = value;
		}
	}

	internal int BadgeTypeID
	{
		get
		{
			return _BadgeTypeID;
		}
		set
		{
			_BadgeTypeID = value;
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

	private static string ConnectionString => RobloxDatabase.RobloxPremiumFeatures.GetConnectionString();

	internal GrantedBadgeListItemDAL()
	{
	}

	internal void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[GrantedBadgeListItems_DeleteGrantedBadgeListItemByID]", queryParameters));
	}

	internal void Insert()
	{
		if (_GrantedBadgeListID == 0)
		{
			throw new ApplicationException("Required value not specified: GrantedBadgeListID.");
		}
		if (_BadgeTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: BadgeTypeID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@GrantedBadgeListID", _GrantedBadgeListID));
		queryParameters.Add(new SqlParameter("@BadgeTypeID", _BadgeTypeID));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[GrantedBadgeListItems_InsertGrantedBadgeListItem]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	internal void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value was not specified: ID.");
		}
		if (_GrantedBadgeListID == 0)
		{
			throw new ApplicationException("Required value not specified: GrantedBadgeListID.");
		}
		if (_BadgeTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: BadgeTypeID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@GrantedBadgeListID", _GrantedBadgeListID));
		queryParameters.Add(new SqlParameter("@BadgeTypeID", _BadgeTypeID));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[GrantedBadgeListItems_UpdateGrantedBadgeListItemByID]", queryParameters));
	}

	internal static GrantedBadgeListItemDAL BuildDAL(SqlDataReader reader)
	{
		GrantedBadgeListItemDAL dal = new GrantedBadgeListItemDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.GrantedBadgeListID = (byte)reader["GrantedBadgeListID"];
			dal.BadgeTypeID = (int)reader["BadgeTypeID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static GrantedBadgeListItemDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[GrantedBadgeListItems_GetGrantedBadgeListItemByID]", queryParameters), BuildDAL);
	}

	internal static GrantedBadgeListItemDAL GetByGrantedBadgeListIDAndBadgeTypeID(byte grantedBadgeListId, int badgeTypeId)
	{
		if (grantedBadgeListId == 0)
		{
			return null;
		}
		if (badgeTypeId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@GrantedBadgeListID", grantedBadgeListId));
		queryParameters.Add(new SqlParameter("@BadgeTypeID", badgeTypeId));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[GrantedBadgeListItems_GetGrantedBadgeListItemByGrantedBadgeListIDAndBadgeTypeID]", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetGrantedBadgeListItemIDsByGrantedBadgeListID(byte grantedBadgeListId)
	{
		if (grantedBadgeListId == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@GrantedBadgeListID", grantedBadgeListId));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[GrantedBadgeListItems_GetGrantedBadgeListItemIDsByGrantedBadgeListID]", queryParameters));
	}
}
