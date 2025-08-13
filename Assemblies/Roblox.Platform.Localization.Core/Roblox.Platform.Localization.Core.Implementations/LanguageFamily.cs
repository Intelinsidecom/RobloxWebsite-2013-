using System;

namespace Roblox.Platform.Localization.Core.Implementations;

internal class LanguageFamily : IEquatable<LanguageFamily>, ILanguageFamily, ILanguageFamilyIdentifier
{
	public int Id { get; }

	public string Name { get; }

	public string NativeName { get; }

	public string LanguageCode { get; }

	public LanguageFamily(int id, string name, string nativeName, string languageCode)
	{
		Id = id;
		Name = name;
		NativeName = nativeName;
		LanguageCode = languageCode;
	}

	public override bool Equals(object other)
	{
		return Equals(other as LanguageFamily);
	}

	public bool Equals(LanguageFamily other)
	{
		if (other != null && Id == other.Id && Name == other.Name && LanguageCode == other.LanguageCode)
		{
			return NativeName == other.NativeName;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return 0x17 ^ Id.GetHashCode() ^ Name.GetHashCode() ^ NativeName.GetHashCode() ^ LanguageCode.GetHashCode();
	}
}
