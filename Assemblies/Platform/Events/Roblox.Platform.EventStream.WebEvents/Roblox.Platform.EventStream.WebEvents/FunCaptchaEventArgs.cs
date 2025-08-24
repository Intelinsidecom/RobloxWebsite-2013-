namespace Roblox.Platform.EventStream.WebEvents;

public class FunCaptchaEventArgs : WebEventArgs
{
	/// <summary>
	/// If FunCaptcha was solved
	/// </summary>
	public bool? Solved { get; set; }

	/// <summary>
	/// The score given by the service. Currently always 0.
	/// </summary>
	public double? Score { get; set; }

	/// <summary>
	/// The ip of the user according to FunCaptcha
	/// </summary>
	public string UserIp { get; set; }

	/// <summary>
	/// The action that triggered FunCaptcha
	/// </summary>
	public string Context { get; set; }

	/// <summary>
	/// The FunCaptcha session token. This is always set and always unique.
	/// </summary>
	public string FunCaptchaSession { get; set; }

	/// <summary>
	/// Unix Timestamp of when FunCaptcha was verified with our server as solved or not.
	/// </summary>
	public long? TimeVerified { get; set; }

	/// <summary>
	/// If the user didn't interact with FunCaptcha but it was submitted for verification.
	/// </summary>
	public bool? Attempted { get; set; }

	/// <summary>
	/// If this session had previously been validated. 
	/// Sessions can only be validated once and will always return solved:false 
	/// with this added if previously verified. Prevents replay attacks.
	/// </summary>
	public bool? PreviouslyVerified { get; set; }

	/// <summary>
	/// Sessions can only live for a certain time, by default 30 minutes.
	/// </summary>
	public bool? SessionTimedOut { get; set; }

	/// <summary>
	/// FunCaptcha was not shown due to users prior history.
	/// </summary>
	public bool? Suppressed { get; set; }

	/// <summary>
	/// Suppress mode would have shown, except user hit internal rate limits
	/// </summary>
	public bool? SuppressLimited { get; set; }

	/// <summary>
	/// The time it took to get response from FC servers
	/// </summary>
	public long? VerificationTimeElapsed { get; set; }

	/// <summary>
	/// If this is true, the result of the "Solved" parameter was ignored and we blocked this
	/// particular captcha solve. Currently this can happen if the ASN of the IP used to create
	/// the captcha token and the ASN of the IP used to redeem the token don't match.
	/// </summary>
	public bool VerificationBlocked { get; set; }
}
