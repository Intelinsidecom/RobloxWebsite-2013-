using System.Collections.Generic;
namespace Roblox.EventStream {
    interface IDataSender

{
	void PublishData(List<string> dataList);
}


}
