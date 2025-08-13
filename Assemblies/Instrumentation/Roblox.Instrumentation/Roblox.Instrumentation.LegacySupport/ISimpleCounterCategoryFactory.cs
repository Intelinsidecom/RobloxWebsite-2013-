using System.Collections.Generic;

namespace Roblox.Instrumentation.LegacySupport;

public interface ISimpleCounterCategoryFactory
{
	ISimpleCounterCategory CreateSimpleCounterCategory(string categoryName, ICollection<string> counterNames);
}
