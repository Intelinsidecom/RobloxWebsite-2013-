using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using Roblox.Data;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class UserDAL
{
	public enum SelectFilter
	{
		AccountID,
		ID
	}

	private const RobloxDatabase _Database = RobloxDatabase.RobloxUsers;

	private long _ID;

	private long _AccountID;

	private byte _AgeBracket = 1;

	private bool _UseSuperSafeConversationMode;

	private bool _UseSuperSafePrivacyMode;

	private DateTime _Created = DateTime.MinValue;

	private bool _AgeBracketIsLocked;

	private bool _ConversationSafetyModeIsLocked;

	private bool _PrivacySafetyModeIsLocked;

	private long? _AssociatedEntityID;

	private CreatorType _AssociatedEntityTypeID = CreatorType.User;

	private DateTime? _Updated;

	[OptionalField]
	public DateTime? BirthDate;

	[OptionalField]
	public byte? GenderTypeId;

	public long ID
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

	public long AccountID
	{
		get
		{
			return _AccountID;
		}
		set
		{
			_AccountID = value;
		}
	}

	public byte AgeBracket
	{
		get
		{
			return _AgeBracket;
		}
		set
		{
			_AgeBracket = value;
		}
	}

	public bool UseSuperSafeConversationMode
	{
		get
		{
			return _UseSuperSafeConversationMode;
		}
		set
		{
			_UseSuperSafeConversationMode = value;
		}
	}

	public bool UseSuperSafePrivacyMode
	{
		get
		{
			return _UseSuperSafePrivacyMode;
		}
		set
		{
			_UseSuperSafePrivacyMode = value;
		}
	}

	public DateTime Created
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

	public bool AgeBracketIsLocked
	{
		get
		{
			return _AgeBracketIsLocked;
		}
		set
		{
			_AgeBracketIsLocked = value;
		}
	}

	public bool ConversationSafetyModeIsLocked
	{
		get
		{
			return _ConversationSafetyModeIsLocked;
		}
		set
		{
			_ConversationSafetyModeIsLocked = value;
		}
	}

	public bool PrivacySafetyModeIsLocked
	{
		get
		{
			return _PrivacySafetyModeIsLocked;
		}
		set
		{
			_PrivacySafetyModeIsLocked = value;
		}
	}

	public long? AssociatedEntityID
	{
		get
		{
			return _AssociatedEntityID;
		}
		set
		{
			_AssociatedEntityID = value;
		}
	}

	public CreatorType AssociatedEntityTypeID
	{
		get
		{
			return _AssociatedEntityTypeID;
		}
		set
		{
			_AssociatedEntityTypeID = value;
		}
	}

	public DateTime? Updated
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

	private static string ConnectionString => RobloxDatabase.RobloxUsers.GetConnectionString();

	private static UserDAL BuildDAL(SqlDataReader reader)
	{
		UserDAL dal = new UserDAL();
		while (reader.Read())
		{
			dal.ID = Convert.ToInt64(reader["ID"]);
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.AgeBracket = (byte)(reader["AgeBracket"].Equals(DBNull.Value) ? 1 : ((byte)reader["AgeBracket"]));
			dal.UseSuperSafeConversationMode = (bool)reader["UseSuperSafeConversationMode"];
			dal.UseSuperSafePrivacyMode = (bool)reader["UseSuperSafePrivacyMode"];
			dal.Created = (DateTime)reader["Created"];
			dal.AgeBracketIsLocked = (bool)reader["AgeBracketIsLocked"];
			dal.ConversationSafetyModeIsLocked = (bool)reader["ConversationSafetyModeIsLocked"];
			dal.PrivacySafetyModeIsLocked = (bool)reader["PrivacySafetyModeIsLocked"];
			dal.AssociatedEntityID = (reader["AssociatedEntityID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["AssociatedEntityID"])));
			dal.AssociatedEntityTypeID = (CreatorType)(byte)reader["AssociatedEntityTypeID"];
			dal.BirthDate = (reader["BirthDate"].Equals(DBNull.Value) ? null : ((DateTime?)reader["BirthDate"]));
			dal.GenderTypeId = (reader["GenderTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["GenderTypeID"]));
			dal.Updated = reader["Updated"] as DateTime?;
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static UserDAL BuildDAL(IDictionary<string, object> record)
	{
		return new UserDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			AccountID = Convert.ToInt64(record["AccountID"]),
			AgeBracket = (((byte?)record["AgeBracket"]) ?? 1),
			UseSuperSafeConversationMode = (bool)record["UseSuperSafeConversationMode"],
			UseSuperSafePrivacyMode = (bool)record["UseSuperSafePrivacyMode"],
			Created = (DateTime)record["Created"],
			AgeBracketIsLocked = (bool)record["AgeBracketIsLocked"],
			ConversationSafetyModeIsLocked = (bool)record["ConversationSafetyModeIsLocked"],
			PrivacySafetyModeIsLocked = (bool)record["PrivacySafetyModeIsLocked"],
			AssociatedEntityID = ((record["AssociatedEntityID"] != null) ? new long?(Convert.ToInt64(record["AssociatedEntityID"])) : null),
			AssociatedEntityTypeID = (CreatorType)(byte)record["AssociatedEntityTypeID"],
			BirthDate = (DateTime?)record["BirthDate"],
			GenderTypeId = (byte?)record["GenderTypeID"],
			Updated = ((record["Updated"] == null) ? new DateTime?(DateTime.Now) : (record["Updated"] as DateTime?))
		};
	}

	public static UserDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		using DbHelper dbHelper = DBHelperFactory.GetDBHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[UsersV2_GetUserV2ByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static UserDAL GetByAccountID(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(ConnectionString);
		dbHelper.SQLParameters.AddWithValue("@AccountID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[UsersV2_GetUserV2ByAccountID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static UserDAL Get(SelectFilter selectFilter, long id)
	{
		return selectFilter switch
		{
			SelectFilter.ID => Get(id), 
			SelectFilter.AccountID => GetByAccountID(id), 
			_ => throw new ApplicationException($"Unknown SelectFilter: {selectFilter}."), 
		};
	}

	internal static ICollection<UserDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxUsers.MultiGet("UsersV2_GetUserV2sByIDs", ids, BuildDAL);
	}
}
