<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="JavascriptErrorTracker.ascx.cs" Inherits="Roblox.Website.UserControls.TrackingPixels.JavascriptErrorTracker" %>
<script type="text/javascript">
        $(function () {
            Roblox.JSErrorTracker.initialize(<%=JavascriptErrorTrackerViewModel.InitializeParameter%>);
        });
</script>