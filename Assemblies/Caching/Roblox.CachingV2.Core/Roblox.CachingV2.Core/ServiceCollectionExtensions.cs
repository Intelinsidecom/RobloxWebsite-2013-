using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Roblox.EventLog;

namespace Roblox.CachingV2.Core;

public static class ServiceCollectionExtensions
{
	public static void AddCachingV2Core(this IServiceCollection serviceCollection)
	{
		if (serviceCollection == null)
		{
			throw new ArgumentNullException("serviceCollection");
		}
		serviceCollection.CheckDependency<Func<Guid>>();
		serviceCollection.CheckDependency<ILogger>();
		serviceCollection.AddSingleton<ICacheVersionTokenFactory, CacheVersionTokenFactory>();
		serviceCollection.AddSingleton<ICacheOperationFactory, CacheOperationFactory>();
		serviceCollection.AddSingleton<ISerializer, NewtonsoftJsonSerializer>();
	}

	private static void CheckDependency<T>(this IServiceCollection serviceCollection)
	{
		Type type = typeof(T);
		if (serviceCollection.All((ServiceDescriptor s) => s.ServiceType != type))
		{
			throw new InvalidOperationException($"Missing dependency {type}");
		}
	}
}
