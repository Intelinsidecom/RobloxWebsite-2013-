using System.Collections;
using System.IO;
using System.Net;

namespace com.amazon.s3;

public class GetResponse : Response
{
	private S3Object obj;

	public S3Object Object => obj;

	private GetResponse()
	{
	}

	protected override void Process(WebRequest request)
	{
		base.Process(request);
		SortedList metadata = extractMetadata(response);
		byte[] data;
		using (Stream stream = response.GetResponseStream())
		{
			data = Utils.slurpInputStream(stream);
		}
		obj = new S3Object(data, metadata);
	}

	private static SortedList extractMetadata(WebResponse response)
	{
		SortedList metadata = new SortedList();
		foreach (string key in response.Headers.Keys)
		{
			if (key != null && key.StartsWith(Utils.METADATA_PREFIX))
			{
				metadata.Add(key.Substring(Utils.METADATA_PREFIX.Length), response.Headers[key]);
			}
		}
		return metadata;
	}

	public new static GetResponse Get(WebRequest request)
	{
		GetResponse getResponse = new GetResponse();
		getResponse.Process(request);
		return getResponse;
	}
}
