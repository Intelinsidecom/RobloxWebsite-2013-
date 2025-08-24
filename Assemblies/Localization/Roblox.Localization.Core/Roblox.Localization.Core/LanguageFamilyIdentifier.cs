namespace Roblox.Platform.Localization.Core;

public class LanguageFamilyIdentifier : ILanguageFamilyIdentifier
{
	public int Id { get; }

	public LanguageFamilyIdentifier(int id)
	{
		Id = id;
	}
}
