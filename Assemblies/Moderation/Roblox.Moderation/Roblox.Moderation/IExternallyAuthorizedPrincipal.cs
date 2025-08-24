namespace Roblox.Platform.Moderation;

public interface IExternallyAuthorizedPrincipal<TId>
{
	/// <summary>
	/// The approved external service that authorized the action for the principal
	///
	/// Ex. The ModerationActionCreator determines that a principal, which the ModerationActionCreator refers to using its own identity conventions as principal with id 1234, is authorized to
	/// perform some moderation activity (such as Sequestration).
	/// </summary>
	AuthorizingParty AuthorizingParty { get; }

	/// <summary>
	/// The id of the externally authorized principal
	/// </summary>
	TId Id { get; }

	/// <summary>
	/// The operation that the external authorizing party has authorized the principal to perform
	/// </summary>
	ExternallyAuthorizedOperation ExternallyAuthorizedOperation { get; }
}
