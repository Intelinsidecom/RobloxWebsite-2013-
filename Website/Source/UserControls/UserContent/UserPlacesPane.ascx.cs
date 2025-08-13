using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Website.ViewModels.Users;
using Roblox.Website.ViewModels.Catalog;
using Roblox.Showcases.Entities;

namespace Roblox.Website.UserControls.UserContent
{
    public partial class UserPlacesPane : System.Web.UI.UserControl
    {
        public UserPlacesViewModel Model { get; set; }

        protected void Page_Init(object sender, EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateViewModel();
            rbxItemPurchaseAjax.Model = new ItemPurchaseAjaxViewModel(Model.AuthenticatedUser);

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            ShowcasePlaces.DataSource = Model.Places;
            DataBind();
        }

        protected ICollection<IAsset> GetShowcasedPlaces()
        {
            var showcase = Showcase.GetOrCreate(ShowcaseType.Place, CreatorType.User, Model.UserID);
            var showcaseItems = ShowcaseItem.GetShowcaseItemsByShowcaseIDPaged(0, 20, showcase.ID);

            var places = new List<IAsset>();
            foreach (var item in showcaseItems)
            {
                places.Add(item.Asset);
            }

            return places;
        }

        protected void PopulateViewModel()
        {
            Model.Places = GetShowcasedPlaces();
            Model.ShowcasePagerPageSize = 10;
            Model.DisplayShowcasePager = Model.Places.Count > Model.ShowcasePagerPageSize;
        }
    }
}