namespace Roblox.Platform.EventStream.WebEvents;

public class DeviceHandleRequestedEventArgs : WebEventArgs
{
	/// <summary>
	/// Url of the action for which the device handle was evaluated.
	/// E.g. this would be the friend request api endpoint while the
	/// ReferrerUrl would corresopnd to the user profile page.
	/// </summary>
	public string PageUrl { get; set; }

	/// <summary>
	/// Did this HTTP request supply device handle, either in header or in cookie,
	/// and was it valid?
	/// </summary>
	public bool Valid { get; set; }

	/// <summary>
	/// Device handle was supplied in the header.
	/// </summary>
	public bool SuppliedInHeader { get; set; }

	/// <summary>
	/// Device handle was supplied as a cookie
	/// </summary>
	public bool SuppliedInCookie { get; set; }

	/// <summary>
	/// Device handle was not supplied
	/// </summary>
	public bool NotSupplied { get; set; }

	/// <summary>
	/// Device handle was supplied in header or as cookie,
	/// it was evaluated and determined to be invalid
	/// </summary>
	public bool Invalid { get; set; }

	/// <summary>
	/// This request failed the device handle check, either because it supplied
	/// an invalid device handle or none was supplied at all
	/// </summary>
	public bool Failed { get; set; }
}
