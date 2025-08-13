using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BeIT.MemCached;

internal class PooledSocket : IPooledSocket, IDisposable
{
	private readonly Socket _Socket;

	private readonly Stream _Stream;

	private readonly MemcachedMonitor _MemcachedMonitor;

	private readonly IMemCachedClientSettings _Settings;

	private readonly IMemcachedClientExceptionHandler _ExceptionHandler;

	private readonly IPEndPoint _EndPoint;

	private volatile bool _Disposed;

	public string RemoteEndPoint { get; }

	public DateTime Created { get; }

	public bool IsAlive
	{
		get
		{
			if (_Socket != null && _Socket.Connected)
			{
				return _Stream.CanRead;
			}
			return false;
		}
	}

	public event EventHandler Disposed;

	public PooledSocket(MemcachedMonitor monitor, IPEndPoint endPoint, IMemCachedClientSettings settings, IMemcachedClientExceptionHandler exceptionHandler)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		_MemcachedMonitor = monitor ?? throw new ArgumentNullException("monitor");
		_EndPoint = endPoint ?? throw new ArgumentNullException("endPoint");
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_ExceptionHandler = exceptionHandler ?? throw new ArgumentNullException("exceptionHandler");
		Created = DateTime.UtcNow;
		_Socket = new Socket(endPoint.AddressFamily, (SocketType)1, (ProtocolType)6);
		int num = (int)settings.SendReceiveTimeout.TotalMilliseconds;
		_Socket.SetSocketOption((SocketOptionLevel)65535, (SocketOptionName)4101, num);
		_Socket.SetSocketOption((SocketOptionLevel)65535, (SocketOptionName)4102, num);
		_Socket.ReceiveTimeout = num;
		_Socket.SendTimeout = num;
		RemoteEndPoint = endPoint.ToString();
		_Socket.NoDelay = true;
		Connect(_Settings.PooledSocketConstructionSocketConnectTimeout);
		_Stream = new BufferedStream((Stream)new NetworkStream(_Socket, false));
	}

	private void Connect(TimeSpan connectTimeout)
	{
		if (connectTimeout <= TimeSpan.Zero)
		{
			throw new ArgumentOutOfRangeException("connectTimeout");
		}
		IAsyncResult asyncResult = _Socket.BeginConnect((EndPoint)_EndPoint, (AsyncCallback)null, (object)null);
		asyncResult.AsyncWaitHandle.WaitOne((int)connectTimeout.TotalMilliseconds);
		if (!_Socket.Connected)
		{
			_Socket.Close();
			throw new TimeoutException($"Failed to connect to {_EndPoint} after {connectTimeout}.");
		}
		_Socket.EndConnect(asyncResult);
	}

	public void Write(string str)
	{
		Write(Encoding.UTF8.GetBytes(str));
	}

	public void Write(byte[] bytes)
	{
		if (bytes == null)
		{
			throw new ArgumentNullException("bytes");
		}
		_Stream.Write(bytes, 0, bytes.Length);
		_Stream.Flush();
	}

	public string ReadLine()
	{
		MemoryStream memoryStream = new MemoryStream();
		bool flag = false;
		int num;
		while ((num = _Stream.ReadByte()) != -1)
		{
			if (flag)
			{
				if (num == 10)
				{
					break;
				}
				memoryStream.WriteByte(13);
				flag = false;
			}
			if (num == 13)
			{
				flag = true;
			}
			else
			{
				memoryStream.WriteByte((byte)num);
			}
		}
		byte[] buffer = memoryStream.GetBuffer();
		return Encoding.UTF8.GetString(buffer);
	}

	public string ReadResponse()
	{
		string text = ReadLine();
		if (string.IsNullOrEmpty(text))
		{
			throw new MemcachedClientException(RemoteEndPoint, "Received empty response.");
		}
		if (text.StartsWith("ERROR") || text.StartsWith("CLIENT_ERROR") || text.StartsWith("SERVER_ERROR"))
		{
			throw new MemcachedClientException(RemoteEndPoint, $"Server returned {text}");
		}
		return text;
	}

	public void Read(byte[] bytes)
	{
		if (bytes == null)
		{
			return;
		}
		int num;
		for (int i = 0; i < bytes.Length; i += num)
		{
			num = _Stream.Read(bytes, i, bytes.Length - i);
			if (num == 0)
			{
				break;
			}
		}
	}

	public void SkipUntilEndOfLine()
	{
		bool flag = false;
		int num;
		while ((num = _Stream.ReadByte()) != -1)
		{
			if (flag)
			{
				if (num == 10)
				{
					break;
				}
				flag = false;
			}
			if (num == 13)
			{
				flag = true;
			}
		}
	}

	public bool Reset(bool forceReset)
	{
		if (_Socket.Available > 0)
		{
			_MemcachedMonitor.PooledSocketReadLeftoverBytesReadAttemptsPerSecond.Increment();
			byte[] bytes = new byte[_Socket.Available];
			Read(bytes);
			return true;
		}
		if (forceReset)
		{
			int num = 0;
			try
			{
				int num2 = Math.Max(1, _Settings.ForceResetBytesMaxAttempts);
				int forceResetBytesMaxNumberOfBytes = _Settings.ForceResetBytesMaxNumberOfBytes;
				for (int i = 0; i < num2; i++)
				{
					byte[] array = new byte[forceResetBytesMaxNumberOfBytes];
					int num3 = _Stream.Read(array, 0, array.Length);
					num += num3;
					if (num3 < array.Length)
					{
						break;
					}
				}
			}
			catch (Exception)
			{
				_MemcachedMonitor.PooledSocketForceResetExceptionsPerSecond.Increment();
			}
			if (num > 0)
			{
				_MemcachedMonitor.PooledSocketForceResetAnyBytesReturnedPerSecond.Increment();
				return true;
			}
			_MemcachedMonitor.PooledSocketForceResetNoBytesReturnedPerSecond.Increment();
			return false;
		}
		return false;
	}

	public void Dispose()
	{
		if (!_Disposed)
		{
			_Disposed = true;
			this.Disposed?.Invoke(this, null);
			_MemcachedMonitor.PooledSocketDisposedPerSecond.Increment();
		}
		try
		{
			_Stream?.Dispose();
			Socket socket = _Socket;
			if (socket != null)
			{
				socket.Close();
			}
		}
		catch (Exception innerException)
		{
			_ExceptionHandler?.HandleException(new MemcachedClientException(RemoteEndPoint, string.Format("Failed to dispose {0}", "PooledSocket"), innerException));
		}
	}
}
