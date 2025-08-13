using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class CreateContentPackRequest
{
	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "componentName")]
	public string ComponentName { get; set; }

	[DataMember(Name = "cssContent")]
	public string CssContent { get; set; }

	[DataMember(Name = "javaScriptContent")]
	public string JavaScriptContent { get; set; }

	[DataMember(Name = "translationResourceNamespaces")]
	public string[] TranslationResourceNamespaces { get; set; }

	[DataMember(Name = "componentDependencies")]
	public string[] ComponentDependencies { get; set; }
}
