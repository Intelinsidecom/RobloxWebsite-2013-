using System;
using System.Collections.Generic;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.Outfits;

namespace Roblox.Platform.Outfits;

public class Color : IColor
{
	public int ID { get; private set; }

	public byte R { get; private set; }

	public byte G { get; private set; }

	public byte B { get; private set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	public static IColor GetOrCreate(byte r, byte g, byte b)
	{
		return Roblox.Outfits.Color.GetOrCreate(r, g, b).Translate();
	}

	public static IColor GetOrCreate(int brickColorId)
	{
		BrickColor brickColorEntity = BrickColor.Get(brickColorId);
		if (brickColorEntity == null)
		{
			return null;
		}
		return GetOrCreate(brickColorEntity.Color.R, brickColorEntity.Color.G, brickColorEntity.Color.B);
	}

	public bool IsValidBrickColor()
	{
		if (BrickColor.GetByRGB(R, G, B) == null)
		{
			return false;
		}
		return true;
	}

	public int GetBrickColorID()
	{
		return BrickColor.GetByRGB(R, G, B)?.ID ?? BrickColor.DefaultBrickColor.ID;
	}

	internal Color(int id, byte r, byte g, byte b)
	{
		ID = id;
		R = r;
		G = g;
		B = b;
	}
}

// Merge-in of the source entity to avoid separate files.
namespace Roblox.Outfits
{
    public class Color : IRobloxEntity<int, ColorDAL>, ICacheableObject<int>, ICacheableObject, IRemoteCacheableObject
    {
        private ColorDAL _EntityDAL;

        public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: false, countsAreCacheable: false, entityIsCacheable: true, idLookupsAreCacheable: true, hasUnqualifiedCollections: false), typeof(Color).ToString(), isNullCacheable: true);

        public int ID => _EntityDAL.ID;

        public byte R
        {
            get
            {
                return _EntityDAL.R;
            }
            set
            {
                _EntityDAL.R = value;
            }
        }

        public byte G
        {
            get
            {
                return _EntityDAL.G;
            }
            set
            {
                _EntityDAL.G = value;
            }
        }

        public byte B
        {
            get
            {
                return _EntityDAL.B;
            }
            set
            {
                _EntityDAL.B = value;
            }
        }

        public DateTime Created
        {
            get
            {
                return _EntityDAL.Created;
            }
            set
            {
                _EntityDAL.Created = value;
            }
        }

        public DateTime Updated
        {
            get
            {
                return _EntityDAL.Updated;
            }
            set
            {
                _EntityDAL.Updated = value;
            }
        }

        public CacheInfo CacheInfo => EntityCacheInfo;

        public Color()
        {
            _EntityDAL = new ColorDAL();
        }

        public void Delete()
        {
            EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
        }

        public void Save()
        {
            EntityHelper.SaveEntity(this, delegate
            {
                _EntityDAL.Created = DateTime.Now;
                _EntityDAL.Updated = _EntityDAL.Created;
                _EntityDAL.Insert();
            }, delegate
            {
                _EntityDAL.Updated = DateTime.Now;
                _EntityDAL.Update();
            });
        }

        public static Color CreateNew(byte r, byte g, byte b)
        {
            Color color = new Color();
            color.R = r;
            color.G = g;
            color.B = b;
            color.Save();
            return color;
        }

        public static Color Get(int id)
        {
            return EntityHelper.GetEntity<int, ColorDAL, Color>(EntityCacheInfo, id, () => ColorDAL.Get(id));
        }

        public static Color GetOrCreate(byte r, byte g, byte b)
        {
            return EntityHelper.GetOrCreateEntityWithRemoteCache<int, Color>(EntityCacheInfo, $"R:{r}G:{g}B:{b}".Trim(), () => DoGetOrCreate(r, g, b), Get);
        }

        private static Color DoGetOrCreate(byte r, byte g, byte b)
        {
            return EntityHelper.DoGetOrCreate<int, ColorDAL, Color>(() => ColorDAL.GetOrCreate(r, g, b));
        }

        public object GetSerializable()
        {
            return _EntityDAL;
        }

        public void Construct(ColorDAL dal)
        {
            _EntityDAL = dal;
        }

        public IEnumerable<string> BuildEntityIDLookups()
        {
            yield return $"R:{R}G:{G}B:{B}";
        }

        public IEnumerable<StateToken> BuildStateTokenCollection()
        {
            yield break;
        }
    }
}
