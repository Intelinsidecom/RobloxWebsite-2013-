using System;

namespace Roblox.Billing;

public interface ITransactionLog
{
	long ID { get; }

	int SaleID { get; set; }

	long PaymentID { get; set; }

	byte PaymentStatusTypeID { get; set; }

	long? UserAccountID { get; set; }

	string TransactionID { get; set; }

	string TransactionType { get; set; }

	string AuthCode { get; set; }

	string AvsCode { get; set; }

	string Number { get; set; }

	decimal? Amount { get; set; }

	int? Year { get; set; }

	int? Month { get; set; }

	string Address { get; set; }

	string Address2 { get; set; }

	string City { get; set; }

	string Country { get; set; }

	string Email { get; set; }

	string FirstName { get; set; }

	string LastName { get; set; }

	string Phone { get; set; }

	string StateProvince { get; set; }

	string ZipPostal { get; set; }

	string ClientIP { get; set; }

	DateTime? TransactionDate { get; set; }

	string ErrorMessage { get; set; }

	string Description { get; set; }

	string Code { get; set; }

	string AccountID { get; set; }

	DateTime Created { get; set; }

	DateTime Updated { get; set; }

	int? PayPalBillingAgreementID { get; set; }

	byte? CurrencyTypeID { get; set; }

	void Save();
}
