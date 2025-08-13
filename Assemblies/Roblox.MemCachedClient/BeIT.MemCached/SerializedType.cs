namespace BeIT.MemCached;

internal enum SerializedType : ushort
{
	ByteArray = 0,
	Object = 1,
	String = 2,
	Datetime = 3,
	Bool = 4,
	Byte = 6,
	Short = 7,
	UShort = 8,
	Int = 9,
	UInt = 10,
	Long = 11,
	ULong = 12,
	Float = 13,
	Double = 14,
	Null = 15,
	CompressedByteArray = 255,
	CompressedObject = 256,
	CompressedString = 257
}
