using System.ComponentModel;
using Newtonsoft.Json;

namespace Roblox;

public class TransferFileTask
{
	public string Hash { get; set; }

	public string ContentType { get; set; }

	public string Format { get; set; }

	[DefaultValue(0)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
	public int VerifyRetryCount { get; set; }

	[DefaultValue(0)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
	public int UploadRetryCount { get; set; }

	[DefaultValue(false)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Populate)]
	public bool VerifyOnly { get; set; }
}
