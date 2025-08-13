using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Roblox.Website.Controllers
{
    public class ThumbnailController : Controller
    {
        public void AssetRequestThumbnail(long assetId, long? assetVersionId, int? width, int? height, string imageFormat, int thumbnailFormatId, bool overrideModeration)
        {

        }

        public void AvatarRequestThumbnail(long userId, int? width, int? height, string imageFormat, int thumbnailFormatId, bool dummy)
        {

        }
    }
}