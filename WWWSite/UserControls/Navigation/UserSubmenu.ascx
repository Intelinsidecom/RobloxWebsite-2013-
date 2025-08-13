<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserSubmenu.ascx.cs" Inherits="Roblox.Website.UserControls.Navigation.UserSubmenu" %>
<% if (Request.IsAuthenticated)
        { %>
  <div class="mySubmenuFixed Redesign">
    <asp:Panel ID="subMenu" CssClass="subMenu" runat="server">
      <ul>
        <li><asp:HyperLink NavigateUrl="/User.aspx?submenu=true" Text="<%$ Resources: SubNav.Profile %>" runat="server"/></li>
        <li><asp:HyperLink NavigateUrl="/My/Character.aspx" Text="<%$ Resources: SubNav.Character %>" runat="server"/></li>
        <li><asp:HyperLink NavigateUrl="/My/EditFriends.aspx" Text="<%$ Resources: SubNav.Friends %>" runat="server"/></li>
        <li><asp:HyperLink NavigateUrl="/My/Groups.aspx" Text="<%$ Resources: SubNav.Groups %>" runat="server"/></li>
        <li><asp:HyperLink NavigateUrl="/My/Stuff.aspx" Text="<%$ Resources: SubNav.Inventory %>" runat="server"/></li>
        <li><asp:HyperLink ID="SetsUrl" NavigateUrl="/My/Sets.aspx" Text="<%$ Resources: SubNav.Sets %>" runat="server"/></li>
        <li><asp:HyperLink NavigateUrl="/My/Money.aspx?tab=TradeItems" Text="<%$ Resources: SubNav.Trade %>" runat="server"/></li>
        <li><asp:HyperLink NavigateUrl="/My/Money.aspx?tab=MyTransactions" Text="<%$ Resources: SubNav.Money %>" runat="server"/></li>
        <li><asp:HyperLink NavigateUrl="/develop?Page=ads" Text="<%$ Resources: SubNav.Advertising %>" runat="server"/></li>
        <li><asp:HyperLink NavigateUrl="/My/Account.aspx" Text="<%$ Resources: SubNav.Account %>" runat="server"/></li>
      </ul>
    </asp:Panel>
  </div>
<div class="forceSpaceUnderSubmenu">&nbsp;</div>
<% } %>