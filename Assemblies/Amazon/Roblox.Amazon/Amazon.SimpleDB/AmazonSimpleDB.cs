using Amazon.SimpleDB.Model;

namespace Amazon.SimpleDB;

/// <summary>
/// Amazon SimpleDB is a web service for running queries on structured
/// data in real time. This service works in close conjunction with Amazon
/// Simple Storage Service (Amazon S3) and Amazon Elastic Compute Cloud
/// (Amazon EC2), collectively providing the ability to store, process
/// and query data sets in the cloud. These services are designed to make
/// web-scale computing easier and more cost-effective for developers.
///
/// Traditionally, this type of functionality has been accomplished with
/// a clustered relational database that requires a sizable upfront
/// investment, brings more complexity than is typically needed, and often
/// requires a DBA to maintain and administer. In contrast, Amazon SimpleDB
/// is easy to use and provides the core functionality of a database -
/// real-time lookup and simple querying of structured data without the
/// operational complexity.  Amazon SimpleDB requires no schema, automatically
/// indexes your data and provides a simple API for storage and access.
/// This eliminates the administrative burden of data modeling, index
/// maintenance, and performance tuning. Developers gain access to this
/// functionality within Amazon's proven computing environment, are able
/// to scale instantly, and pay only for what they use.
///
/// </summary>
internal interface AmazonSimpleDB
{
	/// <summary>
	/// Create Domain 
	/// </summary>
	/// <param name="request">Create Domain  request</param>
	/// <returns>Create Domain  Response from the service</returns>
	/// <remarks>
	/// The CreateDomain operation creates a new domain. The domain name must be unique
	/// among the domains associated with the Access Key ID provided in the request. The CreateDomain
	/// operation may take 10 or more seconds to complete.
	///
	/// </remarks>
	CreateDomainResponse CreateDomain(CreateDomain request);

	/// <summary>
	/// List Domains 
	/// </summary>
	/// <param name="request">List Domains  request</param>
	/// <returns>List Domains  Response from the service</returns>
	/// <remarks>
	/// The ListDomains operaton lists all domains associated with the Access Key ID. It returns
	/// domain names up to the limit set by MaxNumberOfDomains. A NextToken is returned if there are more
	/// than MaxNumberOfDomains domains. Calling ListDomains successive times with the
	/// NextToken returns up to MaxNumberOfDomains more domain names each time.
	///
	/// </remarks>
	ListDomainsResponse ListDomains(ListDomains request);

	/// <summary>
	/// Delete Domain 
	/// </summary>
	/// <param name="request">Delete Domain  request</param>
	/// <returns>Delete Domain  Response from the service</returns>
	/// <remarks>
	/// The DeleteDomain operation deletes a domain. Any items (and their attributes) in the domain
	/// are deleted as well. The DeleteDomain operation may take 10 or more seconds to complete.
	///
	/// </remarks>
	DeleteDomainResponse DeleteDomain(DeleteDomain request);

	/// <summary>
	/// Put Attributes 
	/// </summary>
	/// <param name="request">Put Attributes  request</param>
	/// <returns>Put Attributes  Response from the service</returns>
	/// <remarks>
	/// The PutAttributes operation creates or replaces attributes within an item. You specify new attributes
	/// using a combination of the Attribute.X.Name and Attribute.X.Value parameters. You specify
	/// the first attribute by the parameters Attribute.0.Name and Attribute.0.Value, the second
	/// attribute by the parameters Attribute.1.Name and Attribute.1.Value, and so on.
	///
	/// Attributes are uniquely identified within an item by their name/value combination. For example, a single
	/// item can have the attributes { "first_name", "first_value" } and { "first_name",
	/// second_value" }. However, it cannot have two attribute instances where both the Attribute.X.Name and
	/// Attribute.X.Value are the same.
	/// Optionally, the requestor can supply the Replace parameter for each individual value. Setting this value
	/// to true will cause the new attribute value to replace the existing attribute value(s). For example, if an
	/// item has the attributes { 'a', '1' }, { 'b', '2'} and { 'b', '3' } and the requestor does a
	/// PutAttributes of { 'b', '4' } with the Replace parameter set to true, the final attributes of the
	/// item will be { 'a', '1' } and { 'b', '4' }, replacing the previous values of the 'b' attribute
	/// with the new value.
	///
	/// </remarks>
	PutAttributesResponse PutAttributes(PutAttributes request);

	/// <summary>
	/// Get Attributes 
	/// </summary>
	/// <param name="request">Get Attributes  request</param>
	/// <returns>Get Attributes  Response from the service</returns>
	/// <remarks>
	/// Returns all of the attributes associated with the item. Optionally, the attributes returned can be limited to
	/// the specified AttributeName parameter.
	/// If the item does not exist on the replica that was accessed for this operation, an empty attribute is
	/// returned. The system does not return an error as it cannot guarantee the item does not exist on other
	/// replicas.
	///
	/// </remarks>
	GetAttributesResponse GetAttributes(GetAttributes request);

	/// <summary>
	/// Delete Attributes 
	/// </summary>
	/// <param name="request">Delete Attributes  request</param>
	/// <returns>Delete Attributes  Response from the service</returns>
	/// <remarks>
	/// Deletes one or more attributes associated with the item. If all attributes of an item are deleted, the item is
	/// deleted.
	///
	/// </remarks>
	DeleteAttributesResponse DeleteAttributes(DeleteAttributes request);

	/// <summary>
	/// Query 
	/// </summary>
	/// <param name="request">Query  request</param>
	/// <returns>Query  Response from the service</returns>
	/// <remarks>
	/// The Query operation returns a set of ItemNames that match the query expression. Query operations that
	/// run longer than 5 seconds will likely time-out and return a time-out error response.
	/// A Query with no QueryExpression matches all items in the domain.
	///
	/// </remarks>
	QueryResponse Query(Query request);
}
