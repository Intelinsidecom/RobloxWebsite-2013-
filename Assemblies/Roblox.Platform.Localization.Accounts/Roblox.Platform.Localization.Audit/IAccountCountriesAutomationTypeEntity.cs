using Roblox.Entities;

namespace Roblox.Platform.Localization.Audit;

internal interface IAccountCountriesAutomationTypeEntity : IUpdateableEntity<byte>, IEntity<byte>
{
	string Value { get; set; }

	string Description { get; set; }
}
