<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BillingInfoPane.ascx.cs" Inherits="Roblox.Website.UserControls.Admi.UserAdmin.BillingInfoPane" %>

<asp:Panel ID="BillingInfoPanel" CssClass="ua_component_col1" runat="server">
    <asp:FormView ID="BillingInfoFormView" ItemType="Roblox.Website.ViewModels.Admi.UserAdmin.BillingInfoViewModel" runat="server">
        <ItemTemplate>
            <tr>
                <td>Billing Name:</td><td><asp:Label ID="lblBillingName" runat="server" Text='<%# Item.BillingName %>' /></td>
            </tr>
            <tr>
                <td>Postal Code:</td><td><asp:Label ID="lblPostalCode" runat="server" Text='<%# Item.PostalCode %>' /></td>
            </tr>
            <tr>
                <td>Billing Email:</td><td><asp:Label ID="lblBillingEmail" runat="server" Text='<%# Item.BillingEmail %>' /></td>
            </tr>
            <tr>
                <td>Credit Card Info:</td><td><asp:Label ID="lblCreditCardInfo" runat="server" Text='<%# Item.CreditCardInfo %>' /></td>
            </tr>
        </ItemTemplate>
    </asp:FormView>
</asp:Panel>