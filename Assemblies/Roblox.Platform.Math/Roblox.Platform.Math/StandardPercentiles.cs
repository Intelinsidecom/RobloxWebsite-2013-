namespace Roblox.Platform.Math;

internal class StandardPercentiles : IStandardPercentiles
{
	public double P01 { get; }

	public double P05 { get; }

	public double P10 { get; }

	public double P25 { get; }

	public double P50 { get; }

	public double P75 { get; }

	public double P95 { get; }

	public double P99 { get; }

	public StandardPercentiles(double p01, double p05, double p10, double p25, double p50, double p75, double p95, double p99)
	{
		P01 = p01;
		P05 = p05;
		P10 = p10;
		P25 = p25;
		P50 = p50;
		P75 = p75;
		P95 = p95;
		P99 = p99;
	}
}
