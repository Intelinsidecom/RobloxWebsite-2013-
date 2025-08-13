using System.Collections.Generic;
using System.Drawing;

namespace Roblox.Drawing;

public class BitmapRegistry
{
	private readonly IDictionary<string, IDictionary<Size, Bitmap>> _TypedBitmaps = new Dictionary<string, IDictionary<Size, Bitmap>>();

	public bool TryGet(string type, Size size, out Bitmap bitmap)
	{
		bitmap = null;
		bool success = false;
		if (_TypedBitmaps.TryGetValue(type, out var sizedBitmaps) && sizedBitmaps.TryGetValue(size, out bitmap))
		{
			success = true;
		}
		return success;
	}

	public void Set(string type, Bitmap bitmap)
	{
		Size size = bitmap.Size;
		lock (_TypedBitmaps)
		{
			Bitmap sizedBitmap;
			if (!_TypedBitmaps.TryGetValue(type, out var sizedBitmaps))
			{
				sizedBitmaps = new Dictionary<Size, Bitmap>();
				sizedBitmaps[size] = bitmap;
				_TypedBitmaps[type] = sizedBitmaps;
			}
			else if (!sizedBitmaps.TryGetValue(size, out sizedBitmap))
			{
				sizedBitmaps.Add(size, bitmap);
			}
			else
			{
				sizedBitmaps[size] = bitmap;
				sizedBitmap.Dispose();
			}
		}
	}
}
