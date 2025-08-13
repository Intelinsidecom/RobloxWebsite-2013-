using System;
using System.ComponentModel;

namespace Roblox.Configuration;

internal class SingleSetting<T, TVal> : ISingleSetting<TVal>, INotifyPropertyChanged, IDisposable where T : class, INotifyPropertyChanged
{
	private readonly T _Settings;

	private readonly Func<T, TVal> _ValueGetter;

	private readonly string _SettingName;

	public TVal Value { get; private set; }

	public event PropertyChangedEventHandler PropertyChanged;

	public SingleSetting(T settings, Func<T, TVal> valueGetter, string settingName)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_ValueGetter = valueGetter ?? throw new ArgumentNullException("valueGetter");
		_SettingName = settingName ?? throw new ArgumentNullException("settingName");
		settings.PropertyChanged += SettingsOnPropertyChanged;
		Value = valueGetter(settings);
	}

	private void SettingsOnPropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		TVal val = default(TVal);
		try
		{
			val = _ValueGetter(_Settings);
		}
		catch (Exception ex)
		{
			ConfigurationLogging.Error(ex.ToString());
			return;
		}
		if (e.PropertyName == _SettingName && !object.Equals(Value, val))
		{
			Value = val;
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Value"));
		}
	}

	public void Dispose()
	{
		_Settings.PropertyChanged -= SettingsOnPropertyChanged;
	}
}
