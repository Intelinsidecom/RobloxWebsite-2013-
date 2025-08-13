using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;
using Roblox.DataAccess;
using Roblox.Properties;

namespace Roblox;

public class Script : IEquatable<Script>, IRobloxEntity<int, ScriptDAL>, ICacheableObject<int>, ICacheableObject
{
	public static class Rating
	{
		public const float Infected = 0f;

		public const float InheritFromAuthor = 0.5f;

		public const float Safe = 1f;
	}

	public class ScriptDisplayInfo
	{
		public string Hash;

		public string Name;

		public string Text;

		public Script Script => Get(Hash);

		public override bool Equals(object obj)
		{
			ScriptDisplayInfo s = (ScriptDisplayInfo)obj;
			if (s == null)
			{
				return false;
			}
			return s.Hash == Hash;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}

	private ScriptDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Script", isNullCacheable: true);

	public static bool ScriptAuthorsAreTentative => Settings.Default.ScriptAuthorsAreTentative;

	public int ID => _EntityDAL.ID;

	public string Hash
	{
		get
		{
			return _EntityDAL.Hash;
		}
		private set
		{
			_EntityDAL.Hash = value;
		}
	}

	public long AuthorAgentID
	{
		get
		{
			return _EntityDAL.AuthorAgentID;
		}
		set
		{
			_EntityDAL.AuthorAgentID = value;
		}
	}

	public int FailureCount
	{
		get
		{
			return _EntityDAL.FailureCount;
		}
		set
		{
			_EntityDAL.FailureCount = value;
		}
	}

	public int SuccessCount
	{
		get
		{
			return _EntityDAL.SuccessCount;
		}
		set
		{
			_EntityDAL.SuccessCount = value;
		}
	}

	public int? LineNumber
	{
		get
		{
			return _EntityDAL.LineNumber;
		}
		set
		{
			_EntityDAL.LineNumber = value;
		}
	}

	public int? ScriptErrorID
	{
		get
		{
			return _EntityDAL.ScriptErrorID;
		}
		set
		{
			_EntityDAL.ScriptErrorID = value;
		}
	}

	public string CallStackHash
	{
		get
		{
			return _EntityDAL.CallStackHash;
		}
		set
		{
			_EntityDAL.CallStackHash = value;
		}
	}

	public bool IsTentativeAuthor
	{
		get
		{
			return _EntityDAL.IsTentativeAuthor;
		}
		set
		{
			_EntityDAL.IsTentativeAuthor = value;
		}
	}

	/// Member Getters *
	public float Safety
	{
		get
		{
			if (_EntityDAL.Safety == 1f)
			{
				return 1f;
			}
			if (_EntityDAL.Safety == 0f)
			{
				return 0f;
			}
			return 0.5f;
		}
	}

	public bool IsInfected => Safety == 0f;

	public bool IsSafe => Safety == 1f;

	public bool InheritsFromAuthorsRating => Safety == 0.5f;

	public DateTime Created => _EntityDAL.Created;

	public DateTime Updated => _EntityDAL.Updated;

	public CacheInfo CacheInfo => EntityCacheInfo;

	public Script()
	{
		_EntityDAL = new ScriptDAL();
	}

	public static Script Get(int id)
	{
		return EntityHelper.GetEntity<int, ScriptDAL, Script>(EntityCacheInfo, id, () => ScriptDAL.Get(id));
	}

	public static Script Get(string Hash)
	{
		return EntityHelper.GetEntityByLookup<int, ScriptDAL, Script>(EntityCacheInfo, $"Hash:{Hash}", () => ScriptDAL.Get(Hash));
	}

	private static Script DoGetOrCreate(string hash, long authorAgentId, float safety, int failureCount, int successCount, int? lineNumber, int? scriptErrorId, string callStackHash)
	{
		return EntityHelper.DoGetOrCreate<int, ScriptDAL, Script>(() => ScriptDAL.GetOrCreate(hash, authorAgentId, safety, failureCount, successCount, lineNumber, scriptErrorId, callStackHash, ScriptAuthorsAreTentative));
	}

