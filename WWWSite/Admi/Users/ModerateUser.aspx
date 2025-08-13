<%@ Page Title="" Language="C#" MasterPageFile="~/Admi/AdmiSimple.Master" AutoEventWireup="true" CodeBehind="ModerateUser.aspx.cs" Inherits="Roblox.Website.Admi.Users.ModerateUser" %>
<%@ Register assembly="Roblox.Controls" namespace="Roblox.Controls" tagprefix="rbx" %>
<%@ Register Src="~/UserControls/Admi/Users/ModerationCard.ascx" TagName="ModerationCard" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/Admi/Users/CheatDetections.ascx" TagName="CheatDetections" TagPrefix="rbx"%>
<%@ Register Src="~/UserControls/Admi/Users/PunishmentsPane.ascx" TagName="PunishmentsPane" TagPrefix="rbx"%>

<asp:Content ID="Content" ContentPlaceHolderID="cphRoblox" runat="server">
    <asp:Panel ID="container" ClientIDMode="Static" runat="server">
        <%-- TODO: Make this into a UserControl somewhere down the line once we have AbuseReviewTasks or whatever they're called implemented --%>
        <rbx:Panel ID="pnlPageHeader" BorderStyle="None" runat="server">
            <Header>
                <span class="caption">
                    Current abuses to review for <%# IUser.Name %>
                </span>
            </Header>
            <Content>
                <br />
                <asp:Panel ID="pnlAbuses" runat="server">
                    <rbx:Panel ID="pnlAbuse"
                        HeaderStyle-BackColor="Black" HeaderStyle-ForeColor="White"
                        BackColor="White" runat="server">
                        <Header>
                            <span class="caption">
                                Privacy (UserStatus)
                            </span>
                        </Header>
                        <Content>
                            <div class="text">
                                i guess i cant use windows 7 for roblox wont let me change my password im so bleepin mad
                            </div>
                        </Content>
                    </rbx:Panel>
                </asp:Panel>
            </Content>
        </rbx:Panel>
        <br />
        <table id="tblModerationControls" runat="server">
            <tr>
                <td>
                    <table>
                        <tr>
                            <td style="vertical-align: top; min-width: 140px">
                                <b>Action:</b>
                                <asp:RadioButtonList
                                    ID="rblModerationAction"
                                    DataTextField="Value"
                                    DataValueField="ID"
                                    runat="server" />
                            </td>
                            <td style="vertical-align: top; min-width: 155px">
                                <b>Auto-fill fields:</b>
                                <br /> <br />
                                <table id="tblAutoFillButtons">
                                    <tr><td><asp:Button ID="btnSpam" Text="Spam" runat="server" /></td></tr>
                                    <tr><td><asp:Button ID="btnSwear" Text="Swear" runat="server" /></td></tr>
                                    <tr><td><asp:Button ID="btnPII" Text="Personal Info" runat="server" /></td></tr>
                                    <tr><td><asp:Button ID="btnSpamAlt" Text="Spam Alt" runat="server" /></td></tr>
                                    <tr><td><asp:Button ID="btnDating" Text="Dating" runat="server" /></td></tr>
                                    <tr><td><asp:Button ID="btnInappropriateTalk" Text="Inappropriate Talk" runat="server" /></td></tr>
                                    <tr><td><asp:Button ID="btnLink" Text="Link" runat="server" /></td></tr>
                                    <tr><td><asp:Button ID="btnHarassment" Text="Harassment" runat="server" /></td></tr>
                                    <tr><td><asp:Button ID="btnScam" Text="Scam" runat="server" /></td></tr>
                                    <tr><td><asp:Button ID="btnBadImage" Text="Bad Image" runat="server" /></td></tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
                <td style="vertical-align: top; width: 555px">
                    <table>
                        <tr><td>
                            <b>Note to <%# IUser.Name %>:</b>
                            <asp:TextBox ID="txtModeratorNote" TextMode="MultiLine" Width="100%" Height="4em" CssClass="text_area" runat="server" />
                        </td></tr>
                        <tr><td>
                            <b>Internal Note:</b>
                            <asp:TextBox ID="txtInternalNote" TextMode="MultiLine" Width="100%" Height="4em" CssClass="text_area" runat="server" />
                        </td></tr>
                        <tr><td>
                            <asp:CheckBox ID="cbxEscalateReport" runat="server" />
                            <b>Escalate Report:</b> For abuse reports which contain threats, suicide alerts, and/or child endangerments or a paying customer has a bad name.
                        </td></tr>
                        <tr><td>
                            <asp:CheckBox ID="cbxScrubUserName" runat="server" />
                            <b>Scrub User Name:</b> This will set the user's name to [Content Deleted]. Making it impossible for them to log in. It will also delete this account.
                        </td></tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td />
                <td style="text-align:center">
                    <asp:Button ID="btnSubmit" Text="Submit" Width="17em" Height="4em" runat="server" />
                    <asp:Button ID="btnSkip" Text="Skip" Width="8em" Height="4em" runat="server" />
                </td>
            </tr>
        </table>
        <table id="tblModerationInfo"class="ModerationInfo">
            <tr>
                <td>
                    <rbx:ModerationCard ID="rbxModerationCard" UserID="<%# UserID %>" runat="server" />
                    <rbx:CheatDetections ID="rbxCheatDetections" UserID="<%# UserID %>" runat="server" />
                </td>
                <td>
                    <rbx:PunishmentsPane ID="rbxPunishmentsPane" UserID="<%# UserID %>" runat="server" />
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
