<%@ Page Title="" Language="C#" MasterPageFile="~/Admi/Admi.Master" AutoEventWireup="true" CodeBehind="UserAdmin.aspx.cs" Inherits="Roblox.Website.Admi.Users.UserAdmin" %>
<%@ Register Assembly="Roblox.Controls" Namespace="Roblox.Controls" TagPrefix="rbx" %>
<%@ Register Src="~/UserControls/Admi/UserAdmin/AccountSummaryPane.ascx" TagName="AccountSummaryPane" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/Admi/UserAdmin/BillingInfoPane.ascx" TagName="BillingInfoPane" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/Admi/UserAdmin/PunishmentsPane.ascx" TagName="PunishmentsPane" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/Admi/UserAdmin/UserNotesPane.ascx" TagName="UserNotesPane" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/Admi/UserAdmin/UpdateUserPane.ascx" TagName="UpdateUserPane" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/Admi/UserAdmin/GiveAndTakePane.ascx" TagName="GiveAndTakePane" TagPrefix="rbx"%>

<asp:Content ID="Content1" ContentPlaceHolderID="cphRoblox" runat="server">
    <table id="tblUserAdmin">
        <tr>
            <td class="ua_fieldset_col1" style="vertical-align: top">
                <asp:Panel ID="AccountSummarySection" GroupingText="Account Summary" runat="server">
                    <rbx:AccountSummaryPane ID="rbxAccountSummaryPane" runat="server" />
                </asp:Panel>
                <asp:Panel ID="BillingInfoSection" GroupingText="Billing Info" runat="server">
                    <rbx:BillingInfoPane ID="rbxBillingInfoPane" runat="server" />
                </asp:Panel>
                <asp:Panel ID="PunishmentsSection" GroupingText="Punishments" runat="server">
                    <rbx:PunishmentsPane ID="rbxPunishmentsPane" runat="server" />
                </asp:Panel>
                <asp:Panel ID="ProfileRatingsSection" GroupingText="Profile Ratings" runat="server">
                    someone didn't scroll down, so I don't have this section of the page >:(
                </asp:Panel>
            </td>
            <td class="ua_fieldset_col2" style="vertical-align: top">
                <asp:Panel ID="UserNotesSection" GroupingText="User Notes" runat="server">
                    <rbx:UserNotesPane ID="rbxUserNotesPane" UserID="<%# IUser.Id %>" runat="server" />
                </asp:Panel>
                <asp:Panel ID="UpdateUserSection" GroupingText="Update User" runat="server">
                    <rbx:UpdateUserPane ID="rbxUpdateUserPane" runat="server" />
                </asp:Panel>
                <asp:Panel ID="GiveAndTakeSection" GroupingText="Give and Take" runat="server">
                    <rbx:GiveAndTakePane ID="rbxGiveAndTakePane" runat="server" />
                </asp:Panel>
            </td>
        </tr>
    </table>
</asp:Content>
