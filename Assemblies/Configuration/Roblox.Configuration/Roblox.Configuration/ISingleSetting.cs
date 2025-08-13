using System.ComponentModel;

namespace Roblox.Configuration;

public interface ISingleSetting<T> : INotifyPropertyChanged
{
	T Value { get; }
}
