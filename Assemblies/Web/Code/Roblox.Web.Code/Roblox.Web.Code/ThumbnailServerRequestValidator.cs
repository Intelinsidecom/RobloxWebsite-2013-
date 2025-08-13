using System;
using System.Web;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Platform.Infrastructure;

namespace Roblox.Web.Code;

/// <summary>
/// Validates ThumbnailServer requests 
/// </summary>
public class ThumbnailServerRequestValidator
{
	private readonly IServerIpValidator _ServerIpValidator;

	private const string _AccessKeyParam = "accesskey";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Code.ThumbnailServerRequestValidator" /> class.
	/// </summary>
	/// <param name="serverIpValidator">Instance of type which implements <see cref="T:Roblox.Platform.Infrastructure.IServerIpValidator" />.</param>
	/// <exception cref="T:System.ArgumentNullException">serverIpValidator is null</exception>
	/// <exception cref="T:System.ArgumentException">Is not thumbnail server validator</exception>
	public ThumbnailServerRequestValidator(IServerIpValidator serverIpValidator)
	{
		if (serverIpValidator == null)
		{
			throw new ArgumentNullException("serverIpValidator");
		}
		if (serverIpValidator.ServerGroup != ServerGroup.ThumbnailServiceRCC || serverIpValidator.ServerType != ServerType.GameServer)
		{
			throw new ArgumentException($"Is not thumbnail server validator: ServerGroup is {serverIpValidator.ServerGroup}, " + $"ServerType is {serverIpValidator.ServerType}", "serverIpValidator");
		}
		_ServerIpValidator = serverIpValidator;
	}

	/// <summary>
	/// Determines whether current request is valid thumbnail server request
	/// </summary>
	/// <param name="context">Instance of HttpContext</param>
	/// <returns>true if request is valid thumbnailServer request, otherwise false</returns>
	public bool IsValidThumbnailServerRequest(HttpContext context)
	{
		string accessKeyValue = context?.Request?.Headers?.Get("accesskey");
		if (string.IsNullOrWhiteSpace(accessKeyValue) || (accessKeyValue != Settings.Default.AccessKey && accessKeyValue != Settings.Default.AlternateAccessKey))
		{
			return false;
		}
		string ipAddress = context.GetOriginIP();
		return _ServerIpValidator.VerifyServerAccess(ipAddress);
	}
}
