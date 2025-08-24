using System.Collections.Generic;

namespace Roblox.Platform.EventStream;

public interface IDataSender
{
	void PublishData(List<string> dataList);
}
