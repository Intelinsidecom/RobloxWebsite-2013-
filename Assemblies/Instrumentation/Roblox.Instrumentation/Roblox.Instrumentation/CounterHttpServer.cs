using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Roblox.Instrumentation;

public sealed class CounterHttpServer
{
	private const int _MaxPortNumber = 49151;

	private const int _MinPortNumber = 0;

	private readonly ICounterRegistry _CounterRegistry;

	private readonly int _PortNumber;

	private readonly Action<Exception> _ExceptionHandler;

	private HttpListener _HttpListener;

	private bool _IsRunning;

	public CounterHttpServer(ICounterRegistry counterRegistry, int portNumber, Action<Exception> exceptionHandler)
	{
		if (portNumber < 0 || portNumber > 49151)
		{
			throw new ArgumentOutOfRangeException("portNumber", $"Invalid value port portNumber: {portNumber}.  Must be between {0} and {49151} inclusive.");
		}
		_PortNumber = portNumber;
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_ExceptionHandler = exceptionHandler ?? throw new ArgumentNullException("exceptionHandler");
	}

	public void Start()
	{
		_IsRunning = true;
		Task.Run(delegate
		{
			_HttpListener = new HttpListener();
			_HttpListener.Prefixes.Add($"http://*:{_PortNumber}/");
			_HttpListener.Start();
			while (_IsRunning)
			{
				try
				{
					HttpListenerContext context = _HttpListener.GetContext();
					Task.Run(delegate
					{
						HandleRequest(context);
					});
				}
				catch (Exception obj)
				{
					_ExceptionHandler(obj);
				}
			}
		});
	}

	public void Stop()
	{
		_IsRunning = false;
		_HttpListener?.Close();
		_HttpListener = null;
	}

	private void HandleRequest(HttpListenerContext context)
	{
		try
		{
			KeyValuePair<CounterKey, double>[] array = (from c in _CounterRegistry.GetCounterValues()
				orderby c.Key.Category, c.Key.Name, c.Key.Instance
				select c).ToArray();
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<table border=\"1\" cellpadding=\"3\" cellspacing=\"0\">");
			stringBuilder.AppendLine("<tr><th>Category</th><th>Name</th><th>Instance</th><th>Value</th></tr>");
			foreach (KeyValuePair<CounterKey, double> item in (IEnumerable<KeyValuePair<CounterKey, double>>)array)
			{
				CounterKey key = item.Key;
				double value = item.Value;
				string text = WebUtility.HtmlEncode(key.Category);
				string text2 = WebUtility.HtmlEncode(key.Name);
				string text3 = WebUtility.HtmlEncode(key.Instance);
				stringBuilder.AppendLine($"<tr><td>{text}</td><td>{text2}</td><td>{text3}</td><td>{value}</td></tr>");
			}
			stringBuilder.AppendLine("</table>");
			byte[] bytes = Encoding.UTF8.GetBytes(stringBuilder.ToString());
			context.Response.StatusCode = 200;
			context.Response.ContentType = "text/html";
			context.Response.OutputStream.Write(bytes, 0, bytes.Length);
			context.Response.OutputStream.Close();
		}
		catch (Exception obj)
		{
			_ExceptionHandler(obj);
		}
	}
}
