using Roblox.Entities;

namespace Roblox.Platform.Devices;

internal interface IApplicationTypeEntity : IUpdateableEntity<byte>, IEntity<byte>
{
	string Value { get; set; }
}
