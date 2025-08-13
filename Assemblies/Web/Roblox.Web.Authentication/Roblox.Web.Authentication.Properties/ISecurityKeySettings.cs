namespace Roblox.Web.Authentication.Properties;

public interface ISecurityKeySettings
{
	bool UsePasswordResetSignatureKey { get; }

	bool UseClassicAndNewKeyForPasswordReset { get; }
}
