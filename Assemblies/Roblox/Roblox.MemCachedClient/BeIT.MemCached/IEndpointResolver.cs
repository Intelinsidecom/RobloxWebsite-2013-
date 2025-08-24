using System.Net;

namespace BeIT.MemCached;

internal interface IEndpointResolver
{
	IPEndPoint GetEndPoint(string host, ushort defaultPort = 11211);
}
