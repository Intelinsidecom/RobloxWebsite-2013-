using System;

namespace Roblox.Billing;

internal class PlatformSale
{
	internal static void Log(int saleId, byte platformTypeId)
	{
		PlatformSaleDAL platformSaleDAL = new PlatformSaleDAL();
		platformSaleDAL.SaleID = saleId;
		platformSaleDAL.PlatformTypeID = platformTypeId;
		platformSaleDAL.Created = DateTime.Now;
		platformSaleDAL.Insert();
	}
}
