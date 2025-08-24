using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using Roblox.Instrumentation;

namespace BeIT.MemCached;

public class MemcachedClient : IMemcachedClient, IDisposable
{
	public enum CasResult
	{
		Stored,
		NotStored,
		Exists,
		NotFound
	}

	public static object Null = Serializer.Null;

	private readonly IServerPool _ServerPool;

	private readonly MemcachedMonitor _MemcachedMonitor;

	private readonly IMemCachedClientSettings _Settings;

	private readonly IMemcachedClientExceptionHandler _ExceptionHandler;

	private readonly Serializer _Serializer;

	private readonly Action<Exception> _HandleException;

	private static readonly TimeSpan _MaximumMemcachedExpiry = TimeSpan.FromDays(30.0);

	public MemcachedClient(string name, string[] hosts, Action<Exception> handleException, ICounterRegistry counterRegistry, IMemCachedClientSettings settings = null)
		: this(name, hosts, handleException, counterRegistry, settings, null, null)
	{
	}

	internal MemcachedClient(string name, string[] hosts, Action<Exception> handleException, ICounterRegistry counterRegistry, IMemCachedClientSettings settings, IMemcachedClientExceptionHandler exceptionHandler, IEndpointResolver endpointResolver)
	{
		if (settings == null)
		{
			settings = new DefaultMemCachedClientSettings();
		}
		_Settings = settings;
		if (exceptionHandler == null)
		{
			exceptionHandler = new MemcachedClientExceptionHandler(settings);
		}
		_ExceptionHandler = exceptionHandler;
		endpointResolver = endpointResolver ?? new CachingEndpointResolver(new EndpointResolver(settings.DnsSettings), () => settings.EndpointCacheExpiry, exceptionHandler.HandleException);
		_HandleException = handleException ?? throw new ArgumentNullException("handleException");
		_MemcachedMonitor = new MemcachedMonitor(counterRegistry, name);
		_ServerPool = CreateServerPool(hosts, _MemcachedMonitor, settings, exceptionHandler, endpointResolver);
		exceptionHandler.ExceptionOccurred += handleException;
		_Serializer = new Serializer(_MemcachedMonitor);
	}

	public bool Set<T>(string key, T value, TimeSpan expiry)
	{
		return Store("set", key, value, expiry);
	}

	public bool Add<T>(string key, T value, TimeSpan expiry)
	{
		return Store("add", key, value, expiry);
	}

	public bool Replace<T>(string key, T value, TimeSpan expiry)
	{
		return Store("replace", key, value, expiry);
	}

	public bool Append<T>(string key, T value)
	{
		return Store("append", key, value, null);
	}

	public bool Prepend<T>(string key, T value)
	{
		return Store("prepend", key, value, null);
	}

	public CasResult CheckAndSet<T>(string key, T value, TimeSpan expiry, ulong unique)
	{
		return Store(key, value, expiry, unique);
	}

	private bool Store<T>(string command, string key, T value, TimeSpan? expiry)
	{
		return Store(command, key, value, expiry, 0uL).StartsWith("STORED");
	}

	private CasResult Store<T>(string key, T value, TimeSpan? expiry, ulong unique)
	{
		string text = Store("cas", key, value, expiry, unique);
		if (text.StartsWith("STORED"))
		{
			return CasResult.Stored;
		}
		if (text.StartsWith("EXISTS"))
		{
			return CasResult.Exists;
		}
		if (text.StartsWith("NOT_FOUND"))
		{
			return CasResult.NotFound;
		}
		return CasResult.NotStored;
	}

	private int GetAdjustedExpiry(IPooledSocket socket, TimeSpan defaultExpiry)
	{
		if (_Settings.PerHostExpiryOverrides.TryGetValue(socket.RemoteEndPoint, out var value))
		{
			return Math.Min((int)value.TotalSeconds, (int)defaultExpiry.TotalSeconds);
		}
		return (int)defaultExpiry.TotalSeconds;
	}

