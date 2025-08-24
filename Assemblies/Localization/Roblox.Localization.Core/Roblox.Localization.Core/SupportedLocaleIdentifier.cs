namespace Roblox.Platform.Localization.Core;

public class SupportedLocaleIdentifier : ISupportedLocaleIdentifier
{
	public int Id { get; }

	public SupportedLocaleIdentifier(int id)
	{
		Id = id;
	}
}
