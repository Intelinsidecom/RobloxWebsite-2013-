using System.Collections.Generic;
using Roblox.Platform.Membership;
using Roblox.Platform.Outfits;

namespace Roblox.Platform.UniverseSettings;

public interface IUniverseSettingsFactory
{
	/// <summary>
	/// If you want to get all UniverseAvatarSettings, use this and do fewer db hits.
	/// </summary>
	/// <param name="universeId">The Id of the universe.</param>
	UniverseAvatarSettingsResponseModel GetUniverseAvatarSettings(long universeId);

	/// <summary>
	/// If universe is null just return an empty array.
	/// Otherwise, the collection of assetOverrides for this universe.
	/// </summary>
	/// <param name="universeId">The Id of the universe.</param>
	ICollection<UniverseAvatarAssetOverrideResponseModel> GetValidUniverseAvatarAssetOverrides(long? universeId);

	/// <summary>
	/// If universe is null just return the default universeAvatarType.
	/// Otherwise, getOrCreate a min scale entity for this universe, with default values.
	/// Then return either the existing setting or the default.
	/// </summary>
	/// <param name="universeId">The Id of the universe.</param>
	Scale GetValidUniverseMinScale(long? universeId);

	/// <summary>
	/// If universe is null just return the default universeAvatarType.
	/// Otherwise, getOrCreate a max scale entity for this universe, with default values.
	/// Then return either the existing setting or the default.
	/// </summary>
	/// <param name="universeId">The Id of the universe.</param>
	Scale GetValidUniverseMaxScale(long? universeId);

	/// <summary>
	/// If universe is null just return the default universeAvatarType.
	/// Otherwise, getOrCreate a universeSettings entity for this universe, with default values.
	/// Then return either the existing setting or the default.
	/// </summary>
	/// <param name="universeId">The Id of the universe.</param>
	UniverseAvatarType GetValidUniverseAvatarType(long? universeId);

	/// <summary>
	/// If universe is null just return the default universeScaleType.
	/// Otherwise, getOrCreate a universeSettings entity for this universe, with default values.
	/// Then return either the existing setting or the default.
	/// </summary>
	/// <param name="universeId">The Id of the universe.</param>
	UniverseScaleType GetValidUniverseScaleType(long? universeId);

	/// <summary>
	/// If universe is null just return the default universeAvatarAnimationType.
	/// Otherwise, getOrCreate a universeSettings entity for this universe, with default values.
	/// Then return either the existing setting or the default.
	/// </summary>
	/// <param name="universeId">The Id of the universe.</param>
	UniverseAvatarAnimationType GetValidUniverseAvatarAnimationType(long? universeId);

	/// <summary>
	/// If universe is null just return the default universeAvatarCollisionType.
	/// Otherwise, getOrCreate a universeSettings entity for this universe, with default values.
	/// Then return either the existing setting or the default.
	/// </summary>
	/// <param name="universeId">The Id of the universe.</param>
	UniverseAvatarCollisionType GetValidUniverseAvatarCollisionType(long? universeId);

	/// <summary>
	/// If universe is null just return the default universeAvatarBodyType.
	/// Otherwise, getOrCreate a universeSettings entity for this universe, with default values.
	/// Then return either the existing setting or the default.
	/// </summary>
	/// <param name="universeId">The Id of the universe.</param>
	UniverseAvatarBodyType GetValidUniverseAvatarBodyType(long? universeId);

	/// <summary>
	/// If universe is null just return the default universeAvatarJointPositioningType.
	/// Otherwise, getOrCreate a universeSettings entity for this universe, with default values.
	/// Then return either the existing setting or the default.
	/// </summary>
	/// <param name="universeId">The Id of the universe.</param>
	UniverseAvatarJointPositioningType GetValidUniverseAvatarJointPositioningType(long? universeId);

	/// <summary>
	/// UniverseAvatarSettings entities may not have existed for this universe, or may have had 0/null as the typeIDs.
	/// </summary>
	/// <returns>Returns whether the type actually changed from what clients would have received before.
	/// This is complicated because game servers have been served default values if the dev has never edited this setting before.</returns>
	/// <param name="user">The user who is modifying the universe. This user must own the universe they are attempting to modify.</param>
	/// <param name="universeId">The Id of the universe to modify.</param>
	/// <param name="universeAvatarType">The type of Avatars that will be allowed by the universe.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformPermissionDeniedException">This exception is thrown when the user does not have permissions to modify the Universe's Avatar Settings.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">This exception is thrown when the a universe doesn't exist for the given UniverseId or the universeId is invalid.</exception>
	bool SetUniverseAvatarType(IUser user, long universeId, UniverseAvatarType universeAvatarType);

	/// <summary>
	/// UniverseAvatarSettings entities may not have existed for this universe, or may have had 0/null as the typeIDs.
	/// </summary>
	/// <param name="user">The user who is modifying the universe. This user must own the universe they are attempting to modify.</param>
	/// <param name="universeId">The Id of the universe to modify.</param>
	/// <param name="universeScaleType">The type of scales that will be allowed by the universe.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformPermissionDeniedException">This exception is thrown when the user does not have permissions to modify the Universe's Avatar Settings.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">This exception is thrown when the a universe doesn't exist for the given UniverseId or the universeId is invalid.</exception>
	void SetUniverseScaleType(IUser user, long universeId, UniverseScaleType universeScaleType);

