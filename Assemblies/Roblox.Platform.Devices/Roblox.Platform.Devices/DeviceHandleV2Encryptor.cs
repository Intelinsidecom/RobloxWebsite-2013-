using System;
using Roblox.Platform.Devices.Properties;

namespace Roblox.Platform.Devices;

public class DeviceHandleV2Encryptor : IDeviceHandleEncryptor
{
	private readonly ISettings _Settings;

	private static readonly DateTime _Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	public DeviceHandleV2Encryptor()
	{
		_Settings = Settings.Default;
	}

	internal DeviceHandleV2Encryptor(ISettings settings)
	{
		_Settings = settings;
	}

	/// <inheritdoc />
	public DeviceHandleEvaluationResult IsValidDeviceHandleId(ulong browserTrackerId, string deviceHandleV2)
	{
		try
		{
			if (string.IsNullOrEmpty(deviceHandleV2))
			{
				return new DeviceHandleEvaluationResult
				{
					IsValid = false,
					FailureReason = DeviceHandleFailureReason.ParseFailed
				};
			}
			if (deviceHandleV2.Length != 32)
			{
				return new DeviceHandleEvaluationResult
				{
					IsValid = false,
					FailureReason = DeviceHandleFailureReason.ParseFailed
				};
			}
			ulong encryptedBtidWithTimestamp = ConvertFromHexString(deviceHandleV2.Substring(0, 16));
			ulong encryptedTimestamp = ConvertFromHexString(deviceHandleV2.Substring(16));
			return EvaluateDeviceHandleV2(encryptedBtidWithTimestamp, encryptedTimestamp, browserTrackerId);
		}
		catch (Exception ex) when (ex is FormatException || ex is OverflowException)
		{
			return new DeviceHandleEvaluationResult
			{
				IsValid = false,
				FailureReason = DeviceHandleFailureReason.ParseFailed
			};
		}
	}

	/// <inheritdoc />
	public string GetDeviceHandle(ulong browserTrackerId)
	{
		if (!string.IsNullOrWhiteSpace(_Settings.DeviceHandleV2PrivateKey1))
		{
			return GetDeviceHandle(browserTrackerId, _Settings.DeviceHandleV2PrivateKey1);
		}
		if (!string.IsNullOrWhiteSpace(_Settings.DeviceHandleV2PrivateKey2))
		{
			return GetDeviceHandle(browserTrackerId, _Settings.DeviceHandleV2PrivateKey2);
		}
		return string.Empty;
	}

	internal string GetDeviceHandle(ulong browserTrackerId, string key, DateTime? timestamp = null)
	{
		timestamp = timestamp ?? DateTime.UtcNow;
		ulong timestampSeconds = (ulong)(timestamp.Value - _Epoch).TotalSeconds;
		ulong btidWithTimestamp = browserTrackerId ^ timestampSeconds;
		return HexEncodeDeviceHandle(TeaEncryptor.TeaEncrypt(btidWithTimestamp, key), TeaEncryptor.TeaEncrypt(timestampSeconds, key));
	}

	private string HexEncodeDeviceHandle(ulong encryptedBtidWithTimestamp, ulong timestamp)
	{
		return ConvertToHexString(encryptedBtidWithTimestamp) + ConvertToHexString(timestamp);
	}

	private string ConvertToHexString(ulong number)
	{
		return Convert.ToString((long)number, 16).PadLeft(16, '0');
	}

	private ulong ConvertFromHexString(string hexString)
	{
		return (ulong)Convert.ToInt64(hexString, 16);
	}

	private DeviceHandleEvaluationResult EvaluateDeviceHandleV2(ulong encryptedBtidWithTimestamp, ulong encryptedTimestamp, ulong browserTrackerId)
	{
		DeviceHandleEvaluationResult result = EvaluateDeviceHandleV2WithKey(encryptedBtidWithTimestamp, encryptedTimestamp, browserTrackerId, DeviceHandleEvaluationType.DeviceHandleV2Key1);
		if (result.FailureReason == DeviceHandleFailureReason.ComparisonFailed)
		{
			result = EvaluateDeviceHandleV2WithKey(encryptedBtidWithTimestamp, encryptedTimestamp, browserTrackerId, DeviceHandleEvaluationType.DeviceHandleV2Key2);
		}
		return result;
	}

	private DeviceHandleEvaluationResult EvaluateDeviceHandleV2WithKey(ulong encryptedBtidWithTimestamp, ulong encryptedTimestamp, ulong browserTrackerId, DeviceHandleEvaluationType evaluationType)
	{
		DeviceHandleEvaluationResult result = new DeviceHandleEvaluationResult();
		string key = ((evaluationType == DeviceHandleEvaluationType.DeviceHandleV2Key1) ? _Settings.DeviceHandleV2PrivateKey1 : _Settings.DeviceHandleV2PrivateKey2);
		if (string.IsNullOrWhiteSpace(key))
		{
			result.FailureReason = DeviceHandleFailureReason.ComparisonFailed;
			return result;
		}
		ulong num = TeaEncryptor.TeaDecrypt(encryptedBtidWithTimestamp, key);
		ulong decryptedTimestamp = TeaEncryptor.TeaDecrypt(encryptedTimestamp, key);
		ulong decryptedBrowserTrackerId = num ^ decryptedTimestamp;
		if (browserTrackerId == decryptedBrowserTrackerId)
		{
			if (EvaluateDeviceHandleV2Timestamp(decryptedTimestamp, key))
			{
				result.IsValid = true;
				result.EvaluationType = evaluationType;
			}
			else
			{
				result.FailureReason = DeviceHandleFailureReason.Expired;
			}
		}
		else
		{
			result.FailureReason = DeviceHandleFailureReason.ComparisonFailed;
		}
		return result;
	}

	private bool EvaluateDeviceHandleV2Timestamp(ulong timestampSeconds, string privateKey)
	{
		if (!_Settings.DeviceHandleV2EnforceTimestamp)
		{
			return true;
		}
		DateTime timestamp = _Epoch.AddSeconds(timestampSeconds);
		if (Math.Abs((DateTime.UtcNow - timestamp).TotalMinutes) < _Settings.DeviceHandleV2TimestampValidTimespan.TotalMinutes)
		{
			return true;
		}
		return false;
	}
}
