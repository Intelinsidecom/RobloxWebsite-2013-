using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Math.Numerics;

namespace Roblox.Platform.Math.Series;

internal class TimeSeries : DataSeries<DateTime, double>, ITimeSeries, IDataSeries<DateTime, double>
{
	public enum AddConflictResolution
	{
		Skip,
		Replace,
		Average,
		Maximum,
		Minimum
	}

	private int _Count;

	private double _Maximum = double.NaN;

	private double _Minimum = double.NaN;

	private double _Sum = double.NaN;

	private double _Average = double.NaN;

	private double _StandardDeviation = double.NaN;

	private bool _StatisticsAreStale;

	private DateRange _DateRange;

	private KeyValuePair<DateTime, double>? _LatestDataPoint;

	private KeyValuePair<DateTime, double>? _MaximumDataPoint;

	private KeyValuePair<DateTime, double>? _MinimumDataPoint;

	private readonly AddConflictResolution _ConflictResolution;

	private readonly Dictionary<DateTime, int> _AverageConflictCount = new Dictionary<DateTime, int>();

	public DateRange DateRange => _DateRange;

	public KeyValuePair<DateTime, double>? LatestDataPoint
	{
		get
		{
			UpdateStatistics();
			if (!_LatestDataPoint.HasValue)
			{
				return null;
			}
			KeyValuePair<DateTime, double> dp = _LatestDataPoint.Value;
			return new KeyValuePair<DateTime, double>(dp.Key, dp.Value);
		}
	}

	public KeyValuePair<DateTime, double>? MaximumDataPoint
	{
		get
		{
			UpdateStatistics();
			if (!_MaximumDataPoint.HasValue)
			{
				return null;
			}
			KeyValuePair<DateTime, double> dp = _MaximumDataPoint.Value;
			return new KeyValuePair<DateTime, double>(dp.Key, dp.Value);
		}
	}

	public KeyValuePair<DateTime, double>? MinimumDataPoint
	{
		get
		{
			UpdateStatistics();
			if (!_MinimumDataPoint.HasValue)
			{
				return null;
			}
			KeyValuePair<DateTime, double> dp = _MinimumDataPoint.Value;
			return new KeyValuePair<DateTime, double>(dp.Key, dp.Value);
		}
	}

	public int Count
	{
		get
		{
			UpdateStatistics();
			return _Count;
		}
	}

	public double Maximum
	{
		get
		{
			UpdateStatistics();
			return _Maximum;
		}
	}

	public double Minimum
	{
		get
		{
			UpdateStatistics();
			return _Minimum;
		}
	}

	public double Average
	{
		get
		{
			UpdateStatistics();
			return _Average;
		}
	}

	public double StandardDeviation
	{
		get
		{
			UpdateStatistics();
			return _StandardDeviation;
		}
	}

	public double Sum
	{
		get
		{
			UpdateStatistics();
			return _Sum;
		}
	}

	public TimeSeries(AddConflictResolution resolution = AddConflictResolution.Average)
	{
		_ConflictResolution = resolution;
	}

	public int NumberOfTimesGreaterThanThreshhold(double threshhold)
	{
		int count = 0;
		foreach (KeyValuePair<DateTime, double> dataPoint in base.DataPoints)
		{
			if (dataPoint.Value > threshhold)
			{
				count++;
			}
		}
		return count;
	}

	public int NumberOfTimesLessThanThreshhold(double threshhold)
	{
		int count = 0;
		foreach (KeyValuePair<DateTime, double> dataPoint in base.DataPoints)
		{
			if (dataPoint.Value < threshhold)
			{
				count++;
			}
		}
		return count;
	}

	public ITimeSeries ComputeFirstDerivative(TimeUnits units)
	{
		try
		{
			TimeSeries firstDerivative = new TimeSeries(AddConflictResolution.Maximum);
			double? y_i = null;
			DateTime? x_i = null;
			SortedDictionary<DateTime, double>.Enumerator points = base.DataPoints.GetEnumerator();
			while (points.MoveNext())
			{
				DateTime? x_im1 = x_i;
				double? y_im1 = y_i;
				x_i = points.Current.Key;
				y_i = points.Current.Value;
				if (x_im1.HasValue && y_im1.HasValue)
				{
					double firstDeriv = Differentiation.ComputeFirstDerivative(y_i.Value, y_im1.Value, x_i.Value, x_im1.Value, units);
					firstDerivative.AddDataPoint(x_i.Value, firstDeriv);
				}
			}
			return firstDerivative;
		}
		catch (Exception ex)
		{
			throw new MathException("Internal Exception", ex);
		}
	}

