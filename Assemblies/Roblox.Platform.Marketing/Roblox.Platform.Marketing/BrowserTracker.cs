using System;

namespace Roblox.Platform.Marketing;

public class BrowserTracker : IBrowserTracker
{
	public long Id { get; private set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	public BrowserTracker(long id, DateTime created, DateTime updated)
	{
		Id = id;
		Created = created;
		Updated = updated;
	}
}
