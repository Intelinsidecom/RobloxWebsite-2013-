namespace Roblox.Kickbox;

/// <summary>
/// Result of an Email check request.
/// </summary>
public interface IKickboxVerifyEmailResult
{
	string Status { get; }

	string Error { get; }

	string Result { get; set; }

	string Reason { get; set; }

	/// <summary>
	/// true if the email address is a role address (postmaster@example.com, support@example.com, etc)
	/// </summary>
	bool Role { get; }

	/// <summary>
	/// true if the email address uses a free email service like gmail.com or yahoo.com
	/// </summary>
	bool Free { get; }

	/// <summary>
	/// Whether the email was identified as a disposable address.
	/// </summary>
	bool Disposable { get; }

	/// <summary>
	/// true if the email was accepted, but the domain appears to accept all emails addressed to that domain
	/// </summary>
	bool AcceptAll { get; }

	/// <summary>
	/// Returns a suggested email if a possible spelling error was detected. (bill.lumbergh@gamil.com -&gt; bill.lumbergh@gmail.com)
	/// </summary>
	string DidYouMean { get; }

	/// <summary>
	/// A quality score of the provided email address ranging between 0 (no quality) and 1 (perfect quality). More information on the Sendex Score can be found here
	/// </summary>
	double Sendex { get; }

	/// <summary>
	/// Returns a normalized version of the provided email address. (BoB@example.com -&gt; bob@example.com)
	/// </summary>
	string Email { get; }

	/// <summary>
	/// The username part of the email address
	/// </summary>
	string User { get; }

	/// <summary>
	/// The email address domain.
	/// </summary>
	string Domain { get; }

	/// <summary>
	/// true if the API request was successful (i.e., no authentication or unexpected errors occurred)
	/// </summary>
	bool Success { get; }

	/// <summary>
	/// The Kickbox error description.
	/// </summary>
	string Message { get; }
}
