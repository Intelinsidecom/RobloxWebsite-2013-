using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public class WebsiteReportContextDAL
{
	private long _ID;

	private string _ContextUrl;

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

	internal string ContextUrl
	{
		get
		{
			return _ContextUrl;
		}
		set
		{
			_ContextUrl = value;
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

	internal WebsiteReportContextDAL()
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "WebsiteReportContexts_DeleteWebsiteReportContextByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ContextUrl", ContextUrl),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "WebsiteReportContexts_InsertWebsiteReportContext", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@ContextUrl", ContextUrl),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "WebsiteReportContexts_UpdateWebsiteReportContextByID", queryParameters));
	}

	private static WebsiteReportContextDAL BuildDAL(SqlDataReader reader)
	{
		WebsiteReportContextDAL dal = new WebsiteReportContextDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.ContextUrl = (string)reader["ContextUrl"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static WebsiteReportContextDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "WebsiteReportContexts_GetWebsiteReportContextByID", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<WebsiteReportContextDAL> GetOrCreate(string contextUrl)
	{
		if (contextUrl == null)
		{
			throw new ApplicationException("Required value not specified: Context Url");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ContextUrl", contextUrl));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "WebsiteReportContexts_GetOrCreateWebsiteReportContextByContextUrl", queryParameters), BuildDAL);
	}
}
