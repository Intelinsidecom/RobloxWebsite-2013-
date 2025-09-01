using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Roblox;
using Roblox.Configuration;
using Roblox.Platform.Thumbnails.RequestValidation.Properties;

namespace Roblox.Platform.Thumbnails.RequestValidation
{
    public class ThumbnailRequestValidator
    {
        private static readonly HashSet<string> _ExtraDimensions = new HashSet<string>();

        public ThumbnailRequestValidator()
        {
            Roblox.Platform.Thumbnails.RequestValidation.Properties.Settings.Default.ReadValueAndMonitorChanges((Expression<Func<Roblox.Platform.Thumbnails.RequestValidation.Properties.Settings, string>>)((Roblox.Platform.Thumbnails.RequestValidation.Properties.Settings s) => s.WhitelistedDimensions), (Action)delegate
            {
                lock (_ExtraDimensions)
                {
                    _ExtraDimensions.Clear();
                    if (!string.IsNullOrWhiteSpace(Roblox.Platform.Thumbnails.RequestValidation.Properties.Settings.Default.WhitelistedDimensions))
                    {
                        Array.ForEach(Roblox.Platform.Thumbnails.RequestValidation.Properties.Settings.Default.WhitelistedDimensions.Split(new char[2] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries), delegate(string t)
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
            if (!Roblox.Platform.Thumbnails.RequestValidation.Properties.Settings.Default.ValidateThumbnailDimensions)
            {
                return true;
            }
            bool valid = Roblox.ThumbnailFormat.ValidateDimensions(width, height);
            if (!valid)
            {
                string key = Roblox.ThumbnailFormat.GetDimensionKey(width, height);
                valid = _ExtraDimensions.Contains(key);
            }
            if (!valid)
            {
                string errorMessage = "Request had invalid dimensions: " + Roblox.ThumbnailFormat.GetDimensionKey(width, height);
                if (Roblox.Platform.Thumbnails.RequestValidation.Properties.Settings.Default.LogRequestsWithInvalidDimensionsAsExceptions)
                {
                    ExceptionHandler.LogException(errorMessage);
                }
                throw new InvalidThumbnailSizeException(errorMessage);
            }
            return valid;
        }
    }
}
