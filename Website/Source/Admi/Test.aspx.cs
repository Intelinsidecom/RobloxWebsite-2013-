using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Roblox.Platform.Membership;
using Roblox.Platform.Roles;
using Roblox.Platform.Email;

namespace Roblox.Website.Admi
{
    public partial class Test : System.Web.UI.Page
    {
        private static MembershipDomainFactories _factories;

        public IUser IUser { get; private set; }
        public IRoleSet IRoleSet { get; private set; }
        public ICollection<AssetType> AssetTypes { get; private set; }

        static Test()
        {
            _factories = Global.MembershipDomainFactories;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            IUser = _factories.UserFactory.GetCurrentUser();
            var isPriveleged = _factories.RoleSetValidator.IsPrivilegedUser(IUser);

            // Only show this page to privileged users
            if (!isPriveleged)
                Response.Redirect("~/", true);

            GridView1.DataSource = new List<IUser> { IUser };

            IRoleSet = (IRoleSet)_factories.RoleSetValidator.GetHighestRoleSet(IUser);
            GridView2.DataSource = _factories.RoleSetValidator.GetRoleSets(IUser);

            //IUserEmail = "N/a";

            //AssetTypes = AssetType.GetAssetTypes();
            GridView4.DataSource = AssetTypes;

            DataBind();
        }
    }
}