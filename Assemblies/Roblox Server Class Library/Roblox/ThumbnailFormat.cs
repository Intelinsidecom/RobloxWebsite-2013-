using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;

namespace Roblox;

[Serializable]
public class ThumbnailFormat : IRobloxEntity<int, ThumbnailFormatDAL>, ICacheableObject<int>, ICacheableObject
{
	public static class AvatarFormats
	{
		private static readonly LazyWithRetry<int> _JPEG48x48Lazy = LazyGetter("jpeg", 48, 48);

		private static readonly LazyWithRetry<int> _PNG100x100Lazy = LazyGetter("png", 100, 100);

		private static readonly LazyWithRetry<int> _JPEG100x100Lazy = LazyGetter("jpeg", 100, 100);

		private static readonly LazyWithRetry<int> _PNG150x200Lazy = LazyGetter("png", 150, 200);

		private static readonly LazyWithRetry<int> _PNG352x352Lazy = LazyGetter("png", 352, 352);

		private static readonly LazyWithRetry<int> _PNG30x30Lazy = LazyGetter("png", 30, 30);

		private static readonly LazyWithRetry<int> _PNG48x48Lazy = LazyGetter("png", 48, 48);

		private static readonly LazyWithRetry<int> _PNG180x180Lazy = LazyGetter("png", 180, 180);

		private static readonly LazyWithRetry<int> _PNG60x60Lazy = LazyGetter("png", 60, 60);

		private static readonly LazyWithRetry<int> _PNG150x150Lazy = LazyGetter("png", 150, 150);

		private static readonly LazyWithRetry<int> _PNG720x720Lazy = LazyGetter("png", 720, 720);

		public static int JPEG48x48 => _JPEG48x48Lazy.Value;

		public static int PNG100x100 => _PNG100x100Lazy.Value;

		public static int JPEG100x100 => _JPEG100x100Lazy.Value;

		public static int PNG150x200 => _PNG150x200Lazy.Value;

		public static int PNG352x352 => _PNG352x352Lazy.Value;

		public static int PNG30x30 => _PNG30x30Lazy.Value;

		public static int PNG48x48 => _PNG48x48Lazy.Value;

		public static int PNG180x180 => _PNG180x180Lazy.Value;

		public static int PNG60x60 => _PNG60x60Lazy.Value;

		public static int PNG150x150 => _PNG150x150Lazy.Value;

		public static int PNG720x720 => _PNG720x720Lazy.Value;
	}

	public static class AssetFormats
	{
		private static readonly LazyWithRetry<int> _PNG30x30Lazy = LazyGetter("png", 30, 30);

		private static readonly LazyWithRetry<int> _JPEG30x30Lazy = LazyGetter("jpeg", 30, 30);

		private static readonly LazyWithRetry<int> _PNG42x42Lazy = LazyGetter("png", 42, 42);

		private static readonly LazyWithRetry<int> _PNG60x62Lazy = LazyGetter("png", 60, 62);

		private static readonly LazyWithRetry<int> _PNG75x75Lazy = LazyGetter("png", 75, 75);

		private static readonly LazyWithRetry<int> _PNG110x110Lazy = LazyGetter("png", 110, 110);

		private static readonly LazyWithRetry<int> _JPEG110x110Lazy = LazyGetter("jpeg", 110, 110);

		private static readonly LazyWithRetry<int> _PNG150x150Lazy = LazyGetter("png", 150, 150);

		private static readonly LazyWithRetry<int> _PNG250x250Lazy = LazyGetter("png", 250, 250);

		private static readonly LazyWithRetry<int> _PNG728x90Lazy = LazyGetter("png", 728, 90);

		private static readonly LazyWithRetry<int> _JPEG728x90Lazy = LazyGetter("jpeg", 728, 90);

		private static readonly LazyWithRetry<int> _PNG160x600Lazy = LazyGetter("png", 160, 600);

		private static readonly LazyWithRetry<int> _JPEG160x600Lazy = LazyGetter("jpeg", 160, 600);

		private static readonly LazyWithRetry<int> _JPEG396x216Lazy = LazyGetter("jpeg", 396, 216);

		private static readonly LazyWithRetry<int> _JPEG304x166Lazy = LazyGetter("jpeg", 304, 166);

		private static readonly LazyWithRetry<int> _PNG300x250Lazy = LazyGetter("png", 300, 250);

		private static readonly LazyWithRetry<int> _JPEG300x250Lazy = LazyGetter("jpeg", 300, 250);

		private static readonly LazyWithRetry<int> _PNG420x420Lazy = LazyGetter("png", 420, 420);

		private static readonly LazyWithRetry<int> _JPEG420x420Lazy = LazyGetter("jpeg", 420, 420);

		private static readonly LazyWithRetry<int> _PNG512x512Lazy = LazyGetter("png", 512, 512);

		private static readonly LazyWithRetry<int> _PNG140x140Lazy = LazyGetter("png", 140, 140);

		private static readonly LazyWithRetry<int> _PNG700x700Lazy = LazyGetter("png", 700, 700);

