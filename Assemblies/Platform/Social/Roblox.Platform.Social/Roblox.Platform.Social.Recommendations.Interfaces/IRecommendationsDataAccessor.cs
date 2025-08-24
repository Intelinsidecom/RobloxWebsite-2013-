using System.Collections.Generic;
using Roblox.Platform.Presence;

namespace Roblox.Platform.Social.Recommendations.Interfaces;

public interface IRecommendationsDataAccessor
{
	IReadOnlyCollection<IPresence> GetPeopleRecommendationsForUser(long userId);
}
