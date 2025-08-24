using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Email.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Email.User;

internal class UserEmailFloodCheckerFactory : IUserEmailFloodCheckerFactory
{
	private readonly IFloodCheckerFactory<IFloodChecker> _FloodCheckerFactory;

	private readonly ILogger _Logger;

	private readonly ISettings _Settings;

	internal UserEmailFloodCheckerFactory(IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, ILogger logger, ISettings settings)
	{
		_FloodCheckerFactory = floodCheckerFactory;
		_Logger = logger;
		_Settings = settings;
	}

	public IFloodChecker GetFloodCheckerForVerifyEmail(IUser currentUser)
	{
		return _FloodCheckerFactory.GetFloodChecker("VerifyEmailFloodChecker", $"UserEmailVerifierFloodChecker_UserID:{currentUser.Id}", () => _Settings.VerifyEmailFloodCheckLimit, () => _Settings.VerifyEmailFloodCheckExpiry, () => true, () => false, _Logger);
	}
}
