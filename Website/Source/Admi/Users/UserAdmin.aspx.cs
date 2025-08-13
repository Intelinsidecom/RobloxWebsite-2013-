using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data;

using Roblox.Platform.Email;
using Roblox.Platform.Membership;

using Roblox.Website.Models.Moderation;
using Roblox.Website.ModelFactories.Moderation;
using Roblox.Website.ViewModels.Admi.UserAdmin;

using AccountEntity = Roblox.Platform.Membership.Entities.AccountEntity;
using AccountStatusEntity = Roblox.AccountStatus;

namespace Roblox.Website.Admi.Users
{
    public partial class UserAdmin : System.Web.UI.Page
    {
        private static IUserFactory _userFactory;
        private static IUserEmailFactory _userEmailFactory;
        public IUser IUser { get; private set; }


        static UserAdmin()
        {
            _userFactory = Global.MembershipDomainFactories.UserFactory;
            _userEmailFactory = Global.EmailDomainFactories.UserEmailFactory;
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            long id;
            if (!long.TryParse(Request["ID"], out id))
                id = 1;
            IUser = _userFactory.GetUser(id);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateDataFields();
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Populates all of the data fields on the form
        /// </summary>
        protected void PopulateDataFields()
        {
            PopulateAccountSummary();
            PopulateBillingInfo();
            PopulatePunishments();
            //PopulateUserNotes();
            rbxUserNotesPane.DataBind();
            PopulateUpdateUserPane();
            PopulateGiveAndTakePane();
        }

        protected void PopulateAccountSummary()
        {
            rbxAccountSummaryPane.Model = new AccountSummaryViewModel()
            {
                ID = IUser.Id,
                Name = IUser.Name,
                ModerationStatus = AccountStatusEntity.Get(IUser.AccountStatus.TranslateToByte()).Value,
                IsPremiumUser = false,
                MembershipType = "N/A",
                MembershipExpirationDate = "N/A",
                LoyalSinceDate = "N/A",
                Location = "[ Offline ]",
                UserID = IUser.Id,
                UserName = IUser.Name
            };
        }

        protected void PopulateBillingInfo()
        {
            rbxBillingInfoPane.Model = new BillingInfoViewModel()
            {
                BillingName = "",
                PostalCode = "",
                BillingEmail = "",
                CreditCardInfo = ""
            };
        }

        protected void PopulatePunishments()
        {
            rbxPunishmentsPane.Model = new PunishmentsViewModel()
            {
                Punishments = PunishmentModelFactory.PopulatePunishmentModels(IUser.Id)
            };
        }

        protected void PopulateUpdateUserPane()
        {
            var emailAddress = _userEmailFactory.GetCurrentVerified(IUser);
            var userEmail = _userEmailFactory.GetByEmail(emailAddress != null ? emailAddress.EmailAddress.Address : "");
            // HACK: Do we even need IsApproved anymore?
            var account = AccountEntity.MustGet(IUser.AccountId);

            rbxUpdateUserPane.Model = new UpdateUserViewModel()
            {
                ID = IUser.Id,
                Blurb = IUser.Description,
                EmailAddress = emailAddress != null ? emailAddress.EmailAddress.Address : "",
                IsEmailVerified = emailAddress != null ? emailAddress.IsValid : false,
                Created = IUser.Created,
                LastLocation = null,
                LastActivityDate = null,
                IsApproved = account.AccountStatus == AccountStatusEntity.Ok,
            };
        }

        protected void PopulateGiveAndTakePane()
        {
            rbxGiveAndTakePane.Model = new GiveAndTakeViewModel()
            {
                ID = IUser.Id,
                Robux = 0,
                MaxRobux = 0,
                Tickets = 0,
                MaxTickets = 0,
                Credit = 2013,
                MaxCredit = 2013
            };
        }
    }
}