using System;

namespace Roblox.Platform.EventStream.WebEvents;

public class WebEventArgs : BasicEventArgs
{
	/// <summary>
	/// The pageId to tie various things on a page.
	/// </summary>
	public Guid? PageId { get; set; }

	public long? UserId { get; set; }

	public long? GuestId { get; set; }

	public long? BrowserTrackerId { get; set; }

	public string ReferrerUrl { get; set; }

	public byte? PlatformTypeId { get; set; }

	public string SessionId { get; set; }

	public string UserAgent { get; set; }
}
