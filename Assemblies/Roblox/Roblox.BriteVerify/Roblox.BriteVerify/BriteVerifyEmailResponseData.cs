using Newtonsoft.Json;

namespace Roblox.BriteVerify;

internal class BriteVerifyEmailResponseData
{
	/// <summary>
	/// The full email address.
	/// </summary>
	[JsonProperty("address")]
	public string Address { get; set; }

	/// <summary>
	/// The username part of the email address
	/// </summary>
	[JsonProperty("account")]
	public string Account { get; set; }

	/// <summary>
	/// The email address domain.
	/// </summary>
	[JsonProperty("domain")]
	public string Domain { get; set; }

	/// <summary>
	/// The result of the BriteVerify call.
	/// </summary>
	[JsonProperty("status")]
	public string Status { get; set; }

	/// <summary>
	/// ???.
	/// </summary>
	[JsonProperty("connected")]
	public string Connected { get; set; }

	/// <summary>
	/// Whether the email was identified as a disposable address.
	/// </summary>
	[JsonProperty("disposable")]
	public bool IsDisposable { get; set; }

	/// <summary>
	/// ??.
	/// </summary>
	[JsonProperty("role_address")]
	public bool IsRoleAddress { get; set; }

	/// <summary>
	/// The BriteVerify internal error code.
	/// </summary>
	[JsonProperty("error_code")]
	public string ErrorCode { get; set; }

	/// <summary>
	/// The BriteVerify error description.
	/// </summary>
	[JsonProperty("error")]
	public string Error { get; set; }

	/// <summary>
	/// Duration of the API call, in seconds.
	/// </summary>
	[JsonProperty("duration")]
	public double Duration { get; set; }
}
