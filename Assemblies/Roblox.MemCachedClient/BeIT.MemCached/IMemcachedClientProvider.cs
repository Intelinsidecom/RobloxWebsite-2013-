using System.ComponentModel;

namespace BeIT.MemCached;

public interface IMemcachedClientProvider : INotifyPropertyChanged
{
	IMemcachedClient MemcachedClient { get; }
}
