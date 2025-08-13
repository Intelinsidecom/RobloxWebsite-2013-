<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Footer.ascx.cs" Inherits="Roblox.Website.UserControls.Navigation.Footer" %>
<div id="Footer" class="footer-container">
    <div class="FooterNav">
        <a href="/info/Privacy.aspx"><b><asp:Literal runat="server" Text="<%$ Resources: Privacy Policy%>" /></b></a>
        &nbsp;|&nbsp; 
        <a href="http://corp.roblox.com/advertise-on-roblox"><asp:Literal runat="server" Text="<%$ Resources: Advertise with Us %>" /></a>
        &nbsp;|&nbsp; 
        <a href="http://corp.roblox.com/roblox-press"><asp:Literal runat="server" Text="<%$ Resources: Press %>" /></a>
        &nbsp;|&nbsp; 
        <a href="http://corp.roblox.com/contact-us"><asp:Literal runat="server" Text="<%$ Resources: Contact Us %>" /></a>
        &nbsp;|&nbsp;
        <a href="http://corp.roblox.com/"><asp:Literal runat="server" Text="<%$ Resources: About Us %>" /></a>
        &nbsp;|&nbsp;
        <a href="http://blog.roblox.com"><asp:Literal runat="server" Text="<%$ Resources: Blog %>" /></a>
        &nbsp;|&nbsp;
        <a href="http://corp.roblox.com/jobs"><asp:Literal runat="server" Text="<%$ Resources: Jobs %>" /></a>
        &nbsp;|&nbsp;
        <a href="/Parents.aspx"><asp:Literal runat="server" Text="<%$ Resources: Parents %>" /></a>  
            <span class="LanguageOptionElement">&nbsp;|&nbsp;</span> 
            <span runat="server" NavigateUrl="/Parents.aspx" ref="footer-parents" class="LanguageOptionElement LanguageTrigger"  drop-down-nav-button="LanguageTrigger">English&nbsp;<span class="FooterArrow">▼</span>
                    <div class="dropuplanguagecontainer" style="display:none;" drop-down-nav-container="LanguageTrigger">
                        <div class="dropdownmainnav" style="z-index:1023">
                                <a href="/UserLanguage/LanguageRedirect?languageCode=de&amp;relativePath=<%= HttpUtility.UrlEncode(HttpContext.Current.Request.Url.AbsolutePath) %>"class="LanguageOption js-lang" data-js-langcode="de"><span class="notranslate">Deutsch</span>&nbsp;(German) </a>
                            </div>  
                    </div>
            </span> 
    </div>
    <div class="FooterNav">
        <div id="SEOGenreLinks" class="SEOGenreLinks">
                  <a href="/all-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.AllGames %>" /></a> 
                      <span>|</span>
                  <a href="/building-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.Building %>" /></a> 
                      <span>|</span>
                  <a href="/horror-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.Horror %>" /></a> 
                      <span>|</span>
                  <a href="/town-and-city-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.TownAndCity %>" /></a> 
                      <span>|</span>
                  <a href="/military-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.Military %>" /></a> 
                      <span>|</span>
                  <a href="/comedy-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.Comedy %>" /></a> 
                      <span>|</span>
                  <a href="/medieval-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.Medieval %>" /></a> 
                      <span>|</span>
                  <a href="/adventure-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.Adventure %>" /></a> 
                      <span>|</span>
                  <a href="/sci-fi-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.Sci-Fi %>" /></a> 
                      <span>|</span>
                  <a href="/naval-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.Naval %>" /></a> 
                      <span>|</span>
                  <a href="/fps-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.FPS %>" /></a> 
                      <span>|</span>
                  <a href="/rpg-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.RPG %>" /></a> 
                      <span>|</span>
                  <a href="/sports-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.Sports %>" /></a> 
                      <span>|</span>
                  <a href="/fighting-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.Fighting %>" /></a> 
                      <span>|</span>
                  <a href="/western-games"><asp:Literal runat="server" Text="<%$ Resources: SEOGenres.Western %>" /></a> 
        </div>
    </div>
    <div class="legal">
        <div class="left">
            <div id="a15b1695-1a5a-49a9-94f0-9cd25ae6c3b2">
                <a href="http://www.truste.org/ivalidate.php?url=www.roblox.com&sealid=105" id="TrusteeSeal"><img src="/Images/TRUSTe/seal.png" border="0" id="TrusteLogo" alt="Truste" /></a>
            </div>
        </div>
        <div class="right">
            <p class="Legalese">
    ROBLOX, "Online Building Toy", characters, logos, names, and all related indicia are trademarks of <a href="http://corp.roblox.com/" ref="footer-smallabout">ROBLOX Corporation</a>, &copy;<asp:Label ID="YearLabel" runat="server"/>. Patents pending.
    ROBLOX is not sponsored, authorized or endorsed by any producer of plastic building bricks, including The LEGO Group, MEGA Brands, and K'Nex, and no resemblance to the products of these companies is intended. Use of this site signifies your acceptance of the <a href="/info/terms-of-service" ref="footer-terms">Terms and Conditions</a>.
</p>
        </div>
        <div class="clear"></div>
    </div>
</div>