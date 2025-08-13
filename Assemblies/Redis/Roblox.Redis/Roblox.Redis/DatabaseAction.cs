using StackExchange.Redis;

namespace Roblox.Redis;

public delegate void DatabaseAction(IDatabase database);
public delegate TResult DatabaseAction<out TResult>(IDatabase database);
