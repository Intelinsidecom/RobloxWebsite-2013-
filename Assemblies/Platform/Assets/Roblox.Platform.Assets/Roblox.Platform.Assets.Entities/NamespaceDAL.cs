using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Platform.Assets.Properties;

namespace Roblox.Platform.Assets.Entities;

internal class NamespaceDAL
{
	internal long ID { get; set; }

	internal byte NamespaceTypeID { get; set; }

	internal long NamespaceTargetID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.DbConnectionString_RobloxAssetNamespaces;

	internal NamespaceDAL()
	{
	}

	private static NamespaceDAL BuildDAL(SqlDataReader reader)
	{
		NamespaceDAL dal = new NamespaceDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.NamespaceTypeID = (byte)reader["NamespaceTypeID"];
			dal.NamespaceTargetID = (long)reader["NamespaceTargetID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "Namespaces_DeleteNamespaceByID", queryParameters));
	}

	internal static NamespaceDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "Namespaces_GetNamespaceByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@NamespaceTypeID", NamespaceTypeID),
			new SqlParameter("@NamespaceTargetID", NamespaceTargetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "Namespaces_InsertNamespace", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@NamespaceTypeID", NamespaceTypeID),
			new SqlParameter("@NamespaceTargetID", NamespaceTargetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "Namespaces_UpdateNamespaceByID", queryParameters));
	}

	internal static NamespaceDAL GetNamespaceByNamespaceTypeIDNamespaceTargetID(byte namespaceTypeID, long namespaceTargetID)
	{
		if (namespaceTypeID == 0)
		{
			return null;
		}
		if (namespaceTargetID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@NamespaceTypeID", namespaceTypeID),
			new SqlParameter("@NamespaceTargetID", namespaceTargetID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "Namespaces_GetNamespaceByNamespaceTypeIDNamespaceTargetID", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<NamespaceDAL> GetOrCreate(byte namespaceTypeID, long namespaceTargetID)
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@NamespaceTypeID", namespaceTypeID),
			new SqlParameter("@NamespaceTargetID", namespaceTargetID)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "[dbo].[Namespaces_GetOrCreateNamespace]", queryParameters), BuildDAL);
	}
}
