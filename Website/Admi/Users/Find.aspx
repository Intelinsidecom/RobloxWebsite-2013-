<%@ Page Title="" Language="C#" MasterPageFile="~/Admi/Admi.Master" AutoEventWireup="true" CodeBehind="Find.aspx.cs" Inherits="Roblox.Website.Admi.Users.Find" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphRoblox" runat="server">
    <asp:Panel ID="SearchForm" runat="server">
        <asp:Panel ID="BillingSearchPanel" runat="server">
            Billing: Billing Search has been moved <asp:HyperLink ID="hlBillingSearch" NavigateUrl="~/Admi/AccountUpgrades/Payments.aspx" Text="HERE" runat="server" />
        </asp:Panel>
        <br />
        <asp:Panel ID="UserNameSearchPanel" runat="server">
            User Name <asp:TextBox ID="txtUserName" runat="server" /> <asp:Button ID="btnUserNameSearch" OnClick="btnUserNameSearch_Click" Text="Search By Username" runat="server" />
        </asp:Panel>
        <br /><hr /><br />
        <asp:Panel ID="UserIDSearchPanel" runat="server">
            User ID <asp:TextBox ID="txtUserID" runat="server" /> <asp:Button ID="btnUserIDSearch" OnClick="btnUserIDSearch_Click" Text="Search By User ID" runat="server" />
        </asp:Panel>
        <br /><hr /><br />
        <asp:Panel ID="EmailAddressSearchPanel" runat="server">
            Email Address <asp:TextBox ID="txtEmailAddress" runat="server" /> <asp:Button ID="btnEmailAddressSearch" OnClick="btnEmailAddressSearch_Click" Text="Search By Email Address" runat="server" />
        </asp:Panel>
        <br /><hr />
    </asp:Panel>
    User Search Results

    <asp:GridView ID="UserSearchGridView"
        AutoGenerateColumns="False"
        ShowHeaderWhenEmpty="True"
        CellPadding="4" ForeColor="#333333"
        GridLines="None"
        runat="server" >

        <AlternatingRowStyle BackColor="White" />
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />

        <Columns>
            <asp:HyperLinkField DataTextField="Name" HeaderText="Name" DataNavigateUrlFields="ID" DataNavigateUrlFormatString="~/Admi/Users/UserAdmin.aspx?ID={0}" />
            <asp:BoundField DataField="ID" HeaderText="ID" />
            <asp:CheckBoxField DataField="IsOnline" HeaderText="Online" />
            <asp:BoundField DataField="EmailAddress" HeaderText="Email" />
            <asp:BoundField DataField="RoleSet" HeaderText="RoleSet" />
            <asp:BoundField DataField="Created" HeaderText="Creation Date" HeaderStyle-Width="10em" />
            <asp:BoundField DataField="LastActivityDate" HeaderText="Last Activity" HeaderStyle-Width="10em" />
            <asp:CheckBoxField DataField="IsApproved" HeaderText="Approved" />
            <asp:BoundField DataField="LastLocation" HeaderText="Last Location" HeaderStyle-Width="12em" />
            <asp:BoundField DataField="MembershipType" HeaderText="BC" />
            <asp:BoundField DataField="ModerationStatus" HeaderText="Moderation Status" HeaderStyle-Width="7em" />
            <asp:TemplateField HeaderText="Moderate User" HeaderStyle-Width="5em">
                <ItemTemplate>
                    <asp:CheckBox ID="cbxModerateUser" Checked="False" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnModerateUsers" Text="Moderate Selected Users" Visible="False" OnClick="btnModerateUsers_Click" runat="server" />
</asp:Content>
