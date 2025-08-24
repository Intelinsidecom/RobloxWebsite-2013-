using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class SponsoredPageDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal int ID { get; set; }

	internal string Name { get; set; }

	internal string Description { get; set; }

	internal string Title { get; set; }

	internal long PlaceID { get; set; }

	internal int? ContestID { get; set; }

	internal string VideoURL { get; set; }

	internal bool VideoIsYoutube { get; set; }

	internal bool Enabled { get; set; }

	internal bool PreviewEnabled { get; set; }

	internal string AdSlot728x90 { get; set; }

	internal string AdSlot300x250 { get; set; }

	internal DateTime StartDate { get; set; }

	internal DateTime EndDate { get; set; }

	internal string OriginalCssMd5Hash { get; set; }

	internal string CurrentCssMd5Hash { get; set; }

	internal string NavigationLogoImageMd5Hash { get; set; }

	internal string NavigationOverrideUrl { get; set; }

	internal string IFrameUrl { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal byte PageTypeID { get; set; }

	internal string JavascriptMd5Hash { get; set; }

	private static SponsoredPageDAL BuildDAL(IDictionary<string, object> record)
	{
		int id = (int)record["ID"];
		if (id == 0)
		{
			return null;
		}
		return new SponsoredPageDAL
		{
			ID = id,
			Name = (string)record["Name"],
			Description = (string)record["Description"],
			Title = (string)record["Title"],
			PlaceID = (long)record["PlaceID"],
			ContestID = (int?)record["ContestID"],
			VideoURL = (string)record["VideoURL"],
			VideoIsYoutube = (bool)record["VideoIsYoutube"],
			Enabled = (bool)record["Enabled"],
			PreviewEnabled = (bool)record["PreviewEnabled"],
			AdSlot728x90 = (string)record["AdSlot728x90"],
			AdSlot300x250 = (string)record["AdSlot300x250"],
			StartDate = DateTime.SpecifyKind((DateTime)record["StartDate"], DateTimeKind.Local),
			EndDate = DateTime.SpecifyKind((DateTime)record["EndDate"], DateTimeKind.Local),
			OriginalCssMd5Hash = (string)record["OriginalCssMd5Hash"],
			CurrentCssMd5Hash = (string)record["CurrentCssMd5Hash"],
			NavigationLogoImageMd5Hash = (string)record["NavigationLogoImageMd5Hash"],
			NavigationOverrideUrl = (string)record["NavigationOverrideUrl"],
			IFrameUrl = (string)record["IFrameURL"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local),
			PageTypeID = (byte)record["PageTypeID"],
			JavascriptMd5Hash = (string)record["JavascriptMd5Hash"]
		};
	}

	internal void Insert()
	{
		SqlParameter[] obj = new SqlParameter[23]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Name", Name),
			new SqlParameter("@Description", string.IsNullOrWhiteSpace(Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Description)),
			new SqlParameter("@Title", Title),
			new SqlParameter("@PlaceID", PlaceID),
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		int? contestID = ContestID;
		obj[5] = new SqlParameter("@ContestID", contestID.HasValue ? ((object)contestID.GetValueOrDefault()) : DBNull.Value);
		obj[6] = new SqlParameter("@VideoURL", VideoURL);
		obj[7] = new SqlParameter("@VideoIsYoutube", VideoIsYoutube);
		obj[8] = new SqlParameter("@Enabled", Enabled);
		obj[9] = new SqlParameter("@PreviewEnabled", PreviewEnabled);
		obj[10] = new SqlParameter("@AdSlot728x90", AdSlot728x90);
		obj[11] = new SqlParameter("@AdSlot300x250", AdSlot300x250);
		obj[12] = new SqlParameter("@StartDate", StartDate.ToLocalTime());
		obj[13] = new SqlParameter("@EndDate", EndDate.ToLocalTime());
		obj[14] = new SqlParameter("@OriginalCssMd5Hash", string.IsNullOrWhiteSpace(OriginalCssMd5Hash) ? ((IConvertible)DBNull.Value) : ((IConvertible)OriginalCssMd5Hash));
		obj[15] = new SqlParameter("@CurrentCssMd5Hash", string.IsNullOrWhiteSpace(CurrentCssMd5Hash) ? ((IConvertible)DBNull.Value) : ((IConvertible)CurrentCssMd5Hash));
		obj[16] = new SqlParameter("@NavigationLogoImageMd5Hash", string.IsNullOrWhiteSpace(NavigationLogoImageMd5Hash) ? ((IConvertible)DBNull.Value) : ((IConvertible)NavigationLogoImageMd5Hash));
		obj[17] = new SqlParameter("@NavigationOverrideUrl", string.IsNullOrWhiteSpace(NavigationOverrideUrl) ? ((IConvertible)DBNull.Value) : ((IConvertible)NavigationOverrideUrl));
		obj[18] = new SqlParameter("@IFrameURL", string.IsNullOrWhiteSpace(IFrameUrl) ? ((IConvertible)DBNull.Value) : ((IConvertible)IFrameUrl));
		obj[19] = new SqlParameter("@Created", Created.ToLocalTime());
		obj[20] = new SqlParameter("@Updated", Updated.ToLocalTime());
		obj[21] = new SqlParameter("@PageTypeID", PageTypeID);
		obj[22] = new SqlParameter("@JavascriptMd5Hash", string.IsNullOrWhiteSpace(JavascriptMd5Hash) ? ((IConvertible)DBNull.Value) : ((IConvertible)JavascriptMd5Hash));
		SqlParameter[] queryParameters = obj;
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("SponsoredPages_InsertSponsoredPage", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] obj = new SqlParameter[23]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Description", string.IsNullOrWhiteSpace(Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Description)),
			new SqlParameter("@Title", Title),
			new SqlParameter("@PlaceID", PlaceID),
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		int? contestID = ContestID;
		obj[5] = new SqlParameter("@ContestID", contestID.HasValue ? ((object)contestID.GetValueOrDefault()) : DBNull.Value);
		obj[6] = new SqlParameter("@VideoURL", VideoURL);
		obj[7] = new SqlParameter("@VideoIsYoutube", VideoIsYoutube);
		obj[8] = new SqlParameter("@Enabled", Enabled);
		obj[9] = new SqlParameter("@PreviewEnabled", PreviewEnabled);
		obj[10] = new SqlParameter("@AdSlot728x90", AdSlot728x90);
		obj[11] = new SqlParameter("@AdSlot300x250", AdSlot300x250);
		obj[12] = new SqlParameter("@StartDate", StartDate.ToLocalTime());
		obj[13] = new SqlParameter("@EndDate", EndDate.ToLocalTime());
		obj[14] = new SqlParameter("@OriginalCssMd5Hash", string.IsNullOrWhiteSpace(OriginalCssMd5Hash) ? ((IConvertible)DBNull.Value) : ((IConvertible)OriginalCssMd5Hash));
		obj[15] = new SqlParameter("@CurrentCssMd5Hash", string.IsNullOrWhiteSpace(CurrentCssMd5Hash) ? ((IConvertible)DBNull.Value) : ((IConvertible)CurrentCssMd5Hash));
		obj[16] = new SqlParameter("@NavigationLogoImageMd5Hash", string.IsNullOrWhiteSpace(NavigationLogoImageMd5Hash) ? ((IConvertible)DBNull.Value) : ((IConvertible)NavigationLogoImageMd5Hash));
		obj[17] = new SqlParameter("@NavigationOverrideUrl", string.IsNullOrWhiteSpace(NavigationOverrideUrl) ? ((IConvertible)DBNull.Value) : ((IConvertible)NavigationOverrideUrl));
		obj[18] = new SqlParameter("@IFrameURL", string.IsNullOrWhiteSpace(IFrameUrl) ? ((IConvertible)DBNull.Value) : ((IConvertible)IFrameUrl));
		obj[19] = new SqlParameter("@Created", Created.ToLocalTime());
		obj[20] = new SqlParameter("@Updated", Updated.ToLocalTime());
		obj[21] = new SqlParameter("@PageTypeID", PageTypeID);
		obj[22] = new SqlParameter("@JavascriptMd5Hash", string.IsNullOrWhiteSpace(JavascriptMd5Hash) ? ((IConvertible)DBNull.Value) : ((IConvertible)JavascriptMd5Hash));
		SqlParameter[] queryParameters = obj;
		RobloxDatabase.RobloxMarketing.Update("SponsoredPages_UpdateSponsoredPageByID", queryParameters);
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxMarketing.Delete("SponsoredPages_DeleteSponsoredPageByID", ID);
	}

	internal static SponsoredPageDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxMarketing.Get("SponsoredPages_GetSponsoredPageByID", id, BuildDAL);
	}

	internal static SponsoredPageDAL GetByName(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Name", name)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("SponsoredPages_GetSponsoredPageByName", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetSponsoredPageIDs_Paged(int startRowIndex, int maximumRows)
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxMarketing.GetIDCollection<int>("SponsoredPages_GetSponsoredPageIDs_Paged", queryParameters);
	}
}
