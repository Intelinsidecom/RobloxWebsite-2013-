using System;
using System.Collections.Generic;
using Roblox.ApiClientBase;

namespace Roblox.Universes.Client
{
    public interface IUniversesClient
    {
        // Place-Universe association
        void SetPlaceUniverse(long placeId, long universeId, bool isCreatedByUniverse);
        void RemovePlaceUniverse(long placeId, long universeId);

        // Creation and updates
        long CreateUniverse(string name, string description, long? rootPlaceId, string creatorType, long creatorTargetId, long shopId, PrivacyType? privacyType);
        void UpdateUniverse(long universeId, string name, string description, long? rootPlaceId, bool studioAccessToApisAllowed, bool isArchived, PrivacyType? privacyType);
        void SetUniverseCreator(long universeId, string creatorType, long creatorTargetId);
        void SetUniverseToPublic(long universeId, long creatorAgentId, long rootPlaceId);
        void SetUniverseToPrivate(long universeId, long creatorAgentId, long rootPlaceId);

        // Queries
        Universe GetUniverse(long universeId);
        Universe GetUniverseByShopId(long shopId);
        Universe GetPlaceUniverse(long placeId);
        long? GetUniverseShop(long universeId);
        IEnumerable<KeyValuePair<long, Universe>> MultiGetPlaceUniverses(IEnumerable<long> placeIds);
        IEnumerable<Universe> MultiGetUniverses(ICollection<long> universeIds);

        // Paging (page-number based)
        PagedResult<long, Universe> GetCreatorUniverses(string creatorType, long creatorTargetId, int? page, bool includeArchived);
        PagedResult<long, Universe> GetCreatorPublicUniversesPaged(string creatorType, long creatorTargetId, int? page, bool includeArchived);
        PagedResult<long, long> GetUniversePlaces(long universeId, int? page, bool isUniverseCreation);

        // Paging (exclusive-start based)
        IEnumerable<Universe> GetCreatorUniverses(string creatorType, long creatorTargetId, long? exclusiveStartKey, int pageSize, SortOrder sortOrder, bool includeArchived);
        IEnumerable<Universe> GetCreatorPublicUniverses(string creatorType, long creatorTargetId, long? exclusiveStartKey, int pageSize, SortOrder sortOrder, bool includeArchived);
        IEnumerable<long> GetUniversePlaceIds(long universeId, bool isUniverseCreation, long exclusiveStartId, int pageSize, SortOrder sortOrder);

        // Counts
        int GetCreatorPublicUniverseCount(string creatorType, long creatorTargetId);
    }
}
