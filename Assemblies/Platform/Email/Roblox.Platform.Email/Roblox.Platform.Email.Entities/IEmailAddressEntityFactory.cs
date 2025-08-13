namespace Roblox.Platform.Email.Entities;

internal interface IEmailAddressEntityFactory
{
	IEmailAddressEntity GetById(int id);

	IEmailAddressEntity GetOrCreateByEmailAddress(string emailAddress);

	IEmailAddressEntity GetByEmailAddress(string emailAddress);
}
