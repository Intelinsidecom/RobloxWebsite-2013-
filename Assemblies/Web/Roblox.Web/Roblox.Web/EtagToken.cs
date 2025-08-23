using System;
using System.Globalization;
using System.Text;
using System.Web.Security;

namespace Roblox.Web;

public class EtagToken
{
	public Guid Key { get; private set; }

	public string IP { get; private set; }

	public DateTime Timestamp { get; private set; }

	/// <summary>
	/// Encode the ETAG data into a string to be stored
	/// </summary>
	/// <returns>encoded etag string</returns>
	public string Encode()
	{
		string serialized = $"{Key.ToString()}%{IP}%{Timestamp.ToString()}";
		return MachineKey.Encode(Encoding.UTF8.GetBytes(serialized), MachineKeyProtection.Validation);
	}

	/// <summary>
	/// Decode an ETAG string into its parts
	/// </summary>
	/// <param name="data">The string to decode</param>
	/// <param name="token">The decoded token object</param>
	/// <returns>If decoding was successful</returns>
	public static bool TryDecode(string data, out EtagToken token)
	{
		try
		{
			byte[] decodedBytes = MachineKey.Decode(data, MachineKeyProtection.Validation);
			string[] array = Encoding.UTF8.GetString(decodedBytes).Split('%');
			Guid tokenKey = Guid.Parse(array[0]);
			string tokenIp = array[1];
			DateTime tokenTimestamp = DateTime.Parse(array[2], CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
			token = new EtagToken
			{
				Key = tokenKey,
				IP = tokenIp,
				Timestamp = tokenTimestamp
			};
			return true;
		}
		catch (Exception)
		{
			token = null;
			return false;
		}
	}

	/// <summary>
	/// Change the IP Address embedded in the Etag
	/// </summary>
	/// <param name="ip">IP Address of client</param>
	public void UpdateEtagIp(string ip)
	{
		IP = ip;
		Timestamp = DateTime.UtcNow;
	}

	/// <summary>
	/// Create a new ETAG token
	/// </summary>
	/// <param name="ip">IP Address of client</param>
	/// <returns>The newly created token</returns>
	public static EtagToken CreateNew(string ip)
	{
		return new EtagToken
		{
			Key = Guid.NewGuid(),
			IP = ip,
			Timestamp = DateTime.UtcNow
		};
	}
}
