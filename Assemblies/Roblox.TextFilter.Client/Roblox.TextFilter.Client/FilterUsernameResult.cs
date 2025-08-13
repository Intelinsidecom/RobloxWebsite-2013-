using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Roblox.TextFilter.Client;

[DataContract]
public class FilterUsernameResult
{
	[DataMember(Name = "filteredText")]
	public virtual string FilteredText { get; set; }

	[DataMember(Name = "isValid")]
	public bool IsValid { get; set; }

	[DataMember(Name = "triggeredModerationCategories")]
	public ICollection<int> TriggeredModerationCategories { get; set; }
}
