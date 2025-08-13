using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Roblox.Moderation;
using Roblox;

namespace Roblox.Website
{
    public partial class NotApproved : System.Web.UI.Page
    {
        public string TitleText { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsBanished { get; set; } = false;
        public string PunishmentDurationString { get; set; } = string.Empty;
        public Punishment Punishment { get; set; }

        private Roblox.User _user;
        private Roblox.Account _account;
        private ICollection<Punishment> _punishments;

        protected void Page_Init(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated)
                Response.Redirect("~/Login/Default.aspx", true);

            _account = Roblox.Account.GetCurrent();
            _user = Roblox.User.GetByAccountID(_account.ID);

            var punishmentCount = Punishment.GetTotalNumberOfUserPunishments(_user.ID);
            if (punishmentCount > 0)
            {

                // HACK: Average user should never have a long amount of punishments, only an int amount
                _punishments = Punishment.GetUserPunishmentsPaged(_user.ID, (int)punishmentCount - 1, 1);

                Punishment = _punishments.Last();
                var punishType = Punishment.Type;

                var days = punishType.DurationInDays;
                if (days.HasValue && days > 0)
                {
                    PunishmentDurationString = $"{days} Day";
                    if (days > 1)
                        PunishmentDurationString += "s";

                    TitleText = "Banned for " + PunishmentDurationString;
                    IsBanished = true;
                    PanelBanned.Visible = true;
                }
                else if (punishType == PunishmentType.DeleteAccount || punishType == PunishmentType.PoisonMachine)
                {
                    TitleText = "Account Deleted";
                    IsDeleted = true;
                    IsBanished = true;
                    PanelDeleted.Visible = true;
                }
                else if (punishType == PunishmentType.Remind)
                {
                    PanelRemind.Visible = true;
                    TitleText = "Reminder";
                }
                else if (punishType == PunishmentType.Warn)
                {
                    PanelRemind.Visible = true;
                    TitleText = "Warning";
                }
            }
            else
            {
                Response.Redirect("~/", true);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            DataBind();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            Page.Title = "ROBLOX | Disabled Account";
        }

        protected void LogoutButton_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("~/", true);
        }

        protected void ButtonAgree_Click(object sender, EventArgs e)
        {
            if (_account.AccountStatusID != AccountStatus.OkId)
            {
                var activePunsihmentsCount = Punishment.GetTotalNumberOfActiveUserPunishments(_user);

                if (activePunsihmentsCount > 0)
                    return;

                // Bypass punishment screen provided there are no active punishments
                _account.Status = AccountStatus.Ok;
                // _account.Save(); // Commenting out as Save method doesn't exist
            }

            Response.Redirect("~/", true);
        }
    }
}