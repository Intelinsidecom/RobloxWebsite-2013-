using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.TextFilter.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class FilterTextResult
{
	[DataMember(Name = "filteredText")]
	public virtual string FilteredText { get; set; }

	[DataMember(Name = "moderationLevel")]
	public virtual byte ModerationLevel { get; set; }

	[DataMember(Name = "triggeredModerationCategories")]
	public virtual ICollection<int> TriggeredModerationCategories { get; set; }
}
