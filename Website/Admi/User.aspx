<%@ Page Title="" Language="C#" MasterPageFile="~/Admi/Admi.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="Roblox.Website.Admi.User" %>

<asp:Content ID="Content" ContentPlaceHolderID="cphRoblox" runat="server">
    <div>
        <br />
        User's <asp:HyperLink ID="UserHomePageHyperLink" NavigateUrl='<%# $"~/User.aspx?ID={UserID}" %>' Text="home page" runat="server" /><br />
        <br />
        <asp:Menu ID="ViewMenu"
            StaticDisplayLevels="3"
            Orientation="Horizontal"
            BackColor="#FFFBD6"
            IncludeStyleBlock="False"
            RenderingMode="Table" runat="server">
            <StaticMenuItemStyle
                ForeColor="#990000"
                Font-Names="Verdana"
            />
            <StaticHoverStyle BackColor="Firebrick" />
            <StaticSelectedStyle BackColor="#FFCC66" />
            <Items>
                <asp:MenuItem Text="Details" Value="0" />
                <asp:MenuItem Text="Actions" Value="1" />
            </Items>
        </asp:Menu>
        <br />
        <% switch (ViewMenu.SelectedValue)
        {%>
            <%case "1":%>
                <asp:Button ID="PurgeForumPostsButton" Text="Purge Forum Posts" runat="server" /><br />
                <br />
                Account State override:<br />
                <asp:RadioButtonList
                    ID="PunishmentOptionsRadioButtonList"
                    DataSourceID="PunishmentTypeDataSource"
                    DataTextField="Value"
                    DataValueField="ID"
                    runat="server" />
                <asp:ObjectDataSource ID="PunishmentTypeDataSource" runat="server"  SelectMethod="GetPunishmentTypes" TypeName="Roblox.Website.Admi.User" />
                
                <p>Moderation Note: <asp:TextBox ID="AccountStateModerationNoteTextBox" runat="server" /></p>
                <p>Message to User: <asp:TextBox ID="AccountStateMessageToUserTextBox" runat="server" /></p>
                <asp:Button ID="OverrideAccountStateButton" Text="Submit" OnClick="OverrideAccountStateButton_Click" runat="server" /><br />
                <br />
                
                <div>
                    <asp:GridView ID="UserPunishmentsGridView"
                        CellPadding="4"
                        BackColor="White"
                        GridLines="None"
                        AutoGenerateColumns="false" runat="server">

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
                            <asp:BoundField
                                HeaderText="ID"
                                DataField="ID" />
                            <asp:BoundField
                                HeaderText="Punishment Type"
                                DataField="Action" />
                            <asp:HyperLinkField
                                HeaderText="Moderator"
                                DataTextField="ModeratorName"
                                DataNavigateUrlFields="ModeratorID" DataNavigateUrlFormatString="~/Admi/Users/UserAdmin.aspx?ID={0}" />
                            <asp:BoundField
                                HeaderText="Action Date"
                                DataField="Created" />
                            <asp:BoundField
                                HeaderText="Expires"
                                DataField="Expiration" />
                        </Columns>

                        <EmptyDataTemplate>
                            There are no punishments against this user.
                        </EmptyDataTemplate>
                    </asp:GridView>
</div>
            <%break;%>
        <% } %>
        <br />
    </div>
</asp:Content>
