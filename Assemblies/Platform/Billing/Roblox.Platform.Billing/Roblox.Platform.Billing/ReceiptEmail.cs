using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roblox.Billing;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Billing;

internal class ReceiptEmail
{
	private string PurchaserName { get; set; }

	private int SaleId { get; set; }

	private string RetrievalUrl { get; set; }

	private string PurchaserEmail { get; set; }

	private string MaskedCCNumber { get; set; }

	private string BillingAddress1 { get; set; }

	private string BillingAddress2 { get; set; }

	private string BillingCityZip { get; set; }

	private string Country { get; set; }

	private decimal OrderTotal { get; set; }

	private string ProductTitle { get; set; }

	private string Username { get; set; }

	private ICollection<LineItem> LineItems { get; set; }

	private bool IsGiftcardPurchase { get; set; }

	private GiftCard GiftCard { get; set; }

	private CreditCardType CreditCardType { get; set; }

	private LineItem MembershipItem { get; set; }

	private bool IsMembershipPurchase { get; set; }

	public ReceiptEmail(ICollection<LineItem> lineItems, CreditCardTransactionInfo creditCardTransactionInfo, ITransactionResult transactionResult, IUser user)
	{
		CreditCardPaymentInfo creditCardPaymentInfo = creditCardTransactionInfo.CreditCardPaymentInfo;
		LineItems = lineItems;
		SaleId = transactionResult.Sale.Id;
		BillingAddress1 = creditCardPaymentInfo.AddressLine1;
		BillingAddress2 = creditCardPaymentInfo.AddressLine2;
		BillingCityZip = creditCardPaymentInfo.City + " " + creditCardPaymentInfo.PostalCode;
		Country = creditCardPaymentInfo.Country;
		PurchaserName = creditCardPaymentInfo.FirstName + " " + creditCardPaymentInfo.LastName;
		IsGiftcardPurchase = lineItems.IsGiftCardPurchase();
		MaskedCCNumber = creditCardPaymentInfo.AccountNumber.Substring(creditCardPaymentInfo.AccountNumber.Length - 4);
		PurchaserEmail = creditCardPaymentInfo.Email;
		OrderTotal = Roblox.Billing.Sale.Get(SaleId).DiscountedPriceTotal;
		CreditCardType = creditCardTransactionInfo.CreditCardType;
		IsMembershipPurchase = lineItems.IsMembershipPurchase();
		if (IsMembershipPurchase)
		{
			MembershipItem = lineItems.GetMembershipItem();
		}
		if (IsGiftcardPurchase)
		{
			GiftCard = (from sp in SaleProduct.GetSaleProductsBySaleID(SaleId)
				select GiftCard.GetBySaleProductID(sp.ID)).First();
			RetrievalUrl = $"{creditCardTransactionInfo.BaseUrlHttps}/Gift.aspx?s={SaleId}&gc={GiftCard.RedemptionCode}";
		}
		else
		{
			Username = user.Name;
		}
	}

	private string GetFormattedLineItem(LineItem lineItem)
	{
		Product product = lineItem.ProductPrice.GetProduct();
		decimal finalPrice;
		string productName;
		if (GiftCard.IsGiftCardProduct(product))
		{
			finalPrice = GiftCard.Value;
			productName = (product.Name.Contains("Custom") ? "Printable Gift Card" : product.Name.Replace("Gift", "Printable Card Redeemable for"));
		}
		else
		{
			finalPrice = lineItem.FinalPrice;
			productName = GetFriendlyProductName(product);
		}
		string formattedPrice = $"{finalPrice:C}";
		return $"<pre>{productName,-48}  {formattedPrice.Trim(),8}</pre>";
	}

	private string GetMembershipFormattedLineItem(LineItem lineItem)
	{
		StringBuilder stringBuilder = new StringBuilder();
		string productName = GetFriendlyProductName(lineItem.ProductPrice.GetProduct());
		stringBuilder.Append("<tr>");
		stringBuilder.Append("<td width=\"150px\" style=\"font-weight:bold\">Items Purchased:</td>");
		stringBuilder.Append("<td>" + productName + "</td>");
		stringBuilder.Append("</tr>");
		stringBuilder.Append("<tr>");
		stringBuilder.Append("<td width=\"150px\" style=\"font-weight:bold\">Items Price:</td>");
		stringBuilder.Append("<td>" + GetFormatedPrice(lineItem.FinalPrice) + "</td>");
		stringBuilder.Append("</tr>");
		return stringBuilder.ToString();
	}

