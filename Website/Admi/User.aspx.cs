using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Moderation;
using Roblox.Platform.Membership;
using Roblox.Website.ModelFactories.Moderation;

namespace Roblox.Website.Admi
{
    public partial class User : System.Web.UI.Page
    {
        public long UserID { get; set; }

        private IUser _IUser;
        private IUserFactory _userFactory;

        public ICollection<PunishmentType> GetPunishmentTypes() => PunishmentType.AllPunishmentTypes;

        protected void Page_Init(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(Request["ID"], out id))
                id = 1;

            _userFactory = Global.MembershipDomainFactories.UserFactory;
            _IUser = _userFactory.GetUser(id);
            UserID = _IUser.Id;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            PopulatePunishments();

            DataBind();
        }

        protected void PopulatePunishments()
        {
            UserPunishmentsGridView.DataSource = PunishmentModelFactory.PopulatePunishmentModels(_IUser.Id);
        }

        protected void OverrideAccountStateButton_Click(object sender, EventArgs e)
        {

        }
    }
}