using System;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.AccountPins.Entities.Audit;

internal interface IAccountPinHashesAuditMetadataEntity : IEntity<long>, IAuditMetadata
{
	Guid AccountPinHashesAuditPublicId { get; }

	/// <summary>
	/// Id of the user whose account pin was changed 
	/// </summary>
	long UserId { get; }

	new long? ActorUserId { get; }

	byte AccountPinChangeTypeId { get; }
}
