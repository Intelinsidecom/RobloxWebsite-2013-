using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Roblox.WebAppUploader;

[DataContract]
internal class ComponentConfiguration
{
	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "files")]
	public ICollection<string> Files { get; set; }

	[DataMember(Name = "translationResourceNamespaces")]
	public ICollection<string> TranslationResourceNamespaces { get; set; }

	[DataMember(Name = "componentDependencies")]
	public ISet<string> ComponentDependencies { get; set; }
}
