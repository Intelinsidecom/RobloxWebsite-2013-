using System;

namespace Roblox.Platform.Billing;

public class ProductDisplayModel
{
	public int ProductId { get; set; }

	public string Name { get; set; }

	public string DurationTitle { get; set; }

	public decimal? Price { get; set; }

	public bool IsCurrentPremiumFeature { get; set; }

	public int PremiumFeatureId { get; set; }

	public ProductRank Rank { get; set; }

	public bool IsDisabled { get; set; }

	public DateTime? Expiration { get; set; }

	public bool IsRenewable { get; set; }

	public string RenewOrExpireText { get; set; }

	public string ImageFile { get; set; }

	public string PriceText { get; set; }

	public long GiftcardShoppingCartProductId { get; set; }

	public ProductDisplayModel()
	{
	}

	public ProductDisplayModel(int productId, string productName, string durationTitle, DateTime? expiration, bool renewable, string imageFileName)
	{
		ProductId = productId;
		Name = productName;
		DurationTitle = durationTitle;
		Expiration = expiration;
		IsRenewable = renewable;
		ImageFile = imageFileName;
	}

	public ProductDisplayModel(int productId, string productName, string durationTitle, DateTime? expiration, bool renewable, string imageFileName, ProductRank rank, int premiumFeatureId)
		: this(productId, productName, durationTitle, expiration, renewable, imageFileName)
	{
		Rank = rank;
		PremiumFeatureId = premiumFeatureId;
	}

	public ProductDisplayModel Clone()
	{
		return (ProductDisplayModel)MemberwiseClone();
	}
}
