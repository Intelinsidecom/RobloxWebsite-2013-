using System;
using System.ComponentModel;
using System.Globalization;

namespace Roblox.Caching;

public class MigrationStateChangeConverter : TypeConverter
{
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
	{
		return sourceType == typeof(string);
	}

	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
	{
		if (value is string migrationStateChange)
		{
			return new MigrationStateChange(migrationStateChange);
		}
		return base.ConvertFrom(context, culture, value);
	}

	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
	{
		if (destinationType == typeof(string))
		{
			return (value as MigrationStateChange)?.ToString();
		}
		return base.ConvertTo(context, culture, value, destinationType);
	}
}
