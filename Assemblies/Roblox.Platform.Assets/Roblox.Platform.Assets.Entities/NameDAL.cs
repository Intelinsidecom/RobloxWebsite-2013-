using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Assets.Entities;

internal class NameDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAssetNamespaces;

	internal long ID { get; set; }

	internal long NamespaceID { get; set; }

	internal string Name { get; set; }

	internal long AssetID { get; set; }

	internal int? AssetVersion { get; set; }

	internal byte? NameTypeID { get; set; }

	internal long? NameTargetID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static NameDAL BuildDAL(IDictionary<string, object> record)
	{
		return new NameDAL
		{
			ID = (long)record["ID"],
			NamespaceID = (long)record["NamespaceID"],
			Name = (string)record["Name"],
			AssetID = (long)record["AssetID"],
			AssetVersion = (int?)record["AssetVersion"],
			NameTypeID = (byte?)record["NameTypeID"],
			NameTargetID = (long?)record["NameTargetID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAssetNamespaces.Delete("Names_DeleteNameByID", ID);
	}

	internal static NameDAL Get(long id)
	{
		return RobloxDatabase.RobloxAssetNamespaces.Get("Names_GetNameByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@NamespaceID", NamespaceID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@AssetVersion", AssetVersion.HasValue ? ((object)AssetVersion) : DBNull.Value),
			new SqlParameter("@NameTypeID", NameTypeID.HasValue ? ((object)NameTypeID) : DBNull.Value),
			new SqlParameter("@NameTargetID", NameTargetID.HasValue ? ((object)NameTargetID) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAssetNamespaces.Insert<long>("Names_InsertName", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@NamespaceID", NamespaceID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@AssetVersion", AssetVersion.HasValue ? ((object)AssetVersion) : DBNull.Value),
			new SqlParameter("@NameTypeID", NameTypeID.HasValue ? ((object)NameTypeID) : DBNull.Value),
			new SqlParameter("@NameTargetID", NameTargetID.HasValue ? ((object)NameTargetID) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAssetNamespaces.Update("Names_UpdateNameByID", queryParameters);
	}

	internal static ICollection<NameDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAssetNamespaces.MultiGet("Names_GetNamesByIDs", ids, BuildDAL);
	}

	internal static NameDAL GetNameByNamespaceIDAndName(long namespaceID, string name)
	{
		if (namespaceID == 0L)
		{
			return null;
		}
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@NamespaceID", namespaceID),
			new SqlParameter("@Name", name)
		};
		return RobloxDatabase.RobloxAssetNamespaces.Lookup("Names_GetNameByNamespaceIDName", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetNameIDsByNamespaceIDPaged(long namespaceID, long startRowIndex, long maximumRows)
	{
		if (namespaceID == 0L)
		{
			throw new ArgumentException("Parameter 'namespaceID' cannot be null, empty or the default value.");
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
			new SqlParameter("@NamespaceID", namespaceID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxAssetNamespaces.GetIDCollection<long>("Names_GetNameIDsByNamespaceID_Paged", queryParameters);
	}

	internal static int GetTotalNumberOfNamesByNamespaceID(long namespaceID)
	{
		if (namespaceID == 0L)
		{
			throw new ArgumentException("Parameter 'namespaceID' cannot be null, empty or the default value.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@NamespaceID", namespaceID)
		};
		return RobloxDatabase.RobloxAssetNamespaces.GetCount<int>("Names_GetTotalNumberOfNamesByNamespaceID", queryParameters);
	}

	internal static ICollection<long> GetNameIDsByNamespaceIDNameTypeIDAndNameTargetIDPaged(long namespaceID, byte? nameTypeID, long? nameTargetID, long startRowIndex, long maximumRows)
	{
		if (namespaceID == 0L)
		{
			throw new ArgumentException("Parameter 'namespaceID' cannot be null, empty or the default value.");
		}
		if (nameTypeID == 0)
		{
			throw new ArgumentException("Parameter 'nameTypeID' cannot be null, empty or the default value.");
		}
		if (nameTargetID == 0)
		{
			throw new ArgumentException("Parameter 'nameTargetID' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@NamespaceID", namespaceID),
			new SqlParameter("@NameTypeID", nameTypeID.HasValue ? ((object)nameTypeID) : DBNull.Value),
			new SqlParameter("@NameTargetID", nameTargetID.HasValue ? ((object)nameTargetID) : DBNull.Value),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxAssetNamespaces.GetIDCollection<long>("Names_GetNameIDsByNamespaceIDNameTypeIDAndNameTargetID_Paged", queryParameters);
	}

	internal static long GetTotalNumberOfNamesByNamespaceIDNameTypeIDAndNameTargetID(long namespaceID, byte? nameTypeID, long? nameTargetID)
	{
		if (namespaceID == 0L)
		{
			throw new ArgumentException("Parameter 'namespaceID' cannot be null, empty or the default value.");
		}
		if (nameTypeID == 0)
		{
			throw new ArgumentException("Parameter 'nameTypeID' cannot be null, empty or the default value.");
		}
		if (nameTargetID == 0)
		{
			throw new ArgumentException("Parameter 'nameTargetID' cannot be null, empty or the default value.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@NamespaceID", namespaceID),
			new SqlParameter("@NameTypeID", nameTypeID.HasValue ? ((object)nameTypeID) : DBNull.Value),
			new SqlParameter("@NameTargetID", nameTargetID.HasValue ? ((object)nameTargetID) : DBNull.Value)
		};
		return RobloxDatabase.RobloxAssetNamespaces.GetCount<long>("Names_GetTotalNumberOfNamesByNamespaceIDNameTypeIDAndNameTargetID", queryParameters);
	}
}
