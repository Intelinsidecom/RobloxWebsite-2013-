namespace BeIT.MemCached;

internal interface IRateLimiter
{
	bool TryOperation();
}
