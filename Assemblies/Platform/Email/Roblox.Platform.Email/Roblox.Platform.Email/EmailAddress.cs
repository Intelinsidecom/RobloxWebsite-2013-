using System;
using Roblox.Platform.Email.Entities;

namespace Roblox.Platform.Email;

internal class EmailAddress : IEmailAddress
{
	public int Id { get; }

	public string Address { get; }

	public bool IsBlacklisted { get; }

	public EmailAddress(IEmailAddressEntity entity)
	{
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		Id = entity.Id;
		Address = entity.Address;
		IsBlacklisted = entity.IsBlacklisted;
	}
}
