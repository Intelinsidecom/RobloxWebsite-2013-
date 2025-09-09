namespace Roblox.Web.Code
{
    public static class LayoutSettings
    {
        // Toggle to switch between MVC nav bar and WebForms MenuRedesign.
        // Default to false to keep legacy WebForms behavior unless explicitly enabled.
        public static bool UseMvcNavBar { get; set; } = false;

        // Mirrors the old external setting: Layout.Default.IsUpdatedInstallationInstructionsModalEnabled
        public static bool UseUpdatedInstallationInstructionsModal { get; set; } = false;
    }
}
