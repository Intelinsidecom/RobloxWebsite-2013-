namespace Roblox.CachingV2.Core;

public delegate TRawValue FinalToRawValueConverter<in TFinalValue, out TRawValue>(TFinalValue finalValue);
