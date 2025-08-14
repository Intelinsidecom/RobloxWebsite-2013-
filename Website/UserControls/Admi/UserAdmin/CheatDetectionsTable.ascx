<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CheatDetectionsTable.ascx.cs" Inherits="Roblox.Website.UserControls.Admi.UserAdmin.CheatDetectionsTable" %>

<asp:GridView ID="CheatDetectionGridView"
    AutoGenerateColumns="False"
    ShowHeaderWhenEmpty="True"
    CellPadding="3" ForeColor="Black"
    GridLines="None" BorderStyle="None" CellSpacing="2"
    runat="server">

    <HeaderStyle BackColor="Gray" Height="25px" HorizontalAlign="Left" Font-Bold="True" />

    <Columns>
        <asp:BoundField DataField="ID" HeaderText="ID" HeaderStyle-Width="90" />
        <asp:BoundField DataField="Action" HeaderText="Action" />
        <asp:BoundField DataField="Behavior" HeaderText="Detected Behavior" />
        <asp:BoundField DataField="Created" HeaderText="Date" />
    </Columns>

    <EmptyDataTemplate><b>No Results Found</b></EmptyDataTemplate>
</asp:GridView>