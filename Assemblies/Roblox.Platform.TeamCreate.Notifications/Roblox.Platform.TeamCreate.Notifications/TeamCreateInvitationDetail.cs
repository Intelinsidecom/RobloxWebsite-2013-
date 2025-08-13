using System.Runtime.Serialization;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// Details class with all information to describe a team create invitation notification.
/// </summary>
[DataContract]
public class TeamCreateInvitationDetail
{
	/// <summary>
	/// The id of the acting user.
	/// </summary>
	[DataMember(Name = "actingUserId")]
	public long ActingUserId { get; set; }

	/// <summary>
	/// The name of the acting user.
	/// </summary>
	[DataMember(Name = "actingUsername")]
	public string ActingUsername { get; set; }

	/// <summary>
	/// The id of the affected user.
	/// </summary>
	[DataMember(Name = "affectedUserId")]
	public long AffectedUserId { get; set; }

	/// <summary>
	/// The name of the affected user.
	/// </summary>
	[DataMember(Name = "affectedUsername")]
	public string AffectedUsername { get; set; }

	/// <summary>
	/// The id of the universe the affected user is invited to.
	/// </summary>
	[DataMember(Name = "universeId")]
	public long UniverseId { get; set; }

	/// <summary>
	/// The id of the root place of the universe.
	/// </summary>
	[DataMember(Name = "rootPlaceId")]
	public long RootPlaceId { get; set; }

	/// <summary>
	/// The name of the universe the affected user is invited to.
	/// </summary>
	[DataMember(Name = "universeName")]
	public string UniverseName { get; set; }
}
