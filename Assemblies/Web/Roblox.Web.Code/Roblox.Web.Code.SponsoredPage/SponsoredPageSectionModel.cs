using System.Web.Mvc;

namespace Roblox.Web.Code.SponsoredPage;

public class SponsoredPageSectionModel
{
	public SponsoredPageModel PageModel { get; set; }

	public int ID { get; set; }

	public string Name { get; set; }

	public int SortOrder { get; set; }

	public int TargetTopPixel { get; set; }

	public string CssOverrideMd5Hash { get; set; }

	public string CssOverrideFilePath { get; set; }

	public bool HasNavigation { get; set; }

	public string SelectedSponsoredPageSectionType { get; set; }

	[AllowHtml]
	public string CustomHtml { get; set; }
}
