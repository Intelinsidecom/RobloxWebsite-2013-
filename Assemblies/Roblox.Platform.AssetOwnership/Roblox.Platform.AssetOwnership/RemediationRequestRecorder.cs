using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.Platform.AssetOwnership.Properties;

namespace Roblox.Platform.AssetOwnership;

/// <summary>
/// This will be implemented as a table of userAssetIds.
/// These items are all products of interrupted transactions, where the ov1 stage happened, ov2 failed, and ov1 rollback failed.
/// So the correct course of action is to make ov2 ownership status match that in ov1.
/// </summary>
public class RemediationRequestRecorder : IRemediationRequestRecorder
{
	private HashSet<RemediationRequest> _RemediationRequests { get; } = new HashSet<RemediationRequest>();


	private ILogger _Logger { get; }

	private ISettings _Settings { get; }

	public RemediationRequestRecorder(ILogger logger)
		: this(logger, Settings.Default)
	{
	}

	internal RemediationRequestRecorder(ILogger logger, ISettings settings)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	/// <summary>
	/// This doesn't actually persist anything yet.
	/// </summary>
	public void RecordUserAssetIdForRemediation(long userAssetId, string message)
	{
		LogMessage($"Recording remediation: userAssetId:{userAssetId} Message:'{message}'");
		try
		{
			ActuallyRecord(userAssetId, message);
			LogMessage($"Successfully recorded: userAssetId:{userAssetId} Message:'{message}'");
		}
		catch (Exception ex)
		{
			_Logger.Error($"Failed to record: userAssetId:{userAssetId} Message:'{message}'. {ex}");
		}
	}

	public HashSet<RemediationRequest> GetRemediationRequests()
	{
		return new HashSet<RemediationRequest>(_RemediationRequests);
	}

	internal void ActuallyRecord(long userAssetId, string message)
	{
		_RemediationRequests.Add(new RemediationRequest(userAssetId, message));
	}

	private void LogMessage(string message)
	{
		if (_Settings.ErrorLogLevelForRemediationRequestRecorder)
		{
			_Logger.Error(message);
		}
		else
		{
			_Logger.Info(message);
		}
	}
}
