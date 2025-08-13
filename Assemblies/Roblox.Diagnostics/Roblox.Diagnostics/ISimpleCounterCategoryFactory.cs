using System.Collections.Generic;

namespace Roblox.Diagnostics;

public interface ISimpleCounterCategoryFactory
{
	ISimpleCounterCategory CreateSimplePerfmonCounterCategory(string categoryName, ICollection<string> counterNames);
}
