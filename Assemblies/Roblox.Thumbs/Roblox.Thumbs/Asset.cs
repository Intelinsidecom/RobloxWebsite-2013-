using System;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using Roblox.Common;

namespace Roblox.Thumbs;

/// <summary>
/// Creates Asset thumbnails and provides Urls to the thumbnails
/// This web service is coupled with AssetImage.js and the AssetImage control
/// </summary>
[WebService(Namespace = "http://roblox.com/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[GenerateScriptType(typeof(ScriptThumbResult))]
[ScriptService]
public class Asset : WebService
{
	internal ThumbnailDomainFactories DomainFactories { get; }

	private IRequestProtocolResolver<HttpRequest> ProtocolResolver { get; }

	public bool IsReusable => true;

	public Asset(ThumbnailDomainFactories domainFactories, IRequestProtocolResolver<HttpRequest> resolver = null)
	{
		DomainFactories = domainFactories ?? throw new ArgumentNullException("domainFactories");
		ProtocolResolver = resolver ?? new HttpRequestProtocolResolver();
	}

	/// <exception cref="T:Roblox.Thumbnails.RequestValidation.InvalidThumbnailSizeException"></exception>
	[WebMethod]
	[ScriptMethod(UseHttpGet = true)]
	public ScriptThumbResult RequestThumbnail(long assetId, long? assetVersionId, int? width, int? height, string imageFormat, int thumbnailFormatId, bool overrideModeration)
	{
		if (!width.HasValue || !height.HasValue)
		{
			ThumbnailFormat thumbnailFormat = ThumbnailFormat.Get(thumbnailFormatId);
			width = thumbnailFormat.Width;
			height = thumbnailFormat.Height;
		}
		IAsset iAsset = ((!assetVersionId.HasValue || assetVersionId.Value == 0L) ? ((IAsset)Roblox.Asset.Get(assetId)) : ((IAsset)AssetVersion.Get(assetVersionId.Value)));
		ImageParameters imageParameters = new ImageParameters(width.Value, height.Value, imageFormat, thumbnailFormatId);
		DomainFactories.ThumbnailRequestValidator.ValidateDimensions(imageParameters.Width, imageParameters.Height);
		return new ScriptThumbResult(DomainFactories.Asset.GetThumbnailUrl(iAsset, imageParameters, overrideModeration), ProtocolResolver.IsRequestSecure(base.Context.Request));
	}

	[WebMethod]
	[ScriptMethod(UseHttpGet = true)]
	public ScriptThumbResult RequestThumbnail_v2(long assetId, long? assetVersionId, int? width, int? height, string imageFormat, int thumbnailFormatId, bool overrideModeration)
	{
		return RequestThumbnail(assetId, assetVersionId, width, height, imageFormat, thumbnailFormatId, overrideModeration);
	}
}
