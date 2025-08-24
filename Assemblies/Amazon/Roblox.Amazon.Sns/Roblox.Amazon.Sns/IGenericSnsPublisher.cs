namespace Roblox.Amazon.Sns;

/// <summary>
/// A generic Sns event publisher that wraps the <see cref="T:Roblox.Amazon.Sns.SnsPublisher" /> and handles its initialization and re-initialization when config settings changed.
/// </summary>
public interface IGenericSnsPublisher<T> where T : class
{
	/// <summary>
	/// Publish a message to the configured Sns Topic.
	/// </summary>
	/// <param name="message">The message to be published.</param>
	/// <exception cref="T:System.ArgumentNullException">Throws when <paramref name="message" /> is null.</exception>
	/// <exception cref="T:System.InvalidOperationException">Throws when SnsPublisher is not properly initialized.</exception>
	void Publish(T message);
}
