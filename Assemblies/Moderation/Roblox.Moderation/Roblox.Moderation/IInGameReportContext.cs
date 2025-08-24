using System;

namespace Roblox.Moderation;

public interface IInGameReportContext : IReportContext
{
	long PlaceID { get; }

	long UniverseID { get; }

	Guid GameInstanceID { get; }
}
