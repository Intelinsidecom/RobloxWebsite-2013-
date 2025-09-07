using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Roblox.WebAppUploader;

[DataContract]
internal class WebAppUploaderConfiguration
{
	[DataMember(Name = "apiKey")]
	public string ApiKey { get; set; }

	[DataMember(Name = "staticContentServiceEndpoint")]
	public string StaticContentServiceEndpoint { get; set; }

	[DataMember(Name = "contentPackName")]
	public string ContentPackName { get; set; }

	[DataMember(Name = "components")]
	public ICollection<ComponentConfiguration> Components { get; set; }

	[DataMember(Name = "imagesDirectory")]
	public string ImagesDirectory { get; set; }

	[DataMember(Name = "sourceMapsDirectory")]
	public string SourceMapsDirectory { get; set; }
}