	public ITimeSeries ComputeSecondDerivative(TimeUnits units)
	{
		try
		{
			TimeSeries secondDerivative = new TimeSeries(AddConflictResolution.Maximum);
			double? y_im1 = null;
			DateTime? x_im1 = null;
			double? y_i = null;
			DateTime? x_i = null;
			SortedDictionary<DateTime, double>.Enumerator points = base.DataPoints.GetEnumerator();
			while (points.MoveNext())
			{
				DateTime? x_im2 = x_im1;
				double? y_im2 = y_im1;
				x_im1 = x_i;
				y_im1 = y_i;
				x_i = points.Current.Key;
				y_i = points.Current.Value;
				if (x_im1.HasValue && y_im1.HasValue && x_im2.HasValue && y_im2.HasValue)
				{
					double secondDeriv = Differentiation.ComputeSecondDerivative(y_i.Value, y_im1.Value, y_im2.Value, x_i.Value, x_im1.Value, x_im2.Value, units);
					secondDerivative.AddDataPoint(x_i.Value, secondDeriv);
				}
			}
			return secondDerivative;
		}
		catch (Exception ex)
		{
			throw new MathException("Internal Exception", ex);
		}
	}

	/// <summary>
	/// timeseries of absolute increases in percent, or 0 if no increase
	/// </summary>
	public ITimeSeries ComputeRelativeIncreaseInPercent()
	{
		return ComputeRelativeChangeInPercent((double v) => (!(v > 0.0)) ? 0.0 : System.Math.Abs(v));
	}

	/// <summary>
	/// timeseries of absolute decreases in percent, or 0 if no decrease
	/// </summary>
	public ITimeSeries ComputeRelativeDecreaseInPercent()
	{
		return ComputeRelativeChangeInPercent((double v) => (!(v < 0.0)) ? 0.0 : System.Math.Abs(v));
	}

	/// <summary>
	/// returns change in percent for each datapoint relative to the previous data point
	/// </summary>
	/// <param name="postEvaluator">final adjustments to the computed value. 0=&gt;0 is considered no change.</param>
	public ITimeSeries ComputeRelativeChangeInPercent(Func<double, double> postEvaluator)
	{
		try
		{
			TimeSeries relativeChangeInPercent = new TimeSeries(AddConflictResolution.Maximum);
			using (SortedDictionary<DateTime, double>.Enumerator points = base.DataPoints.GetEnumerator())
			{
				points.MoveNext();
				KeyValuePair<DateTime, double> previous = points.Current;
				while (points.MoveNext())
				{
					KeyValuePair<DateTime, double> current = points.Current;
					if (previous.Value == 0.0)
					{
						if (current.Value > 0.0)
						{
							relativeChangeInPercent.AddDataPoint(current.Key, postEvaluator(double.MaxValue));
						}
						else if (current.Value < 0.0)
						{
							relativeChangeInPercent.AddDataPoint(current.Key, postEvaluator(double.MinValue));
						}
						else
						{
							relativeChangeInPercent.AddDataPoint(current.Key, 0.0);
						}
						previous = current;
						continue;
					}
					double changeInPercent = (current.Value - previous.Value) / System.Math.Abs(previous.Value) * 100.0;
					if (double.IsPositiveInfinity(changeInPercent))
					{
						changeInPercent = double.MaxValue;
					}
					else if (double.IsNegativeInfinity(changeInPercent))
					{
						changeInPercent = double.MinValue;
					}
					relativeChangeInPercent.AddDataPoint(current.Key, postEvaluator(changeInPercent));
					previous = current;
				}
			}
			return relativeChangeInPercent;
		}
		catch (Exception ex)
		{
			throw new MathException("Internal Exception", ex);
		}
	}

	public double? InterpolateValueAt(DateTime timestamp)
	{
		try
		{
			SortedDictionary<DateTime, double> dataPoints = base.DataPoints;
			if (timestamp < dataPoints.First().Key)
			{
				return null;
			}
			if (timestamp > dataPoints.Last().Key)
			{
				return null;
			}
			if (timestamp == dataPoints.First().Key)
			{
				return dataPoints.First().Value;
			}
			if (timestamp == dataPoints.Last().Key)
			{
				return dataPoints.Last().Value;
			}
			DateTime? x_im1 = null;
			DateTime? x_i = null;
			double? y_im1 = null;
			double? y_i = null;
			SortedDictionary<DateTime, double>.Enumerator points = dataPoints.GetEnumerator();
			while (points.MoveNext())
			{
				x_im1 = x_i;
				y_im1 = y_i;
				x_i = points.Current.Key;
				y_i = points.Current.Value;
				if (x_i >= timestamp)
				{
					return Interpolation.LinearlyInterpolate(y_i, y_im1, x_i, x_im1, timestamp);
				}
			}
			return null;
		}
		catch (Exception ex)
		{
			throw new MathException("Internal Exception", ex);
		}
	}

