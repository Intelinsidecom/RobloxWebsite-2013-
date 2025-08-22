using System;
using System.Collections.Generic;

// Minimal interfaces to satisfy references when the external
// Roblox.GameInstances.Interfaces assembly is unavailable.
// Namespace must match the existing using statements.
namespace Roblox.GameInstances.Interfaces
{
    public interface IGame { }

    public interface IPlaySession { }

    public interface IGeolocation { }

    public interface IPlaceSummary { }

    public interface IUniverseSummary { }

    public interface IDetailedBotCheckSignals { }

    public interface IRawGameSessionModel { }
}
