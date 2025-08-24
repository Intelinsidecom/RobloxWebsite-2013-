namespace Roblox.BriteVerify;

/// <summary>
/// Result of an Email check request.
/// </summary>
public interface IBriteVerifyEmailResult
{
	/// <summary>
	/// The full email address.
	/// </summary>
	string Address { get; }

	/// <summary>
	/// The username part of the email address
	/// </summary>
	string Account { get; }

	/// <summary>
	/// The email address domain.
	/// </summary>
	string Domain { get; }

	/// <summary>
	/// The result of the BriteVerify call.
	/// http://docs.briteverify.com/status-key/
	/// VALID, INVALID, ACCEPT ALL, UNKNOWN
	/// </summary>
	string Status { get; }

	/// <summary>
	/// ???.
	/// </summary>
	string Connected { get; }

	/// <summary>
	/// Whether the email was identified as a disposable address.
	/// </summary>
	bool IsDisposable { get; }

	/// <summary>
	/// ??.
	/// </summary>
	bool IsRoleAddress { get; }

	/// <summary>
	/// The BriteVerify internal error code.
	/// </summary>
	string ErrorCode { get; }

	/// <summary>
	/// The BriteVerify error description.
	/// </summary>
	string Error { get; }

	/// <summary>
	/// Duration of the API call, in seconds.
	/// </summary>
	double Duration { get; }
}
