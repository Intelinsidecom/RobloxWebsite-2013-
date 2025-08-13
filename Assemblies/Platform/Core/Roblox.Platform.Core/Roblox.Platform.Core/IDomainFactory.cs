namespace Roblox.Platform.Core;

/// <summary>
/// Provides a common interface for a factory object that is part of a domain.
/// </summary>
/// <typeparam name="T">The type of the container containing all factories in the domain.</typeparam>
public interface IDomainFactory<out T> : IDomainObject<T> where T : DomainFactoriesBase
{
}
