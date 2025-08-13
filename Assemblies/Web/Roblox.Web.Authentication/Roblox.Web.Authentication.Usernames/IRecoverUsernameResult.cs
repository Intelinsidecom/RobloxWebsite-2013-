using Roblox.Platform.Core;
using Roblox.Web.Authentication.Recovery;

namespace Roblox.Web.Authentication.Usernames;

public interface IRecoverUsernameResult : IResult<UsernameResponseCodes>
{
	TransmissionType? TransmissionType { get; }
}
