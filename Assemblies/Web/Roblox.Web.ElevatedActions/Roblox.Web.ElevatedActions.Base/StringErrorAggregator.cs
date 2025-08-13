using System.Collections.Generic;

namespace Roblox.Web.ElevatedActions.Base;

public class StringErrorAggregator : IErrorAggregator<string, IEnumerable<string>>
{
	private readonly ICollection<string> _Errors;

	public IEnumerable<string> Errors => _Errors;

	public StringErrorAggregator()
	{
		_Errors = new List<string>();
	}

	public void Push(string errorMessage)
	{
		_Errors.Add(errorMessage);
	}
}
