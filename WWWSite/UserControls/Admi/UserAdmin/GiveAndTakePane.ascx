<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GiveAndTakePane.ascx.cs" Inherits="Roblox.Website.UserControls.Admi.UserAdmin.GiveAndTakePane" %>

<asp:UpdatePanel ID="GiveAndTakeUpdatePanel" UpdateMode="Conditional" runat="server">
    <ContentTemplate>
        <asp:Table ID="GiveAndTakeTable" CssClass="ua_component_col2_table"  runat="server">
            <asp:TableRow>
                <asp:TableCell>Robux:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtRobux" Text='<%# Model.Robux %>' TextMode="Number" runat="server" /></asp:TableCell>
                <asp:TableCell>Max:</asp:TableCell>
                <asp:TableCell><asp:Label ID="lblMaxRobux" Text='<%# Model.MaxRobux %>' runat="server" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Tickets:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtTickets" Text='<%# Model.Tickets %>' TextMode="Number" runat="server" /></asp:TableCell>
                <asp:TableCell>Max:</asp:TableCell>
                <asp:TableCell><asp:Label ID="lblMaxTickets" Text='<%# Model.MaxTickets %>' runat="server" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Asset:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtAssetID" Text="" TextMode="Number" runat="server" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Badge</asp:TableCell>
                <asp:TableCell></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Credit:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtCredit" Text='<%# Model.Credit %>' TextMode="Number" runat="server" /></asp:TableCell>
                <asp:TableCell>Max:</asp:TableCell>
                <asp:TableCell><asp:Label ID="lblMaxCredit" Text='<%# Model.MaxCredit %>' runat="server" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableFooterRow>
                <asp:TableCell><asp:Button ID="btnSubmit" Text="Give" OnClick="btnSubmit_Click" runat="server" /></asp:TableCell>
            </asp:TableFooterRow>
        </asp:Table>
    </ContentTemplate>
</asp:UpdatePanel>