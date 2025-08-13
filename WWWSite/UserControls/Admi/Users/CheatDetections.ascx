<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CheatDetections.ascx.cs" Inherits="Roblox.Website.UserControls.Admi.Users.CheatDetections" %>
<%@ Register assembly="Roblox.Controls" namespace="Roblox.Controls" tagprefix="rbx" %>
<%@ Register Src="~/UserControls/Admi/UserAdmin/CheatDetectionsTable.ascx" TagName="CheatDetectionsTable" TagPrefix="rbx"%>

<rbx:Panel ID="pnlCheatDetections" runat="server">
    <Header>
        <span>Cheat Detections</span>
    </Header>
    <Content>
        <rbx:CheatDetectionsTable ID="rbxCheatDetectionsTable" UserID="<%# UserID %>" RenderHeader="False" runat="server" />
    </Content>
</rbx:Panel>