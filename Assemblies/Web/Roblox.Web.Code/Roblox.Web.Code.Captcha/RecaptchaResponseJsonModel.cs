using System.Collections.Generic;
using Newtonsoft.Json;

namespace Roblox.Web.Code.Captcha;

public class RecaptchaResponseJsonModel
{
	[JsonProperty("success")]
	public bool Success;

	[JsonProperty("error-codes")]
	public List<string> ErrorCodes;

	[JsonProperty("score")]
	public double Score;
}
