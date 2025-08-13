<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AccountSummaryPane.ascx.cs" Inherits="Roblox.Website.UserControls.Admi.UserAdmin.AccountSummaryPane" %>
<%@ Register Src="CheatDetectionsTable.ascx" TagName="CheatDetectionsTable" TagPrefix="rbx"%>

<asp:Panel ID="AccountSummaryPanel" BackColor="LightSteelBlue" runat="server">
    <asp:FormView ItemType="Roblox.Website.ViewModels.Admi.UserAdmin.AccountSummaryViewModel" ID="AccountSummaryFormView" runat="server">
        <ItemTemplate>
            <tr>
                <td>User Name:</td>
                <td><asp:Label ID="lblName" runat="server" Text='<%# Item.Name %>' /></td>
            </tr>
            <tr>
                <td>Moderation Status:</td>
                <td><asp:Label ID="lblModerationStatus" runat="server" Text='<%# Item.ModerationStatus %>' /></td>
            </tr>
            <tr>
                <td>User ID:</td>
                <td>
                    <asp:TextBox ID="txtUserID" runat="server" Text='<%# Item.UserID %>' />
                    <asp:Button ID="btnUserIDSearch" runat="server" OnClick="btnUserIDSearch_Click" Text="Search" />
                </td>
            </tr>
            <tr>
                <td>User Name:</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server" Text='<%# Item.UserName %>'></asp:TextBox>
                    <asp:Button ID="btnUserNameSearch" runat="server" OnClick="btnUserNameSearch_Click" Text="Search" />
                </td>
            </tr>
            <tr>
                <td>Builders Club Member:</td>
                <td><asp:CheckBox ID="cbxBCMember" runat="server" Enabled='<%# Item.IsPremiumUser %>' /></td>
            </tr>
            <tr>
                <td>Builders Club Type:</td>
                <td><asp:Label ID="lblBCType" Text='<%# Item.MembershipType %>' runat="server" /></td>
            </tr>
            <tr>
                <td>Builders Club Expiration Date:</td>
                <td><asp:Label ID="lblBCExpirationDate" Text='<%# Item.MembershipExpirationDate %>' runat="server" /></td>
            </tr>
            <tr>
                <td>Builders Club Renewal Date:</td>
                <td><asp:Label ID="lblBCRenewalDate" Text='<%# Item.MembershipRenewalDate %>' runat="server" /></td>
            </tr>
            <tr>
                <td>Loyal Since:</td>
                <td><asp:Label ID="lblLoyalSince" Text='<%# Item.LoyalSinceDate %>' runat="server" /></td>
            </tr>
            <tr>
                <td>Current Location:</td>
                <td><asp:Label ID="lblCurrentLocation" Text='<%# Item.Location %>' runat="server" /></td>
            </tr>
            <tr>
                <td><asp:Image ID="AvatarThumbnail" ImageUrl="~/Images/Accounts/boy.png" runat="server" /><asp:Image ID="MembershipOverlay" ImageUrl="~/Images/empty.png" runat="server" /></td>
                <td>
                    <rbx:CheatDetectionsTable ID="rbxCheatDetectionsTable" UserID="<%# Item.ID %>" runat="server" />
                </td>
            </tr>
            <tr>
                <td />
                <td><asp:HyperLink NavigateUrl='<%# Eval("ID", "~/User.aspx?ID={0}") %>' Text="User Homepage" ID="hlUserHomepage" runat="server" /></td>
            </tr>
            <tr>
                <td />
                <td><asp:HyperLink NavigateUrl="" Text="Machine Info" ID="hlMachineInfo" runat="server" /></td>
            </tr>
            <tr>
                <td />
                <td><asp:LinkButton ID="lbModerateUser" Text="Moderate User" OnClick="lbModerateUser_Click" runat="server" /></td>
            </tr>
            <tr>
                <td />
                <td><asp:HyperLink NavigateUrl="" Text="Payment Info" ID="hlPaymentInfo" runat="server" /></td>
            </tr>
        </ItemTemplate>
    </asp:FormView>
</asp:Panel>