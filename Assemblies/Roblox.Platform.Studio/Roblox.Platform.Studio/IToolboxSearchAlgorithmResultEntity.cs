namespace Roblox.Platform.Studio;

internal interface IToolboxSearchAlgorithmResultEntity
{
	long Id { get; set; }

	int AlgorithmId { get; set; }

	string Keyword { get; set; }

	long[] Results { get; set; }

	void Delete();
}
