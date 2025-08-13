using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Web;
using Roblox.Agents.Entities;
using Roblox.Agents.Properties;
using Roblox.Caching.DotNet;
using Roblox.Caching.Interfaces;
using Roblox.Data;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Users.Client;

namespace Roblox.Agents;

/// <summary>
/// Factory to get or create Agents
/// </summary>
public class AgentFactory : IAgentFactory
{
	/// <remarks>
	/// Must match Roblox.Web.RequestContextDictionaryProvider._RequestCacheDictionaryKey in order to ensure cache consistency across the request.
	/// </remarks>
	private const string _RequestCacheDictionaryKey = "RequestCacheDictionary";

	private const string _MigrationPerformanceCounterCategory = "Roblox.Users.Service.Migration";

	private const string _MigrationPerformanceCounterCounterName = "Requests/second";

	private const string _MigrationFailurePerformanceCounterCounterName = "Failures/second";

	private const string _MigrationGetByIdInstanceName = "GetAgentById";

	private const string _MigrationGetByTypeAndTargetIdInstanceName = "GetAgentByTypeAndTargetId";

	private readonly IUsersClient _UsersClient;

	private readonly ISettings _Settings;

	private readonly ILogger _Logger;

	private readonly ICounterRegistry _CounterRegistry;

	internal static Lazy<IUsersClient> UsersClientLazy;

	internal static Lazy<IAgentFactory> AgentFactoryLazy;

	/// <summary>
	/// A cached <see cref="T:Roblox.Users.Client.IUsersClient" /> instance.
	/// </summary>
	/// <remarks>
	/// Singleton instance of <see cref="T:Roblox.Users.Client.CachedUsersClient" /> that can be used to communicate with Roblox.Users.Service.
	/// </remarks>
	public static IUsersClient UsersClient => UsersClientLazy.Value;

	/// <summary>
	/// A singleton instance of the <see cref="T:Roblox.Agents.IAgentFactory" />
	/// </summary>
	public static IAgentFactory Singleton => AgentFactoryLazy.Value;

