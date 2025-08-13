using System;
using Roblox.Platform.Email.Entities;

namespace Roblox.Platform.Email;

internal class EmailAddressDeleter : IEmailAddressDeleter
{
	private readonly IEmailAddressEntityFactory _EmailAddressEntityFactory;

	public EmailAddressDeleter(IEmailAddressEntityFactory emailAddressEntityFactory)
	{
		_EmailAddressEntityFactory = emailAddressEntityFactory ?? throw new ArgumentNullException("emailAddressEntityFactory");
	}

	public void Delete(int emailAddressId)
	{
		_EmailAddressEntityFactory.GetById(emailAddressId)?.Delete();
	}
}
