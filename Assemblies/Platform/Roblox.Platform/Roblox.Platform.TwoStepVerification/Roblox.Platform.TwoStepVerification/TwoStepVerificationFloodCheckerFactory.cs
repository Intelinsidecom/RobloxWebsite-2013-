using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.TwoStepVerification.Properties;

namespace Roblox.Platform.TwoStepVerification;

internal class TwoStepVerificationFloodCheckerFactory : ITwoStepVerificationFloodCheckerFactory
{
	private readonly IFloodCheckerFactory<IFloodChecker> _FloodCheckerFactory;

	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	internal TwoStepVerificationFloodCheckerFactory(IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, ILogger logger, ISettings settings)
	{
		_FloodCheckerFactory = floodCheckerFactory ?? throw new PlatformArgumentNullException("floodCheckerFactory");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
	}

	public IFloodChecker GetFloodCheckerForSetTwoStepSetting(IUser currentUser)
	{
		return _FloodCheckerFactory.GetFloodChecker("TwoStepVerificationSetFloodChecker", $"UserEmailVerifierFloodChecker_UserID:{currentUser.Id}", () => _Settings.TwoStepVerificationSetFloodCheckLimit, () => _Settings.TwoStepVerificationSetFloodCheckExpiry, () => true, () => false, _Logger);
	}
}
