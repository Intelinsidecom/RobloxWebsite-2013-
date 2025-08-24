namespace Roblox.Platform.AbTesting.Core;

internal interface IEnrollmentFactory
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> with the given, version ID, subject type ID, and subject target ID.
	/// </summary>
	/// <param name="versionId">The version ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> to get.</param>
	/// <param name="subjectTypeId">The subject type ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> to get.</param>
	/// <param name="subjectTargetId">The subject target ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> with the given version ID, subject type ID, and subject target ID, or null if none existed.</returns>
	IEnrollment GetByVersionIdSubjectTypeIdAndSubjectTargetId(int versionId, int subjectTypeId, long subjectTargetId);

	/// <summary>
	/// Gets or creates the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> with the given, version ID, subject type ID, subject target ID, and variation ID.
	/// </summary>
	/// <param name="versionId">The ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IVersion" />.</param>
	/// <param name="subjectTypeId">The type ID of the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" />.</param>
	/// <param name="subjectTargetId">The target ID of the <see cref="T:Roblox.Platform.AbTesting.Core.ISubject" />.</param>
	/// <param name="variationId">The ID of the <see cref="T:Roblox.Platform.AbTesting.Core.IVariation" /></param>
	/// <param name="created">Indicates if a new enrollment was created</param>
	/// <returns>The <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> with the given version ID, subject type ID, subject target ID, and variation ID.</returns>
	IEnrollment GetOrCreate(int versionId, int subjectTypeId, long subjectTargetId, int variationId, out bool created);

	/// <summary>
	/// Delete the <see cref="T:Roblox.Platform.AbTesting.Core.IEnrollment" /> with the given enrollment ID
	/// </summary>
	/// <param name="id">The enrollment ID</param>
	void Delete(long id);
}
