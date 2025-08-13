using System.Collections.Generic;

namespace Roblox.CachingV2.Core;

public delegate IEnumerable<TSetArgs> MultiSetArgsConstructor<in TValue, out TSetArgs>(IReadOnlyCollection<TValue> values) where TSetArgs : BasicSetArgs;
