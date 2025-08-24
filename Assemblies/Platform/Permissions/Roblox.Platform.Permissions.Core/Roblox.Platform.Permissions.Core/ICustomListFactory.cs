namespace Roblox.Platform.Permissions.Core;

/// <summary>
/// ICustomList Factory
/// </summary>
public interface ICustomListFactory
{
	/// <summary>
	/// Verifies that CustomList with specified id is exist and returns it
	/// </summary>
	/// <param name="id">Id of custom list</param>
	/// <returns>Corresponding CustomList</returns>
	ICustomList CheckedGetCustomList(long? id);

	/// <summary>
	/// Returns custom list for specified Id or null (if it's not exist)
	/// </summary>
	/// <param name="id">Id of custom list</param>
	/// <returns>Corresponding CustomList</returns>
	ICustomList GetCustomList(long? id);

	/// <summary>
	/// Creates new instance of ICustomList
	/// </summary>
	/// <param name="listName">Name of the new list</param>
	/// <param name="creatorId">Creator id</param>
	/// <param name="creatorType">Creator type</param>
	/// <returns>new instance of ICustomList</returns>
	ICustomList CreateList(string listName, long creatorId, string creatorType);
}
