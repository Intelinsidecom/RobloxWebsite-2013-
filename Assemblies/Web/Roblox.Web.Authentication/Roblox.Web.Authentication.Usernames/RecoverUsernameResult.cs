using Roblox.Platform.Core;
using Roblox.Web.Authentication.Recovery;

namespace Roblox.Web.Authentication.Usernames;

internal class RecoverUsernameResult : Result<UsernameResponseCodes>, IRecoverUsernameResult, IResult<UsernameResponseCodes>
{
	public TransmissionType? TransmissionType { get; }

	public RecoverUsernameResult(UsernameResponseCodes response, TransmissionType? transmissionType = null)
		: base(response)
	{
		TransmissionType = transmissionType;
	}
}
