using System;

namespace Roblox.Platform.Core;

/// <summary>
/// Provides a common interface for an object that is part of a domain.
/// </summary>
/// <typeparam name="TDomainFactories">The type of the container containing all factories in the domain.</typeparam>
public interface IDomainObject<out TDomainFactories> where TDomainFactories : DomainFactoriesBase
{
	/// <summary>
	/// Gets the container containing all factories in the object's domain.
	/// </summary>
	/// <value>
	/// The domain factories.
	/// </value>
	TDomainFactories DomainFactories { get; }
}
/// <summary>
/// Provides a common interface for a uniquely identifiable object that is part of a domain.
/// </summary>
/// <typeparam name="TDomainFactories">The type of the container containing all factories in the domain.</typeparam>
/// <typeparam name="TId">The type of the identifier that uniquely identifies the object.</typeparam>
public interface IDomainObject<TDomainFactories, TId> : IDomainObject<TDomainFactories>, IDomainObjectIdentifier<TId>, IEquatable<IDomainObject<TDomainFactories, TId>> where TDomainFactories : DomainFactoriesBase where TId : struct, IEquatable<TId>
{
}
