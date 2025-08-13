using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

internal class GenericSubject : SubjectBase
{
	private readonly long _TargetId;

	private readonly string _Type;

	public override long TargetId => _TargetId;

	public override string Type => _Type;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AbTesting.Core.GenericSubject" /> class with the given type and target ID.
	/// </summary>
	/// <param name="type">The type of the subject.</param>
	/// <param name="targetId">The target ID of the subject.</param>
	/// <remarks><see cref="T:Roblox.Platform.AbTesting.Core.GenericSubject" /> uses <see cref="P:Roblox.Platform.AbTesting.Core.EligibilityCheckerRegistry.Instance" /> as its <see cref="T:Roblox.Platform.AbTesting.Core.IEligibilityCheckerRegistry" />.</remarks>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="type" /> is null.</exception>
	internal GenericSubject(string type, long targetId)
		: base(new VersionFactory())
	{
		if (type == null)
		{
			throw new PlatformArgumentNullException("type");
		}
		_Type = type;
		_TargetId = targetId;
	}
}
