<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ReportAbuseButton.ascx.cs" Inherits="Roblox.Website.UserControls.Abuse.ReportAbuseButton" %>
<asp:Panel ID="AbuseReportPanel" CssClass="ReportAbuse" runat="server" >
    <span class="AbuseIcon"><asp:HyperLink ID="ReportAbuseIconHyperLink" ImageUrl="~/images/abuse.PNG?v=2" ToolTip="Report Abuse" runat="server" /></span>
    <span class="AbuseButton"><asp:HyperLink ID="ReportAbuseTextHyperLink" Text="Report Abuse" runat="server" /></span>
</asp:Panel>