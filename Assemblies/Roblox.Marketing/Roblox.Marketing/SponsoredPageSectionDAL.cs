using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class SponsoredPageSectionDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal int SponsoredPageID { get; set; }

	internal byte SponsoredPageSectionTypeID { get; set; }

	internal string Name { get; set; }

	internal int SortOrder { get; set; }

	internal int TargetTopPixel { get; set; }

	internal bool HasNavigation { get; set; }

	internal string CssOverrideMd5Hash { get; set; }

	internal string CustomHtml { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static SponsoredPageSectionDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new SponsoredPageSectionDAL
		{
			ID = id,
			SponsoredPageID = (int)record["SponsoredPageID"],
			SponsoredPageSectionTypeID = (byte)record["SponsoredPageSectionTypeID"],
			Name = (string)record["Name"],
			SortOrder = (int)record["SortOrder"],
			TargetTopPixel = (int)record["TargetTopPixel"],
			HasNavigation = (bool)record["HasNavigation"],
			CssOverrideMd5Hash = (string)record["CssOverrideMd5Hash"],
			CustomHtml = (string)record["CustomHtml"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
	}

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		RobloxDatabase.RobloxMarketing.Delete("SponsoredPageSections_DeleteSponsoredPageSectionByID", ID);
	}

	internal static SponsoredPageSectionDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("SponsoredPageSections_GetSponsoredPageSectionByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[11]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@SponsoredPageID", SponsoredPageID),
			new SqlParameter("@SponsoredPageSectionTypeID", SponsoredPageSectionTypeID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@SortOrder", SortOrder),
			new SqlParameter("@TargetTopPixel", TargetTopPixel),
			new SqlParameter("@HasNavigation", HasNavigation),
			new SqlParameter("@CssOverrideMd5Hash", string.IsNullOrWhiteSpace(CssOverrideMd5Hash) ? ((IConvertible)DBNull.Value) : ((IConvertible)CssOverrideMd5Hash)),
			new SqlParameter("@CustomHtml", string.IsNullOrWhiteSpace(CustomHtml) ? ((IConvertible)DBNull.Value) : ((IConvertible)CustomHtml)),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("SponsoredPageSections_InsertSponsoredPageSection", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[11]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@SponsoredPageID", SponsoredPageID),
			new SqlParameter("@SponsoredPageSectionTypeID", SponsoredPageSectionTypeID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@SortOrder", SortOrder),
			new SqlParameter("@TargetTopPixel", TargetTopPixel),
			new SqlParameter("@HasNavigation", HasNavigation),
			new SqlParameter("@CssOverrideMd5Hash", string.IsNullOrWhiteSpace(CssOverrideMd5Hash) ? ((IConvertible)DBNull.Value) : ((IConvertible)CssOverrideMd5Hash)),
			new SqlParameter("@CustomHtml", string.IsNullOrWhiteSpace(CustomHtml) ? ((IConvertible)DBNull.Value) : ((IConvertible)CustomHtml)),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("SponsoredPageSections_UpdateSponsoredPageSectionByID", queryParameters);
	}

	internal static ICollection<int> GetSponsoredPageSectionIDsBySponsoredPageID_Paged(int sponsoredPageId, int startRowIndex, int maximumRows)
	{
		if (sponsoredPageId == 0)
		{
			throw new ApplicationException("Required value not specified: SponsoredPageID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@SponsoredPageID", sponsoredPageId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("SponsoredPageSections_GetSponsoredPageSectionIDsBySponsoredPageID_Paged", queryParameters);
	}
}
