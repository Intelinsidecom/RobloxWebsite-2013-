namespace Roblox.Platform.Social.Properties;

public interface ISettings
{
	long BuildermanUserId { get; }

	int MessageSubjectCharacterLimit { get; }

	int MessageBodyCharacterLimit { get; }
}
