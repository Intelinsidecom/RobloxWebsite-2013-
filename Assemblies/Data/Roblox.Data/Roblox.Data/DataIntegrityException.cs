using System;

namespace Roblox.Data;

public class DataIntegrityException : Exception
{
	public enum Scope
	{
		Entity,
		System
	}

	public enum ThreatLevel
	{
		Low,
		Guarded,
		Elevated,
		High,
		Severe
	}

	public DataIntegrityException()
	{
	}

	public DataIntegrityException(string message)
		: base(message)
	{
	}

	public DataIntegrityException(string message, DataIntegrityException innerException)
		: base(message, innerException)
	{
	}
}
