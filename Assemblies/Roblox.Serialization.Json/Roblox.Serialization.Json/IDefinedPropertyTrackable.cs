using System.Collections.Generic;

namespace Roblox.Serialization.Json;

public interface IDefinedPropertyTrackable
{
	HashSet<string> DefinedPropertyNames { get; }
}
