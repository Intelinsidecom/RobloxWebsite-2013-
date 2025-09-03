using System;
namespace Roblox.Marketing {
    public interface IBrowserTracker

{
	long Id { get; }

	DateTime Created { get; }

	DateTime Updated { get; }
}


}
