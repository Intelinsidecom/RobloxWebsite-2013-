using System;
using System.IO;
using Roblox.BucketStore;
using Roblox.EventLog;
using Roblox.Properties;

namespace Roblox;

public class TempStoreManager
{
	private readonly IBucket _TempStoreOnPrime;

	private readonly IBucket _TempStoreOnChi1;

	private readonly ILogger _Logger;

	private readonly bool _ReadFromTemporaryStoreDirectoryOnChi1;

	private readonly bool _WriteToTemporaryStoreDirectoryOnChi1;

	private readonly bool _StopWritingToTemporaryStoreDirectoryOnPrime;

	public TempStoreManager(DirectoryInfo directoryInfoOnPrime, DirectoryInfo directoryInfoOnChi1, bool readFromTemporaryStoreDirectoryOnChi1, bool writeToTemporaryStoreDirectoryOnChi1, bool stopWritingToTemporaryStoreDirectoryOnPrime, ILogger logger = null)
	{
		_TempStoreOnPrime = new FileSystemBucket(directoryInfoOnPrime);
		if (Settings.Default.ReadFromTemporaryStoreDirectoryOnChi1 || Settings.Default.WriteToTemporaryStoreDirectoryOnChi1)
		{
			_TempStoreOnChi1 = new FileSystemBucket(directoryInfoOnChi1);
		}
		_ReadFromTemporaryStoreDirectoryOnChi1 = readFromTemporaryStoreDirectoryOnChi1;
		_WriteToTemporaryStoreDirectoryOnChi1 = writeToTemporaryStoreDirectoryOnChi1;
		_StopWritingToTemporaryStoreDirectoryOnPrime = stopWritingToTemporaryStoreDirectoryOnPrime;
		_Logger = logger;
	}

	internal void Delete(string temporaryStoreFileName)
	{
		if (!_StopWritingToTemporaryStoreDirectoryOnPrime)
		{
			_TempStoreOnPrime.Delete(temporaryStoreFileName);
		}
		if (_WriteToTemporaryStoreDirectoryOnChi1)
		{
			try
			{
				_TempStoreOnChi1.Delete(temporaryStoreFileName);
			}
			catch (Exception e)
			{
				_Logger?.Error($"There was an exception while deleting from temp store on chi1: {e}");
			}
		}
	}

	public void Upload(string temporaryStoreFileName, byte[] compressedData)
	{
		if (!_StopWritingToTemporaryStoreDirectoryOnPrime)
		{
			_TempStoreOnPrime.Upload(temporaryStoreFileName, compressedData);
		}
		if (_WriteToTemporaryStoreDirectoryOnChi1)
		{
			_TempStoreOnChi1.Upload(temporaryStoreFileName, compressedData);
		}
	}

	public bool Exists(string temporaryStoreFileName)
	{
		if (_ReadFromTemporaryStoreDirectoryOnChi1)
		{
			return _TempStoreOnChi1.Exists(temporaryStoreFileName);
		}
		return _TempStoreOnPrime.Exists(temporaryStoreFileName);
	}

	public string GetDownloadUrl(string v, bool secureConnection)
	{
		if (_ReadFromTemporaryStoreDirectoryOnChi1)
		{
			return _TempStoreOnChi1.GetDownloadUrl(v, secureConnection);
		}
		return _TempStoreOnPrime.GetDownloadUrl(v, secureConnection);
	}

	public string DeriveKey(string hash)
	{
		if (_ReadFromTemporaryStoreDirectoryOnChi1)
		{
			return _TempStoreOnChi1.DeriveKey(hash);
		}
		return _TempStoreOnPrime.DeriveKey(hash);
	}

	public byte[] Download(string temporaryStoreFileName)
	{
		if (_ReadFromTemporaryStoreDirectoryOnChi1)
		{
			return _TempStoreOnChi1.Download(temporaryStoreFileName);
		}
		return _TempStoreOnPrime.Download(temporaryStoreFileName);
	}

	public IBucket GetTempStoreToRead()
	{
		if (_ReadFromTemporaryStoreDirectoryOnChi1)
		{
			return _TempStoreOnChi1;
		}
		return _TempStoreOnPrime;
	}
}
