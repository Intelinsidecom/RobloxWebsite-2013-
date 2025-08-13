using Roblox.Entities;

namespace Roblox.Platform.Localization.Audit;

internal interface IAccountCountriesAuditMetadataTypeEntity : IUpdateableEntity<byte>, IEntity<byte>
{
	string Value { get; set; }

	string Description { get; set; }
}
