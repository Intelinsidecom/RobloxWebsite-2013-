using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public class ReportCategoryDAL
{
	private byte _ID;

	private string _InternalName;

	private string _PublicName;

	private bool _IsVisible;

	private byte _PublicSortOrder;

	private byte _DefaultPriority;

	private DateTime _Created;

	private DateTime _Updated;

	internal byte ID
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

	internal string InternalName
	{
		get
		{
			return _InternalName;
		}
		set
		{
			_InternalName = value;
		}
	}

	internal string PublicName
	{
		get
		{
			return _PublicName;
		}
		set
		{
			_PublicName = value;
		}
	}

	internal bool IsVisible
	{
		get
		{
			return _IsVisible;
		}
		set
		{
			_IsVisible = value;
		}
	}

	internal byte PublicSortOrder
	{
		get
		{
			return _PublicSortOrder;
		}
		set
		{
			_PublicSortOrder = value;
		}
	}

	internal byte DefaultPriority
	{
		get
		{
			return _DefaultPriority;
		}
		set
		{
			_DefaultPriority = value;
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

	internal ReportCategoryDAL()
	{
	}

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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "ReportCategories_DeleteReportCategoryByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@InternalName", InternalName),
			new SqlParameter("@PublicName", PublicName),
			new SqlParameter("@IsVisible", IsVisible),
			new SqlParameter("@PublicSortOrder", PublicSortOrder),
			new SqlParameter("@DefaultPriority", DefaultPriority),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "ReportCategories_InsertReportCategory", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<byte>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@InternalName", InternalName),
			new SqlParameter("@PublicName", PublicName),
			new SqlParameter("@IsVisible", IsVisible),
			new SqlParameter("@PublicSortOrder", PublicSortOrder),
			new SqlParameter("@DefaultPriority", DefaultPriority),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "ReportCategories_UpdateReportCategoryByID", queryParameters));
	}

	private static ReportCategoryDAL BuildDAL(SqlDataReader reader)
	{
		ReportCategoryDAL dal = new ReportCategoryDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.InternalName = (string)reader["InternalName"];
			dal.PublicName = (string)reader["PublicName"];
			dal.IsVisible = (bool)reader["IsVisible"];
			dal.PublicSortOrder = (byte)reader["PublicSortOrder"];
			dal.DefaultPriority = (byte)reader["DefaultPriority"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static ReportCategoryDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ReportCategories_GetReportCategoryByID", queryParameters), BuildDAL);
	}

	public static ICollection<byte> GetReportCategoriesByIsVisiblePaged(bool isVisible, int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@IsVisible", isVisible));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<byte>(new DbInfo(Helper.DBConnectionString, "ReportCategories_GetReportCategoryIDsByIsVisible_Paged", queryParameters));
	}

	public static int GetTotalNumberOfReportCategoriesByIsVisible(bool isVisible)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@IsVisible", isVisible));
		return EntityHelper.GetDataCount<int>(new DbInfo(Helper.DBConnectionString, "ReportCategories_GetTotalNumberOfReportCategoriesByIsVisible", queryParameters));
	}
}
