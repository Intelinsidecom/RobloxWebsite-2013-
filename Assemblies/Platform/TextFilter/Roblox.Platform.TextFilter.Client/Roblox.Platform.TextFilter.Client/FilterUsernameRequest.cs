using System.Runtime.Serialization;

namespace Roblox.TextFilter.Client;

[DataContract]
public class FilterUsernameRequest
{
	[DataMember(Name = "text")]
	public string Text { get; set; }

	[DataMember(Name = "author")]
	public IClientTextAuthor Author { get; set; }

	[DataMember(Name = "canBypassReservedUsername")]
	public virtual bool CanBypassReservedUsername { get; set; }
}