	private string Store<T>(string command, string key, T value, TimeSpan? expiry, ulong unique)
	{
		ValidateKeyOrThrow(key);
		if (expiry.HasValue && expiry.Value > _MaximumMemcachedExpiry)
		{
			throw new ArgumentException(string.Format("{0} is {1} which is longer than the {2} limit.", "expiry", expiry.Value, _MaximumMemcachedExpiry), "expiry");
		}
		uint hash = Hash(key);
		SerializedType type;
		byte[] bytes = _Serializer.Serialize(value, out type, _Settings.CompressionThreshold);
		return _ServerPool.Execute(hash, ExecutionType.Write, delegate(IPooledSocket socket)
		{
			int num = (_Settings.PerHostExpiryOverridesEnabled ? GetAdjustedExpiry(socket, expiry.GetValueOrDefault()) : ((int)expiry.GetValueOrDefault().TotalSeconds));
			string str = "";
			switch (command)
			{
			case "set":
			case "add":
			case "replace":
				str = command + " " + key + " " + (ushort)type + " " + num + " " + bytes.Length + "\r\n";
				break;
			case "append":
			case "prepend":
				str = command + " " + key + " 0 0 " + bytes.Length + "\r\n";
				break;
			case "cas":
				str = command + " " + key + " " + (ushort)type + " " + num + " " + bytes.Length + " " + unique + "\r\n";
				break;
			}
			socket.Write(str);
			socket.Write(bytes);
			socket.Write("\r\n");
			return socket.ReadResponse();
		}) ?? string.Empty;
	}

	public object Get(string key)
	{
		ulong unique;
		return Get("get", key, out unique);
	}

	public object Gets(string key, out ulong unique)
	{
		return Get("gets", key, out unique);
	}

	private object Get(string command, string key, out ulong unique)
	{
		ValidateKeyOrThrow(key);
		ulong readUniqueInsideLambda = 0uL;
		uint hash = Hash(key);
		string commandLine = command + " " + key + "\r\n";
		object result = _ServerPool.Execute(hash, ExecutionType.Read, delegate(IPooledSocket socket)
		{
			socket.Write(commandLine);
			if (ReadValue(socket, out var value, out var key2, out var unique2))
			{
				socket.ReadLine();
			}
			readUniqueInsideLambda = unique2;
			if (key != key2 && (!string.IsNullOrWhiteSpace(key2) || value != null))
			{
				_MemcachedMonitor.GetCommandReturnedValueMismatchedPerSecond.Increment();
				return null;
			}
			return value;
		});
		unique = readUniqueInsideLambda;
		return result;
	}

	public object[] Get(string[] keys)
	{
		ulong[] uniques;
		return Get("get", keys, out uniques);
	}

	public object[] Gets(string[] keys, out ulong[] uniques)
	{
		return Get("gets", keys, out uniques);
	}

	private object[] Get(string command, string[] keys, out ulong[] uniques)
	{
		if (keys == null)
		{
			throw new ArgumentException("Keys array must not be null.");
		}
		uniques = new ulong[keys.Length];
		if (keys.Length == 1)
		{
			return new object[1] { Get(command, keys[0], out uniques[0]) };
		}
		foreach (string key in keys)
		{
			ValidateKeyOrThrow(key);
		}
		uint[] hashes = Hash(keys);
		Dictionary<ISocketPool, Dictionary<string, List<int>>> dictionary = new Dictionary<ISocketPool, Dictionary<string, List<int>>>();
		ISocketPool[] socketPoolsForHashes = GetSocketPoolsForHashes(hashes);
		for (int j = 0; j < keys.Length; j++)
		{
			ISocketPool key2 = socketPoolsForHashes[j];
			if (!dictionary.TryGetValue(key2, out var value))
			{
				value = (dictionary[key2] = new Dictionary<string, List<int>>());
			}
			if (!value.TryGetValue(keys[j], out var value2))
			{
				value2 = (value[keys[j]] = new List<int>());
			}
			value2.Add(j);
		}
		object[] returnValues = new object[keys.Length];
		ulong[] uniquesUpdatedInLambda = new ulong[keys.Length];
		foreach (KeyValuePair<ISocketPool, Dictionary<string, List<int>>> kv in dictionary)
		{
			StringBuilder stringBuilder = new StringBuilder(command);
			foreach (KeyValuePair<string, List<int>> item in kv.Value)
			{
				stringBuilder.Append(" ");
				stringBuilder.Append(item.Key);
			}
			stringBuilder.Append("\r\n");
			string commandLine = stringBuilder.ToString();
			_ServerPool.Execute(kv.Key, ExecutionType.Read, delegate(IPooledSocket pooledSocket)
			{
				pooledSocket.Write(commandLine);
				object value3;
				string key3;
				ulong unique;
				while (ReadValue(pooledSocket, out value3, out key3, out unique))
				{
					foreach (int item2 in kv.Value[key3])
					{
						returnValues[item2] = value3;
						uniquesUpdatedInLambda[item2] = unique;
					}
				}
			});
		}
		uniques = uniquesUpdatedInLambda;
		return returnValues;
	}

