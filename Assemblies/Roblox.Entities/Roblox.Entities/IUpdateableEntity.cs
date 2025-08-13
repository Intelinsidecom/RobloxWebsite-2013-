using System;

namespace Roblox.Entities;

/// <summary>
/// Provides a common interface for a persisted entity that can be updated.
/// </summary>
/// <typeparam name="TId">The type of the identifier.</typeparam>
/// <seealso cref="T:Roblox.Entities.IEntity`1" />
public interface IUpdateableEntity<out TId> : IEntity<TId> where TId : IEquatable<TId>
{
	/// <summary>
	/// Gets the <see cref="T:System.DateTime" /> at which the entity was last updated.
	/// </summary>
	/// <value>
	/// The <see cref="T:System.DateTime" /> at which the entity was last updated.
	/// </value>
	DateTime Updated { get; }

	/// <summary>
	/// Updates the persisted entity to match its current in-memory values.
	/// </summary>
	/// <exception cref="T:System.InvalidOperationException">
	///     Thrown if the entity no longer exists in persistent storage.
	/// </exception>
	void Update();
}
