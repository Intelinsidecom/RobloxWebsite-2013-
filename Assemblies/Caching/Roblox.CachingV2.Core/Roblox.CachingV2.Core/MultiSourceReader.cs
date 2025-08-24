using System.Collections.Generic;

namespace Roblox.CachingV2.Core;

public delegate IEnumerable<TValue> MultiSourceReader<out TValue, in TKey>(IReadOnlyCollection<TKey> keys);
