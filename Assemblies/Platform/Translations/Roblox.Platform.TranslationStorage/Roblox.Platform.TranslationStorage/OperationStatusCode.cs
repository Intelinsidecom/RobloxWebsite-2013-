namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// Status codes for the Translation Storage Service.
/// </summary>
public enum OperationStatusCode
{
	/// <summary>
	/// When the operation has completed successfully.
	/// </summary>
	Success = 1,
	/// <summary>
	/// When trying to delete a translation that didn't exist.
	/// </summary>
	CannotDeleteNonExistingTranslation,
	/// <summary>
	/// When trying to migrate translation but failed. 
	/// </summary>
	TranslationMigrationFailed
}
