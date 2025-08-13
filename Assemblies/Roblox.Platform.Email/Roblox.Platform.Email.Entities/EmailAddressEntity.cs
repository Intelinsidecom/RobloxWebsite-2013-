using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.Email.Entities;

[ExcludeFromCodeCoverage]
internal class EmailAddressEntity : IEmailAddressEntity, IEntity<int>
{
	public int Id { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public string Address { get; set; }

	public bool IsBlacklisted { get; set; }

	public void Delete()
	{
		(Roblox.EmailAddress.Get(Id) ?? throw new PlatformDataIntegrityException($"Specified ID {Id} does not exist.")).Delete();
	}
}
