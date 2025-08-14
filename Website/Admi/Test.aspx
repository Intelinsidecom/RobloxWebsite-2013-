<%@ Page Title="Test Page" Language="C#" MasterPageFile="~/Admi/AdmiSimple.Master" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Roblox.Website.Admi.Test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cphRoblox" runat="server">
    <h1>WebForms Test Page</h1>

    <asp:Panel ID="Panel1" BackColor="White" CssClass="AdminPanel" runat="server">
        <h3>Platform IUser Test</h3>
        Primary RoleSet: <asp:Label ID="Label1" Text='<%# IRoleSet.Name %>' runat="server" />
        <asp:GridView ID="GridView1"
            AutoGenerateColumns="True"
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
            <EmptyDataTemplate>
                The specified user does not exist
            </EmptyDataTemplate>
        </asp:GridView>

        <h3>Platform IRoleSet Test</h3>
        <asp:GridView ID="GridView2"
            AutoGenerateColumns="True"
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
            <EmptyDataTemplate>
                The specified account ID has no associated roles
            </EmptyDataTemplate>
        </asp:GridView>

        
        <h3>Platform IEmailAddress Test</h3>
        <asp:GridView ID="GridView3"
            AutoGenerateColumns="True"
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
            <EmptyDataTemplate>
                The specified account ID has no associated email address
            </EmptyDataTemplate>
        </asp:GridView>

        
        <h3>AssetType Test</h3>
        <asp:GridView ID="GridView4"
            AutoGenerateColumns="True"
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
            <EmptyDataTemplate>
                No AssetTypes found
            </EmptyDataTemplate>
        </asp:GridView>
    </asp:Panel>
</asp:Content>
