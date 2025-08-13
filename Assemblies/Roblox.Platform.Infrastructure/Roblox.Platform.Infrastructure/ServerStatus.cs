namespace Roblox.Platform.Infrastructure;

public enum ServerStatus
{
	Prep = 1,
	Live,
	Maintenance,
	Retired,
	Reserve,
	PaidReserve,
	IdentifiedHw,
	HwClassified,
	ProvisioningOs,
	OsProvisioned,
	ConfiguringNetwork,
	NetworkConfigured,
	HwDiagnostics,
	Prototype,
	Deallocation,
	UpdatingFirmware,
	Hibernation,
	Reanimation,
	ConfiguringBios,
	ConfiguringRaid,
	ConfiguringNics,
	ConfiguringIpmi,
	ProvisioningVm,
	Defective,
	ClassifyHardware,
	Migration
}