	public ITimeSeries InterpolateOntoGrid(ICollection<DateTime> grid)
	{
		try
		{
			SortedDictionary<DateTime, double> dataPoints = base.DataPoints;
			TimeSeries interpolatedSeries = new TimeSeries(_ConflictResolution);
			if (grid == null || grid.Count == 0 || dataPoints.Count < 2)
			{
				return interpolatedSeries;
			}
			List<DateTime> sortedGrid = new List<DateTime>(grid);
			sortedGrid.Sort();
			List<DateTime> sortedKeys = new List<DateTime>(dataPoints.Keys);
			sortedKeys.Sort();
			int iStart = 1;
			for (int j = 0; j < sortedGrid.Count; j++)
			{
				DateTime gridPoint = sortedGrid[j];
				for (int i = iStart; i < sortedKeys.Count; i++)
				{
					DateTime x_im1 = sortedKeys[i - 1];
					double y_im1 = dataPoints[x_im1];
					DateTime x_i = sortedKeys[i];
					double y_i = dataPoints[x_i];
					if (gridPoint.CompareTo(x_im1) > 0 && gridPoint.CompareTo(x_i) <= 0)
					{
						double? y_interpolated = Interpolation.LinearlyInterpolate(y_i, y_im1, x_i, x_im1, gridPoint);
						if (y_interpolated.HasValue)
						{
							interpolatedSeries.AddDataPoint(gridPoint, y_interpolated.Value);
							iStart = ((i == 1) ? 1 : (i - 1));
							break;
						}
					}
				}
			}
			return interpolatedSeries;
		}
		catch (Exception ex)
		{
			throw new MathException("Internal Exception", ex);
		}
	}

	public ITimeSeries MultiplyBy(double constant)
	{
		SortedDictionary<DateTime, double> dataPoints = base.DataPoints;
		TimeSeries returnedSeries = new TimeSeries(AddConflictResolution.Replace);
		foreach (DateTime key in dataPoints.Keys)
		{
			returnedSeries.AddDataPoint(key, constant * dataPoints[key]);
		}
		return returnedSeries;
	}

	public ITimeSeries MultiplyBy(ITimeSeries otherSeries)
	{
		return PerformMathOn(otherSeries, MathOperation.Multiply);
	}

	public ITimeSeries DivideBy(ITimeSeries otherSeries)
	{
		return PerformMathOn(otherSeries, MathOperation.Divide);
	}

	public ITimeSeries AddTo(ITimeSeries otherSeries)
	{
		return PerformMathOn(otherSeries, MathOperation.Add);
	}

	public ITimeSeries Subtract(ITimeSeries otherSeries)
	{
		return PerformMathOn(otherSeries, MathOperation.Subtract);
	}

	public ITimeSeries ComputeForwardRollingAverage(int intervalToAverage)
	{
		TimeSeries rollingAverage = new TimeSeries(_ConflictResolution);
		if (intervalToAverage > 0)
		{
			SortedDictionary<DateTime, double> dataPoints = base.DataPoints;
			List<DateTime> sortedKeys = new List<DateTime>(dataPoints.Keys);
			sortedKeys.Sort();
			int i = 0;
			int count = sortedKeys.Count;
			double inverseDivisor = 1.0 / (double)intervalToAverage;
			for (; i + intervalToAverage - 1 < count; i++)
			{
				double ithRollingAverage = 0.0;
				for (int j = 0; j < intervalToAverage; j++)
				{
					ithRollingAverage += dataPoints[sortedKeys[i + j]];
				}
				rollingAverage.AddDataPoint(sortedKeys[i], ithRollingAverage * inverseDivisor);
			}
		}
		return rollingAverage;
	}

