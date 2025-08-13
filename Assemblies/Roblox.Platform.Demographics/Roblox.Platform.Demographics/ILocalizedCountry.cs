namespace Roblox.Platform.Demographics;

/// <summary>
/// This interface extend <see cref="T:Roblox.Platform.Demographics.ICountry" /> to have localized country name.
/// If you don't need localized country name, just use <see cref="T:Roblox.Platform.Demographics.ICountry" />
/// </summary>
public interface ILocalizedCountry : ICountry, ICountryIdentifier
{
	/// <summary>
	/// The localized country name
	/// </summary>
	string LocalizedName { get; }
}
