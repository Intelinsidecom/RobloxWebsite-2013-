<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HeaderPane.ascx.cs" Inherits="Roblox.Website.UserControls.UserContent.HeaderPane" %>
<%@ Register Src="~/UserControls/Abuse/ReportAbuseButton.ascx" TagName="ReportAbuseButton" TagPrefix="rbx"%>
<div style="width:900px;height:30px;clear:both; display:none;">
    <asp:Label ID="nameRegion" CssStyle="font-size:20px; font-weight:bold;" runat="server" />
</div>


<div ID="statusBox" class="blank-box" style="width:951px; padding: 8px;word-wrap: break-word;display:block;" runat="server" >
    <span style="font-size:12px;color: #888;word-wrap: normal;">
    Right now I'm: 
    </span> &nbsp;&nbsp;
        
    <asp:Label ID="statusRegion" Font-Size="14px" Font-Italic="True" CssClass="notranslate" runat="server" />&nbsp;&nbsp;
    <rbx:ReportAbuseButton ID="ReportAbuse" runat="server" />
    <asp:LinkButton NavigateUrl="#" ID="updateStatusLink" Visible="false" Style="font-size:14px;word-wrap:normal" Text="> Update My Status" OnClientClick="document.getElementById('updateStatusBox').style.display='block';document.getElementById('ctl00_cphRoblox_rbxHeaderPane_updateStatusLink').style.display='none'; return false;" runat="server" />
    <div id="updateStatusBox" style="display:none;">
        <input type="text" style="visibility:hidden;position:absolute">
        <span style="position:relative">
            <asp:TextBox ID="txtStatusMessage" Style="margin-bottom:5px;width:560px;height:17px;" runat="server" />&nbsp;&nbsp;
        </span>
        <asp:Button ID="btnUpdateStatus" Text="Save" CssClass="translate" runat="server" />&nbsp<input type="button" value="Cancel" onclick="document.getElementById('updateStatusBox').style.display='none';document.getElementById('<%# updateStatusLink.ClientID %>').style.display='inline';" /><br />
    </div>
</div>