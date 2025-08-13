namespace Roblox.TextFilter;

/// <summary>
/// List of constants for the type of text being sent.
/// </summary>
public static class TextFilterServerType
{
	/// <summary>
	/// Text coming through webchat.
	/// </summary>
	public static readonly string WebChat = "web_chat";

	/// <summary>
	/// Text coming through the basic website or forums.
	/// </summary>
	public static readonly string WebPost = "web_post";

	/// <summary>
	/// Text connected with asset creation.
	/// </summary>
	public static readonly string WebAsset = "web_asset";

	/// <summary>
	/// Text connected with private messaging.
	/// </summary>
	public static readonly string WebPm = "web_pm";

	/// <summary>
	/// Text connected with universe creation.
	/// </summary>
	public static readonly string WebUniverse = "web_universe";
}
