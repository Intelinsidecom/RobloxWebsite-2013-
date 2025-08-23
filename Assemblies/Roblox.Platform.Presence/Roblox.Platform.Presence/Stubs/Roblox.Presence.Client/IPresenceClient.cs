using System;
using System.Collections.Generic;

namespace Roblox.Presence.Client
{
    // Minimal stub interface to satisfy Roblox.Platform.Presence project compilation
    public interface IPresenceClient
    {
        // Reader methods
        IEnumerable<PresenceReport> GetAllActiveUserPresences(long userId);
        IEnumerable<PresenceReport> MultiGetUserPresence(IEnumerable<long> userIds);
        IEnumerable<IReadOnlyCollection<PresenceReport>> MultiGetAllActivePresences(ICollection<long> userIds);

        // Registrar methods
        void RegisterUserPresence(long userId, string location, string clientLocationType, string platform, string sessionId, long? universeId);
        void RegisterGuestPresence(long guestId, string location, string clientLocationType, string platform);

        void RegisterUserAbsence(long userId, string sessionId);
        void RegisterGuestAbsence(long guestId);
    }
}
