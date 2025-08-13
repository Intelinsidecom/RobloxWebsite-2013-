using System;
using System.Collections.Specialized;

namespace Roblox;

/// <summary>
/// An interface for RobloxCookie.
/// </summary>
public interface IRobloxCookie
{
	/// <summary>
	/// Gets the expires.
	/// </summary>
	/// <value>
	/// The expires.
	/// </value>
	DateTime Expires { get; }

	/// <summary>
	/// Gets a value indicating whether [HTTP only].
	/// </summary>
	/// <value>
	///   <c>true</c> if [HTTP only]; otherwise, <c>false</c>.
	/// </value>
	bool HttpOnly { get; }

	/// <summary>
	/// Gets the name.
	/// </summary>
	/// <value>
	/// The name.
	/// </value>
	string Name { get; }

	/// <summary>
	/// Gets the value.
	/// </summary>
	/// <value>
	/// The value.
	/// </value>
	string Value { get; }

	/// <summary>
	/// Gets the domain.
	/// </summary>
	/// <value>
	/// The domain.
	/// </value>
	string Domain { get; }

	/// <summary>
	/// Gets the values.
	/// </summary>
	/// <value>
	/// The values.
	/// </value>
	NameValueCollection Values { get; }

	/// <summary>
	/// Gets the path.
	/// </summary>
	/// <value>
	/// The path.
	/// </value>
	string Path { get; }

	/// <summary>
	/// Appends the cookie to response.
	/// </summary>
	void AppendToResponse();

	/// <summary>
	/// Saves the specified expiration length.
	/// </summary>
	/// <param name="expirationLength">Length of the expiration.</param>
	void Save(TimeSpan expirationLength);

	/// <summary>
	/// Session Cookie Save.
	/// </summary>
	void Save();

	/// <summary>
	/// Deletes this instance.
	/// </summary>
	void Delete();
}