	protected override double PreProcessValueToAdd(DateTime key, double val, bool keyExists, double oldVal)
	{
		double? newVal;
		if (keyExists)
		{
			switch (_ConflictResolution)
			{
			case AddConflictResolution.Average:
			{
				if (!_AverageConflictCount.ContainsKey(key))
				{
					_AverageConflictCount.Add(key, 1);
				}
				int currentCount = _AverageConflictCount[key];
				_AverageConflictCount[key] = currentCount + 1;
				newVal = (oldVal * (double)currentCount + val) / (double)(currentCount + 1);
				break;
			}
			case AddConflictResolution.Maximum:
				newVal = ((oldVal > val) ? oldVal : val);
				break;
			case AddConflictResolution.Minimum:
				newVal = ((oldVal < val) ? oldVal : val);
				break;
			case AddConflictResolution.Skip:
				newVal = oldVal;
				break;
			default:
				newVal = val;
				break;
			}
		}
		else
		{
			newVal = val;
		}
		return newVal.Value;
	}

	protected override void PostProcessAddedDataPoint(DateTime key, double val)
	{
		_StatisticsAreStale = true;
		if (_DateRange == null)
		{
			_DateRange = new DateRange(key, key);
		}
		else
		{
			_DateRange.Update(key);
		}
	}

	internal ITimeSeries PerformMathOn(ITimeSeries otherSeries, MathOperation operation)
	{
		if (otherSeries == null)
		{
			return null;
		}
		SortedDictionary<DateTime, double> dataPoints = base.DataPoints;
		SortedDictionary<DateTime, double> interpolatedOtherSeries = otherSeries.InterpolateOntoGrid(dataPoints.Keys).DataPoints;
		TimeSeries returnedSeries = new TimeSeries(AddConflictResolution.Replace);
		foreach (DateTime key in dataPoints.Keys)
		{
			if (!interpolatedOtherSeries.ContainsKey(key))
			{
				continue;
			}
			double thisValue = dataPoints[key];
			double otherValue = interpolatedOtherSeries[key];
			switch (operation)
			{
			case MathOperation.Add:
				returnedSeries.AddDataPoint(key, thisValue + otherValue);
				break;
			case MathOperation.Subtract:
				returnedSeries.AddDataPoint(key, thisValue - otherValue);
				break;
			case MathOperation.Multiply:
				returnedSeries.AddDataPoint(key, thisValue * otherValue);
				break;
			case MathOperation.Divide:
				if (0.0 != otherValue)
				{
					returnedSeries.AddDataPoint(key, thisValue / otherValue);
				}
				break;
			}
		}
		return returnedSeries;
	}

	private void UpdateStatistics()
	{
		if (_StatisticsAreStale)
		{
			LockAndOperateOnDataPoints(DoUpdateStatistics);
		}
	}

	private void DoUpdateStatistics(SortedDictionary<DateTime, double> dataPoints)
	{
		if (!_StatisticsAreStale)
		{
			return;
		}
		int count = 0;
		double max = double.MinValue;
		double min = double.MaxValue;
		double sum = 0.0;
		double avg = 0.0;
		double std = 0.0;
		KeyValuePair<DateTime, double>? latestPoint = null;
		KeyValuePair<DateTime, double>? maximumPoint = null;
		KeyValuePair<DateTime, double>? minimumPoint = null;
		foreach (KeyValuePair<DateTime, double> pair in dataPoints)
		{
			count++;
			sum += pair.Value;
			if (pair.Value > max)
			{
				maximumPoint = new KeyValuePair<DateTime, double>(pair.Key, pair.Value);
				max = pair.Value;
			}
			if (pair.Value < min)
			{
				minimumPoint = new KeyValuePair<DateTime, double>(pair.Key, pair.Value);
				min = pair.Value;
			}
			if (!latestPoint.HasValue || pair.Key > latestPoint.Value.Key)
			{
				latestPoint = new KeyValuePair<DateTime, double>(pair.Key, pair.Value);
			}
		}
		avg = ((count > 0) ? (sum / (double)count) : 0.0);
		foreach (KeyValuePair<DateTime, double> dataPoint in dataPoints)
		{
			std += System.Math.Pow(dataPoint.Value - avg, 2.0);
		}
		std = ((count > 2) ? System.Math.Sqrt(std / (double)(count - 1)) : 0.0);
		_Count = count;
		if (_Count == 0)
		{
			_Maximum = double.NaN;
			_Minimum = double.NaN;
			_Sum = double.NaN;
			_Average = double.NaN;
			_StandardDeviation = double.NaN;
		}
		else
		{
			_Maximum = max;
			_Minimum = min;
			_Sum = sum;
			_Average = avg;
			_StandardDeviation = std;
		}
		_LatestDataPoint = latestPoint;
		_MaximumDataPoint = maximumPoint;
		_MinimumDataPoint = minimumPoint;
		_StatisticsAreStale = false;
	}
}
