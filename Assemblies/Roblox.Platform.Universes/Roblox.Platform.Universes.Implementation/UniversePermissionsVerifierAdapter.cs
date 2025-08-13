using System;
using System.ComponentModel;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes.Properties;
using Roblox.Random;

namespace Roblox.Platform.Universes.Implementation;

/// <summary>
/// Class that encapsulates two IUniversePermissionsVerifier implementations to handle
/// the additional permission check against the new Permissions V2 service. Access
/// to the Permissions V2 service is gated by settings to enable toggling reading
/// from the service as well as progressive rollout which enables turning on a given
/// percentage of reads. Ultimately, both verifier implementations will still be
/// invoked as they represent non-overlapping functionality. Permission could be
/// granted in either system.
/// </summary>
/// <inheritdoc cref="T:Roblox.Platform.Universes.IUniversePermissionsVerifier" />
public class UniversePermissionsVerifierAdapter : IUniversePermissionsVerifier
{
	private readonly IUniversePermissionsVerifier _UniversePermissionsVerifier;

	private readonly IUniversePermissionsVerifier _PermissionsV2UniversePermissionsVerifier;

	private readonly ISingleSetting<bool> _PermissionsV2ReadsEnabled;

	private readonly ISingleSetting<double> _PermissionsV2ReadsPercentage;

	private readonly ISingleSetting<bool> _PermissionsV2PlayReadsEnabled;

	private readonly ISingleSetting<double> _PermissionsV2PlayReadsPercentage;

	private readonly ILogger _Logger;

	private readonly IRandom _Random;

	/// <summary>
	/// Constructor. Retrieves setting from default settings object.
	/// </summary>
	/// <param name="universePermissionsVerifier"></param>
	/// <param name="permissionsV2UniversePermissionsVerifier"></param>
	/// <param name="logger"></param>
	public UniversePermissionsVerifierAdapter(IUniversePermissionsVerifier universePermissionsVerifier, IUniversePermissionsVerifier permissionsV2UniversePermissionsVerifier, ILogger logger)
		: this(universePermissionsVerifier, permissionsV2UniversePermissionsVerifier, Settings.Default.ToSingleSetting((Settings s) => s.PermissionsV2ReadsEnabled), Settings.Default.ToSingleSetting((Settings s) => s.PermissionsV2ReadsPercentage), Settings.Default.ToSingleSetting((Settings s) => s.PermissionsV2PlayReadsEnabled), Settings.Default.ToSingleSetting((Settings s) => s.PermissionsV2PlayReadsPercentage), new ThreadLocalRandom(), logger)
	{
	}

	/// <summary>
	/// Constructor. Explicit settings arguments for injection.
	/// </summary>
	/// <param name="universePermissionsVerifier"></param>
	/// <param name="permissionsV2UniversePermissionsVerifier"></param>
	/// <param name="isPermissionsV2Enabled"></param>
	/// <param name="permissionsV2ReadsPercentage"></param>
	/// <param name="isPermissionsV2PlayReadsEnabled"></param>
	/// <param name="permissionsV2PlayReadsPercentage"></param>
	/// <param name="random"></param>
	/// <param name="logger"></param>
	internal UniversePermissionsVerifierAdapter(IUniversePermissionsVerifier universePermissionsVerifier, IUniversePermissionsVerifier permissionsV2UniversePermissionsVerifier, ISingleSetting<bool> isPermissionsV2Enabled, ISingleSetting<double> permissionsV2ReadsPercentage, ISingleSetting<bool> isPermissionsV2PlayReadsEnabled, ISingleSetting<double> permissionsV2PlayReadsPercentage, IRandom random, ILogger logger)
	{
		_UniversePermissionsVerifier = universePermissionsVerifier ?? throw new ArgumentNullException("universePermissionsVerifier");
		_PermissionsV2UniversePermissionsVerifier = permissionsV2UniversePermissionsVerifier ?? throw new ArgumentNullException("permissionsV2UniversePermissionsVerifier");
		_PermissionsV2ReadsEnabled = isPermissionsV2Enabled ?? throw new ArgumentNullException("isPermissionsV2Enabled");
		_PermissionsV2ReadsPercentage = permissionsV2ReadsPercentage ?? throw new ArgumentNullException("permissionsV2ReadsPercentage");
		_PermissionsV2ReadsEnabled.PropertyChanged += HandlePropertyChanged;
		_PermissionsV2ReadsPercentage.PropertyChanged += HandlePropertyChanged;
		_PermissionsV2PlayReadsEnabled = isPermissionsV2PlayReadsEnabled ?? throw new ArgumentNullException("isPermissionsV2PlayReadsEnabled");
		_PermissionsV2PlayReadsPercentage = permissionsV2PlayReadsPercentage ?? throw new ArgumentNullException("permissionsV2PlayReadsPercentage");
		_PermissionsV2PlayReadsEnabled.PropertyChanged += HandlePropertyChanged;
		_PermissionsV2PlayReadsPercentage.PropertyChanged += HandlePropertyChanged;
		_Random = random ?? throw new ArgumentNullException("random");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniversePermissionsVerifier.CanUserManageUniverse(Roblox.Platform.Membership.IUser,Roblox.Platform.Universes.IUniverse)" />
	public bool CanUserManageUniverse(IUser user, IUniverse universe)
	{
		if (_UniversePermissionsVerifier.CanUserManageUniverse(user, universe))
		{
			return true;
		}
		double randomDouble = ((_PermissionsV2ReadsPercentage.Value < 100.0) ? (_Random.NextDouble() * 100.0) : 0.0);
		if (_PermissionsV2ReadsEnabled.Value && randomDouble <= _PermissionsV2ReadsPercentage.Value)
		{
			try
			{
				return _PermissionsV2UniversePermissionsVerifier.CanUserManageUniverse(user, universe);
			}
			catch (Exception ex)
			{
				_Logger.Error($"There was an exception calling PermissionsV2UniversePermissionsVerifier: {ex}");
			}
		}
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Universes.IUniversePermissionsVerifier.CanUserPlayUniverse(Roblox.Platform.Membership.IUser,Roblox.Platform.Universes.IUniverse)" />
	public bool CanUserPlayUniverse(IUser user, IUniverse universe)
	{
		double randomDouble = ((_PermissionsV2PlayReadsPercentage.Value < 100.0) ? (_Random.NextDouble() * 100.0) : 0.0);
		if (_PermissionsV2PlayReadsEnabled.Value && randomDouble <= _PermissionsV2PlayReadsPercentage.Value)
		{
			try
			{
				return _PermissionsV2UniversePermissionsVerifier.CanUserPlayUniverse(user, universe);
			}
			catch (Exception ex)
			{
				_Logger.Error($"There was an exception calling PermissionsV2UniversePermissionsVerifier: {ex}");
			}
		}
		return false;
	}

	private void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		_Logger.Info($"Property, {e.PropertyName}, updated.");
	}
}
