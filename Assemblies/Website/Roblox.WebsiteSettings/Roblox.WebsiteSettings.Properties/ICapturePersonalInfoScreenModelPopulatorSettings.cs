namespace Roblox.WebsiteSettings.Properties;

public interface ICapturePersonalInfoScreenModelPopulatorSettings
{
	byte CapturePersonalInfoNagLevel { get; }

	string GooglePlayUsernamePrefix { get; }

	string GameCenterUsernamePrefix { get; }
}
