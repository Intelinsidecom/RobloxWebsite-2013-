<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserNotesPane.ascx.cs" Inherits="Roblox.Website.UserControls.Admi.UserAdmin.UserNotesPane" %>

<asp:UpdatePanel ID="UserNotesUpdatePanel" UpdateMode="Conditional" runat="server">
    <ContentTemplate>
        <asp:Panel ID="AddUserNotePanel" CssClass="ua_component_col2_div" runat="server">
            <asp:TextBox ID="txtUserNotes" TextMode="MultiLine" Width="325px" Height="80px" CssClass="text_area" runat="server" />
            <asp:Button Text="Add Note" ID="btnAddUserNote" OnClick="btnAddUserNote_Click" runat="server" />
        </asp:Panel>
        <asp:Repeater ID="UserNotesRepeater" ItemType="Roblox.Website.ViewModels.Admi.UserAdmin.UserNoteModel" runat="server">
            <ItemTemplate>
                <asp:Panel ID="UserNotePanel"
                    CssClass="ua_component_col2_div UserNotesContainer"
                    BorderWidth="1"
                    Style="line-height: 10px" runat="server">
                    <asp:Label ID="lblTimestamp" Font-Size="Smaller" Style="float: right" Text='<%# Item.Created %>' runat="server" />
                    <br />
                    <br />
                    <asp:Label ID="lblUserNote" Font-Bold="True" Text='<%# $"\"{Item.Text}\"" %>' Style="line-height: 12px" runat="server" />
                    <br />
                    <br />
                    <asp:HyperLink ID="lblModeratorName" Font-Size="Smaller" Text='<%# $"-{Item.ModeratorName}" %>' NavigateUrl='<%# $"~/Admi/Users/UserAdmin.aspx?ID={Item.ModeratorID}" %>' runat="server" />
                </asp:Panel>
            </ItemTemplate>
        </asp:Repeater>
    </ContentTemplate>
</asp:UpdatePanel>