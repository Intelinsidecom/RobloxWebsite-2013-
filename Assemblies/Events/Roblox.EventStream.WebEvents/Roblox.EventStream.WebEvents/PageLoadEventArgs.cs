using Roblox.EventStream.WebEvents.EventArgs;
namespace Roblox.EventStream.WebEvents {
    public class PageLoadEventArgs : WebEventArgs

{
	public string PageUrl { get; set; }

	public string InternalPageName { get; set; }

	public string EffectiveLocale { get; set; }
}


}






