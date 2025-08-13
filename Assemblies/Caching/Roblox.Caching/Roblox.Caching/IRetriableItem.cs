namespace Roblox.Caching;

internal interface IRetriableItem
{
	int CurrentAttempt { get; set; }
}
