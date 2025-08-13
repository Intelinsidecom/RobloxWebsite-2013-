<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PunishmentsPane.ascx.cs" Inherits="Roblox.Website.UserControls.Admi.Users.PunishmentsPane" %>
<%@ Register assembly="Roblox.Controls" namespace="Roblox.Controls" tagprefix="rbx" %>

<rbx:Panel ID="PunishmentsPanel"
    Width="550px"
    runat="server">
    <Header>
        <span class="caption">
            Past Punishments
        </span>
    </Header>
    <Content>
        <asp:GridView ID="PunishmentsGridView"
            CellPadding="4"
            GridLines="None"
            AutoGenerateColumns="false"
            ItemType="Roblox.Website.Models.Moderation.PunishmentModel"
            ShowHeaderWhenEmpty="True" runat="server">

            <HeaderStyle BackColor="#D25532" Font-Bold="True" ForeColor="White" />

            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <a href="#" class="ExpandLinkButton">Expand</a>
                        <div style="display: none">
                            <div><u>Internal Note:</u> <%# Item.InternalNote %></div><br />
                            <div><u>Note to User:</u> <%# Item.ModeratorMessage %></div><br />
                            <div><u>Reported Abuse:</u><br />
                                <br />
                                <div>
                                    <strong><%# Item.PunishmentReasonType %></strong>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField
                    HeaderText="ID"
                    DataField="ID" />
                <asp:BoundField
                    HeaderText="Action"
                    DataField="Action" />
                <asp:HyperLinkField
                    HeaderText="Moderator"
                    DataTextField="ModeratorName"
                    DataNavigateUrlFields="ModeratorID" DataNavigateUrlFormatString="~/Admi/Users/UserAdmin.aspx?ID={0}" />
                <asp:BoundField
                    HeaderText="Internal Note"
                    DataField="InternalNote" />
                <asp:BoundField
                    HeaderText="Created"
                    DataField="Created" />
                <asp:BoundField
                    HeaderText="Expiration"
                    DataField="Expiration" />
            </Columns>
        </asp:GridView>
    </Content>
</rbx:Panel>

<script language="javascript" type="text/javascript">
    /**
     * Spent hours trying to do this in C#, then
     * gave up, then tried a bit of JS with C#, then gave up and did pure JS.
     * Fucking. Miserable.
     */
    $(document).ready(function () {
        $('.ExpandLinkButton').click(function () {;
            if ($(this).text() == "Expand") {
                $(this).closest("tr").after("<tr class='PunishmentInfoPanel'><td colspan='999'>" + $(this).next().html() + "</td></tr>");
                $(this).text("Collapse");
            } else {
                $(this).closest("tr").next().remove();
                $(this).text("Expand");
            }
        })
    })
</script>