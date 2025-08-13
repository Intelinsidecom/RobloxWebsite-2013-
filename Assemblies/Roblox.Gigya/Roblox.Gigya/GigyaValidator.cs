using System;
using Gigya.Socialize.SDK;
using Roblox.Gigya.Properties;

namespace Roblox.Gigya;

internal class GigyaValidator : IGigyaValidator
{
	/// <summary>
	/// The secret key used validate signatures.
	/// </summary>
	protected virtual string SecretKey => Settings.Default.GigyaSecretKey;

	/// <remarks>
	/// See: http://developers.gigya.com/display/GD/Security+Guidelines#SecurityGuidelines-VerifyingAuthenticity
	/// </remarks>
	public bool Validate(IGigyaValidatable validatable, out string errorMessage)
	{
		errorMessage = string.Empty;
		if (validatable == null)
		{
			throw new ArgumentNullException("validatable");
		}
		if (!SigUtils.ValidateUserSignature(validatable.UID, validatable.Timestamp.ToString(), SecretKey, validatable.Signature))
		{
			errorMessage = "Could not validate gigya request for UID: " + validatable.UID;
			return false;
		}
		return true;
	}
}
