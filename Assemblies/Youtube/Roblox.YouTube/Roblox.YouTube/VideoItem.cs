using System;
using System.Text.RegularExpressions;

namespace Roblox.YouTube;

internal class VideoItem
{
	private readonly Regex _HoursMatch = new Regex("(\\d+)h", RegexOptions.IgnoreCase);

	private readonly Regex _MinutesMatch = new Regex("(\\d+)m", RegexOptions.IgnoreCase);

	private readonly Regex _SecondsMatch = new Regex("(\\d+)s", RegexOptions.IgnoreCase);

	public string Id { get; set; }

	public Snippet Snippet { get; set; }

	public ContentDetails ContentDetails { get; set; }

	public Status Status { get; set; }

	public bool SupportsEmbedding => Status.Embeddable;

	public int TotalSeconds => (int)ParseDuration(ContentDetails.Duration).TotalSeconds;

	public string Title => Snippet.Title;

	public string Description => Snippet.Description;

	/// <summary>
	/// Parses a <see cref="T:System.TimeSpan" /> from a YouTube duration value.
	/// </summary>
	/// <remarks>
	/// "duration": "P3W3DT20H31M21S"
	/// 3 weeks, 3 days, 20 hours, 31 minutes, 21 seconds
	/// Source: https://www.youtube.com/watch?v=04cF1m6Jxu8
	/// Timestamp pieces will be left out as they do not apply (e.g. seconds will not be included if it the video duration is exactly on a whole minute)
	///
	/// Right now this method does not support durations of a day or more, if we ever need to we can add this support.
	/// </remarks>
	/// <param name="duration">The YouTube duration string.</param>
	/// <returns>The <see cref="T:System.TimeSpan" /> (will be <see cref="F:System.TimeSpan.MinValue" /> if duration cannot be parsed.)</returns>
	internal TimeSpan ParseDuration(string duration)
	{
		Match hours = _HoursMatch.Match(duration);
		Match minutes = _MinutesMatch.Match(duration);
		Match seconds = _SecondsMatch.Match(duration);
		return new TimeSpan(hours.Success ? int.Parse(hours.Groups[1].ToString()) : 0, minutes.Success ? int.Parse(minutes.Groups[1].ToString()) : 0, seconds.Success ? int.Parse(seconds.Groups[1].ToString()) : 0);
	}
}