	private bool ReadValue(IPooledSocket socket, out object value, out string key, out ulong unique)
	{
		string[] array = socket.ReadResponse().Split(new char[1] { ' ' });
		if (array[0] == "VALUE")
		{
			key = array[1];
			SerializedType type = (SerializedType)Enum.Parse(typeof(SerializedType), array[2]);
			byte[] bytes = new byte[Convert.ToUInt32(array[3], CultureInfo.InvariantCulture)];
			if (array.Length > 4)
			{
				unique = Convert.ToUInt64(array[4]);
			}
			else
			{
				unique = 0uL;
			}
			socket.Read(bytes);
			socket.SkipUntilEndOfLine();
			value = _Serializer.DeSerialize(bytes, type);
			return true;
		}
		key = null;
		value = null;
		unique = 0uL;
		return false;
	}

	public bool Delete(string key)
	{
		return Delete(key, 0);
	}

	public bool Delete(string key, TimeSpan delay)
	{
		return Delete(key, (int)delay.TotalSeconds);
	}

	private bool Delete(string key, int time)
	{
		ValidateKeyOrThrow(key);
		uint hash = Hash(key);
		string commandline;
		if (time == 0)
		{
			commandline = "delete " + key + "\r\n";
		}
		else
		{
			commandline = "delete " + key + " " + time + "\r\n";
		}
		return _ServerPool.Execute(hash, ExecutionType.Write, delegate(IPooledSocket socket)
		{
			socket.Write(commandline);
			return socket.ReadResponse().StartsWith("DELETED");
		});
	}

	public bool SetCounter(string key, ulong value, TimeSpan expiry)
	{
		return Set(key, value.ToString(CultureInfo.InvariantCulture), expiry);
	}

	public ulong? GetCounter(string key)
	{
		if (!ulong.TryParse(Get("get", key, out var _) as string, out var result))
		{
			return null;
		}
		return result;
	}

	public ulong?[] GetCounter(string[] keys)
	{
		ulong?[] array = new ulong?[keys.Length];
		ulong[] uniques;
		object[] array2 = Get("get", keys, out uniques);
		for (int i = 0; i < array2.Length; i++)
		{
			string s = array2[i] as string;
			array[i] = (ulong.TryParse(s, out var result) ? new ulong?(result) : null);
		}
		return array;
	}

	public ulong? Increment(string key, ulong value)
	{
		return IncrementDecrement("incr", key, value);
	}

	public ulong? Decrement(string key, ulong value)
	{
		return IncrementDecrement("decr", key, value);
	}

	private ulong? IncrementDecrement(string cmd, string key, ulong value)
	{
		ValidateKeyOrThrow(key);
		uint hash = Hash(key);
		string command = cmd + " " + key + " " + value + "\r\n";
		return _ServerPool.Execute(hash, ExecutionType.Write, delegate(IPooledSocket socket)
		{
			socket.Write(command);
			string text = socket.ReadResponse();
			return text.StartsWith("NOT_FOUND") ? null : new ulong?(Convert.ToUInt64(text.TrimEnd('\0', '\r', '\n')));
		});
	}

	public IEnumerable<Stat> Stats()
	{
		ISocketPool[] hostList = _ServerPool.HostList;
		for (int i = 0; i < hostList.Length; i++)
		{
			SocketPool pool = (SocketPool)hostList[i];
			yield return Stats(pool);
		}
	}

	internal IReadOnlyDictionary<string, ulong> StatsSlabs()
	{
		Dictionary<string, ulong> stats = new Dictionary<string, ulong>();
		_ServerPool.Execute(_ServerPool.HostList.First(), ExecutionType.Read, delegate(IPooledSocket pooledSocket)
		{
			pooledSocket.Write("stats slabs\r\n");
			string text;
			while (!(text = pooledSocket.ReadResponse().TrimEnd('\0', '\r', '\n')).StartsWith("END"))
			{
				string[] array = text.Split(new char[1] { ' ' });
				if (array[0] == "STAT")
				{
					string key = array[1];
					ulong.TryParse(array[2], out var result);
					stats.Add(key, result);
				}
			}
		});
		return stats;
	}

