namespace Roblox.Platform.EventStream.WebEvents;

public class GroupSearchEventArgs : WebEventArgs
{
	/// <summary>
	/// The keyword for the search.
	/// </summary>
	public string Keyword { get; set; }

	/// <summary>The assets returned in CSV format</summary>
	public string GroupsReturned { get; set; }

	/// <summary>
	/// Page on which current results shown.
	/// </summary>
	public string Page { get; set; }
}