	/// <summary>
	/// Sets the AnimationType for the given <see param="universeId" /> if the <see param="user" /> has permission to do so, i.e. if the user owns the universe.
	/// </summary>
	/// <param name="user">The user who is modifying the universe. This user must own the universe they are attempting to modify.</param>
	/// <param name="universeId">The Id of the universe to modify.</param>
	/// <param name="universeAvatarAnimationType">The setting which controls whether users can bring their own animations into games.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformPermissionDeniedException">This exception is thrown when the user does not have permissions to modify the Universe's Avatar Settings.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">This exception is thrown when the a universe doesn't exist for the given UniverseId or the universeId is invalid.</exception>
	void SetUniverseAvatarAnimationType(IUser user, long universeId, UniverseAvatarAnimationType universeAvatarAnimationType);

	/// <summary>
	/// Sets the CollisionType for the given <see param="universeId" /> if the <see param="user" /> has permission to do so, i.e. if the user owns the universe.
	/// </summary>
	/// <param name="user">The user who is modifying the universe. This user must own the universe they are attempting to modify.</param>
	/// <param name="universeId">The Id of the universe to modify.</param>
	/// <param name="universeAvatarCollisionType">The type of bounding boxes used by the universe for collisions.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformPermissionDeniedException">This exception is thrown when the user does not have permissions to modify the Universe's Avatar Settings.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">This exception is thrown when the a universe doesn't exist for the given UniverseId or the universeId is invalid.</exception>
	void SetUniverseAvatarCollisionType(IUser user, long universeId, UniverseAvatarCollisionType universeAvatarCollisionType);

	/// <summary>
	/// Sets the BodyType for the given <see param="universeId" /> if the <see param="user" /> has permission to do so, i.e. if the user owns the universe.
	/// </summary>
	/// <param name="user">The user who is modifying the universe. This user must own the universe they are attempting to modify.</param>
	/// <param name="universeId">The Id of the universe to modify.</param>
	/// <param name="universeAvatarBodyType">Whether anthro body types allowed by the universe.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformPermissionDeniedException">This exception is thrown when the user does not have permissions to modify the Universe's Avatar Settings.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">This exception is thrown when the a universe doesn't exist for the given UniverseId or the universeId is invalid.</exception>
	void SetUniverseAvatarBodyType(IUser user, long universeId, UniverseAvatarBodyType universeAvatarBodyType);

	/// <inheritdoc />
	/// <summary>
	/// Sets the JointPostioningType for the given <see param="universeId" /> if the <see param="user" /> has permission to do so, i.e. if the user owns the universe.
	/// </summary>
	/// <param name="user">The user who is modifying the universe. This user must own the universe they are attempting to modify.</param>
	/// <param name="universeId">The Id of the universe to modify.</param>
	/// <param name="universeAvatarJointPositioningType">Whether joint positions on the avatar are standard rig or artist's intent for the given universe.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformPermissionDeniedException">This exception is thrown when the user does not have permissions to modify the Universe's Avatar Settings.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">This exception is thrown when the a universe doesn't exist for the given UniverseId or the universeId is invalid.</exception>
	void SetUniverseAvatarJointPositioningType(IUser user, long universeId, UniverseAvatarJointPositioningType universeAvatarJointPositioningType);

	/// <summary>
	/// Sets the UniverseAvatarMinScale for the given <see param="universeId" /> if the <see param="user" /> has permission to do so, i.e. if the user owns the universe.
	/// </summary>
	/// <param name="user">The user who is modifying the universe. This user must own the universe they are attempting to modify.</param>
	/// <param name="universeId">The Id of the universe to modify.</param>
	/// <param name="clampedMinScale">The min scales to set.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformPermissionDeniedException">This exception is thrown when the user does not have permissions to modify the Universe's Avatar Settings.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">This exception is thrown when the a universe doesn't exist for the given UniverseId or the universeId is invalid.</exception>
	void SetUniverseAvatarMinScale(IUser user, long universeId, Scale clampedMinScale);

	/// <summary>
	/// Sets the UniverseAvatarMaxScale for the given <see param="universeId" /> if the <see param="user" /> has permission to do so, i.e. if the user owns the universe.
	/// <param name="user">The user who is modifying the universe. This user must own the universe they are attempting to modify.</param>
	/// <param name="universeId">The Id of the universe to modify.</param>
	/// <param name="clampedMaxScale">The max scales to set.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformPermissionDeniedException">This exception is thrown when the user does not have permissions to modify the Universe's Avatar Settings.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">This exception is thrown when the a universe doesn't exist for the given UniverseId or the universeId is invalid.</exception>
	/// </summary>
	void SetUniverseAvatarMaxScale(IUser user, long universeId, Scale clampedMaxScale);
}
