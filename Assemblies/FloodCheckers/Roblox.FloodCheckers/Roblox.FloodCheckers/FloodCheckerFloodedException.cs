using Roblox.Platform.Core;
namespace Roblox.FloodCheckerspublic {
    class FloodCheckerFloodedException : PlatformException

{
	public new string UserFacingMessage;

	public FloodCheckerFloodedException(string userFacingMessage)
		: base("Floodchecker flooded")
	{
		UserFacingMessage = userFacingMessage;
	}
}


}
