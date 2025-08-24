using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class MerchantDisplayDAL
{
	private int _ID;

	private string _ImageMd5Hash;

	private byte _MerchantID;

	private string _DisplayName;

	private string _LocatorURL;

	private bool _IsHidden;

	private DateTime _Created;

	private DateTime _Updated;

	private bool _RequiresFileExtension;

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

	internal string ImageMd5Hash
	{
		get
		{
			return _ImageMd5Hash;
		}
		set
		{
			_ImageMd5Hash = value;
		}
	}

	internal byte MerchantID
	{
		get
		{
			return _MerchantID;
		}
		set
		{
			_MerchantID = value;
		}
	}

	internal string DisplayName
	{
		get
		{
			return _DisplayName;
		}
		set
		{
			_DisplayName = value;
		}
	}

	internal string LocatorURL
	{
		get
		{
			return _LocatorURL;
		}
		set
		{
			_LocatorURL = value;
		}
	}

	internal bool IsHidden
	{
		get
		{
			return _IsHidden;
		}
		set
		{
			_IsHidden = value;
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

	internal bool RequiresFileExtension
	{
		get
		{
			return _RequiresFileExtension;
		}
		set
		{
			_RequiresFileExtension = value;
		}
	}

	private static string _DbConnectionString => Settings.Default.BillingConnectionString;

	internal MerchantDisplayDAL()
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "MerchantDisplays_DeleteMerchantDisplayByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ImageMd5Hash", ImageMd5Hash),
			new SqlParameter("@MerchantID", MerchantID),
			new SqlParameter("@DisplayName", DisplayName),
			new SqlParameter("@LocatorURL", LocatorURL),
			new SqlParameter("@IsHidden", IsHidden),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@RequiresFileExtension", RequiresFileExtension)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "MerchantDisplays_InsertMerchantDisplay", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		_ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _ID),
			new SqlParameter("@ImageMd5Hash", ImageMd5Hash),
			new SqlParameter("@MerchantID", MerchantID),
			new SqlParameter("@DisplayName", DisplayName),
			new SqlParameter("@LocatorURL", LocatorURL),
			new SqlParameter("@IsHidden", IsHidden),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@RequiresFileExtension", RequiresFileExtension)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "MerchantDisplays_UpdateMerchantDisplayByID", queryParameters));
	}

	private static MerchantDisplayDAL BuildDAL(SqlDataReader reader)
	{
		MerchantDisplayDAL dal = new MerchantDisplayDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.ImageMd5Hash = (string)reader["ImageMd5Hash"];
			dal.MerchantID = (byte)reader["MerchantID"];
			dal.DisplayName = (string)reader["DisplayName"];
			dal.LocatorURL = (string)reader["LocatorURL"];
			dal.IsHidden = (bool)reader["IsHidden"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.RequiresFileExtension = (bool)reader["RequiresFileExtension"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	internal static MerchantDisplayDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "MerchantDisplays_GetMerchantDisplayByID", queryParameters), BuildDAL);
	}

	internal static ICollection<int> GetMerchantDisplayIDsByMerchantIDPaged(int merchantID, int startRowIndex, int maximumRows)
	{
		if (merchantID == 0)
		{
			throw new ApplicationException("Required value not specified: MerchantID.");
		}
		if (maximumRows == 0)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@MerchantID", merchantID)
		};
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		queryParameters.Add(new SqlParameter("@StartRowIndex", ++startRowIndex));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString, "MerchantDisplays_GetMerchantDisplayIDsByMerchantID_Paged", queryParameters));
	}

	internal static ICollection<int> GetMerchantDisplayIDsPaged(int startRowIndex, int maximumRows)
	{
		if (maximumRows == 0)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		queryParameters.Add(new SqlParameter("@StartRowIndex", ++startRowIndex));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString, "MerchantDisplays_GetMerchantDisplayIDs_Paged", queryParameters));
	}
}
