using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Localization.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class GetSupportedLocalesByParentLanguageResponse
{
	[DataMember(Name = "supportedLocales")]
	public IReadOnlyCollection<SupportedLocale> SupportedLocales { get; set; }
}
