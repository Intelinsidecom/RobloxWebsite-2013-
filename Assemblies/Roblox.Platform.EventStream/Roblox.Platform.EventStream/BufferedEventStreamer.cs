using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Roblox.Collections;
using Roblox.EventLog;
using Roblox.Random;

namespace Roblox.Platform.EventStream;

public class BufferedEventStreamer : BufferedCounterBase<string>, IEventStreamer
{
	private IEventStreamer _Streamer;

	private ILogger _Logger;

	private Func<TimeSpan> _CommitIntervalGetter;

	private Func<double> _PercentRolloutGetter;

	private IRandom _Random;

	protected override TimeSpan CommitInterval
	{
		get
		{
			if (_CommitIntervalGetter == null)
			{
				return TimeSpan.FromSeconds(5.0);
			}
			return _CommitIntervalGetter();
		}
	}

	public BufferedEventStreamer(IEventStreamer streamer, Func<TimeSpan> commitIntervalGetter, ILogger logger, Func<double> percentRolloutGetter)
		: base(logger)
	{
		_CommitIntervalGetter = commitIntervalGetter;
		_PercentRolloutGetter = percentRolloutGetter;
		_Streamer = streamer;
		_Logger = logger;
		_Random = new RandomFactory().GetDefaultRandom();
	}

	public void StreamEvent(string target, string eventType, IReadOnlyCollection<KeyValuePair<string, string>> eventParameters, string clientIp, bool isTrustedSource, string partitionKey = null)
	{
		Increment(StandardizeParameters(target, eventType, eventParameters, clientIp, isTrustedSource, partitionKey));
	}

	public void MultiStreamEvent(string target, string eventType, IReadOnlyCollection<KeyValuePair<string, string>> eventParameters, string clientIp, bool isTrustedSource, int numberOfEvents, string partitionKey = null)
	{
		Increment(StandardizeParameters(target, eventType, eventParameters, clientIp, isTrustedSource, partitionKey), numberOfEvents);
	}

	public bool IsIncludedInRollout()
	{
		if (_PercentRolloutGetter() == 100.0)
		{
			return true;
		}
		return _PercentRolloutGetter() > _Random.NextDouble() * 100.0;
	}

	private string StandardizeParameters(string target, string eventType, IReadOnlyCollection<KeyValuePair<string, string>> parameters, string clientIp, bool isTrustedSource, string partitionKey = null)
	{
		return JsonConvert.SerializeObject(new BufferableEvent
		{
			Target = target,
			EventType = eventType,
			EventParameters = parameters,
			ClientIp = clientIp,
			IsTrustedSource = isTrustedSource,
			PartitionKey = partitionKey
		});
	}

	private BufferableEvent DestandardizeParameters(string standardizedParameters)
	{
		return JsonConvert.DeserializeObject<BufferableEvent>(standardizedParameters);
	}

	protected override void Commit(IEnumerable<KeyValuePair<string, double>> committableDictionary)
	{
		try
		{
			Parallel.ForEach(committableDictionary, new ParallelOptions
			{
				MaxDegreeOfParallelism = 10
			}, delegate(KeyValuePair<string, double> item)
			{
				BufferableEvent bufferableEvent = DestandardizeParameters(item.Key);
				List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
				list.AddRange(bufferableEvent.EventParameters);
				list.Add(new KeyValuePair<string, string>("_eventCount", item.Value.ToString()));
				_Streamer.StreamEvent(bufferableEvent.Target, bufferableEvent.EventType, list, bufferableEvent.ClientIp, bufferableEvent.IsTrustedSource, bufferableEvent.PartitionKey);
			});
		}
		catch (AggregateException ex)
		{
			_Logger.Error(ex);
		}
	}
}
