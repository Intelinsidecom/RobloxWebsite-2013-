using System;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace Roblox.Platform.Core;

/// <summary>
/// Represents an object that is part of a domain.
/// </summary>
/// <typeparam name="TDomainFactories">The type of the container containing all factories in the domain.</typeparam>
/// <seealso cref="T:Roblox.Platform.Core.IDomainObject`1" />
public abstract class DomainObjectBase<TDomainFactories> : IDomainObject<TDomainFactories> where TDomainFactories : DomainFactoriesBase
{
	[JsonIgnore]
	[ScriptIgnore]
	public TDomainFactories DomainFactories { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.DomainObjectBase`1" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="domainFactories" /></exception>
	protected DomainObjectBase(TDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		DomainFactories = domainFactories;
	}
}
/// <summary>
/// Represents an identifiable object that is part of a domain.
/// </summary>
/// <typeparam name="TDomainFactories">The type of the container containing all factories in the domain.</typeparam>
/// <typeparam name="TId">The type of the identifier that uniquely identifies the object.</typeparam>
/// <seealso cref="T:Roblox.Platform.Core.IDomainObject`1" />
public abstract class DomainObjectBase<TDomainFactories, TId> : DomainObjectBase<TDomainFactories>, IDomainObject<TDomainFactories, TId>, IDomainObject<TDomainFactories>, IDomainObjectIdentifier<TId>, IEquatable<IDomainObject<TDomainFactories, TId>> where TDomainFactories : DomainFactoriesBase where TId : struct, IEquatable<TId>
{
	public TId Id { get; protected set; }

	public virtual bool Equals(IDomainObject<TDomainFactories, TId> other)
	{
		if (other != null)
		{
			return Id.Equals(other.Id);
		}
		return false;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Core.DomainObjectBase`2" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"><paramref name="domainFactories" /></exception>
	protected DomainObjectBase(TDomainFactories domainFactories)
		: base(domainFactories)
	{
	}
}
