using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Marketing.Core.Entities;

internal class TakeoverContentItemDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal int TakeoverID { get; set; }

	internal byte ContentItemTypeID { get; set; }

	internal long ContentItemTargetID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static TakeoverContentItemDAL BuildDAL(IDictionary<string, object> record)
	{
		return new TakeoverContentItemDAL
		{
			ID = (int)record["ID"],
			TakeoverID = (int)record["TakeoverID"],
			ContentItemTypeID = (byte)record["ContentItemTypeID"],
			ContentItemTargetID = (long)record["ContentItemTargetID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxMarketing.Delete("TakeoverContentItems_DeleteTakeoverContentItemByID", ID);
	}

	internal static TakeoverContentItemDAL Get(int id)
	{
		return RobloxDatabase.RobloxMarketing.Get("TakeoverContentItems_GetTakeoverContentItemByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@TakeoverID", TakeoverID),
			new SqlParameter("@ContentItemTypeID", ContentItemTypeID),
			new SqlParameter("@ContentItemTargetID", ContentItemTargetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("TakeoverContentItems_InsertTakeoverContentItem", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@TakeoverID", TakeoverID),
			new SqlParameter("@ContentItemTypeID", ContentItemTypeID),
			new SqlParameter("@ContentItemTargetID", ContentItemTargetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxMarketing.Update("TakeoverContentItems_UpdateTakeoverContentItemByID", queryParameters);
	}

	internal static ICollection<TakeoverContentItemDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxMarketing.MultiGet("TakeoverContentItems_GetTakeoverContentItemsByIDs", ids, BuildDAL);
	}

	internal static ICollection<int> GetTakeoverContentItemIDsByTakeoverIDPaged(int takeoverID, long startRowIndex, long maximumRows)
	{
		if (takeoverID == 0)
		{
			throw new ArgumentException("Parameter 'takeoverID' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@TakeoverID", takeoverID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("TakeoverContentItems_GetTakeoverContentItemIDsByTakeoverID_Paged", queryParameters);
	}

	internal static long GetTotalNumberOfTakeoverContentItemsByTakeoverID(int takeoverID)
	{
		if (takeoverID == 0)
		{
			throw new ArgumentException("Parameter 'takeoverID' cannot be null, empty or the default value.");
		}
		(new SqlParameter[1])[0] = new SqlParameter("@TakeoverID", takeoverID);
		return RobloxDatabase.RobloxMarketing.GetCount<long>("TakeoverContentItems_GetTotalNumberOfTakeoverContentItemsByTakeoverID", Array.Empty<SqlParameter>());
	}

	internal static ICollection<int> GetTakeoverContentItemIDsByContentItemTypeIDAndContentItemTargetIDPaged(byte contentItemTypeID, long contentItemTargetID, long startRowIndex, long maximumRows)
	{
		if (contentItemTypeID == 0)
		{
			throw new ArgumentException("Parameter 'contentItemTypeID' cannot be null, empty or the default value.");
		}
		if (contentItemTargetID == 0L)
		{
			throw new ArgumentException("Parameter 'contentItemTargetID' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ContentItemTypeID", contentItemTypeID),
			new SqlParameter("@ContentItemTargetID", contentItemTargetID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("TakeoverContentItems_GetTakeoverContentItemIDsByContentItemTypeIDAndContentItemTargetID_Paged", queryParameters);
	}

	internal static long GetTotalNumberOfTakeoverContentItemsByContentItemTypeIDAndContentItemTargetID(byte contentItemTypeID, long contentItemTargetID)
	{
		if (contentItemTypeID == 0)
		{
			throw new ArgumentException("Parameter 'contentItemTypeID' cannot be null, empty or the default value.");
		}
		if (contentItemTargetID == 0L)
		{
			throw new ArgumentException("Parameter 'contentItemTargetID' cannot be null, empty or the default value.");
		}
		_ = new SqlParameter[2]
		{
			new SqlParameter("@ContentItemTypeID", contentItemTypeID),
			new SqlParameter("@ContentItemTargetID", contentItemTargetID)
		};
		return RobloxDatabase.RobloxMarketing.GetCount<long>("TakeoverContentItems_GetTotalNumberOfTakeoverContentItemsByContentItemTypeIDAndContentItemTargetID", Array.Empty<SqlParameter>());
	}

	internal static TakeoverContentItemDAL GetTakeoverContentItemByTakeoverIDContentItemTypeIDAndContentItemTargetID(int takeoverID, byte contentItemTypeID, long contentItemTargetID)
	{
		if (takeoverID == 0)
		{
			return null;
		}
		if (contentItemTypeID == 0)
		{
			return null;
		}
		if (contentItemTargetID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@TakeoverID", takeoverID),
			new SqlParameter("@ContentItemTypeID", contentItemTypeID),
			new SqlParameter("@ContentItemTargetID", contentItemTargetID)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("TakeoverContentItems_GetTakeoverContentItemByTakeoverIDContentItemTypeIDAndContentItemTargetID", BuildDAL, queryParameters);
	}
}
