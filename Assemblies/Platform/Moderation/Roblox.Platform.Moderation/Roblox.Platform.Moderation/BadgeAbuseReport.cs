using System;
using System.Collections.Generic;
using System.Linq;

namespace Roblox.Moderation;

/// <summary>
/// Badge abuse report
/// </summary>
public class BadgeAbuseReport : WebAbuseReport, IReportable
{
	private readonly long _BadgeId;

	private readonly long _BadgeImageAssetVersionId;

	private readonly string _Name;

	private readonly string _Description;

	private readonly string _ContextUrl;

	private readonly IEnumerable<(string, string)> _LocalizedNames;

	private readonly IEnumerable<(string, string)> _LocalizedDescriptions;

	public long AllegedAbuserID { get; }

	public string CommentText { get; }

	public long SubmitterID { get; }

	public string FloodCheckKey => $"_BadgeAbuseReport_BadgeID:{_BadgeId}";

	public byte? ReportCategoryID { get; }

	public IReportContext ReportContext { get; }

	public int SubmitterRank { get; }

	public BadgeAbuseReport(GetUserRankGetter getUserRankGetter, WebApplicationUrlGetter applicationUrlGetter, long badgeId, long badgeImageAssetVersionId, string name, string description, long allegedAbuserId, string commentText, long submitterId, string contextUrl, byte? reportCategoryId = null, IEnumerable<(string, string)> localizedNames = null, IEnumerable<(string, string)> localizedDescriptions = null)
		: base(getUserRankGetter, applicationUrlGetter)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ArgumentNullException("name");
		}
		AllegedAbuserID = allegedAbuserId;
		CommentText = commentText;
		SubmitterID = submitterId;
		ReportCategoryID = reportCategoryId;
		ReportContext = BuildWebsiteContext(contextUrl);
		SubmitterRank = GetUserRank(submitterId);
		_ContextUrl = contextUrl;
		_BadgeId = badgeId;
		_BadgeImageAssetVersionId = badgeImageAssetVersionId;
		_Name = name;
		_Description = description;
		_LocalizedDescriptions = localizedDescriptions;
		_LocalizedNames = localizedNames;
	}

	protected override string BuildContextUrl()
	{
		return _ContextUrl;
	}

	public ICollection<IUtterable> GetUtterableItems()
	{
		List<IUtterable> utterables = new List<IUtterable>();
		AbuseReportUtterance assetVersionUtterance = new AbuseReportUtterance(AllegedAbuserID, new AssetVersionSource(_BadgeImageAssetVersionId), string.Empty);
		AbuseReportUtterance nameUtterance = new AbuseReportUtterance(AllegedAbuserID, new BadgeNameSource(_BadgeId), _Name);
		AbuseReportUtterance descriptionUtterance = new AbuseReportUtterance(AllegedAbuserID, new BadgeDescriptionSource(_BadgeId), _Description);
		utterables.Add(assetVersionUtterance);
		if (_LocalizedNames == null || !_LocalizedNames.Any() || _LocalizedDescriptions == null || !_LocalizedDescriptions.Any())
		{
			utterables.Add(nameUtterance);
			utterables.Add(descriptionUtterance);
		}
		else
		{
			foreach (var (name, languageCode2) in _LocalizedNames)
			{
				utterables.Add(new AbuseReportUtterance(AllegedAbuserID, new BadgeNameSource(_BadgeId), name, languageCode2));
			}
			foreach (var (description, languageCode) in _LocalizedDescriptions)
			{
				utterables.Add(new AbuseReportUtterance(AllegedAbuserID, new BadgeDescriptionSource(_BadgeId), description, languageCode));
			}
		}
		return utterables;
	}
}
