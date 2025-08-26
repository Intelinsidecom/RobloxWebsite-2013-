using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
namespace Roblox.Platform.Localization.Client {
    [DataContract]

[ExcludeFromCodeCoverage]
public class GetLanguageFamilyByIdResponse
{
	[DataMember(Name = "languageFamily")]
	public LanguageFamily LanguageFamily { get; set; }
}


}
