<%@ Page Title="" Language="C#" MasterPageFile="~/Roblox.Master" AutoEventWireup="true" CodeBehind="ResetPasswordRequest.aspx.cs" Inherits="Roblox.Website.Login.ResetPasswordRequest" %>
<asp:Content ID="Content" ContentPlaceHolderID="cphRoblox" runat="server">
    <div style="margin: 10px 0;"><h2><asp:Literal runat="server" Text="<%$ Resources:Authentication.ResetPassword, Heading.ForgotUsernameOrPassword %>" /></h2></div>
    <div>
        <p><asp:Literal runat="server" Text="<%$ Resources:Authentication.ResetPassword, Message.PasswordResetExplanation %>" /><br /></p>
        <p style="color: red;"><asp:Literal runat="server" Text="<%$ Resources:Authentication.ResetPassword, Message.CantSendEmailWarning %>" /></p>
        <p><span class="form-label" style="display:inline-block;min-width:120px;"><asp:Literal runat="server" Text="<%$ Resources:Authentication.ResetPassword, Label.Username %>" />:</span><asp:TextBox ID="UserName" runat="server" /></p>
        <table>
            <tr>
                <td>&nbsp;</td>
                <td width="140">
                    <asp:LinkButton ID="ResetPasswordButton" OnClick="ResetPasswordButton_Click" Text="<%$ Resources:Authentication.ResetPassword, Label.ResetPassword %>" runat="server" />
                </td>
                <td>
                    <asp:Label ID="PasswordMessage" runat="server" />
                </td>
            </tr>
        </table>
        <p><span class="form-label" style="display:inline-block;min-width:120px;"><asp:Literal runat="server" Text="<%$ Resources:Authentication.ResetPassword, Label.Email %>" />:</span><asp:TextBox ID="UserEmail" runat="server" /></p>
        <table>
            <tr>
                <td>&nbsp;</td>
                <td width="140">
                    <asp:LinkButton ID="UsernamesReminderButton" OnClick="UsernamesReminderButton_Click" Text="<%$ Resources:Authentication.ResetPassword, Label.UsernamesReminder %>" runat="server" />
                </td>
                <td>
                    <asp:Label ID="UsernameMessage" runat="server" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>