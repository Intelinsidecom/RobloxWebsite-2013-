namespace Roblox.Platform.Marketing;

/// <summary>
/// Provides common interface for an object that defines SponsoredPageDeviceType.
/// </summary>
public interface ISponsoredPageAgeRating
{
	/// <summary>
	/// Gets the identifier.
	/// </summary>
	/// <value>
	/// The identifier.
	/// </value>
	int Id { get; }

	/// <summary>
	/// Gets or sets the sponsored page identifier.
	/// </summary>
	/// <value>
	/// The sponsored page identifier.
	/// </value>
	int SponsoredPageId { get; set; }

	/// <summary>
	/// Gets or sets the minimum age.
	/// </summary>
	/// <value>
	/// The minimum age
	/// </value>
	byte MinAge { get; set; }

	/// <summary>
	/// Gets or sets the maximum age.
	/// </summary>
	/// <value>
	/// The maximum age
	/// </value>
	byte MaxAge { get; set; }

	/// <summary>
	/// Saves underlying entity of SponsoredPageAgeRating to database.
	/// </summary>
	void Save();

	/// <summary>
	/// Deletes underlying entity of SponsoredPageAgeRating from database.
	/// </summary>
	void Delete();
}
