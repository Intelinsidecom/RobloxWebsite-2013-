using Gigya.Socialize.SDK;

namespace Roblox.Gigya;

internal class GigyaUserInfoResponse : GigyaResponseBase, IGigyaUserInfoResponse, IGigyaResponse
{
	/// <remarks>
	/// The cast in set exists because <see cref="T:Roblox.Gigya.IGigyaValidatable" /> has no public setter for IsValid.
	/// </remarks>
	public override bool IsValid
	{
		get
		{
			return User.IsValid;
		}
		internal set
		{
			(User as GigyaUser).IsValid = value;
		}
	}

	public IGigyaUser User { get; private set; }

	protected virtual IGigyaUser BuildUser(GSObject data)
	{
		return new GigyaUser(data);
	}

	public GigyaUserInfoResponse(GSResponse response)
		: base(response)
	{
		User = BuildUser(base.ResponseData);
	}
}