	private static string GetFormatedPrice(decimal finalPrice)
	{
		return $"{finalPrice:C}".Trim();
	}

	private static string GetFriendlyProductName(Product product)
	{
		if (product.ID == Product.BC6MonthsRenewalID)
		{
			return "Builders Club Every 6 Months";
		}
		if (product.ID == Product.BC12MonthsRenewalID)
		{
			return "Builders Club Annual";
		}
		if (product.ID == Product.TBC6MonthsRenewalID)
		{
			return "Turbo Builders Club Every 6 Months";
		}
		if (product.ID == Product.TBC12MonthsRenewalID)
		{
			return "Turbo Builders Club Annual";
		}
		if (product.ID == Product.OBC6MonthsRenewalID)
		{
			return "Outrageous Builders Club Every 6 Months";
		}
		if (product.ID != Product.OBC12MonthsRenewalID)
		{
			return product.Name;
		}
		return "Outrageous Builders Club Annual";
	}

	private static string GetFriendlyRenewalName(Product product)
	{
		if (product.RenewalPeriodTypeID == RenewalPeriodType.Annual.ID)
		{
			return "year";
		}
		if (product.RenewalPeriodTypeID == RenewalPeriodType.SemiAnnual.ID)
		{
			return "semi annual";
		}
		if (product.RenewalPeriodTypeID == RenewalPeriodType.Quarterly.ID)
		{
			return "quarter";
		}
		if (product.RenewalPeriodTypeID != RenewalPeriodType.Monthly.ID)
		{
			return "hour";
		}
		return "month";
	}

	private string GetPlainTextEmailContent()
	{
		StringBuilder sb = new StringBuilder();
		sb.Append("Thanks for your " + (IsGiftcardPurchase ? "gift card " : "") + "order, ");
		sb.Append(PurchaserName + "!\n");
		sb.Append("Your sale ID is " + SaleId + "\n");
		sb.Append("Visit this page to retrieve and check the redemption status of your gift card: \n");
		sb.Append(RetrievalUrl + "\n");
		sb.Append("----------------------------------------\n\n");
		sb.Append("Billing Summary");
		sb.Append("\n\n");
		sb.Append("Email Address: \n");
		sb.Append(PurchaserEmail);
		sb.Append("\n\n");
		if (!IsGiftcardPurchase)
		{
			sb.Append("User Name: \n");
			sb.Append(Username);
			sb.Append("\n\n");
		}
		sb.Append("Last Four Digits: \n");
		sb.Append(MaskedCCNumber);
		sb.Append("\n\n");
		sb.Append("Billing Address: \n");
		sb.Append(PurchaserName + "\n");
		sb.Append(BillingAddress1 + "\n");
		sb.Append((!string.IsNullOrEmpty(BillingAddress2)) ? (BillingAddress2 + "\n") : "");
		sb.Append(BillingCityZip + "\n");
		sb.Append(Country);
		sb.Append("\n\n");
		sb.Append("Order Total: \n");
		sb.Append(OrderTotal + "\n");
		sb.Append("----------------------------------------\n\n");
		sb.Append("Your Order");
		sb.Append("\n\n");
		sb.Append($"{ProductTitle}: \n");
		foreach (LineItem lineItem in LineItems)
		{
			sb.Append(GetFormattedLineItem(lineItem));
		}
		sb.Append("\n\n");
		sb.Append("----------------------------------------\n\n");
		sb.Append("*You are receiving this email because you made a purchase at our website.");
		return sb.ToString();
	}

