namespace Roblox.Platform.IpAddresses;

public interface IAccountIpAddressRecorder
{
	void RecordAccountIpAddressEntity(long accountId, string userHostAddress);

	void RecordHostAddressInBackground(long accountId, string userHostAddress);
}
