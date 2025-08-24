using System.Collections.Generic;

namespace Roblox.Moderation;

public interface IReportable
{
	long AllegedAbuserID { get; }

	string CommentText { get; }

	long SubmitterID { get; }

	string FloodCheckKey { get; }

	byte? ReportCategoryID { get; }

	IReportContext ReportContext { get; }

	int SubmitterRank { get; }

	ICollection<IUtterable> GetUtterableItems();
}
