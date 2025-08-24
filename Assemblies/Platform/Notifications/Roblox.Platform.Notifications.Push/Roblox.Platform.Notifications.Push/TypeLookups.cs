using Roblox.Platform.Notifications.Push.Entities;

namespace Roblox.Platform.Notifications.Push;

internal class TypeLookups
{
	public TypeLookup<IApplicationTypeEntity, PushApplicationType> Applications { get; }

	public TypeLookup<IAuthenticationTypeEntity, PushAuthenticationType> Authentications { get; }

	public TypeLookup<IPlatformTypeEntity, PushPlatformType> Platforms { get; }

	public ReceiverTypeLookup Receivers { get; }

	public TypeLookups(PushDomainFactory pushDomainFactory)
	{
		Applications = new TypeLookup<IApplicationTypeEntity, PushApplicationType>(pushDomainFactory.ApplicationTypeEntityFactory.GetOrCreate);
		Authentications = new TypeLookup<IAuthenticationTypeEntity, PushAuthenticationType>(pushDomainFactory.AuthenticationTypeEntityFactory.GetOrCreate);
		Platforms = new TypeLookup<IPlatformTypeEntity, PushPlatformType>(pushDomainFactory.PlatformTypeEntityFactory.GetByValue);
		Receivers = new ReceiverTypeLookup(pushDomainFactory.ReceiverTypeEntityFactory);
	}
}
