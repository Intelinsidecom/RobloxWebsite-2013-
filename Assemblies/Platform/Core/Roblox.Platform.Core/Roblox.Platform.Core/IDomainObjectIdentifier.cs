using System;

namespace Roblox.Platform.Core;

/// <summary>
/// Provides a common interface for an object that uniquely identifies an object in a domain.
/// </summary>
/// <typeparam name="TId">The type of the ID.</typeparam>
public interface IDomainObjectIdentifier<out TId> where TId : struct, IEquatable<TId>
{
	/// <summary>
	/// Gets the ID.
	/// </summary>
	/// <value>
	/// The ID.
	/// </value>
	TId Id { get; }
}
