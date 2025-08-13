<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UpdateUserPane.ascx.cs" Inherits="Roblox.Website.UserControls.Admi.UserAdmin.UpdateUserPane" %>

<asp:UpdatePanel ID="UpdateUserUpdatePanel" UpdateMode="Conditional" runat="server">
    <ContentTemplate>
        <asp:Table ID="UpdateUserTable" CssClass="ua_component_col2_table" runat="server">
            <asp:TableRow>
                <asp:TableCell>Blurb:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtUserBlurb" TextMode="MultiLine" Width="150px" Height="120px" CssClass="text_area" Text='<%# Model.Blurb %>' runat="server" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Email:</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="lblEmail" Width="138px" Text='<%# Model.EmailAddress %>' runat="server" />
                    <asp:CheckBox ID="cbxEmailVerified" Enabled="False" Checked='<%# Model.IsEmailVerified %>' runat="server" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Password:</asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtPassword" Width="138px" Text='<%# Model.Password %>' runat="server" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>User Created:</asp:TableCell>
                <asp:TableCell><asp:Label ID="lblUserCreated" runat="server" Text='<%# Model.Created %>'></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Last Location:</asp:TableCell>
                <asp:TableCell><asp:Label ID="lblLastLocation" runat="server" Text='<%# Model.LastLocation %>'></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Last Activity:</asp:TableCell>
                <asp:TableCell><asp:Label ID="lblLastActivity" runat="server" Text='<%# Model.LastActivityDate %>'></asp:Label></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>Approved:</asp:TableCell>
                <asp:TableCell><asp:CheckBox ID="cbxApproved" Enabled="False" Checked='<%# Model.IsApproved %>' runat="server" /></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell />
                <asp:TableCell><asp:Button ID="btnUpdateUser" Text="Update User" OnClick="btnUpdateUser_Click" runat="server" /></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </ContentTemplate>
</asp:UpdatePanel>