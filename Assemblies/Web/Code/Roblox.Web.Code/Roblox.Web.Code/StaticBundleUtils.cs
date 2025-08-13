using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Hosting;
using Roblox.WebsiteSettings.Properties;

namespace Roblox.Web.Code;

public static class StaticBundleUtils
{
	private class UniqueValueList
	{
		private readonly List<string> _List = new List<string>();

		private readonly HashSet<string> _ControlSet = new HashSet<string>();

		public IEnumerable<string> Values => new ReadOnlyCollection<string>(_List);

		public void Add(string val)
		{
			if (!_ControlSet.Contains(val))
			{
				_ControlSet.Add(val);
				_List.Add(val);
			}
		}

		public void Shift(string val)
		{
			if (!_ControlSet.Contains(val))
			{
				_ControlSet.Add(val);
				_List.Insert(0, val);
			}
		}

		public void AddRange(IEnumerable<string> values)
		{
			foreach (string value in values)
			{
				Add(value);
			}
		}
	}

	public class Bundle : IEnumerable<string>, IEnumerable
	{
		private readonly string _Key;

		public Bundle(string key)
		{
			_Key = key;
		}

		public void Add(string path)
		{
			GetRequestScopedVariable<UniqueValueList>(_Key).Add(path);
		}

		public void Shift(string path)
		{
			GetRequestScopedVariable<UniqueValueList>(_Key).Shift(path);
		}

		public void PrependRange(IEnumerable<string> values)
		{
			values = values.Reverse();
			foreach (string v in values)
			{
				Shift(v);
			}
		}

		public void AddRange(IEnumerable<string> values)
		{
			if (values != null)
			{
				GetRequestScopedVariable<UniqueValueList>(_Key).AddRange(values);
			}
		}

		public IEnumerator<string> GetEnumerator()
		{
			return GetRequestScopedVariable<UniqueValueList>(_Key).Values.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}

	public static T GetRequestScopedVariable<T>(string name) where T : class, new()
	{
		IDictionary items = HttpContext.Current.Items;
		T obj = (T)items[name];
		if (obj == null)
		{
			obj = (T)(items[name] = new T());
		}
		return obj;
	}

	public static V GetOrAddSafe<T, V>(this ConcurrentDictionary<T, Lazy<V>> dictionary, T key, Func<T, V> valueFactory)
	{
		return dictionary.GetOrAdd(key, new Lazy<V>(() => valueFactory(key))).Value;
	}

	/// <summary>
	/// Quickly generate a hash for a collection of files.  Hash each file, then rehash the combined hashes. 
	/// Optionally add a salt to generate bundle in case we need to regenerate bundles without file changes.
	/// </summary>
	/// <param name="files">The files for which the contents will be hashed</param>
	/// <param name="salt">Optional salt</param>
	/// <returns></returns>
	public static string ComputeHashForFiles(IEnumerable<string> files, string salt = null)
	{
		using MemoryStream ms = new MemoryStream();
		using BinaryWriter bw = new BinaryWriter(ms);
		foreach (string filePath in files)
		{
			string absolutePath = HttpContext.Current.Server.MapPath(filePath);
			try
			{
				byte[] bytes = HashFunctions.ComputeHash(File.ReadAllBytes(absolutePath));
				bw.Write(bytes);
			}
			catch (FileNotFoundException ex)
			{
				ExceptionHandler.LogException(ex);
			}
		}
		if (!string.IsNullOrWhiteSpace(salt))
		{
			bw.Write(Encoding.ASCII.GetBytes(salt));
		}
		return HashFunctions.ComputeHashString(ms.ToArray());
	}

	public static void ConfigureFileWatcher(string folderToWatch, string extensionToWatch, string excludedFolder, Action clearCache)
	{
		FileSystemEventHandler handler = delegate(object sender, FileSystemEventArgs e)
		{
			if (!e.FullPath.Contains(excludedFolder))
			{
				clearCache();
			}
		};
		string physicalPath = HostingEnvironment.MapPath(folderToWatch);
		if (physicalPath == null)
		{
			return;
		}
		FileSystemWatcher fileSystemWatcher = null;
		try
		{
			fileSystemWatcher = new FileSystemWatcher(physicalPath, extensionToWatch)
			{
				IncludeSubdirectories = true,
				EnableRaisingEvents = Settings.Default.MonitorJavaScriptAndCssFileChanges
			};
		}
		catch (ArgumentException)
		{
		}
		if (fileSystemWatcher == null)
		{
			return;
		}
		fileSystemWatcher.Changed += handler;
		fileSystemWatcher.Created += handler;
		fileSystemWatcher.Deleted += handler;
		Settings.Default.PropertyChanged += delegate(object o, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "MonitorJavaScriptAndCssFileChanges")
			{
				fileSystemWatcher.EnableRaisingEvents = Settings.Default.MonitorJavaScriptAndCssFileChanges;
			}
		};
	}
}
