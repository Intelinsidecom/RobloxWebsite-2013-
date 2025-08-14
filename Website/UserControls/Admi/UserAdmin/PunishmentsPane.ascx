<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PunishmentsPane.ascx.cs" Inherits="Roblox.Website.UserControls.Admi.UserAdmin.PunishmentsPane" %>

<asp:GridView ID="PunishmentsGridView"
    CellPadding="4"
    ForeColor="#333333"
    GridLines="None"
    AutoGenerateColumns="false"
    ShowHeaderWhenEmpty="True" runat="server">

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
            HeaderText="Action"
            DataField="Action" />
        <asp:HyperLinkField
            HeaderText="Moderator"
            DataTextField="ModeratorName"
            DataNavigateUrlFields="ModeratorID" DataNavigateUrlFormatString="~/Admi/Users/UserAdmin.aspx?ID={0}" />
        <asp:BoundField
            HeaderText="Created"
            DataField="Created" />
        <asp:BoundField
            HeaderText="Expiration"
            DataField="Expiration" />
    </Columns>
</asp:GridView>