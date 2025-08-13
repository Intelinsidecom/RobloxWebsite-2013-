using System.Collections.Generic;

namespace Roblox.Platform.Notifications.Push.Entities;

internal interface IReceiverDestinationEntityFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Notifications.Push.Entities.IReceiverDestinationEntity" /> by its ID.
	/// </summary>
	/// <param name="id">The ID.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Notifications.Push.Entities.IReceiverDestinationEntity" /> with the given ID, or null if none existed.</returns>
	IReceiverDestinationEntity Get(long id);

	IReceiverDestinationEntity GetByReceiverTypeIdReceiverTargetIdAndDestinationId(int receiverTypeId, long receiverTargetId, long destinationId);

	/// <summary>
	/// </summary>
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="startRowIndex" /> is less than 0.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="maxRows" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Notifications.Push.Entities.IReceiverDestinationEntity" />s.</returns>
	IEnumerable<IReceiverDestinationEntity> GetByDestinationIdAndIsActivePaged(long destinationId, bool isActive, long startRowIndex, long maxRows);

	/// <summary>
	/// </summary>
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="startRowIndex" /> is less than 0.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="maxRows" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Notifications.Push.Entities.IReceiverDestinationEntity" />s.</returns>
	IEnumerable<IReceiverDestinationEntity> GetByReceiverTypeIdReceiverTargetIdAndIsActivePaged(int receiverTypeId, long receiverTargetId, bool isActive, long startRowIndex, long maxRows);

	/// <summary>
	/// </summary>
	/// <param name="startRowIndex">The zero-indexed start row index at which to begin getting rows.</param>
	/// <param name="maxRows">The maximum number of rows to get.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="startRowIndex" /> is less than 0.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="maxRows" /> is non-positive.</exception>
	/// <returns>The page of <see cref="T:Roblox.Platform.Notifications.Push.Entities.IReceiverDestinationEntity" />s.</returns>
	/// ///
	IEnumerable<IReceiverDestinationEntity> GetByReceiverTypeIdReceiverTargetIdIsAuthorizedByReceiverAndIsActivePaged(int receiverTypeId, long receiverTargetId, bool isAuthorizedByReceiver, bool isActive, long startRowIndex, long maxRows);

	IEnumerable<IReceiverDestinationEntity> GetByReceiverTypeIdReceiverTargetIdAuthenticationTypeIdAndAuthenticationValuePaged(int receiverTypeId, long receiverTargetId, int authenticationTypeId, string authenticationValue, long startRowIndex, long maxRows);

	IReceiverDestinationEntity Create(int receiverTypeId, long receiverTargetId, long destinationId, int authenticationTypeId, string authenticationValue, string name, bool isActive, bool isAuthorizedByReceiver);
}
