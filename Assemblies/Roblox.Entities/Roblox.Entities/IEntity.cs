using System;

namespace Roblox.Entities;

/// <summary>
/// Provides a common interface for a persisted entity.
/// </summary>
/// <typeparam name="TId">The type of the entity's ID.</typeparam>
public interface IEntity<out TId> where TId : IEquatable<TId>
{
	/// <summary>
	/// Gets the ID.
	/// </summary>
	/// <value>
	/// The ID.
	/// </value>
	TId Id { get; }

	/// <summary>
	/// Gets the <see cref="T:System.DateTime" /> at which the entity was created.
	/// </summary>
	/// <value>
	/// The <see cref="T:System.DateTime" /> at which the entity was created.
	/// </value>
	DateTime Created { get; }

	/// <summary>
	/// Deletes the entity from persistence.
	/// </summary>
	/// <exception cref="T:System.InvalidOperationException">
	///     Thrown if the entity no longer exists in persistent storage.
	/// </exception>
	void Delete();
}
