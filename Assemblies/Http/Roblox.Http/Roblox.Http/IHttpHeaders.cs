using System.Collections.Generic;

namespace Roblox.Http;

public interface IHttpHeaders
{
	IReadOnlyList<string> Keys { get; }

	string ContentType { get; set; }

	void Add(string name, string value);

	void AddOrUpdate(string name, string value);

	ICollection<string> Get(string name);

	bool Remove(string name);
}
