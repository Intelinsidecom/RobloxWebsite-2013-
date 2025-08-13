using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.AbTesting.Core.Entities;
using Roblox.Platform.Core;

namespace Roblox.Platform.AbTesting.Core;

internal class Version : IVersion
{
	public int Id { get; internal set; }

	public int ExperimentId { get; internal set; }

	public byte VersionNumber { get; internal set; }

	public TimeSpan EnrollmentPeriod { get; internal set; }

	public DateTime Started { get; internal set; }

	public DateTime EndDate { get; internal set; }

	public DateTime Created { get; internal set; }

	public DateTime Updated { get; internal set; }

	public bool IsActive { get; internal set; }

	public byte PercentOfSubjectsToEnroll { get; internal set; }

	public Version()
	{
	}

	internal Version(Roblox.Platform.AbTesting.Core.Entities.Version entity)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		Id = entity.ID;
		ExperimentId = entity.ExperimentID;
		VersionNumber = entity.VersionNumber;
		EnrollmentPeriod = TimeSpan.FromHours(entity.EnrollmentPeriodInHours);
		Started = entity.Started;
		EndDate = entity.EndDate;
		Created = entity.Created;
		Updated = entity.Updated;
		IsActive = entity.IsActive;
		PercentOfSubjectsToEnroll = entity.PercentOfSubjectsToEnroll;
	}

	[ExcludeFromCodeCoverage]
	internal virtual void Save()
	{
		Roblox.Platform.AbTesting.Core.Entities.Version entity = Roblox.Platform.AbTesting.Core.Entities.Version.Get(Id) ?? new Roblox.Platform.AbTesting.Core.Entities.Version();
		entity.EnrollmentPeriodInHours = (int)Math.Ceiling(EnrollmentPeriod.TotalHours);
		entity.ExperimentID = ExperimentId;
		entity.VersionNumber = VersionNumber;
		entity.IsActive = IsActive;
		entity.Started = Started;
		entity.EndDate = EndDate;
		entity.PercentOfSubjectsToEnroll = PercentOfSubjectsToEnroll;
		entity.Save();
		Id = entity.ID;
		Created = entity.Created;
		Updated = entity.Updated;
	}

	public void Deactivate(DateTime currentTime)
	{
		if (!IsActive)
		{
			return;
		}
		if (currentTime < EndDate)
		{
			if (Started.Add(EnrollmentPeriod) > currentTime)
			{
				EnrollmentPeriod = currentTime - Started;
			}
			EndDate = currentTime;
		}
		IsActive = false;
		Save();
	}

	public bool IsRunning(DateTime currentTime)
	{
		if (IsActive && Started <= currentTime)
		{
			return EndDate > currentTime;
		}
		return false;
	}

	public bool IsEnrolling(DateTime currentTime)
	{
		if (IsActive && Started <= currentTime)
		{
			return Started.Add(EnrollmentPeriod) > currentTime;
		}
		return false;
	}

	public void SetEnrollmentEndDate(DateTime enrollmentEndDate, DateTime currentTime)
	{
		if (!IsEnrolling(currentTime) || !IsRunning(currentTime))
		{
			throw new PlatformUnmodifiableVersionException("Cannot set enrollment end date of a version that is no longer enrolling.");
		}
		if (enrollmentEndDate < Started)
		{
			throw new PlatformArgumentException("Enrollment cannot end before the version began.");
		}
		if (enrollmentEndDate > EndDate)
		{
			throw new PlatformArgumentException("Enrollment cannot end after experiment finishes running.");
		}
		if (enrollmentEndDate < currentTime)
		{
			throw new PlatformArgumentException("Enrollment end date cannot be set to before the current time.");
		}
		EnrollmentPeriod = enrollmentEndDate.Subtract(Started);
		Save();
	}

	public void SetEndDate(DateTime endDate, DateTime currentTime)
	{
		if (!IsRunning(currentTime))
		{
			throw new PlatformUnmodifiableVersionException("Cannot set run end date of a version that is no longer running.");
		}
		if (endDate < Started)
		{
			throw new PlatformArgumentException("Cannot end a version before it started.");
		}
		if (endDate < Started.Add(EnrollmentPeriod))
		{
			throw new PlatformArgumentException("Cannot end a version before it finishes enrolling.");
		}
		if (endDate < currentTime)
		{
			throw new PlatformArgumentException("Cannot set the end date of a version to before the current time");
		}
		EndDate = endDate;
		Save();
	}
}
