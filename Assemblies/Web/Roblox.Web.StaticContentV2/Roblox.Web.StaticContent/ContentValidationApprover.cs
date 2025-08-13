using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Web;
using Roblox.Common;
using Roblox.Networking;
using Roblox.Platform.Membership;
using Roblox.Platform.StaticContent;
using Roblox.Web.StaticContent.Properties;

namespace Roblox.Web.StaticContent;

/// <inheritdoc cref="T:Roblox.Platform.StaticContent.IContentValidationApprover" />
public class ContentValidationApprover : IContentValidationApprover
{
	private readonly IRoleSetValidator _RoleSetValidator;

	private readonly IStaticContentSettings _StaticContentSettings;

	[ExcludeFromCodeCoverage]
	internal virtual string IpAddress => HttpContext.Current.GetOriginIP();

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.StaticContent.ContentValidationApprover" />.
	/// </summary>
	/// <param name="roleSetValidator">An <see cref="T:Roblox.Platform.Membership.IRoleSetValidator" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="roleSetValidator" />
	/// </exception>
	[ExcludeFromCodeCoverage]
	public ContentValidationApprover(IRoleSetValidator roleSetValidator)
		: this(roleSetValidator, Settings.Default)
	{
	}

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Web.StaticContent.ContentValidationApprover" />.
	/// </summary>
	/// <param name="roleSetValidator">An <see cref="T:Roblox.Platform.Membership.IRoleSetValidator" />.</param>
	/// <param name="staticContentSettings">An <see cref="T:Roblox.Web.StaticContent.Properties.IStaticContentSettings" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="roleSetValidator" />
	/// - <paramref name="staticContentSettings" />
	/// </exception>
	internal ContentValidationApprover(IRoleSetValidator roleSetValidator, IStaticContentSettings staticContentSettings)
	{
		_RoleSetValidator = roleSetValidator ?? throw new ArgumentNullException("roleSetValidator");
		_StaticContentSettings = staticContentSettings ?? throw new ArgumentNullException("staticContentSettings");
	}

	/// <inheritdoc cref="M:Roblox.Platform.StaticContent.IContentValidationApprover.CanAccessInvalidatedContent(Roblox.Platform.Membership.IUser)" />
	public bool CanAccessInvalidatedContent(IUser user)
	{
		if (_StaticContentSettings.IpAddressBypassRanges.Any())
		{
			System.Net.IPAddress ipAddress = System.Net.IPAddress.Parse(IpAddress);
			if (_StaticContentSettings.IpAddressBypassRanges.Any((IpAddressRange ipRange) => ipRange.IsInRange(ipAddress)))
			{
				return true;
			}
		}
		if (user == null)
		{
			return false;
		}
		return _RoleSetValidator.IsSoothsayer(user);
	}
}
