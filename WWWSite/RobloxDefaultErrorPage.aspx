<%@ Page Title="ROBLOX Error" Language="C#" MasterPageFile="~/Simple.Master" AutoEventWireup="true" CodeBehind="RobloxDefaultErrorPage.aspx.cs" Inherits="Roblox.Website.RobloxDefaultErrorPage" %>
<asp:Content ID="RobloxContent" ContentPlaceHolderID="cphRoblox" runat="server">
    <div id="ErrorPage">    
        <img src='/Images/Icons/img-alert-crop.png' alt="Alert" class="ErrorAlert"/>
    
        <h1><asp:Label ID="ErrorTitle" Text="<%$ Resources: Errors.500.Title %>" runat="server" /></h1>
        <h3><asp:Label ID="ErrorMessage" Text="<%$ Resources: Errors.500.Message %>" runat="server" /></h3>
        <p><asp:Label ID="CustomerServiceMessage" Text="<%$ Resources: CustomerServiceMessage %>" runat="server" /></p>
        <pre><asp:Label ID="errorMsgLbl" Text="" runat="server" /></pre>

        <div class="divideTitleAndBackButtons">&nbsp;</div>

        <div class="CenterNavigationButtonsForFloat">
            <a class="btn-small btn-neutral" title="Go to Previous Page Button" onclick="history.back();return false;" href="#">Go to Previous Page</a>
            <a class="btn-neutral btn-small" title="Return Home" href="/Default.aspx">Return Home</a>
            <div style="clear:both"></div>
        </div>
    </div>
</asp:Content>
