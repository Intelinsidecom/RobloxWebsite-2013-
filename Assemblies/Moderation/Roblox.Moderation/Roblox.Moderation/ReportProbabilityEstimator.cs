using System;
using System.Threading.Tasks;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public static class ReportProbabilityEstimator
{
	private const byte _ReportCategoryId = byte.MaxValue;

	public static double EstimateReportQualityProbability(Report report)
	{
		if (report == null)
		{
			throw new ArgumentNullException("report");
		}
		return EstimateReportQualityProbability(report.ID, report.SubmitterID, report.AllegedAbuserID);
	}

	public static double EstimateReportQualityProbability(long reportId, long submitterId, long allegedAbuserId)
	{
		if (!Settings.Default.CalculateReportProbabilities)
		{
			return 0.5;
		}
		try
		{
			string text = GetTextToEvaluate(submitterId, allegedAbuserId);
			double probability = ContentFilterWrapper.GetGoodProbability(byte.MaxValue, text);
			ReportProbability.CreateNew(reportId, probability);
			return probability;
		}
		catch (Exception ex)
		{
			ExceptionHandler.LogException(ex);
			return 0.5;
		}
	}

	public static void UpdateReportProbabilityAutoclosedStatus(Report report, bool autoClosed)
	{
		if (report == null)
		{
			throw new ArgumentNullException("report");
		}
		UpdateReportProbabilityAutoclosedStatus(report.ID, autoClosed);
	}

	public static void UpdateReportProbabilityAutoclosedStatus(long reportId, bool autoClosed)
	{
		ReportProbability reportProbability = ReportProbability.GetByReportId(reportId);
		if (reportProbability != null)
		{
			reportProbability.IsAutoClosed = autoClosed;
			reportProbability.Save();
		}
	}

	public static void ProcessReportAction(Report report, bool isReportGood)
	{
		if (report == null)
		{
			throw new ArgumentNullException("report");
		}
		ProcessReportAction(report.ID, report.SubmitterID, report.AllegedAbuserID, isReportGood);
	}

	public static void ProcessReportAction(long reportId, long submitterId, long allegedAbuserId, bool isReportGood)
	{
		if (!Settings.Default.CalculateReportProbabilities)
		{
			return;
		}
		Task.Factory.StartNew(delegate
		{
			try
			{
				ReportProbability byReportId = ReportProbability.GetByReportId(reportId);
				if (byReportId != null)
				{
					byReportId.ModeratorConcurred = isReportGood;
					byReportId.Save();
				}
				bool isBad = !isReportGood;
				string textToEvaluate = GetTextToEvaluate(submitterId, allegedAbuserId);
				ContentFilterWrapper.LearnText(byte.MaxValue, textToEvaluate, isBad);
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException(ex);
			}
		});
	}

	private static string GetTextToEvaluate(long submitterId, long allegedAbuserId)
	{
		return string.Format("S_{0} A_{1} SA_{0}_{1}", submitterId, allegedAbuserId);
	}
}
