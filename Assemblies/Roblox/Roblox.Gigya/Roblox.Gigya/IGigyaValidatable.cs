namespace Roblox.Gigya;

/// <summary>
/// Provides a common interface for any Gigya object that can be Validated
/// </summary>
/// <remarks>
/// See: http://developers.gigya.com/display/GD/Security+Guidelines
/// </remarks>
public interface IGigyaValidatable
{
	/// <summary>
	/// The UID of this validatable object.
	/// </summary>
	string UID { get; }

	/// <summary>
	/// The Signature of this validatable object.
	/// </summary>
	/// <remarks>
	/// The name used here isn't quite the same as what we get from Gigya.  This will coorespond to the UIDSignature field
	/// but the name has been simplified to Signature.  This field actually holds signed data that represents both the UID
	/// and the timestamp at which it was signed so UIDSignature isn't a very accurate name.
	/// </remarks>
	string Signature { get; }

	/// <summary>
	/// The Timestamp of this validatable object.
	/// </summary>
	/// <remarks>
	/// The name used here isn't quite the same as what we get from Gigya.  This will coorespond to the signatureTimestamp field
	/// but the name has been simplified to Timestamp.  This field ONLY holds the timestamp at which the signature was signed.
	/// </remarks>
	int Timestamp { get; }

	/// <summary>
	/// The error message describing any errors.
	/// </summary>
	string ErrorMessage { get; }

	/// <summary>
	/// True if validation was not attempted or was passed; false if validation was attempted and not passed.
	/// </summary>
	bool IsValid { get; }
}
