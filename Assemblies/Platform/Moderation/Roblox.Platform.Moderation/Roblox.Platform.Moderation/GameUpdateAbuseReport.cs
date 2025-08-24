using System;
using System.Collections.Generic;

namespace Roblox.Moderation;

/// <summary>
/// Game Update abuse report
/// </summary>
public class GameUpdateAbuseReport : WebAbuseReport, IReportable
{
	private readonly long _GameUpdateId;

	private readonly DateTime _UpdatedCreatedOn;

	private readonly string _GameUpdateBody;

	private readonly string _ContextUrl;

	public long AllegedAbuserID { get; }

	public string CommentText { get; }

	public long SubmitterID { get; }

	public string FloodCheckKey => $"_GameUpdateAbuseReport_GameUpdateID:{_GameUpdateId}";

	public byte? ReportCategoryID { get; }

	public IReportContext ReportContext { get; }

	public int SubmitterRank { get; }

	public GameUpdateAbuseReport(GetUserRankGetter getUserRankGetter, WebApplicationUrlGetter applicationUrlGetter, long gameUpdateId, DateTime updateCreatedOn, string gameUpdateBody, long allegedAbuserId, string commentText, long submitterId, string contextUrl, byte? reportCategoryId = null)
		: base(getUserRankGetter, applicationUrlGetter)
	{
		if (string.IsNullOrEmpty(gameUpdateBody))
		{
			throw new ArgumentNullException("gameUpdateBody");
		}
		AllegedAbuserID = allegedAbuserId;
		CommentText = commentText;
		SubmitterID = submitterId;
		ReportCategoryID = reportCategoryId;
		ReportContext = BuildWebsiteContext(contextUrl);
		SubmitterRank = GetUserRank(submitterId);
		_ContextUrl = contextUrl;
		_GameUpdateId = gameUpdateId;
		_UpdatedCreatedOn = updateCreatedOn;
		_GameUpdateBody = gameUpdateBody;
	}

	protected override string BuildContextUrl()
	{
		return _ContextUrl;
	}

	public ICollection<IUtterable> GetUtterableItems()
	{
		List<IUtterable> list = new List<IUtterable>(1);
		AbuseReportUtterance gameUpdateBodyUtterance = new AbuseReportUtterance(AllegedAbuserID, new GameUpdateBodySource(_GameUpdateId), _GameUpdateBody);
		list.Add(gameUpdateBodyUtterance);
		return list;
	}
}