	internal IReadOnlyCollection<string> StatsCacheDump(int slabId, int numberOfKeys)
	{
		if (slabId <= 0)
		{
			throw new ArgumentOutOfRangeException("slabId");
		}
		if (numberOfKeys < 0)
		{
			throw new ArgumentOutOfRangeException("numberOfKeys");
		}
		List<string> keys = new List<string>();
		_ServerPool.Execute(_ServerPool.HostList.First(), ExecutionType.Read, delegate(IPooledSocket pooledSocket)
		{
			pooledSocket.Write($"stats cachedump {slabId} {numberOfKeys}\r\n");
			string text;
			while (!(text = pooledSocket.ReadResponse().TrimEnd('\0', '\r', '\n')).StartsWith("END"))
			{
				string[] array = text.Split(new char[1] { ' ' });
				if (array[0] == "ITEM")
				{
					string item = array[1];
					keys.Add(item);
				}
			}
		});
		return keys;
	}

	private Stat Stats(ISocketPool pool)
	{
		if (pool == null)
		{
			return null;
		}
		Stat result = new Stat
		{
			Name = pool.Host
		};
		_ServerPool.Execute(pool, ExecutionType.Read, delegate(IPooledSocket pooledSocket)
		{
			pooledSocket.Write("stats\r\n");
			string text;
			while (!(text = pooledSocket.ReadResponse().TrimEnd('\0', '\r', '\n')).StartsWith("END"))
			{
				string[] array = text.Split(new char[1] { ' ' });
				if (array[1] == "version")
				{
					result.version = array[2];
				}
				else
				{
					FieldInfo field = typeof(Stat).GetField(array[1]);
					if (field != null)
					{
						field.SetValue(result, Convert.ToInt64(array[2]));
					}
				}
			}
		});
		return result;
	}

	public void Dispose()
	{
		_ServerPool?.Dispose();
		_ExceptionHandler.ExceptionOccurred -= _HandleException;
	}

	private ISocketPool[] GetSocketPoolsForHashes(uint[] hashes)
	{
		bool useRoundRobinSocketPoolSelection = _Settings.UseRoundRobinSocketPoolSelection;
		ISocketPool[] array = new ISocketPool[hashes.Length];
		if (useRoundRobinSocketPoolSelection)
		{
			ISocketPool socketPool = _ServerPool.GetSocketPool(hashes[0], useRoundRobinSocketPoolSelection);
			for (int i = 0; i < hashes.Length; i++)
			{
				array[i] = socketPool;
			}
		}
		else
		{
			for (int j = 0; j < hashes.Length; j++)
			{
				ISocketPool socketPool2 = _ServerPool.GetSocketPool(hashes[j], useRoundRobinSocketPoolSelection);
				array[j] = socketPool2;
			}
		}
		return array;
	}

	private uint Hash(string key)
	{
		ValidateKeyOrThrow(key);
		byte[] bytes = Encoding.UTF8.GetBytes(key);
		return BitConverter.ToUInt32(new ModifiedFNV1_32().ComputeHash(bytes), 0);
	}

	private uint[] Hash(string[] keys)
	{
		uint[] array = new uint[keys.Length];
		for (int i = 0; i < keys.Length; i++)
		{
			array[i] = Hash(keys[i]);
		}
		return array;
	}

	private void ValidateKeyOrThrow(string key)
	{
		if (key == null)
		{
			throw new ArgumentNullException("key");
		}
		if (key.Length == 0)
		{
			throw new ArgumentException("Key may not be empty.");
		}
		if (key.Length > 250)
		{
			throw new ArgumentException($"Key may not be longer than 250 characters. Key='{key}'");
		}
		foreach (char c in key)
		{
			if (c == ' ' || c == '\n' || c == '\r' || c == '\t' || c == '\f' || c == '\v')
			{
				throw new ArgumentException($"Key may not contain whitespace or control characters. Key='{key}'");
			}
		}
	}

	internal virtual IServerPool CreateServerPool(string[] hosts, MemcachedMonitor monitor, IMemCachedClientSettings clientSettings, IMemcachedClientExceptionHandler exceptionHandler, IEndpointResolver endpointResolver)
	{
		return new ServerPool(hosts, monitor, clientSettings, exceptionHandler, endpointResolver);
	}
}
