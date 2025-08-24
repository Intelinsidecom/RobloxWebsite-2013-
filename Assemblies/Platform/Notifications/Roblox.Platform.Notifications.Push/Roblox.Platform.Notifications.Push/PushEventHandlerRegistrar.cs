namespace Roblox.Platform.Notifications.Push;

public class PushEventHandlerRegistrar : IPushEventHandlerRegistrar
{
	private readonly PushRegistrar _Registrar;

	private readonly PushNotificationDeliverer _Deliverer;

	private readonly PushDestinationExpirer _DestinationExpirer;

	private readonly PushNotificationMetadataManager _MetadataManager;

	private readonly IPushMetricsTracker _MetricsTracker;

	public PushEventHandlerRegistrar(PushRegistrar registrar, PushNotificationDeliverer deliverer, PushDestinationExpirer destinationExpirer, PushNotificationMetadataManager metadataManager, IPushMetricsTracker metricsTracker)
	{
		_Registrar = registrar;
		_Deliverer = deliverer;
		_DestinationExpirer = destinationExpirer;
		_MetadataManager = metadataManager;
		_MetricsTracker = metricsTracker;
	}

	public void Register()
	{
		if (_Registrar != null)
		{
			_Registrar.OnRegistration += _MetricsTracker.IncrementRegistration;
			_Registrar.OnRegistrationEvent += _MetricsTracker.IncrementRegistrationEvent;
		}
		if (_Deliverer != null)
		{
			_Deliverer.OnDelivery += _MetricsTracker.IncrementDeliveryAttempted;
			_Deliverer.OnDestinationFlooded += _MetricsTracker.IncrementDestinationFlooded;
			_Deliverer.OnDestinationAndTypeCombinationFlooded += _MetricsTracker.IncrementDestinationAndTypeCombinationFlooded;
		}
		if (_DestinationExpirer != null)
		{
			_DestinationExpirer.OnDestinationExpiry += _MetricsTracker.IncrementDestinationExpiry;
		}
		if (_MetadataManager != null)
		{
			_MetadataManager.OnMetadataRead += _MetricsTracker.IncrementMetadataRead;
			_MetadataManager.OnMetadataRetrieveFailure += _MetricsTracker.IncrementMetadataRetrieveFailure;
			_MetadataManager.OnInteractionRecorded += _MetricsTracker.IncrementInteraction;
		}
	}
}
