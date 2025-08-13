using System;
using Roblox.Platform.Email.Entities;

namespace Roblox.Platform.Email;

internal class EmailAddressFactory : IEmailAddressFactory
{
	private readonly EmailDomainFactories _DomainFactories;

	public EmailAddressFactory(EmailDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
	}

	public IEmailAddress GetById(int id)
	{
		IEmailAddressEntity entity = _DomainFactories.EmailAddressEntityFactory.GetById(id);
		return EntityToPlatformObject(entity);
	}

	public IEmailAddress GetByEmailAddress(string emailAddress)
	{
		if (emailAddress == null)
		{
			throw new ArgumentNullException("emailAddress");
		}
		if (emailAddress == string.Empty)
		{
			throw new ArgumentException("emailAddress");
		}
		IEmailAddressEntity entity = _DomainFactories.EmailAddressEntityFactory.GetByEmailAddress(emailAddress);
		return EntityToPlatformObject(entity);
	}

	public IEmailAddress GetOrCreateByEmailAddress(string emailAddress)
	{
		if (emailAddress == null)
		{
			throw new ArgumentNullException("emailAddress");
		}
		if (emailAddress == string.Empty)
		{
			throw new ArgumentException("emailAddress");
		}
		IEmailAddressEntity entity = _DomainFactories.EmailAddressEntityFactory.GetOrCreateByEmailAddress(emailAddress);
		return EntityToPlatformObject(entity);
	}

	internal virtual IEmailAddress EntityToPlatformObject(IEmailAddressEntity entity)
	{
		if (entity == null)
		{
			return null;
		}
		return new EmailAddress(entity);
	}
}
