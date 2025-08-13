using System.Collections.Generic;
using StackExchange.Redis;

namespace Roblox.Redis;

public delegate void DatabaseMultiAction(IDatabase database, IReadOnlyCollection<string> keys);
public delegate IEnumerable<TResult> DatabaseMultiAction<out TResult>(IDatabase database, IReadOnlyCollection<string> keys);
