namespace Roblox.RequestContext;

public interface IRequestContextLoader
{
	IRequestContext GetCurrentContext();
}
