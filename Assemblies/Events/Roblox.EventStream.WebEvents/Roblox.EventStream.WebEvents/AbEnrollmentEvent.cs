namespace Roblox.Platform.EventStream.WebEvents;

public class AbEnrollmentEvent : WebEventBase
{
	private const string _Name = "abEnrollment";

	public AbEnrollmentEvent(IEventStreamer streamer, AbEnrollmentEventArgs args)
		: base(streamer, "abEnrollment", args)
	{
		AddEventArg("eid", args.EnrollmentId.ToString());
		AddEventArg("expid", args.ExperimentId.ToString());
		AddEventArg("verid", args.VersionId.ToString());
		AddEventArg("varid", args.VariationId.ToString());
		AddEventArg("varvalue", args.VariationValue.ToString());
		AddEventArg("stid", args.SubjectTargetId.ToString());
	}
}
