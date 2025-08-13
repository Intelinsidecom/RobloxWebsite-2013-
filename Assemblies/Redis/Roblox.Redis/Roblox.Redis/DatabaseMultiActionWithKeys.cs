using System.Collections.Generic;
using StackExchange.Redis;

namespace Roblox.Redis;

public delegate(IEnumerable<string>, IEnumerable<TResult>) DatabaseMultiActionWithKeys<TResult>(IDatabase database, IReadOnlyCollection<string> partitionKeys);
