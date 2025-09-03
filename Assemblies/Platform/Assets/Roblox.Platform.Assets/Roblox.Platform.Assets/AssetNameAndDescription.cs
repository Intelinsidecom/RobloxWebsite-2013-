using Roblox.Platform.Membership;
using Roblox.Platform.TextFilter;
using Roblox.Platform.TextFilter.Client;

namespace Roblox.Platform.Assets;

/// <summary>
/// Wrapper class for submitting Asset Name and Description to be changed.
/// </summary>
public class AssetNameAndDescription : IAssetNameAndDescription, INameAndDescription
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.TextFilter.ITextAuthor" /> who is attempting to make the change.
	/// </summary>
	public ITextAuthor TextAuthor { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.TextFilter.Client.IClientTextAuthor" /> who is attempting to make the change.
	/// </summary>
	public IClientTextAuthor ClientTextAuthor { get; }

	/// <summary>
	/// The new Name of the Asset.
	/// </summary>
	public string Name { get; }

	/// <summary>
	/// The new Description of the Asset.
	/// </summary>
	public string Description { get; }

	/// <summary>
	/// Helper constructor, allows for passing around IUser instead of ITextAuthor.
	/// </summary>
	/// <param name="user"></param>
	/// <param name="name"></param>
	/// <param name="description"></param>
	public AssetNameAndDescription(IUser user, string name, string description)
		: this(new Roblox.Platform.TextFilter.Client.TextAuthor
		{
			Id = user.Id,
			Name = user.Name,
			IsUnder13 = user.IsUnder13()
		}, name, description)
	{
	}

	/// <summary>
	/// Deprecated. Use IClientTextAuthor.
	/// </summary>
	/// <param name="textAuthor"></param>
	/// <param name="name"></param>
	/// <param name="description"></param>
	public AssetNameAndDescription(ITextAuthor textAuthor, string name, string description)
	{
		TextAuthor = textAuthor;
		Name = name;
		Description = description;
		bool isUnder13 = false;
		if (textAuthor is IUser user)
		{
			isUnder13 = user.IsUnder13();
		}
		ClientTextAuthor = new Roblox.Platform.TextFilter.Client.TextAuthor
		{
			Id = textAuthor.Id,
			Name = textAuthor.Name,
			IsUnder13 = isUnder13
		};
	}

	/// <summary>
	/// Default constructor.
	/// </summary>
	/// <param name="textAuthor"></param>
	/// <param name="name"></param>
	/// <param name="description"></param>
	public AssetNameAndDescription(IClientTextAuthor clientTextAuthor, string name, string description)
	{
		ClientTextAuthor = clientTextAuthor;
		Name = name;
		Description = description;
		TextAuthor = new Roblox.Platform.TextFilter.TextAuthor(clientTextAuthor.Id, clientTextAuthor.Name, clientTextAuthor.IsUnder13);
	}
}
