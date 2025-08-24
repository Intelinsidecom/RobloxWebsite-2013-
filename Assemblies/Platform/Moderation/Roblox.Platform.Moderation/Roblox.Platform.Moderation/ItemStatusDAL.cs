using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public class ItemStatusDAL
{
	private long _ID;

	private byte _ItemTypeID;

	private long _ItemTargetID;

	private byte _StatusTypeID;

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

	internal byte ItemTypeID
	{
		get
		{
			return _ItemTypeID;
		}
		set
		{
			_ItemTypeID = value;
		}
	}

	internal long ItemTargetID
	{
		get
		{
			return _ItemTargetID;
		}
		set
		{
			_ItemTargetID = value;
		}
	}

	public byte StatusTypeID
	{
		get
		{
			return _StatusTypeID;
		}
		internal set
		{
			_StatusTypeID = value;
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

	internal ItemStatusDAL()
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "ItemStatuses_DeleteItemStatusByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ItemTypeID", ItemTypeID),
			new SqlParameter("@ItemTargetID", ItemTargetID),
			new SqlParameter("@StatusTypeID", StatusTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "ItemStatuses_InsertItemStatus", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ItemTypeID", ItemTypeID),
			new SqlParameter("@ItemTargetID", ItemTargetID),
			new SqlParameter("@StatusTypeID", StatusTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "ItemStatuses_UpdateItemStatusByID", queryParameters));
	}

	private static ItemStatusDAL BuildDAL(SqlDataReader reader)
	{
		ItemStatusDAL dal = new ItemStatusDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.ItemTypeID = (byte)reader["ItemTypeID"];
			dal.ItemTargetID = (long)reader["ItemTargetID"];
			dal.StatusTypeID = (byte)reader["StatusTypeID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static ItemStatusDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ItemStatuses_GetItemStatusByID", queryParameters), BuildDAL);
	}

	public static ItemStatusDAL GetByItemTypeIdAndItemTargetId(byte itemTypeId, long itemTargetId)
	{
		if (itemTypeId == 0)
		{
			return null;
		}
		if (itemTargetId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ItemTypeID", itemTypeId),
			new SqlParameter("@ItemTargetID", itemTargetId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ItemStatuses_GetItemStatusByItemTypeIDAndItemTargetID", queryParameters), BuildDAL);
	}
}
