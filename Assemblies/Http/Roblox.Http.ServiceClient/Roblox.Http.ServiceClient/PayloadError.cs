using System.Runtime.Serialization;

namespace Roblox.Http.ServiceClient;

[DataContract]
public class PayloadError
{
	[DataMember(Name = "code")]
	public string Code { get; set; }
}
