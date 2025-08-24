using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Roblox.Configuration;
using Roblox.Thumbnails.RequestValidation.Properties;

namespace Roblox.Thumbnails.RequestValidation;

public class ThumbnailRequestValidator
{
	private static readonly HashSet<string> _ExtraDimensions = new HashSet<string>();

	public ThumbnailRequestValidator()
	{
		Settings.Default.ReadValueAndMonitorChanges((Expression<Func<Settings, string>>)((Settings s) => s.WhitelistedDimensions), (Action)delegate
		{
			lock (_ExtraDimensions)
			{
				_ExtraDimensions.Clear();
				if (!string.IsNullOrWhiteSpace(Settings.Default.WhitelistedDimensions))
				{
					Array.ForEach(Settings.Default.WhitelistedDimensions.Split(new char[2] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries), delegate(string t)
					{
						_ExtraDimensions.Add(t);
					});
				}
			}
		});
	}

	/// <exception cref="T:Roblox.Thumbnails.RequestValidation.InvalidThumbnailSizeException">Thrown when invalid thumbnail dimensions are requested</exception>
	public virtual bool ValidateDimensions(int width, int height)
	{
		if (!Settings.Default.ValidateThumbnailDimensions)
		{
			return true;
		}
		bool valid = ThumbnailFormat.ValidateDimensions(width, height);
		if (!valid)
		{
			string key = ThumbnailFormat.GetDimensionKey(width, height);
			valid = _ExtraDimensions.Contains(key);
		}
		if (!valid)
		{
			string errorMessage = "Request had invalid dimensions: " + ThumbnailFormat.GetDimensionKey(width, height);
			if (Settings.Default.LogRequestsWithInvalidDimensionsAsExceptions)
			{
				ExceptionHandler.LogException(errorMessage);
			}
			throw new InvalidThumbnailSizeException(errorMessage);
		}
		return valid;
	}
}
