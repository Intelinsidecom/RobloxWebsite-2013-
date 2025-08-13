namespace Roblox.Billing;

public class FraudDetectionData
{
	public string FirstName { get; set; }

	public string LastName { get; set; }

	public string Phone { get; set; }

	public string SessionId { get; set; }

	public string IpAddress { get; set; }

	public string Email { get; set; }

	public Sale Sale { get; set; }

	public User User { get; set; }

	public PaymentType PaymentType { get; set; }

	public string AccountNumber { get; set; }

	public string AddressLine1 { get; set; }

	public string AddressLine2 { get; set; }

	public string City { get; set; }

	public string State { get; set; }

	public string PostalCode { get; set; }

	public string Country { get; set; }

	public string PayerId { get; set; }

	public string SecurityCode { get; set; }

	public string TransactionId { get; set; }

	public decimal TransactionAmount { get; set; }

	public TransactionStatus TranactionStatus { get; set; }

	public bool IsFirstTimePurchase { get; set; }
}
