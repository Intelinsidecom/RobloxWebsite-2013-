namespace Roblox.Platform.AbTesting;

/// <summary>
/// Represents a generic, strongly typed subject that can enroll in an experiment.
/// </summary>
public class Subject : TranslatedSubjectBase
{
	private readonly long _TargetId;

	private readonly string _Type;

	/// <summary>
	/// Gets the subject's target ID.
	/// </summary>
	public override long TargetId => _TargetId;

	/// <summary>
	/// Gets the subject's <see cref="T:Roblox.Platform.AbTesting.SubjectType" />.
	/// </summary>
	public override string Type => _Type;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.Subject" /> class with the given <see cref="T:Roblox.Platform.AbTesting.SubjectType" /> and target ID.
	/// </summary>
	/// <param name="type">The subject's <see cref="T:Roblox.Platform.AbTesting.SubjectType" />.</param>
	/// <param name="targetId">The subjects target ID.</param>
	public Subject(SubjectType type, long targetId)
	{
		_Type = type.ToString();
		_TargetId = targetId;
	}
}
