using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.TextFilter.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class TextAuthor : IClientTextAuthor
{
	[DataMember(Name = "id")]
	public long Id { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "isUnder13")]
	public bool IsUnder13 { get; set; }

	public static IClientTextAuthor UnknownTextAuthor()
	{
		return new TextAuthor
		{
			Id = -1L,
			Name = "unknown",
			IsUnder13 = true
		};
	}
}
