namespace Roblox.Platform.Games;

public interface IPurchasedPlacesFactory
{
	/// <summary>
	/// Returns a <see cref="T:Roblox.Platform.Games.IUserPurchasedPlacesPagedResult" /> including the total number of places purchased by the user
	/// </summary>
	IUserPurchasedPlacesPagedResult GetUserPurchasedPlacesPaged(long userId, int startIndex, int itemsPerPage);
}
