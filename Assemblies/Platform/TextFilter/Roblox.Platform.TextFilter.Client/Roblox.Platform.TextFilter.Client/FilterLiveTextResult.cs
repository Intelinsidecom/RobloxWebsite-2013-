using System.Runtime.Serialization;

namespace Roblox.TextFilter.Client;

[DataContract]
public class FilterLiveTextResult
{
	[DataMember(Name = "filteredResult")]
	public virtual FilterTextResult FilteredResult { get; set; }

	[DataMember(Name = "filteredResultUnderage")]
	public virtual FilterTextResult FilteredResultUnderage { get; set; }
}