	static AgentFactory()
	{
		UsersClientLazy = new Lazy<IUsersClient>(CreateUsersClient);
		AgentFactoryLazy = new Lazy<IAgentFactory>(() => new AgentFactory());
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Agents.AgentFactory" />.
	/// </summary>
	[ExcludeFromCodeCoverage]
	public AgentFactory()
		: this(UsersClient, Settings.Default, StaticLoggerRegistry.Instance, StaticCounterRegistry.Instance)
	{
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Agents.AgentFactory" />.
	/// </summary>
	/// <param name="usersClient">An <see cref="T:Roblox.Users.Client.IUsersClient" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="counterRegistry">An <see cref="T:Roblox.Instrumentation.ICounterRegistry" />.</param>
	public AgentFactory(IUsersClient usersClient, ILogger logger, ICounterRegistry counterRegistry)
		: this(usersClient, Settings.Default, logger, counterRegistry)
	{
	}

	internal AgentFactory(IUsersClient usersClient, ISettings settings, ILogger logger, ICounterRegistry counterRegistry)
	{
		_UsersClient = usersClient ?? throw new ArgumentNullException("usersClient");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
	}

	/// <inheritdoc cref="M:Roblox.Agents.IAgentFactory.Get(System.Int64)" />
	[Obsolete("Please use the instance method instead.")]
	public static IAgent Get(long agentId)
	{
		return Singleton.Get(agentId);
	}

	/// <inheritdoc cref="M:Roblox.Agents.IAgentFactory.Get(System.Int64)" />
	IAgent IAgentFactory.Get(long agentId)
	{
		IncrementCounter("GetAgentById");
		if (agentId <= 0)
		{
			return null;
		}
		if (agentId % 10000 < _Settings.AgentFactoryGetByIdViaUsersServicePermyriad)
		{
			try
			{
				AgentData agentData = _UsersClient.GetAgentByAgentId(agentId);
				if (agentData == null)
				{
					return null;
				}
				return new Agent
				{
					Id = agentData.Id,
					AgentTargetId = agentData.TargetId,
					AgentType = TranslateAgentType(agentData.Type)
				};
			}
			catch (Exception e)
			{
				_Logger.Error(e);
				IncrementCounter("GetAgentById", "Failures/second");
			}
		}
		return Roblox.Agents.Entities.Agent.Get(agentId).Translate();
	}

	/// <inheritdoc cref="M:Roblox.Agents.IAgentFactory.MustGet(System.Int64)" />
	public static IAgent MustGet(long agentId)
	{
		return Singleton.MustGet(agentId);
	}

	/// <inheritdoc cref="M:Roblox.Agents.IAgentFactory.MustGet(System.Int64)" />
	IAgent IAgentFactory.MustGet(long agentId)
	{
		if (agentId % 10000 < _Settings.AgentFactoryGetByIdViaUsersServicePermyriad)
		{
			return ((IAgentFactory)this).Get(agentId) ?? throw new DataIntegrityException($"Could not retrieve Agent with ID={agentId} (AgentFactory)");
		}
		return Roblox.Agents.Entities.Agent.MustGet(agentId).Translate();
	}

	/// <inheritdoc cref="M:Roblox.Agents.IAgentFactory.GetByAgentTypeAndAgentTargetId(Roblox.Agents.AgentType,System.Int64)" />
	/// <returns></returns>
	public static IAgent GetByAgentTypeAndAgentTargetId(AgentType agentType, long agentTargetId)
	{
		return Singleton.GetByAgentTypeAndAgentTargetId(agentType, agentTargetId);
	}

	/// <inheritdoc cref="M:Roblox.Agents.IAgentFactory.GetByAgentTypeAndAgentTargetId(Roblox.Agents.AgentType,System.Int64)" />
	IAgent IAgentFactory.GetByAgentTypeAndAgentTargetId(AgentType agentType, long agentTargetId)
	{
		IncrementCounter("GetAgentByTypeAndTargetId");
		if (agentTargetId <= 0)
		{
			return null;
		}
		if (agentTargetId % 10000 < _Settings.AgentFactoryGetByTypeAndTargetIdViaUsersServicePermyriad)
		{
			AssociatedEntityType associatedEntityType = agentType switch
			{
				AgentType.User => AssociatedEntityType.User, 
				AgentType.Group => AssociatedEntityType.Group, 
				_ => throw new InvalidEnumArgumentException("agentType", (int)agentType, typeof(AgentType)), 
			};
			try
			{
				long? agentId = _UsersClient.GetAgentIdByTypeAndTargetId(associatedEntityType, agentTargetId);
				if (!agentId.HasValue)
				{
					return null;
				}
				return new Agent
				{
					Id = agentId.Value,
					AgentType = agentType,
					AgentTargetId = agentTargetId
				};
			}
			catch (Exception e)
			{
				_Logger.Error(e);
				IncrementCounter("GetAgentByTypeAndTargetId", "Failures/second");
			}
		}
		return Roblox.Agents.Entities.Agent.GetByAgentTypeIdAndAgentTargetId((byte)agentType, agentTargetId).Translate();
	}

	private AgentType TranslateAgentType(AssociatedEntityType associatedEntityType)
	{
		return associatedEntityType switch
		{
			AssociatedEntityType.User => AgentType.User, 
			AssociatedEntityType.Group => AgentType.Group, 
			_ => throw new Exception($"Unrecognized agent type: {associatedEntityType}"), 
		};
	}

	private void IncrementCounter(string instanceName, string counterName = "Requests/second")
	{
		if (!_Settings.AgentFactoryMetricsEnabled)
		{
			return;
		}
		try
		{
			_CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.Users.Service.Migration", counterName, instanceName).Increment();
		}
		catch (Exception)
		{
		}
	}

	[ExcludeFromCodeCoverage]
	private static IDictionary GetRequestCacheDictionary()
	{
		if (HttpContext.Current == null)
		{
			return null;
		}
		if (!HttpContext.Current.Items.Contains("RequestCacheDictionary"))
		{
			HttpContext.Current.Items["RequestCacheDictionary"] = new Dictionary<string, object>();
		}
		return HttpContext.Current.Items["RequestCacheDictionary"] as IDictionary;
	}

	[ExcludeFromCodeCoverage]
	private static IUsersClient CreateUsersClient()
	{
		UsersClient usersClient = new UsersClient(StaticCounterRegistry.Instance, () => Settings.Default.UsersClientMasterApiKey);
		RequestCache requestCache = new RequestCache(GetRequestCacheDictionary);
		return new CachedUsersClient((IUsersClient)usersClient, (IRequestCache)requestCache);
	}
}
