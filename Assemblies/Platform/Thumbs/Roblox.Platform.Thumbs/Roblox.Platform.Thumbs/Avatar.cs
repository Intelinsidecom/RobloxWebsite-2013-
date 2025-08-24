using System;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using Roblox.Common;

namespace Roblox.Thumbs;

[WebService(Namespace = "http://roblox.com/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[GenerateScriptType(typeof(ScriptThumbResult))]
[ScriptService]
public class Avatar : WebService
{
	private ThumbnailDomainFactories DomainFactories { get; }

	private IRequestProtocolResolver<HttpRequest> ProtocolResolver { get; }

	public Avatar(ThumbnailDomainFactories domainFactories, IRequestProtocolResolver<HttpRequest> resolver = null)
	{
		DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		ProtocolResolver = resolver ?? new HttpRequestProtocolResolver();
	}

	/// <exception cref="T:Roblox.Thumbnails.RequestValidation.InvalidThumbnailSizeException"></exception>
	[WebMethod]
	[ScriptMethod(UseHttpGet = true)]
	public ScriptThumbResult RequestThumbnail(long userId, int? width, int? height, string imageFormat, int thumbnailFormatId, bool dummy)
	{
		if (!width.HasValue || !height.HasValue)
		{
			ThumbnailFormat thumbnailFormat = ThumbnailFormat.Get(thumbnailFormatId) ?? ThumbnailFormat.Get(ThumbnailFormat.AvatarFormats.PNG100x100);
			width = thumbnailFormat.Width;
			height = thumbnailFormat.Height;
		}
		User user = Roblox.User.Get(userId);
		ImageParameters imageParameters = new ImageParameters(width.Value, height.Value, imageFormat, thumbnailFormatId);
		DomainFactories.ThumbnailRequestValidator.ValidateDimensions(imageParameters.Width, imageParameters.Height);
		return new ScriptThumbResult(DomainFactories.Avatar.GetThumbnailUrl(user, imageParameters), ProtocolResolver.IsRequestSecure(base.Context.Request));
	}
}
