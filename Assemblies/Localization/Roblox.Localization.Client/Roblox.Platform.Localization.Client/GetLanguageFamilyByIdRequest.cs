using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
namespace Roblox.Platform.Localization.Client {
    [DataContract]

[ExcludeFromCodeCoverage]
internal class GetLanguageFamilyByIdRequest
{
	[DataMember(Name = "id")]
	public int Id { get; set; }
}


}
