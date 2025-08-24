namespace Roblox.Platform.TwoStepVerification;

internal interface ITwoStepVerificationSettingChangeNotifier
{
	/// <summary>
	/// Sends an email given a <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepEventArgs" /> <paramref name="e" />.
	/// </summary>
	/// <param name="e"><see cref="T:Roblox.Platform.TwoStepVerification.TwoStepEventArgs" /> containing information regarding email to be sent.</param>
	void Send(TwoStepEventArgs e);
}