	private string GetMembershipPlainTextEmailContent()
	{
		StringBuilder sb = new StringBuilder();
		sb.Append("Thank you for your recent purchase of Builders Club, " + Username + "!\n");
		sb.Append("\n\n");
		sb.Append("Your Order Details are below:\n");
		sb.Append("\n\n");
		sb.Append("Your purchase ID:\n");
		sb.Append(SaleId);
		sb.Append("\n\n");
		sb.Append("Date:\n");
		sb.Append(DateTime.Now.ToShortDateString());
		sb.Append("\n\n");
		sb.Append("Next Renewal Date:\n");
		sb.Append(MembershipItem.RenewalStartDate.GetValueOrDefault().ToShortDateString());
		sb.Append("\n\n");
		sb.Append("Username:\n");
		sb.Append(Username);
		sb.Append("\n\n");
		sb.Append("Payment Method:\n");
		sb.Append(CreditCardType.ToString() + " ending in " + MaskedCCNumber);
		sb.Append("\n\n");
		sb.Append("Your Order\n");
		foreach (LineItem lineItem in LineItems)
		{
			string productName = GetFriendlyProductName(lineItem.ProductPrice.GetProduct());
			sb.Append("Items Purchased:\n");
			sb.Append(productName + "\n");
			sb.Append("Items Price:\n");
			sb.Append(GetFormatedPrice(lineItem.FinalPrice) + "\n");
		}
		sb.Append("Total:\n");
		sb.Append(GetFormatedPrice(OrderTotal));
		sb.Append("\n\n");
		sb.Append("You will be charged " + GetFormatedPrice(MembershipItem.FinalPrice) + " per " + GetFriendlyRenewalName(MembershipItem.ProductPrice.GetProduct()) + " for this service until you cancel.You can cancel at any time by going to the billing tab of the account settings page and clicking cancel membership.If you cancel, you still will be charged for the current billing period.We hope you enjoy your membership.If you have any questions, please contact us at info@roblox.com.\n");
		return sb.ToString();
	}

	private string GetHtmlEmailContent()
	{
		StringBuilder sb = new StringBuilder();
		sb.Append("<div style=\"font-weight:bold; font-size:18px;\">Thanks for your " + (IsGiftcardPurchase ? "gift card " : "") + "order, " + PurchaserName + "!</div>");
		sb.Append("<div>Your sale ID is " + SaleId + ".</div>");
		if (IsGiftcardPurchase)
		{
			sb.Append("<div>Visit this page to retrieve and check the redemption status of your gift card:</div>");
			sb.Append("<a href=\"" + RetrievalUrl + "\" style=\"margin-bottom:10px;\">" + RetrievalUrl + "</a>");
			sb.Append("<hr />");
		}
		sb.Append("<div style=\"font-weight:bold; font-size:18px; line-height:2em;\">Billing Summary</div>");
		sb.Append("<table>");
		sb.Append("<tr>");
		sb.Append("<td width=\"150px\" style=\"font-weight:bold\">Email Address:</td>");
		sb.Append("<td>" + PurchaserEmail + "</td>");
		sb.Append("</tr>");
		if (!IsGiftcardPurchase)
		{
			sb.Append("<tr>");
			sb.Append("<td width=\"150px\" style=\"font-weight:bold\">User Name:</td>");
			sb.Append("<td>" + Username + "</td>");
			sb.Append("</tr>");
		}
		sb.Append("<tr>");
		sb.Append("<td width=\"150px\" style=\"font-weight:bold\">Last Four Digits:</td>");
		sb.Append("<td>" + MaskedCCNumber + "</td>");
		sb.Append("</tr>");
		sb.Append("<td width=\"150px\" style=\"font-weight:bold;vertical-align:top;\">Billing Address:</td>");
		sb.Append("<td>");
		sb.Append(PurchaserName + "<br />");
		sb.Append(BillingAddress1 + "<br />");
		if (!string.IsNullOrEmpty(BillingAddress2))
		{
			sb.Append(BillingAddress2 + "<br />");
		}
		sb.Append(BillingCityZip + "<br />");
		sb.Append(Country + "<br />");
		sb.Append("</td>");
		sb.Append("<tr>");
		sb.Append("<td width=\"150px\" style=\"font-weight:bold\">Order Total</td>");
		sb.Append("<td>" + OrderTotal + "</td>");
		sb.Append("</tr>");
		sb.Append("</table>");
		sb.Append("<hr />");
		sb.Append("<div style=\"font-weight:bold; font-size:18px; line-height:2em;\">Your Order</div>");
		sb.Append("<div style=\"font-weight:bold\">" + ProductTitle + "</div>");
		foreach (LineItem lineItem in LineItems)
		{
			sb.Append(GetFormattedLineItem(lineItem));
		}
		sb.Append("<br /><br />");
		sb.Append("<div style=\"border-top:1px solid black;font-size:10px;\">You are receiving this email because you made a purchase at our website. To contact customer service, reply to this email, or mail to info@roblox.com. All sales subject to <a href=\"http://www.roblox.com/info/terms-of-service\">Roblox Terms And Conditions</a></div>");
		return sb.ToString();
	}

