using System;
using System.Collections.Generic;
using Roblox.EventStream.WebEvents.EventArgs;
using Roblox.EventStream.WebEvents;
namespace Roblox.EventStream.WebEvents {
    public class GameSortsDisplayEventArgs : WebEventArgs

{
	public int? VersionId { get; set; }

	public int? VariationValue { get; set; }

	public IReadOnlyCollection<int> GameSetIds { get; set; }
}


}





