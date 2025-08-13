using Roblox.Entities;

namespace Roblox.Platform.TwoStepVerification.Entities;

internal interface ITwoStepVerificationMediaTypeEntity : IUpdateableEntity<byte>, IEntity<byte>
{
	string Value { get; set; }
}
