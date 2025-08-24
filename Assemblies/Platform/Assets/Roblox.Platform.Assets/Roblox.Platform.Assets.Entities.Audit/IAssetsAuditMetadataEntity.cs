using System;
using Roblox.Entities;
using Roblox.Platform.Membership.UserDataAuditCore;

namespace Roblox.Platform.Assets.Entities.Audit;

internal interface IAssetsAuditMetadataEntity : IAuditMetadata, IEntity<long>
{
	Guid AssetsAuditEntryPublicId { get; }

	long AssetId { get; }

	new long? ActorUserId { get; }

	byte AssetChangeTypeId { get; }

	bool IsLegacyValue { get; }
}
