using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class ImbursementAuthorizationDAL
{
	private int _ID;

	private int _ImbursementID;

	private bool _CSAuth;

	private long? _CSID;

	private bool _BursarAuth;

	private long? _BursarID;

	private string _Notes;

	private DateTime _Created;

	private DateTime _Updated;

	internal int ID
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

	internal int ImbursementID
	{
		get
		{
			return _ImbursementID;
		}
		set
		{
			_ImbursementID = value;
		}
	}

	internal bool CSAuth
	{
		get
		{
			return _CSAuth;
		}
		set
		{
			_CSAuth = value;
		}
	}

	internal long? CSID
	{
		get
		{
			return _CSID;
		}
		set
		{
			_CSID = value;
		}
	}

	internal bool BursarAuth
	{
		get
		{
			return _BursarAuth;
		}
		set
		{
			_BursarAuth = value;
		}
	}

	internal long? BursarID
	{
		get
		{
			return _BursarID;
		}
		set
		{
			_BursarID = value;
		}
	}

	internal string Notes
	{
		get
		{
			return _Notes;
		}
		set
		{
			_Notes = value;
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

	private static string _DbConnectionString => Settings.Default.BillingConnectionString;

	internal void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "ImbursementAuthorizations_DeleteImbursementAuthorizationByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ImbursementID", ImbursementID),
			new SqlParameter("@CSAuth", CSAuth),
			new SqlParameter("@CSID", CSID.HasValue ? ((object)CSID) : DBNull.Value),
			new SqlParameter("@BursarAuth", BursarAuth),
			new SqlParameter("@BursarID", BursarID.HasValue ? ((object)BursarID) : DBNull.Value),
			new SqlParameter("@Notes", Notes),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "ImbursementAuthorizations_InsertImbursementAuthorization", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@ImbursementID", ImbursementID),
			new SqlParameter("@CSAuth", CSAuth),
			new SqlParameter("@CSID", CSID.HasValue ? ((object)CSID) : DBNull.Value),
			new SqlParameter("@BursarAuth", BursarAuth),
			new SqlParameter("@BursarID", BursarID.HasValue ? ((object)BursarID) : DBNull.Value),
			new SqlParameter("@Notes", Notes),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "ImbursementAuthorizations_UpdateImbursementAuthorizationByID", queryParameters));
	}

	private static ImbursementAuthorizationDAL BuildDAL(SqlDataReader reader)
	{
		ImbursementAuthorizationDAL dal = new ImbursementAuthorizationDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.ImbursementID = (int)reader["ImbursementID"];
			dal.CSAuth = (bool)reader["CSAuth"];
			dal.CSID = (reader["CSID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["CSID"])));
			dal.BursarAuth = (bool)reader["BursarAuth"];
			dal.BursarID = (reader["BursarID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["BursarID"])));
			dal.Notes = (string)reader["Notes"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static ImbursementAuthorizationDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ImbursementAuthorizations_GetImbursementAuthorizationByID", queryParameters), BuildDAL);
	}

	internal static ImbursementAuthorizationDAL GetByImbursementID(int imbursementID)
	{
		if (imbursementID == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ImbursementID", imbursementID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ImbursementAuthorizations_GetImbursementAuthorizationByImbursementID", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<ImbursementAuthorizationDAL> GetOrCreate(int imbursementID)
	{
		if (imbursementID == 0)
		{
			throw new ApplicationException("Required value not specified: ImbursementID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ImbursementID", imbursementID));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "[dbo].[ImbursementAuthorizations_GetOrCreateImbursementAuthorizationByImbursementID]", queryParameters), BuildDAL);
	}
}
