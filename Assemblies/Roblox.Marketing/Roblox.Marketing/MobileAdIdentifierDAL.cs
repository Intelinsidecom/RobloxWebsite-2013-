using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class MobileAdIdentifierDAL
{
	internal int ID { get; set; }

	internal Guid DeviceID { get; set; }

	internal byte OperatingSystemTypeID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxMarketing.GetConnectionString();

	internal MobileAdIdentifierDAL()
	{
	}

	private static MobileAdIdentifierDAL GetDALFromReader(SqlDataReader reader)
	{
		MobileAdIdentifierDAL dal = new MobileAdIdentifierDAL
		{
			ID = (int)reader["ID"],
			DeviceID = (Guid)reader["DeviceID"],
			OperatingSystemTypeID = (byte)reader["OperatingSystemTypeID"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	private static MobileAdIdentifierDAL BuildDAL(SqlDataReader reader)
	{
		MobileAdIdentifierDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<MobileAdIdentifierDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<MobileAdIdentifierDAL> dals = new List<MobileAdIdentifierDAL>();
		while (reader.Read())
		{
			MobileAdIdentifierDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "MobileAdIdentifiers_DeleteMobileAdIdentifierByID", queryParameters));
	}

	internal static MobileAdIdentifierDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "MobileAdIdentifiers_GetMobileAdIdentifierByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@DeviceID", DeviceID),
			new SqlParameter("@OperatingSystemTypeID", OperatingSystemTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "MobileAdIdentifiers_InsertMobileAdIdentifier", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@DeviceID", DeviceID),
			new SqlParameter("@OperatingSystemTypeID", OperatingSystemTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "MobileAdIdentifiers_UpdateMobileAdIdentifierByID", queryParameters));
	}

	internal static ICollection<MobileAdIdentifierDAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "MobileAdIdentifiers_GetMobileAdIdentifiersByIDs"), ids, BuildDALCollection);
	}

	internal static MobileAdIdentifierDAL GetMobileAdIdentifierByDeviceIDOperatingSystemTypeID(Guid deviceId, byte operatingSystemTypeId)
	{
		if (deviceId == default(Guid))
		{
			return null;
		}
		if (operatingSystemTypeId == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@DeviceID", deviceId),
			new SqlParameter("@OperatingSystemTypeID", operatingSystemTypeId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "MobileAdIdentifiers_GetMobileAdIdentifierByDeviceIDAndOperatingSystemTypeID", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<MobileAdIdentifierDAL> GetOrCreateMobileAdIdentifier(Guid deviceId, byte operatingSystemTypeId)
	{
		if (deviceId == default(Guid))
		{
			return null;
		}
		if (operatingSystemTypeId == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@DeviceID", deviceId),
			new SqlParameter("@OperatingSystemTypeID", operatingSystemTypeId)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "MobileAdIdentifiers_GetOrCreateMobileAdIdentifier", queryParameters), BuildDAL);
	}
}
