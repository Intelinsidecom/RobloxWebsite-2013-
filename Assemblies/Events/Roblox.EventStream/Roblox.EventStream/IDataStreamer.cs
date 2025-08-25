using System.Collections.Generic;

namespace Roblox.Platform.EventStream;

/// <summary>
/// Defines interface for streaming data.
/// </summary>
public interface IDataStreamer
{
	/// <summary>
	/// Streams data.    
	/// </summary>
	/// <param name="dataList">Data list</param>
	void StreamData(List<string> dataList);
}
