using Roblox.Segmentation.Client;

namespace Roblox.Classification.Interfaces;

internal interface IClassifier<T>
{
	ISegment Classify(T item);
}
