using System.Collections;
using System.Text;

namespace com.amazon.s3;

public class S3Object
{
	private byte[] bytes;

	private SortedList metadata;

	/// <summary>
	/// Acquires the binary representation of an object.
	/// </summary>
	public byte[] Bytes => bytes;

	/// <summary>
	/// Acquires the ASCII Encoding representation of an object.
	/// </summary>
	public string Data => new ASCIIEncoding().GetString(bytes, 0, bytes.Length);

	/// <summary>
	/// Acquires the metadata.
	/// </summary>
	public SortedList Metadata => metadata;

	/// <summary>
	/// Constructs an S3Object.
	/// </summary>
	/// <param name="bytes">Byte array representing the object</param>
	/// <param name="metadata">Metadata associated with the object</param>
	public S3Object(byte[] bytes, SortedList metadata)
	{
		this.bytes = bytes;
		this.metadata = metadata;
	}

	/// <summary>
	/// Constructs an S3Object.
	/// </summary>
	/// <param name="data">String representation of the data; this will be decoded via ASCII</param>
	/// <param name="metadata">Metadata associated with the object</param>
	public S3Object(string data, SortedList metadata)
	{
		ASCIIEncoding encoder = new ASCIIEncoding();
		bytes = encoder.GetBytes(data.ToCharArray());
		this.metadata = metadata;
	}
}
