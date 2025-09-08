namespace Roblox.Web.StaticContent.Properties
{
    public static class Settings
    {
        public static class Default
        {
            public static bool MinifyJavaScript { get; set; } = false;
            public static bool MinifyCss { get; set; } = false;
            public static bool PushStaticImagesToS3 { get; set; } = false;
        }
    }
}
