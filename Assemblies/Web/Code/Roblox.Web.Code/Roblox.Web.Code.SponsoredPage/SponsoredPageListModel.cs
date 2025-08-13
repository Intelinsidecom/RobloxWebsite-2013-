using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Roblox.Web.Code.SponsoredPage;

public class SponsoredPageListModel
{
	public ICollection<SponsoredPageIndexModel> SponsoredPageIndex = new Collection<SponsoredPageIndexModel>();

	public User AuthenticatedUser;

	public string Error;
}
