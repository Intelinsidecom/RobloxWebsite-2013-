using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using Roblox.Marketing;

namespace Roblox.Web.Code.SponsoredPage;

public class SponsoredPageModel
{
	public User AuthenticatedUser;

	public ICollection<SponsoredPageItemModel> Prizes = new Collection<SponsoredPageItemModel>();

	public ICollection<SponsoredPageItemModel> Stuff = new Collection<SponsoredPageItemModel>();

	public ICollection<SponsoredPagePlaceModel> Places = new Collection<SponsoredPagePlaceModel>();

	public ICollection<SponsoredPageSectionModel> Sections = new Collection<SponsoredPageSectionModel>();

	public Dictionary<string, string> Images = new Dictionary<string, string>();

	public bool HasStrictAuthorization;

	public string Error { get; set; }

	public int ID { get; set; }

	public string Name { get; set; }

	public string Title { get; set; }

	[AllowHtml]
	public string Description { get; set; }

	public List<long> PlaceIDs { get; set; }

	public string PlaceIDsCSV { get; set; }

	public long ContestID { get; set; }

	public string VideoURL { get; set; }

	public bool VideoIsYoutube { get; set; }

	public bool IsOnComputer { get; set; }

	public bool IsOnPhone { get; set; }

	public bool IsOnTablet { get; set; }

	public byte MinAge { get; set; }

	public byte MaxAge { get; set; }

	public string VideoJSPath { get; set; }

	public string VideoPlayerSWF { get; set; }

	public string CSSFilepath { get; set; }

	public bool Enabled { get; set; }

	public bool PreviewEnabled { get; set; }

	public string NavigationLogoImageURL { get; set; }

	public string NavigationOverrideUrl { get; set; }

	public string IFrameUrl { get; set; }

	public IEnumerable<PageType> PageTypes { get; set; }

	public IEnumerable<SponsoredPageSectionType> AvailableSectionTypes { get; set; }

	public string SelectedPageType { get; set; }

	public IEnumerable<SelectListItem> Countries { get; set; }

	public string JavascriptMd5Hash { get; set; }

	public string JavascriptFilePath { get; set; }

	public string AdSlot728x90 { get; set; }

	public string AdSlot300x250 { get; set; }
}
