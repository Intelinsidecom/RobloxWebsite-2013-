using Roblox.Platform.Core;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeVendorFactory" />
/// </summary>
internal class TwoStepVerificationCodeVendorFactory : ITwoStepVerificationCodeVendorFactory
{
	/// <summary>
	/// A <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeVendor" /> that sends codes via email.
	/// </summary>
	private readonly ITwoStepVerificationCodeVendor _EmailVendor;

	/// <summary>
	/// A <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeVendor" /> that sends codes via SMS.
	/// </summary>
	private readonly ITwoStepVerificationCodeVendor _SmsVendor;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationCodeVendorFactory" />
	/// </summary>
	public TwoStepVerificationCodeVendorFactory(TwoStepVerificationCodeVendorViaEmail emailVendor, TwoStepVerificationCodeVendorViaSms smsVendor)
	{
		_EmailVendor = emailVendor.AssignOrThrowIfNull("emailVendor");
		_SmsVendor = smsVendor.AssignOrThrowIfNull("smsVendor");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeVendorFactory.GetCodeVendor(Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType)" />
	public ITwoStepVerificationCodeVendor GetCodeVendor(TwoStepVerificationMediaType mediaType)
	{
		if (mediaType != 0 && mediaType == TwoStepVerificationMediaType.SMS)
		{
			return _SmsVendor;
		}
		return _EmailVendor;
	}
}
