namespace Roblox.Platform.Assets.Places;

/// <summary>
/// An interface for the <see cref="T:Roblox.Platform.Assets.Places.PlaceAttribute" /> object, which is a misnomer and really is a collection of attributes for a Place
/// </summary>
public interface IPlaceAttribute
{
	/// <summary>
	/// The Place Id
	/// </summary>
	long PlaceId { get; }

	/// <summary>
	/// Use Place Media For Thumb
	/// </summary>
	bool UsePlaceMediaForThumb { get; }

	/// <summary>
	/// Overrides Default Avatar
	/// </summary>
	bool OverridesDefaultAvatar { get; }

	/// <summary>
	/// Use Portrait Mode
	/// </summary>
	bool UsePortraitMode { get; }

	/// <summary>
	/// Whether the place has Filtering Enabled turned on.
	/// </summary>
	bool IsFilteringEnabled { get; }

	/// <summary>
	/// Sets the UsePlaceMediaForThumb attribute
	/// </summary>
	void SetUsePlaceMediaForThumb(bool usePlaceMediaForThumb);

	/// <summary>
	/// Sets the OverridesDefaultAvatar attribute
	/// </summary>
	void SetOverridesDefaultAvatar(bool overridesDefaultAvatar);

	/// <summary>
	/// Sets the UsePortraitMode attribute
	/// </summary>
	void SetUsePortraitMode(bool usePortraitMode);
}