		private static readonly LazyWithRetry<int> _PNG50x50Lazy = LazyGetter("png", 50, 50);

		private static readonly LazyWithRetry<int> _PNG768x432Lazy = LazyGetter("png", 768, 432);

		private static readonly LazyWithRetry<int> _PNG576x324Lazy = LazyGetter("png", 576, 324);

		private static readonly LazyWithRetry<int> _PNG480x270Lazy = LazyGetter("png", 480, 270);

		private static readonly LazyWithRetry<int> _PNG384x216Lazy = LazyGetter("png", 384, 216);

		private static readonly LazyWithRetry<int> _PNG256x144Lazy = LazyGetter("png", 256, 144);

		public static int PNG30x30 => _PNG30x30Lazy.Value;

		public static int JPEG30x30 => _JPEG30x30Lazy.Value;

		public static int PNG42x42 => _PNG42x42Lazy.Value;

		public static int PNG60x62 => _PNG60x62Lazy.Value;

		public static int PNG75x75 => _PNG75x75Lazy.Value;

		public static int PNG110x110 => _PNG110x110Lazy.Value;

		public static int JPEG110x110 => _JPEG110x110Lazy.Value;

		public static int PNG150x150 => _PNG150x150Lazy.Value;

		public static int PNG250x250 => _PNG250x250Lazy.Value;

		public static int PNG728x90 => _PNG728x90Lazy.Value;

		public static int JPEG728x90 => _JPEG728x90Lazy.Value;

		public static int PNG160x600 => _PNG160x600Lazy.Value;

		public static int JPEG160x600 => _JPEG160x600Lazy.Value;

		public static int JPEG396x216 => _JPEG396x216Lazy.Value;

		public static int JPEG304x166 => _JPEG304x166Lazy.Value;

		public static int PNG300x250 => _PNG300x250Lazy.Value;

		public static int JPEG300x250 => _JPEG300x250Lazy.Value;

		public static int PNG420x420 => _PNG420x420Lazy.Value;

		public static int JPEG420x420 => _JPEG420x420Lazy.Value;

		public static int PNG512x512 => _PNG512x512Lazy.Value;

		public static int PNG140x140 => _PNG140x140Lazy.Value;

		public static int PNG700x700 => _PNG700x700Lazy.Value;

		public static int PNG50x50 => _PNG50x50Lazy.Value;

		public static int PNG768x432 => _PNG768x432Lazy.Value;

		public static int PNG576x324 => _PNG576x324Lazy.Value;

		public static int PNG480x270 => _PNG480x270Lazy.Value;

		public static int PNG384x216 => _PNG384x216Lazy.Value;

		public static int PNG256x144 => _PNG256x144Lazy.Value;
	}

	public static class PlaceFormats
	{
		private static readonly LazyWithRetry<int> _PNG120x70Lazy = LazyGetter("png", 120, 70);

		private static readonly LazyWithRetry<int> _PNG160x100Lazy = LazyGetter("png", 160, 100);

		private static readonly LazyWithRetry<int> _JPEG160x100Lazy = LazyGetter("jpeg", 160, 100);

		private static readonly LazyWithRetry<int> _PNG192x108Lazy = LazyGetter("png", 192, 108);

		private static readonly LazyWithRetry<int> _PNG420x230Lazy = LazyGetter("png", 420, 230);

		private static readonly LazyWithRetry<int> _JPEG420x230Lazy = LazyGetter("jpeg", 420, 230);

		private static readonly LazyWithRetry<int> _JPEG455x256Lazy = LazyGetter("jpeg", 455, 256);

		private static readonly LazyWithRetry<int> _JPEG910x512Lazy = LazyGetter("jpeg", 910, 512);

		private static readonly LazyWithRetry<int> _JPEG548x294Lazy = LazyGetter("jpeg", 548, 294);

		private static readonly LazyWithRetry<int> _JPEG500x280Lazy = LazyGetter("jpeg", 500, 280);

		private static readonly LazyWithRetry<int> _PNG576x324Lazy = LazyGetter("png", 576, 324);

		private static readonly LazyWithRetry<int> _PNG512x512Lazy = LazyGetter("png", 512, 512);

		public static int PNG120x70 => _PNG120x70Lazy.Value;

		public static int PNG160x100 => _PNG160x100Lazy.Value;

		public static int JPEG160x100 => _JPEG160x100Lazy.Value;

		public static int PNG192x108 => _PNG192x108Lazy.Value;

		public static int PNG420x230 => _PNG420x230Lazy.Value;

		public static int JPEG420x230 => _JPEG420x230Lazy.Value;

		public static int JPEG455x256 => _JPEG455x256Lazy.Value;

		public static int JPEG910x512 => _JPEG910x512Lazy.Value;

		public static int JPEG548x294 => _JPEG548x294Lazy.Value;

		public static int JPEG500x280 => _JPEG500x280Lazy.Value;

		public static int PNG576x324 => _PNG576x324Lazy.Value;

		public static int PNG512x512 => _PNG512x512Lazy.Value;
	}

	private static readonly string _Jpeg;

