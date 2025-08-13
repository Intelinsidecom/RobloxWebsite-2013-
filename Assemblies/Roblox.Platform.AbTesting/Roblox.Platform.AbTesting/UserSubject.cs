using Roblox.Platform.Core;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.AbTesting;

/// <summary>
/// Represents a subject whose type is <see cref="F:Roblox.Platform.AbTesting.SubjectType.User" />.
/// </summary>
public sealed class UserSubject : TranslatedSubjectBase
{
	private const SubjectType _UserSubjectType = SubjectType.User;

	private readonly long _TargetId;

	/// <summary>
	/// Gets the subject's target ID.
	/// </summary>
	public override long TargetId => _TargetId;

	/// <summary>
	/// Gets the subject's type.
	/// </summary>
	public override string Type => SubjectType.User.ToString();

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.UserSubject" /> class from the given <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> to construct the <see cref="T:Roblox.Platform.AbTesting.UserSubject" /> from.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="user" /> is null.</exception>
	public UserSubject(IUserIdentifier user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		_TargetId = user.Id;
	}
}
