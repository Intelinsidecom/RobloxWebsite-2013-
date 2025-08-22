using System;

namespace Roblox.Universes.Client
{
    public interface IUniversesClient
    {
        void SetPlaceUniverse(long placeId, long universeId, bool isCreatedByUniverse);
        void RemovePlaceUniverse(long placeId, long universeId);
    }
}
