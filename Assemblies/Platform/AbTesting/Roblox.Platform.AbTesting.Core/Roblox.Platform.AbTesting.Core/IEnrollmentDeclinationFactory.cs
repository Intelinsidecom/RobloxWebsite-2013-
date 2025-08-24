namespace Roblox.Platform.AbTesting.Core;

/// <summary>
/// Provides a common interface for getting <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollmentDeclination" />s.
/// </summary>
internal interface IEnrollmentDeclinationFactory
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollmentDeclination" /> with the given, version ID, subject type ID, and subject target ID.
	/// </summary>
	/// <param name="versionId">The version ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollmentDeclination" /> to get.</param>
	/// <param name="subjectTypeId">The subject type ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollmentDeclination" /> to get.</param>
	/// <param name="subjectTargetId">The subject target ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollmentDeclination" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollmentDeclination" /> with the given version ID, subject type ID, and subject target ID, or null if none existed.</returns>
	IEnrollmentDeclination GetByVersionIdSubjectTypeIdAndSubjectTargetId(int versionId, int subjectTypeId, long subjectTargetId);

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollmentDeclination" /> with the given, version ID, subject type ID, and subject target ID. If 
	/// no enrollment declination exists, it will create one with the given parameters.
	/// </summary>
	/// <param name="versionId">The version ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollmentDeclination" /> to get.</param>
	/// <param name="subjectTypeId">The subject type ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollmentDeclination" /> to get.</param>
	/// <param name="subjectTargetId">The subject target ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollmentDeclination" /> to get.</param>
	/// <param name="declinationReasonTypeId">This is only used if it is necessary to create an enrollment declination</param>
	/// <returns></returns>
	IEnrollmentDeclination GetOrCreate(int versionId, int subjectTypeId, long subjectTargetId, int declinationReasonTypeId);

	/// <summary>
	/// Delete the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollmentDeclination" /> with the given enrollment declination ID
	/// </summary>
	/// <param name="id">The enrollment declination ID</param>
	void Delete(long id);
}
