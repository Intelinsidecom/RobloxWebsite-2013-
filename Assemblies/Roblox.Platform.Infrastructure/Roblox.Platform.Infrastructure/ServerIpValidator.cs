using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Common;
using Roblox.EventLog;

namespace Roblox.Platform.Infrastructure;

/// <summary>
/// Provides functionality for checking that specified ipAddress belongs to server with appropriate <see cref="P:Roblox.Platform.Infrastructure.ServerIpValidator.ServerGroup" /> and <see cref="P:Roblox.Platform.Infrastructure.ServerIpValidator.ServerType" />.
/// </summary>
public class ServerIpValidator : IServerIpValidator
{
	private readonly RefreshAhead<HashSet<string>> _ServerIpAddresses;

	private readonly string _RedisKeyFormat = "ServerIpValidator:GetServersByServerGroupIdAndServerTypeId_ServerGroupId:{0}_ServerTypeId:{1}";

	private readonly Func<bool> _LoggingEnabledFunc;

	private readonly ILogger _Logger;

	public ServerType ServerType { get; }

	public ServerGroup ServerGroup { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Infrastructure.ServerIpValidator" /> class.
	/// </summary>
	/// <param name="serverFactory">The server factory.</param>
	/// <param name="serverType">Type of the server.</param>
	/// <param name="serverGroup">The server group.</param>
	/// <param name="loggingEnabled">If enabled the IPs will be logged</param>
	/// <param name="logger">Logger used to log IPs</param>
	public ServerIpValidator(IServerFactory serverFactory, ServerType serverType, ServerGroup serverGroup, Func<bool> loggingEnabled = null, ILogger logger = null)
	{
		ServerIpValidator serverIpValidator = this;
		ServerType = serverType;
		ServerGroup = serverGroup;
		_LoggingEnabledFunc = loggingEnabled;
		_Logger = logger;
		string redisKey = string.Format(_RedisKeyFormat, (int)ServerGroup, (int)ServerType);
		TimeSpan refreshInterval = TimeSpan.FromSeconds(60.0);
		_ServerIpAddresses = RefreshAhead<HashSet<string>>.ConstructAndPopulate(refreshInterval, (Func<HashSet<string>>)delegate
		{
			string[] ips = InfrastructureCache.GetStringArrayFromRedis(redisKey);
			serverIpValidator.LogMessage(() => string.Format("InfrastructureCache reports IPs for Group {0} Type {1}: {2}", serverIpValidator.ServerGroup, serverIpValidator.ServerType, string.Join(",", ips)));
			if (ips == null || ips.Length == 0)
			{
				IReadOnlyCollection<IServer> serversByServerGroupIdAndServerTypeIdWithNoCaching = serverFactory.GetServersByServerGroupIdAndServerTypeIdWithNoCaching((int)serverIpValidator.ServerGroup, (int)serverIpValidator.ServerType);
				ips = serversByServerGroupIdAndServerTypeIdWithNoCaching.Select((IServer m) => m.PrimaryIPAddress).ToArray();
				InfrastructureCache.WriteStringArrayToRedis(redisKey, ips, refreshInterval);
				serverIpValidator.LogMessage(() => string.Format("RobloxInfrastructure reports IPs for Group {0} Type {1}: {2}", serverIpValidator.ServerGroup, serverIpValidator.ServerType, string.Join(",", ips)));
			}
			return new HashSet<string>(ips);
		});
	}

	/// <summary>
	/// Validates that ipAddress belongs to server with appropriate <see cref="P:Roblox.Platform.Infrastructure.ServerIpValidator.ServerGroup" /> and <see cref="P:Roblox.Platform.Infrastructure.ServerIpValidator.ServerType" />.
	/// </summary>
	/// <param name="ipAddress">The ip address.</param>
	/// <returns>
	/// true if ipAddress is ipAddress of server which corresponds to specified settings, otherwise false.
	/// </returns>
	public bool VerifyServerAccess(string ipAddress)
	{
		return _ServerIpAddresses.Value.Contains(ipAddress);
	}

	private void LogMessage(Func<string> messageGetter)
	{
		if (_LoggingEnabledFunc != null && _LoggingEnabledFunc())
		{
			_Logger?.Info(messageGetter);
		}
	}
}
