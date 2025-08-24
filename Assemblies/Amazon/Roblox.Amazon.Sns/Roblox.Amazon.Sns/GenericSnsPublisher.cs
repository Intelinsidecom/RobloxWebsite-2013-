using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using Amazon;
using Roblox.Instrumentation;

namespace Roblox.Amazon.Sns;

public class GenericSnsPublisher<T> : IGenericSnsPublisher<T> where T : class
{
	private readonly Action<Exception> _ErrorHandler;

	private readonly Func<string> _SnsAwsAccessKeyAndSecretGetter;

	private readonly Func<string> _SnsTopicArnGetter;

	private readonly Func<RegionEndpoint> _PrimaryRegionEndpointGetter;

	private readonly string _PerformanceMonitorCategory;

	private SnsPublisher _EventPublisher;

	private readonly ICounterRegistry _CounterRegistry;

	/// <summary>
	/// Initializes an instance of <see cref="T:Roblox.Amazon.Sns.GenericSnsPublisher`1" />.
	///
	/// Note: The generic Type T MUST be a class decorated with [DataContract] attribute.
	/// And all the public properties of the generic type T MUST be decorated with [DataMember] attribute.
	/// </summary>
	/// <param name="errorHandler">The error handler.</param>
	/// <param name="monitorWireup">The Action that wires up the configuration settings monitoring.</param>
	/// <param name="snsAwsAccessKeyAndSecretGetter">The getter for SnsAwsAccessKeyAndSecret.</param>
	/// <param name="snsTopicArnGetter">The getter for SnsTopicArn.</param>
	/// <param name="primaryRegionEndpointGetter">The getter for Primary Region Endpoint.</param>
	/// <param name="performanceMonitorCategory">The performance monitor category of the publisher.</param>
	///             <param name="counterRegistry">the counter registry (used by the <see cref="T:Roblox.Instrumentation.ICounterReporter" /> for telemetry)</param>
	///             <exception cref="T:System.ArgumentNullException">
	///     Throws if <paramref name="errorHandler" />,
	///               <paramref name="monitorWireup" />,
	///               <paramref name="snsAwsAccessKeyAndSecretGetter" />,
	///               <paramref name="snsTopicArnGetter" />,
	///               <paramref name="primaryRegionEndpointGetter" /> is null.
	/// </exception>
	/// <exception cref="T:System.ArgumentException"> Throws if <paramref name="performanceMonitorCategory" /> is null or white space.</exception>
	/// <exception cref="T:System.InvalidOperationException"> Throws if the generic Type T does not have proper [DataContract] or [DataMember] attributes.</exception>
	public GenericSnsPublisher(Action<Exception> errorHandler, Action<Action> monitorWireup, Func<string> snsAwsAccessKeyAndSecretGetter, Func<string> snsTopicArnGetter, Func<RegionEndpoint> primaryRegionEndpointGetter, string performanceMonitorCategory, ICounterRegistry counterRegistry)
	{
		ValidateGenericClassHasCorrectAttributes();
		if (string.IsNullOrWhiteSpace(performanceMonitorCategory))
		{
			throw new ArgumentException("performanceMonitorCategory");
		}
		if (monitorWireup == null)
		{
			throw new ArgumentNullException("monitorWireup");
		}
		_ErrorHandler = errorHandler ?? throw new ArgumentNullException("errorHandler");
		_SnsAwsAccessKeyAndSecretGetter = snsAwsAccessKeyAndSecretGetter ?? throw new ArgumentNullException("snsAwsAccessKeyAndSecretGetter");
		_SnsTopicArnGetter = snsTopicArnGetter ?? throw new ArgumentNullException("snsTopicArnGetter");
		_PrimaryRegionEndpointGetter = primaryRegionEndpointGetter ?? throw new ArgumentNullException("primaryRegionEndpointGetter");
		_PerformanceMonitorCategory = performanceMonitorCategory;
		_CounterRegistry = counterRegistry;
		InitializePublisher();
		monitorWireup(InitializePublisher);
	}

	/// <summary>
	/// Using Reflection to validate the generic class T is decorated with proper attributes.
	/// The validation is called during the construction of this class, which should normally happen
	/// during the application start.
	/// </summary>
	private void ValidateGenericClassHasCorrectAttributes()
	{
		Type typeFromHandle = typeof(T);
		if (Attribute.GetCustomAttribute(typeFromHandle, typeof(DataContractAttribute)) == null)
		{
			throw new InvalidOperationException("The generic Type T must be decorated with [DataContract] attribute.");
		}
		if (typeFromHandle.GetProperties().Any((PropertyInfo p) => Attribute.GetCustomAttribute(p, typeof(DataMemberAttribute)) == null))
		{
			throw new InvalidOperationException("All the public properties of the generic Type T must be decorated with [DataMember] attribute.");
		}
	}

	public void Publish(T message)
	{
		if (message == null)
		{
			throw new ArgumentNullException("message");
		}
		if (_EventPublisher == null)
		{
			throw new InvalidOperationException("SnsPublisher is not initialized.");
		}
		_EventPublisher.Publish(message);
	}

	private void InitializePublisher()
	{
		string snsAwsAccessKeyAndSecret = _SnsAwsAccessKeyAndSecretGetter();
		if (string.IsNullOrWhiteSpace(snsAwsAccessKeyAndSecret))
		{
			return;
		}
		string[] awsKeys = snsAwsAccessKeyAndSecret.Split(new char[1] { ',' });
		if (awsKeys.Length == 2 && !string.IsNullOrWhiteSpace(awsKeys[0]) && !string.IsNullOrWhiteSpace(awsKeys[1]))
		{
			string snsTopicArn = _SnsTopicArnGetter();
			if (!string.IsNullOrWhiteSpace(snsTopicArn))
			{
				RegionEndpoint primaryRegionEndpoint = _PrimaryRegionEndpointGetter();
				CreateNewSnsPublisher(awsKeys[0], awsKeys[1], primaryRegionEndpoint, snsTopicArn);
			}
		}
	}

	internal virtual void CreateNewSnsPublisher(string awsAccessKey, string awsSecretKey, RegionEndpoint primaryRegionEndpoint, string snsTopicArn)
	{
		_EventPublisher = new SnsPublisher(awsAccessKey, awsSecretKey, primaryRegionEndpoint, snsTopicArn, _PerformanceMonitorCategory, _CounterRegistry);
		_EventPublisher.SnsError += delegate(Exception exception, string s)
		{
			_ErrorHandler(exception);
		};
	}
}
