using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Platform.Membership;

namespace Roblox.Website.ViewModels.Catalog
{
    public class ItemPurchaseAjaxViewModel
    {
        public bool AuthenticatedUserIsNull { get; set; }
        public long UserBalanceRobux { get; set; }
        public long UserBalanceTickets { get; set; }
        public byte UserBC { get; set; }
        public string ContinueShoppingUrl { get; set; }
        public string ImageUrl { get; set; }
        public string AlertUrl { get; set; }
        public string BuildersClubUrl { get; set; }

        public ItemPurchaseAjaxViewModel(IUser authenticatedUser)
        {
            AuthenticatedUserIsNull = authenticatedUser == null;
            UserBalanceRobux = 0;
            UserBalanceTickets = 0;
            UserBC = 0;
            ContinueShoppingUrl = "";
            ImageUrl = "";
            AlertUrl = StaticContent.GetUrl("~/Images/Icons/img-alert.png");
            BuildersClubUrl = "https://images.rbxcdn.com/ae345c0d59b00329758518edc104d573.png";
        }
    }
}