	private static readonly string _Png;

	private static readonly string _Bmp;

	private static readonly string _Obj;

	private static readonly string _AnimationManifest;

	private static readonly HashSet<string> _Dimensions;

	private ThumbnailFormatDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo;

	public int ID
	{
		get
		{
			return _EntityDAL.ID;
		}
		set
		{
			_EntityDAL.ID = value;
		}
	}

	public ImageFormat ImageFormat
	{
		get
		{
			return ParseImageFormat(_EntityDAL.Format);
		}
		set
		{
			_EntityDAL.Format = value.ToString();
		}
	}

	public string Format
	{
		get
		{
			return _EntityDAL.Format;
		}
		set
		{
			_EntityDAL.Format = value;
		}
	}

	public int Width
	{
		get
		{
			return _EntityDAL.Width;
		}
		set
		{
			_EntityDAL.Width = value;
		}
	}

	public int Height
	{
		get
		{
			return _EntityDAL.Height;
		}
		set
		{
			_EntityDAL.Height = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	private static LazyWithRetry<int> LazyGetter(string format, int width, int height)
	{
		string key = GetDimensionKey(width, height);
		_Dimensions.Add(key);
		return new LazyWithRetry<int>(() => GetFormatID(format, width, height));
	}

	static ThumbnailFormat()
	{
		_Jpeg = ImageFormat.Jpeg.ToString();
		_Png = ImageFormat.Png.ToString();
		_Bmp = ImageFormat.Bmp.ToString();
		_Obj = "Obj";
		_AnimationManifest = "AnimationManifest";
		_Dimensions = new HashSet<string>();
		EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true), "ThumbnailFormat", isNullCacheable: true);
		RuntimeHelpers.RunClassConstructor(typeof(AssetFormats).TypeHandle);
		RuntimeHelpers.RunClassConstructor(typeof(AvatarFormats).TypeHandle);
		RuntimeHelpers.RunClassConstructor(typeof(PlaceFormats).TypeHandle);
	}

	public static bool ValidateDimensions(int width, int height)
	{
		string key = GetDimensionKey(width, height);
		return _Dimensions.Contains(key);
	}

	public static string GetDimensionKey(int width, int height)
	{
		return $"{width}x{height}";
	}

	public static ImageFormat ParseImageFormat(string format)
	{
		if (string.Compare(format, _Jpeg, ignoreCase: true) == 0)
		{
			return ImageFormat.Jpeg;
		}
		if (string.Compare(format, _Png, ignoreCase: true) == 0)
		{
			return ImageFormat.Png;
		}
		if (string.Compare(format, _Bmp, ignoreCase: true) == 0)
		{
			return ImageFormat.Bmp;
		}
		if (string.Compare(format, _Obj, ignoreCase: true) == 0)
		{
			return null;
		}
		if (string.Compare(format, _AnimationManifest, ignoreCase: true) == 0)
		{
			return null;
		}
		return ImageFormat.Png;
	}

	private static int GetFormatID(string format, int width, int height)
	{
		return GetOrCreate(format, width, height).ID;
	}

	public ThumbnailFormat(ThumbnailFormatDAL dal)
	{
		_EntityDAL = dal;
	}

	public ThumbnailFormat()
	{
		_EntityDAL = new ThumbnailFormatDAL();
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Update();
		});
	}

	private static ThumbnailFormat DoGetOrCreate(string format, int width, int height)
	{
		return EntityHelper.DoGetOrCreate<int, ThumbnailFormatDAL, ThumbnailFormat>(() => ThumbnailFormatDAL.GetOrCreate(format, width, height));
	}

	public static ThumbnailFormat GetOrCreate(string format, int width, int height)
	{
		if (string.IsNullOrEmpty(format))
		{
			throw new ApplicationException("Required value not specified: Format.");
		}
		if (width == 0)
		{
			throw new ApplicationException("Required value not specified: Width.");
		}
		if (height == 0)
		{
			throw new ApplicationException("Required value not specified: Height.");
		}
		return EntityHelper.GetOrCreateEntity<int, ThumbnailFormat>(EntityCacheInfo, $"Format:{format}_Width:{width}_Height:{height}", () => DoGetOrCreate(format, width, height));
	}

	public static ThumbnailFormat Get(string format, int width, int height)
	{
		if (string.IsNullOrEmpty(format))
		{
			return null;
		}
		if (width == 0 || height == 0)
		{
			return null;
		}
		return EntityHelper.GetEntityByLookup<int, ThumbnailFormatDAL, ThumbnailFormat>(EntityCacheInfo, $"Format:{format}_Width:{width}_Height:{height}", () => ThumbnailFormatDAL.Get(format, width, height));
	}

	public static ThumbnailFormat Get(int id)
	{
		return EntityHelper.GetEntity<int, ThumbnailFormatDAL, ThumbnailFormat>(EntityCacheInfo, id, () => ThumbnailFormatDAL.Get(id));
	}

	public void Construct(ThumbnailFormatDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		yield return $"Format:{Format}_Width:{Width}_Height:{Height}";
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield break;
	}
}
