using System;
using Gigya.Socialize.SDK;
using Roblox.Common;
using Roblox.Gigya.Properties;

namespace Roblox.Gigya;

internal class GigyaSignatureTimestamp : IGigyaSignatureTimestamp
{
	public string Signature { get; private set; }

	public int Timestamp { get; private set; }

	/// <summary>
	/// Constructs an <see cref="T:Roblox.Gigya.GigyaSignatureTimestamp" /> for a given Gigya UID.
	/// </summary>
	/// <remarks>
	/// http://developers.gigya.com/display/GD/Security+Guidelines#Constructing_a_signature
	/// </remarks>
	/// <param name="gigyaUid">The Gigya UID for which the Signature and Timestamp are needed.</param>
	/// <returns><see cref="T:Roblox.Gigya.IGigyaSignatureTimestamp" /> which contains the Signature and Timestamp.</returns>
	public GigyaSignatureTimestamp(string gigyaUid)
	{
		Timestamp = (int)DateTime.UtcNow.ToUnixEpochTime().TotalSeconds;
		string text = $"{Timestamp}_{gigyaUid}";
		Signature = SigUtils.CalcSignature(text, Settings.Default.GigyaSecretKey);
	}
}
