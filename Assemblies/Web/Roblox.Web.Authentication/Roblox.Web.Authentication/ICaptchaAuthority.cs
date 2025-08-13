using Roblox.Platform.Marketing;

namespace Roblox.Web.Authentication;

/// <summary>
/// Object that determines whether captcha should be required for an operation
/// and whether or not a consumer of a particular app type should be allowed to
/// bypass captcha.
/// </summary>
public interface ICaptchaAuthority
{
	/// <summary>
	/// Whether captcha should be required.
	/// </summary>
	/// <param name="userAgent"></param>
	/// <param name="browserTracker"></param>
	/// <returns></returns>
	bool IsCaptchaRequired(string userAgent, IBrowserTracker browserTracker);

	/// <summary>
	/// Whether a particular consumer should be allowed to use the Device Handle system to skip
	/// captcha.
	/// </summary>
	/// <param name="userAgent"></param>
	/// <param name="browserTracker"></param>
	/// <returns></returns>
	bool IsDeviceHandleEnabled(string userAgent, IBrowserTracker browserTracker);
}
