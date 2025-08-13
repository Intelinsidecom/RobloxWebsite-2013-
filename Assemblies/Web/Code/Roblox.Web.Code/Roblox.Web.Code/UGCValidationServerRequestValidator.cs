using System;
using System.Web;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Platform.Infrastructure;

namespace Roblox.Web.Code;

/// <summary>
/// Validates UGCValidationRCC requests 
/// </summary>
public class UGCValidationServerRequestValidator
{
	private readonly IServerIpValidator _ServerIpValidator;

	private const string _AccessKeyParam = "accesskey";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Code.UGCValidationServerRequestValidator" /> class.
	/// </summary>
	/// <param name="serverIpValidator">Instance of type which implements <see cref="T:Roblox.Platform.Infrastructure.IServerIpValidator" />.</param>
	/// <exception cref="T:System.ArgumentNullException">serverIpValidator is null</exception>
	/// <exception cref="T:System.ArgumentException">Is not ugc validation rcc server</exception>
	public UGCValidationServerRequestValidator(IServerIpValidator serverIpValidator)
	{
		if (serverIpValidator == null)
		{
			throw new ArgumentNullException("serverIpValidator");
		}
		if (serverIpValidator.ServerGroup != ServerGroup.UGCValidationRCC || serverIpValidator.ServerType != ServerType.GameServer)
		{
			throw new ArgumentException($"Is not ugc validation rcc server: ServerGroup is {serverIpValidator.ServerGroup}, ServerType is {serverIpValidator.ServerType}", "serverIpValidator");
		}
		_ServerIpValidator = serverIpValidator;
	}

	/// <summary>
	/// Determines whether current request is valid ugc validation rcc server request
	/// </summary>
	/// <param name="context">Instance of HttpContext</param>
	/// <returns>true if request is valid ugc validation rcc server request, otherwise false</returns>
	public bool IsValidUGCValidationServerRequest(HttpContext context)
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
