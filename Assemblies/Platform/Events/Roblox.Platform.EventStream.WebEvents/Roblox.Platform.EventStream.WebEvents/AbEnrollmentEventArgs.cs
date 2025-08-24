namespace Roblox.Platform.EventStream.WebEvents;

/// <summary>
/// Represents the event arguments for an <see cref="T:Roblox.Platform.EventStream.WebEvents.AbEnrollmentEvent" />.
/// </summary>
public class AbEnrollmentEventArgs : WebEventArgs
{
	/// <summary>
	/// The enrollment id assigned when enrolled
	/// </summary>
	public long EnrollmentId { get; set; }

	/// <summary>
	/// The id of the experiment id of the test they were enrolled in
	/// </summary>
	public long ExperimentId { get; set; }

	/// <summary>
	/// The version id of the test they were enrolled in
	/// </summary>
	public long VersionId { get; set; }

	/// <summary>
	/// The id of the variation the user ended up in the AB test enrollment
	/// </summary>
	public int VariationId { get; set; }

	/// <summary>
	/// The value of the variation the user ended up in the AB test enrollment
	/// </summary>
	public long VariationValue { get; set; }

	/// <summary>
	/// The value of the SubjectTargetId passed on the enroll call
	/// </summary>
	public long SubjectTargetId { get; set; }
}
