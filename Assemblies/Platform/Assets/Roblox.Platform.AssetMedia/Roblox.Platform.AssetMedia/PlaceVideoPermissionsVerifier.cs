using System;
using Roblox.Platform.AssetMedia.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AssetMedia;

/// <summary>
/// Implements <see cref="T:Roblox.Platform.AssetMedia.IPlaceVideoPermissionsVerifier" />.
/// </summary>
public class PlaceVideoPermissionsVerifier : IPlaceVideoPermissionsVerifier
{
	private readonly ISettings _Settings;

	/// <summary>
	/// Constructs an instance of <see cref="T:Roblox.Platform.AssetMedia.PlaceVideoPermissionsVerifier" />.
	/// </summary>
	/// <param name="settings">Asset media settings.</param>
	public PlaceVideoPermissionsVerifier(ISettings settings)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	/// <inheritdoc cref="M:Roblox.Platform.AssetMedia.IPlaceVideoPermissionsVerifier.CanUserAddPlaceVideos(Roblox.Platform.Membership.IUser)" />
	public bool CanUserAddPlaceVideos(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (_Settings.IsVideoThumbnailUploadDisabledForUnder13Users && user.AgeBracket == Roblox.Platform.Membership.AgeBracket.AgeUnder13)
		{
			return false;
		}
		return true;
	}
}
