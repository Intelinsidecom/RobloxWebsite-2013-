using System;
using Roblox.Platform.Devices.Properties;

namespace Roblox.Platform.Devices;

public class DeviceHandleEncryptor : IDeviceHandleEncryptor
{
	private readonly ISettings _Settings;

	public virtual Func<string> UniqueDeviceIdentifierPrivateKey1 => () => _Settings.DeviceHandlePrivateKey1;

	public virtual Func<string> UniqueDeviceIdentifierPrivateKey2 => () => _Settings.DeviceHandlePrivateKey2;

	public DeviceHandleEncryptor()
	{
		_Settings = Settings.Default;
	}

	internal DeviceHandleEncryptor(ISettings settings)
	{
		_Settings = settings;
	}

	/// <inheritdoc />
	public DeviceHandleEvaluationResult IsValidDeviceHandleId(ulong browserTrackerId, string deviceHandleString)
	{
		if (string.IsNullOrWhiteSpace(deviceHandleString))
		{
			return new DeviceHandleEvaluationResult
			{
				IsValid = false,
				FailureReason = DeviceHandleFailureReason.ParseFailed
			};
		}
		if (!ulong.TryParse(deviceHandleString, out var deviceHandle))
		{
			return new DeviceHandleEvaluationResult
			{
				IsValid = false,
				FailureReason = DeviceHandleFailureReason.ParseFailed
			};
		}
		DeviceHandleEvaluationType? evaluationType;
		bool isValid = IsValidDeviceHandleId(browserTrackerId, deviceHandle, out evaluationType);
		return new DeviceHandleEvaluationResult
		{
			EvaluationType = evaluationType,
			FailureReason = (isValid ? null : new DeviceHandleFailureReason?(DeviceHandleFailureReason.ComparisonFailed)),
			IsValid = isValid
		};
	}

	private bool IsValidDeviceHandleId(ulong deviceHandleId, ulong encryptedDeviceHandleId, out DeviceHandleEvaluationType? evaluationType)
	{
		if (deviceHandleId == 0L || encryptedDeviceHandleId == 0L)
		{
			evaluationType = null;
			return false;
		}
		string deviceHandlePrivateKey1 = UniqueDeviceIdentifierPrivateKey1();
		if (!string.IsNullOrWhiteSpace(deviceHandlePrivateKey1))
		{
			ulong decryptedDeviceHandled1 = TeaEncryptor.TeaDecrypt(encryptedDeviceHandleId, deviceHandlePrivateKey1);
			if (deviceHandleId == decryptedDeviceHandled1)
			{
				evaluationType = DeviceHandleEvaluationType.DeviceHandleV1Key1;
				return true;
			}
		}
		string deviceHandlePrivateKey2 = UniqueDeviceIdentifierPrivateKey2();
		if (!string.IsNullOrWhiteSpace(deviceHandlePrivateKey2))
		{
			ulong decryptedDeviceHandleId2 = TeaEncryptor.TeaDecrypt(encryptedDeviceHandleId, deviceHandlePrivateKey2);
			if (deviceHandleId == decryptedDeviceHandleId2)
			{
				evaluationType = DeviceHandleEvaluationType.DeviceHandleV1Key2;
				return true;
			}
		}
		evaluationType = null;
		return false;
	}

	/// <inheritdoc />
	public string GetDeviceHandle(ulong browserTrackerId)
	{
		if (browserTrackerId == 0L)
		{
			return null;
		}
		string deviceHandlePrivateKey1 = UniqueDeviceIdentifierPrivateKey1();
		if (!string.IsNullOrEmpty(deviceHandlePrivateKey1))
		{
			return TeaEncryptor.TeaEncrypt(browserTrackerId, deviceHandlePrivateKey1).ToString();
		}
		string deviceHandlePrivateKey2 = UniqueDeviceIdentifierPrivateKey2();
		if (!string.IsNullOrEmpty(deviceHandlePrivateKey2))
		{
			return TeaEncryptor.TeaEncrypt(browserTrackerId, deviceHandlePrivateKey2).ToString();
		}
		return null;
	}
}
