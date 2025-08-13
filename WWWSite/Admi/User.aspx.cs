using System;
using System.Collections.Generic;
using System.Linq;
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

        protected void Page_Init(object sender, EventArgs e, MembershipDomainFactories membershipDomainFactories)
        {
            int id = 1;

            _userFactory = membershipDomainFactories.UserFactory;
            _IUser = _userFactory.GetUser(id);
            UserID = _IUser.Id;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            PunishmentType accountState = PunishmentType.None;


            PunishmentOptionsRadioButtonList.SelectedValue = accountState.ID.ToString();

            PopulatePunishments();

            DataBind();
        }

        protected void PopulatePunishments()
        {
            UserPunishmentsGridView.DataSource = PunishmentModelFactory.PopulatePunishmentModels(_IUser.Id);
        }

        protected void OverrideAccountStateButton_Click(object sender, EventArgs e)
        {
            var comment = AccountStateModerationNoteTextBox.Text.Trim();
            var message = AccountStateMessageToUserTextBox.Text.Trim();
            var punishmentType = PunishmentType.Get(byte.Parse(PunishmentOptionsRadioButtonList.SelectedValue));

            // Don't allow blank moderator messages for punished users
            if (!string.IsNullOrWhiteSpace(message))
            {

            }
        }
    }
}