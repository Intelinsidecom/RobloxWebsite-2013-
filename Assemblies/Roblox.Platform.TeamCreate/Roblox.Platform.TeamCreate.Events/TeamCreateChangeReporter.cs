using System;

namespace Roblox.Platform.TeamCreate.Events;

public class TeamCreateChangeReporter : ITeamCreateChangeReporter, IObservable<TeamCreateEvent>
{
	private class Unsubscriber : IDisposable
	{
		private readonly TeamCreateChangeReporter _Reporter;

		private readonly IObserver<TeamCreateEvent> _Observer;

		public Unsubscriber(TeamCreateChangeReporter reporter, IObserver<TeamCreateEvent> observer)
		{
			_Reporter = reporter;
			_Observer = observer;
		}

		public void Dispose()
		{
			_Reporter.ObserverActions -= _Observer.OnNext;
		}
	}

	private event Action<TeamCreateEvent> ObserverActions;

	public IDisposable Subscribe(IObserver<TeamCreateEvent> observer)
	{
		ObserverActions += observer.OnNext;
		return new Unsubscriber(this, observer);
	}

	public virtual void EntityChanged(long universeId, TeamCreateChangeType changeType, long? userId)
	{
		TeamCreateEvent entityEvent = new TeamCreateEvent(universeId, changeType, userId);
		this.ObserverActions?.Invoke(entityEvent);
	}
}
