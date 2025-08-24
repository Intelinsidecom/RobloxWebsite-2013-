using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Http.ServiceClient;

[DataContract]
[ExcludeFromCodeCoverage]
public class Payload<T>
{
	[DataMember(Name = "data")]
	public T Data { get; set; }

	[DataMember(Name = "error", EmitDefaultValue = false)]
	public PayloadError Error { get; set; }
}
