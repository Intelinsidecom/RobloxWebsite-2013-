namespace Roblox.Platform.Avatar;

public interface IUserAvatarFactory
{
	/// <summary>
	/// Get UserAvatar Entity by ID
	/// </summary>
	IUserAvatar Get(int id);

	/// <summary>
	/// Get UserAvatar if one exists with the given userId. 
	/// If a UserAvatar Entity does not exist for the given object, this method creates a new entity with the supplied params.
	/// If the optional parameters are not supplied, they are populated with default values.
	/// </summary>
	IUserAvatar GetOrCreate(long userId, byte? playerAvatarTypeId = null, int? scaleId = null);
}
