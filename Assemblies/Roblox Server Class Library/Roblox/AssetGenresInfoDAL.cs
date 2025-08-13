using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

public class AssetGenresInfoDAL
{
	private byte _ID;

	public byte AssetGenreID;

	public string IconPath;

	public string PageHeader;

	public string PageTitle;

	public string FriendlyURL;

	public string MetaDescription;

	public string MetaKeywords;

	public string FooterText;

	public DateTime Created;

	public DateTime Updated;

	public byte ID
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

	private static string ConnectionString => RobloxDatabase.RobloxAssets.GetConnectionString();

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "AssetGenresInfo_DeleteAssetGenresInfoByID", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetGenreID", AssetGenreID));
		queryParameters.Add(new SqlParameter("@IconPath", (IconPath != null) ? ((IConvertible)IconPath) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@PageHeader", (PageHeader != null) ? ((IConvertible)PageHeader) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@PageTitle", (PageTitle != null) ? ((IConvertible)PageTitle) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@FriendlyURL", (FriendlyURL != null) ? ((IConvertible)FriendlyURL) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@MetaDescription", (MetaDescription != null) ? ((IConvertible)MetaDescription) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@MetaKeywords", (MetaKeywords != null) ? ((IConvertible)MetaKeywords) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@FooterText", (FooterText != null) ? ((IConvertible)FooterText) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<byte>(new DbInfo(ConnectionString, "AssetGenresInfo_InsertAssetGenresInfo", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AssetGenreID", AssetGenreID));
		queryParameters.Add(new SqlParameter("@IconPath", (IconPath != null) ? ((IConvertible)IconPath) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@PageHeader", (PageHeader != null) ? ((IConvertible)PageHeader) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@PageTitle", (PageTitle != null) ? ((IConvertible)PageTitle) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@FriendlyURL", (FriendlyURL != null) ? ((IConvertible)FriendlyURL) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@MetaDescription", (MetaDescription != null) ? ((IConvertible)MetaDescription) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@MetaKeywords", (MetaKeywords != null) ? ((IConvertible)MetaKeywords) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@FooterText", (FooterText != null) ? ((IConvertible)FooterText) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "AssetGenresInfo_UpdateAssetGenresInfoByID", queryParameters));
	}

	private static AssetGenresInfoDAL BuildDAL(SqlDataReader reader)
	{
		AssetGenresInfoDAL dal = new AssetGenresInfoDAL();
		while (reader.Read())
		{
			dal.ID = (byte)reader["ID"];
			dal.AssetGenreID = (byte)reader["AssetGenreID"];
			dal.IconPath = (reader["IconPath"].Equals(DBNull.Value) ? null : ((string)reader["IconPath"]));
			dal.PageHeader = (reader["PageHeader"].Equals(DBNull.Value) ? null : ((string)reader["PageHeader"]));
			dal.PageTitle = (reader["PageTitle"].Equals(DBNull.Value) ? null : ((string)reader["PageTitle"]));
			dal.FriendlyURL = (reader["FriendlyURL"].Equals(DBNull.Value) ? null : ((string)reader["FriendlyURL"]));
			dal.MetaDescription = (reader["MetaDescription"].Equals(DBNull.Value) ? null : ((string)reader["MetaDescription"]));
			dal.MetaKeywords = (reader["MetaKeywords"].Equals(DBNull.Value) ? null : ((string)reader["MetaKeywords"]));
			dal.FooterText = (reader["FooterText"].Equals(DBNull.Value) ? null : ((string)reader["FooterText"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static AssetGenresInfoDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetGenresInfo_GetAssetGenresInfoByID", queryParameters), BuildDAL);
	}

	public static AssetGenresInfoDAL GetByAssetGenreID(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AssetGenreID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetGenresInfo_GetAssetGenresInfoByAssetGenreID", queryParameters), BuildDAL);
	}

	public static AssetGenresInfoDAL GetByFriendlyURL(string friendlyURL)
	{
		if (friendlyURL == null)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@FriendlyURL", friendlyURL));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "AssetGenresInfo_GetAssetGenreInfoByFriendlyURL", queryParameters), BuildDAL);
	}
}
