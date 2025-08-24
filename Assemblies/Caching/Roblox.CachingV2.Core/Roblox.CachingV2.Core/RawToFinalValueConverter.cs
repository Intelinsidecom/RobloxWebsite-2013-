namespace Roblox.CachingV2.Core;

public delegate bool RawToFinalValueConverter<in TRawValue, TFinalValue>(TRawValue rawValue, out TFinalValue finalValue);