	private string GetMembershipHtmlEmailContent()
	{
		StringBuilder sb = new StringBuilder();
		sb.Append("<div style=\"font-weight:bold;\">Thank you for your recent purchase of Builders Club, " + Username + "!</div>");
		sb.Append("<br /><br />");
		sb.Append("<div>Your Order Details are below:</div>");
		sb.Append("<br /><br />");
		sb.Append("<table>");
		sb.Append("<tr>");
		sb.Append("<td width=\"150px\" style=\"font-weight:bold\">Your purchase ID:</td>");
		sb.Append("<td>" + SaleId + "</td>");
		sb.Append("</tr>");
		sb.Append("<tr>");
		sb.Append("<td width=\"150px\" style=\"font-weight:bold\">Date:</td>");
		sb.Append("<td>" + DateTime.Now.ToShortDateString() + "</td>");
		sb.Append("</tr>");
		sb.Append("<tr>");
		sb.Append("<td width=\"150px\">Next Renewal Date:</td>");
		sb.Append("<td>" + MembershipItem.RenewalStartDate.GetValueOrDefault().ToShortDateString() + "</td>");
		sb.Append("</tr>");
		sb.Append("<tr>");
		sb.Append("<td width=\"150px\" style=\"font-weight:bold\">Username:</td>");
		sb.Append("<td>" + Username + "</td>");
		sb.Append("</tr>");
		sb.Append("<tr>");
		sb.Append("<td width=\"150px\" style=\"font-weight:bold\">Payment Method:</td>");
		sb.Append("<td>" + CreditCardType.ToString() + " ending in " + MaskedCCNumber + "</td>");
		sb.Append("</tr>");
		sb.Append("<br /><br />");
		sb.Append("<tr>");
		sb.Append("<td width=\"150px\" style=\"font-weight:bold\">Your Order</td>");
		sb.Append("</tr>");
		foreach (LineItem lineItem in LineItems)
		{
			sb.Append(GetMembershipFormattedLineItem(lineItem));
		}
		sb.Append("<tr>");
		sb.Append("<td width=\"150px\" style=\"font-weight:bold\">Total:</td>");
		sb.Append("<td>" + GetFormatedPrice(OrderTotal) + "</td>");
		sb.Append("</tr>");
		sb.Append("</table>");
		sb.Append("<tr></tr>");
		sb.Append("<tr>");
		sb.Append("<td>You will be charged " + GetFormatedPrice(MembershipItem.FinalPrice) + " per " + GetFriendlyRenewalName(MembershipItem.ProductPrice.GetProduct()) + " for this service until you cancel. You can cancel at any time by going to the billing tab of the account settings page and clicking cancel membership. If you cancel, you still will be charged for the current billing period. We hope you enjoy your membership. If you have any questions, please contact us at info@roblox.com.</td>");
		sb.Append("</tr>");
		return sb.ToString();
	}

	public IEmail GenerateMimeEmail()
	{
		if (IsMembershipPurchase)
		{
			return GenerateMimeEmail(PurchaserEmail, "info@roblox.com", "Roblox Purchase Confirmation", GetMembershipPlainTextEmailContent(), GetMembershipHtmlEmailContent(), "BuildersClubPurchaseConfirmation");
		}
		return GenerateMimeEmail(PurchaserEmail, "info@roblox.com", "Purchase Confirmation", GetPlainTextEmailContent(), GetHtmlEmailContent(), "PurchaseConfirmation");
	}

	private IEmail GenerateMimeEmail(string to, string from, string subject, string plainBody, string htmlBody, string emailType)
	{
		return new Roblox.Platform.Email.Delivery.Email(from, to, subject, EmailBodyType.Mime, emailType, plainBody, htmlBody);
	}
}
