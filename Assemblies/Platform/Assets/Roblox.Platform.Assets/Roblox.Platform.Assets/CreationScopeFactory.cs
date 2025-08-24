using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Assets;

public class CreationScopeFactory
{
	public static ICreationScope BuildCreationScope(CreationContextType creationContextType, CreatorType creatorType, long creatorTargetId, int assetTypeId)
	{
		return new CreationScope(creationContextType, creatorType, creatorTargetId, assetTypeId);
	}

	/// <summary>
	/// Gets the name of a creator.
	/// </summary>
	/// <param name="creationScope">The <see cref="T:Roblox.Platform.Assets.ICreationScope" /> containing information about the creator.</param>
	/// <param name="userFactory"><see cref="T:Roblox.Platform.Membership.IUserFactory" /></param>
	/// <returns>
	/// The name of the creator.
	/// </returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if creationScope is null.</exception>
	/// <exception cref="T:System.ArgumentException">Thrown if creationScope contains an invalid target ID.</exception>
	/// <exception cref="T:System.NotImplementedException">Thrown if creationScope contains an unsupported <see cref="T:Roblox.Platform.Assets.CreatorType" />.</exception>
	public static string GetCreatorName(ICreationScope creationScope, IUserFactory userFactory)
	{
		if (creationScope == null)
		{
			throw new ArgumentNullException("creationScope");
		}
		if (userFactory == null)
		{
			throw new ArgumentNullException("userFactory");
		}
		return creationScope.CreatorType switch
		{
			CreatorType.User => (userFactory.GetUser(creationScope.CreatorTargetId) ?? throw new ArgumentException("Invalid target ID")).Name, 
			CreatorType.Group => (Group.Get(creationScope.CreatorTargetId) ?? throw new ArgumentException("Invalid target ID")).Name, 
			_ => throw new NotImplementedException("CreatorType not supporter"), 
		};
	}
}
