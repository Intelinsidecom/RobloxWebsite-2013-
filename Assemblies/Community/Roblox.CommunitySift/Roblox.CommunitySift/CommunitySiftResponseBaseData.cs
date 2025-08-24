using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace Roblox.CommunitySift;

/// <summary>
/// Base community sift response
/// </summary>
public abstract class CommunitySiftResponseBaseData
{
	/// <summary>
	/// (Always present) The trust level of the user.
	/// </summary>
	[JsonProperty("trust")]
	public int Trust { get; set; }

	/// <summary>
	/// (Always present) Whether the text passed the selected ruleset.
	/// </summary>
	[JsonProperty("response")]
	public bool Response { get; set; }

	/// <summary>
	/// (May be omitted) The topic risk levels identified for the text.
	/// </summary>
	[JsonProperty("topics")]
	public Dictionary<int, int> Topics { get; set; }

	/// <summary>
	/// The text response from CommunitySift, if Response is true this will be set.
	/// </summary>
	public virtual string Text { get; set; }

	/// <summary>
	/// Status Code for Internal Use
	/// </summary>
	public HttpStatusCode StatusCode { get; set; }

	/// <summary>
	/// Custom Error Message for Internal Use
	/// </summary>
	public string ErrorMessage { get; set; }
}
