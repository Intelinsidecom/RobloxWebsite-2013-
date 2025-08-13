using System;
using System.Web;

namespace Roblox.Web.Devices;

/// <summary>
/// Class used to evaluate DeviceHandle against a <see cref="T:System.Web.HttpRequest" /> or <see cref="T:System.Web.HttpRequestBase" />
/// to determine if the request is a legitimate Roblox app request.
/// </summary>
/// <remarks>
/// This class will evaluate both DeviceHandle V1 and V2 depending on which is enabled.
/// </remarks>
public interface IWebDeviceHandleInspector
{
	/// <summary>
	/// Fired when a <see cref="T:Roblox.Web.Devices.IDeviceHandleInspector" /> is used to evaluate DeviceHandle V1 or V2
	/// </summary>
	event Action<DeviceHandleInspectionResult> OnDeviceHandleInspectionCompleted;

	/// <summary>
	/// Evaluates DeviceHandle V1 or V2 against an <see cref="T:System.Web.HttpRequest" /> to
	/// determine if the request is from a legitimate Roblox app.
	/// </summary>
	/// <param name="request"></param>
	/// <param name="browserTrackerId"></param>
	/// <returns><see cref="T:Roblox.Web.Devices.DeviceHandleInspectionResult" /></returns>
	DeviceHandleInspectionResult InspectDeviceHandleRequest(HttpRequest request, ulong browserTrackerId);

	/// <summary>
	/// Evaluates DeviceHandle V1 or V2 against an <see cref="T:System.Web.HttpRequestBase" /> to
	/// determine if the request is from a legitimate Roblox app.
	/// </summary>
	/// <param name="request"></param>
	/// <param name="browserTrackerId"></param>
	/// <returns><see cref="T:Roblox.Web.Devices.DeviceHandleInspectionResult" /></returns>
	DeviceHandleInspectionResult InspectDeviceHandleRequest(HttpRequestBase request, ulong browserTrackerId);

	/// <summary>
	/// Determines whether or not an <see cref="T:System.Web.HttpRequestBase" /> is submitting a valid DeviceHandle,
	/// i.e. whether the request is from a legitimate Roblox app
	/// </summary>
	/// <param name="request"></param>
	/// <param name="browserTrackerId"></param>
	/// <returns>Whether the request is submitting a valid DeviceHandle header or cookie</returns>
	bool IsValidDeviceHandleRequest(HttpRequestBase request, ulong browserTrackerId);

	/// <summary>
	/// Determines whether or not an <see cref="T:System.Web.HttpRequest" /> is submitting a valid DeviceHandle,
	/// i.e. whether the request is from a legitimate Roblox app
	/// </summary>
	/// <param name="request"></param>
	/// <param name="browserTrackerId"></param>
	/// <returns>Whether the request is submitting a valid DeviceHandle header or cookie</returns>
	bool IsValidDeviceHandleRequest(HttpRequest request, ulong browserTrackerId);

	/// <summary>
	/// Determines whether or not an <see cref="T:System.Web.HttpRequestBase" /> is submitting a valid DeviceHandle,
	/// i.e. whether the request is from a legitimate Roblox app
	/// </summary>
	/// <param name="request"></param>
	/// <param name="browserTrackerId"></param>
	/// <returns>Whether the request is submitting a valid DeviceHandle header or cookie</returns>
	bool IsValidDeviceHandleRequest(HttpRequestBase request, long browserTrackerId);

	/// <summary>
	/// Determines whether or not an <see cref="T:System.Web.HttpRequest" /> is submitting a valid DeviceHandle,
	/// i.e. whether the request is from a legitimate Roblox app
	/// </summary>
	/// <param name="request"></param>
	/// <param name="browserTrackerId"></param>
	/// <returns>Whether the request is submitting a valid DeviceHandle header or cookie</returns>
	bool IsValidDeviceHandleRequest(HttpRequest request, long browserTrackerId);
}
