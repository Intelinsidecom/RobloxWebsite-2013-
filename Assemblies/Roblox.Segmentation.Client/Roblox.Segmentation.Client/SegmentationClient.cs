using System;
using System.Collections.Generic;
using System.Text;
using Roblox.ApiClientBase;
using Roblox.Configuration;
using Roblox.Segmentation.Client.Properties;

namespace Roblox.Segmentation.Client;

public class SegmentationClient : GuardedApiClientBase
{
	private readonly Func<string> _ApiKeyGetter;

	private readonly Func<string> _ServiceUrlGetter;

	public override Encoding Encoding => null;

	protected override string ApiKey => _ApiKeyGetter();

	protected override string Endpoint => _ServiceUrlGetter();

	public override string Name => "SegmentationClient";

	protected override TimeSpan Timeout => Settings.Default.SegmentationServiceTimeout;

	public SegmentationClient(Func<string> apiKeyGetterGetter)
		: this(apiKeyGetterGetter, () => RobloxEnvironment.GetApiEndpoint("segmentation"))
	{
	}

	public SegmentationClient(Func<string> apiKeyGetter, Func<string> serviceUrlGetter)
	{
		_ApiKeyGetter = apiKeyGetter;
		_ServiceUrlGetter = serviceUrlGetter;
	}

	public IDimension CreateDimension(string dimensionName)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("dimensionName", dimensionName)
		};
		return Post<Dimension>("/v1.1/CreateDimension", queryStringParameters);
	}

	public ISegment CreateSegment(IDimension dimension, string segmentName)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[2]
		{
			new KeyValuePair<string, object>("dimensionName", dimension.Name),
			new KeyValuePair<string, object>("segmentName", segmentName)
		};
		return Post<Segment>("/v1.1/CreateSegment", queryStringParameters);
	}

	public IDimension GetDimension(string dimensionName)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("dimensionName", dimensionName)
		};
		return Get<Dimension>("/v1.1/GetDimension", queryStringParameters);
	}

	public IEnumerable<ISegment> GetDimensionSegments(IDimension dimension)
	{
		KeyValuePair<string, object>[] queryStringParameters = new KeyValuePair<string, object>[1]
		{
			new KeyValuePair<string, object>("dimensionName", dimension.Name)
		};
		return Get<Segment[]>("/v1.1/GetSegments", queryStringParameters);
	}
}
