using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// The arguments for an <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateEvent" /> of the <see cref="F:Roblox.Platform.TeamCreate.Notifications.TeamCreateEventType.UserInvited" /> type.
/// </summary>
[DataContract]
[ExcludeFromCodeCoverage]
internal class TeamCreateInvitationEventArgs
{
	/// <summary>
	/// The user inviting the <see cref="P:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationEventArgs.AffectedUserId" />.
	/// </summary>
	[DataMember(Name = "userId")]
	public long? UserId { get; set; }

	/// <summary>
	/// The invited user.
	/// </summary>
	[DataMember(Name = "affectedUserId")]
	public long? AffectedUserId { get; set; }

	/// <summary>
	/// The universe id the user is invited to edit.
	/// </summary>
	[DataMember(Name = "universeId")]
	public long? UniverseId { get; set; }
}