	public static Script GetOrCreate(string hash, long authorAgentId, float safety, int failureCount, int successCount, int? lineNumber, int? scriptErrorId, string callStackHash)
	{
		return EntityHelper.GetOrCreateEntity<int, Script>(EntityCacheInfo, $"Hash:{hash}", () => DoGetOrCreate(hash, authorAgentId, safety, failureCount, successCount, lineNumber, scriptErrorId, callStackHash));
	}

	public static Script GetOrCreate(string hash, long authorAgentId)
	{
		return GetOrCreate(hash, authorAgentId, 0.5f, 0, 0, null, null, null);
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public void Report(int numberOfInstancesInAsset)
	{
		ReportedScript.CreateNew(ID, numberOfInstancesInAsset);
	}

	public void SetSafety(float safetyLevel)
	{
		_EntityDAL.Safety = safetyLevel;
	}

	public ScriptDisplayInfo GetScriptDisplayInfo()
	{
		Script script = Get(ID);
		AssetHash hash = AssetHash.Get(AssetHashScript.GetAssetHashScriptsByScriptIDPaged(script.ID, 0, 1).First().AssetHashID);
		return ExtractScripts(FilesManager.Singleton.GetStream(hash.Hash), keepDuplicates: false, decompress: false, null).First((ScriptDisplayInfo a) => a.Hash == script.Hash);
	}

	public static Script CreateNew(string hash, long authorAgentId, int failureCount, int successCount, int? lineNumber, int? scriptErrorId, string callStackHash, float safety)
	{
		Script script = new Script();
		script.Hash = hash;
		script.AuthorAgentID = authorAgentId;
		script.SetSafety(safety);
		script.FailureCount = failureCount;
		script.SuccessCount = successCount;
		script.LineNumber = lineNumber;
		script.ScriptErrorID = scriptErrorId;
		script.CallStackHash = callStackHash;
		script.IsTentativeAuthor = ScriptAuthorsAreTentative;
		script.Save();
		return script;
	}

	public static List<ScriptDisplayInfo> ExtractScripts(Stream stream, bool keepDuplicates, bool decompress, DecompressionMethods? decompressMethod)
	{
		string memoryStreamString;
		if (decompress)
		{
			using Stream newStream = new MemoryStream();
			StreamUtilities.Uncompress(stream, decompressMethod.Value, newStream);
			using StreamReader streamReader2 = new StreamReader(stream);
			memoryStreamString = streamReader2.ReadToEnd();
		}
		else
		{
			using StreamReader streamReader = new StreamReader(stream);
			memoryStreamString = streamReader.ReadToEnd();
		}
		return ExtractScripts(memoryStreamString, keepDuplicates);
	}

	public static List<ScriptDisplayInfo> ExtractScripts(string memoryString, bool keepDuplicates)
	{
		List<ScriptDisplayInfo> scripts = new List<ScriptDisplayInfo>();
		using StringReader str = new StringReader(memoryString);
		using XmlTextReader xmlReader = new XmlTextReader(str);
		xmlReader.Normalization = false;
		while (xmlReader.ReadToFollowing("Item"))
		{
			string classString = xmlReader.GetAttribute("class");
			if (string.IsNullOrEmpty(classString) || (!(classString == "Script") && !(classString == "LocalScript")))
			{
				continue;
			}
			xmlReader.ReadToDescendant("Properties");
			xmlReader.ReadToDescendant("Content");
			string content = "";
			if (xmlReader.GetAttribute("name") == "LinkedSource")
			{
				content = xmlReader.ReadElementString();
			}
			if (!string.IsNullOrEmpty(content))
			{
				continue;
			}
			xmlReader.ReadToNextSibling("string");
			string sname = "";
			if (xmlReader.GetAttribute("name") == "Name")
			{
				sname = xmlReader.ReadElementString();
			}
			string stext = "";
			if (xmlReader.Read() && xmlReader.GetAttribute("name") == "Source")
			{
				stext = xmlReader.ReadElementString();
			}
			if (!string.IsNullOrEmpty(stext))
			{
				byte[] byteArray = new byte[stext.Length];
				for (int i = 0; i < stext.Length; i++)
				{
					byteArray[i] = (byte)stext[i];
				}
				string md5hash = HashFunctions.ComputeHashString(byteArray);
				ScriptDisplayInfo currentScriptDisplayinfo = new ScriptDisplayInfo();
				currentScriptDisplayinfo.Text = stext.Replace("\n", "\\n").Replace("&#009", "\t");
				currentScriptDisplayinfo.Name = sname;
				currentScriptDisplayinfo.Hash = md5hash;
				if (keepDuplicates || !scripts.Contains(currentScriptDisplayinfo))
				{
					scripts.Add(currentScriptDisplayinfo);
				}
			}
		}
		return scripts;
	}

	/// <summary>
	/// Extracts all the scripts found in a model/place and creates the appropriate objects:
	///     Script
	///     AssetScriptHash
	///     ScriptReport (if requested to do so)
	/// </summary>
	public static void ProcessScripts(IAsset modelOrPlace, bool report)
	{
		if (modelOrPlace.Type.ID != AssetType.ModelID && modelOrPlace.Type.ID != AssetType.PlaceID)
		{
			throw new ArgumentException("Can only parse models and places");
		}
		string xmlString;
		using (MemoryStream stream = FilesManager.Singleton.GetStream(modelOrPlace.Hash))
		{
			xmlString = Encoding.UTF8.GetString(stream.ToArray());
		}
		ProcessScripts(xmlString, modelOrPlace.AssetHashID, report, modelOrPlace.CreatorRefObject.AgentID);
	}

	/// <summary>
	/// Extracts all the scripts found in a model/place and creates the appropriate objects:
	///     Script
	///     AssetScriptHash
	///     ScriptReport (if requested to do so)
	/// </summary>
	public static void ProcessScripts(string xmlData, long assetHashId, bool report, long userAgentId)
	{
		List<ScriptDisplayInfo> scripts = ExtractScripts(xmlData, report);
		List<ScriptDisplayInfo> uniqueScripts = new List<ScriptDisplayInfo>();
		foreach (ScriptDisplayInfo script in scripts)
		{
			if (report)
			{
				if (uniqueScripts.Contains(script))
				{
					continue;
				}
				uniqueScripts.Add(script);
			}
			Script s = GetOrCreate(script.Hash, userAgentId);
			if (report && s.Safety != 1f && s.Safety != 0f)
			{
				string hash = script.Hash;
				int scriptCount = scripts.Count((ScriptDisplayInfo x) => x.Hash == hash);
				s.Report(scriptCount);
			}
			AssetHashScript.GetOrCreate(s.ID, assetHashId);
		}
	}

	public static ICollection<Script> GetTopReportedScripts(int maximumRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), $"GetTopReportedScripts_MaximumRows:{maximumRows}", () => ScriptDAL.GetTopReportedScriptIDs(maximumRows), Get);
	}

	public static ICollection<Script> GetTopInstancesReportedScripts(int maximumRows)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Unqualified, null), $"GetTopInstancesReportedScripts_MaximumRows:{maximumRows}", () => ScriptDAL.GetTopInstancesReportedScriptIDs(maximumRows), Get);
	}

	public static IEnumerable<string> GetInterestingScriptHashes()
	{
		return ScriptDAL.GetInterestingScriptHashes();
	}

	public static ICollection<Script> GetScriptsByAuthorAgentID(long authorAgentId)
	{
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"AuthorAgentID:{authorAgentId}"), $"GetScriptsByAuthorAgentID_AuthorAgentID:{authorAgentId}", () => ScriptDAL.GetScriptIDsByAuthorAgentID(authorAgentId), Get);
	}

	public bool Equals(Script other)
	{
		if (other == null)
		{
			return false;
		}
		return ID == other.ID;
	}

	public void Construct(ScriptDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null)
		{
			yield return $"Hash:{Hash}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		yield return new StateToken($"AuthorAgentID:{AuthorAgentID}");
	}
}
