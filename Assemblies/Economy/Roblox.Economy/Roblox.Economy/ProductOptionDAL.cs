using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

[Serializable]
public class ProductOptionDAL
{
	private long _ID;

	private long _ProductID;

	private bool _IsLimitedEdition;

	private bool _IsResellable;

	private long? _TotalAvailable;

	private long? _NumberRemaining;

	private byte _MinMembershipType;

	private DateTime? _OffSaleDeadline;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	public long ID
	{
		get
		{
			return _ID;
		}
		set
		{
			_ID = value;
		}
	}

	public long ProductID
	{
		get
		{
			return _ProductID;
		}
		set
		{
			_ProductID = value;
		}
	}

	public bool IsLimitedEdition
	{
		get
		{
			return _IsLimitedEdition;
		}
		set
		{
			_IsLimitedEdition = value;
		}
	}

	public bool IsResellable
	{
		get
		{
			return _IsResellable;
		}
		set
		{
			_IsResellable = value;
		}
	}

	public long? TotalAvailable
	{
		get
		{
			return _TotalAvailable;
		}
		set
		{
			_TotalAvailable = value;
		}
	}

	public long? NumberRemaining
	{
		get
		{
			return _NumberRemaining;
		}
		set
		{
			_NumberRemaining = value;
		}
	}

	public byte MinMembershipType
	{
		get
		{
			return _MinMembershipType;
		}
		set
		{
			_MinMembershipType = value;
		}
	}

	public DateTime? OffSaleDeadline
	{
		get
		{
			return _OffSaleDeadline;
		}
		set
		{
			_OffSaleDeadline = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _Created;
		}
		set
		{
			_Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _Updated;
		}
		set
		{
			_Updated = value;
		}
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductID", _ProductID));
		queryParameters.Add(new SqlParameter("@IsLimitedEdition", _IsLimitedEdition));
		queryParameters.Add(new SqlParameter("@IsResellable", _IsResellable));
		queryParameters.Add(new SqlParameter("@TotalAvailable", _TotalAvailable.HasValue ? ((object)_TotalAvailable) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@NumberRemaining", _NumberRemaining.HasValue ? ((object)_NumberRemaining) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@MinMembershipType", _MinMembershipType));
		queryParameters.Add(new SqlParameter("@OffSaleDeadline", _OffSaleDeadline));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(Helper.DBConnectionString_Products, "[dbo].[ProductOptions_InsertProductOption]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public bool TryDecrementNumberAvailable()
	{
		SqlParameter output_remaining = new SqlParameter("@NumberRemaining", SqlDbType.BigInt);
		output_remaining.Direction = ParameterDirection.Output;
		SqlParameter output_updated = new SqlParameter("@Updated", SqlDbType.DateTime);
		output_updated.Direction = ParameterDirection.Output;
		SqlParameter output_success = new SqlParameter("@IsSuccess", SqlDbType.Bit);
		output_success.Direction = ParameterDirection.Output;
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(output_remaining);
		queryParameters.Add(output_updated);
		queryParameters.Add(output_success);
		EntityHelper.DoEntityDALAction(new DbInfo(Helper.DBConnectionString_Products, "[dbo].[ProductOptions_TryDecrementNumberAvailable]", queryParameters));
		_NumberRemaining = (long)output_remaining.Value;
		_Updated = (DateTime)output_updated.Value;
		return (bool)output_success.Value;
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@ProductID", _ProductID));
		queryParameters.Add(new SqlParameter("@IsLimitedEdition", _IsLimitedEdition));
		queryParameters.Add(new SqlParameter("@IsResellable", _IsResellable));
		queryParameters.Add(new SqlParameter("@TotalAvailable", _TotalAvailable.HasValue ? ((object)_TotalAvailable) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@NumberRemaining", _NumberRemaining.HasValue ? ((object)_NumberRemaining) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@MinMembershipType", _MinMembershipType));
		queryParameters.Add(new SqlParameter("@OffSaleDeadline", _OffSaleDeadline));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(Helper.DBConnectionString_Products, "[dbo].[ProductOptions_UpdateProductOptionByID]", queryParameters));
	}

	private static ProductOptionDAL BuildDAL(SqlDataReader reader)
	{
		ProductOptionDAL dal = new ProductOptionDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.ProductID = (long)reader["ProductID"];
			dal.IsLimitedEdition = (bool)reader["IsLimitedEdition"];
			dal.IsResellable = (bool)reader["IsResellable"];
			dal.TotalAvailable = (reader["TotalAvailable"].Equals(DBNull.Value) ? null : ((long?)reader["TotalAvailable"]));
			dal.NumberRemaining = (reader["NumberRemaining"].Equals(DBNull.Value) ? null : ((long?)reader["NumberRemaining"]));
			dal.MinMembershipType = (byte)reader["MinMembershipType"];
			dal.OffSaleDeadline = (reader["OffSaleDeadline"].Equals(DBNull.Value) ? null : ((DateTime?)reader["OffSaleDeadline"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static ProductOptionDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString_Products, "[dbo].[ProductOptions_GetProductOptionByID]", queryParameters), BuildDAL);
	}

	public static ProductOptionDAL GetByProductID(long productId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductID", productId));
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString_Products, "[dbo].[ProductOptions_GetProductOptionByProductID]", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<ProductOptionDAL> GetOrCreate(long productId)
	{
		if (productId == 0L)
		{
			throw new ApplicationException("Required value not specified: productID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ProductID", productId));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(Helper.DBConnectionString_Products, "[dbo].[ProductOptions_GetOrCreateProductOptionByProductID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetCollectibleRobloxProductIDsSortedAndPaged(int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(Helper.DBConnectionString_Products, "[dbo].[Products_GetCollectibleRobloxProductIDsSortedAndPaged]", queryParameters));
	}

	public static long GetTotalNumberOfCollectibleRobloxProducts()
	{
		return EntityHelper.GetDataCount<long>(new DbInfo(Helper.DBConnectionString_Products, "[dbo].[Products_GetTotalNumberOfCollectibleRobloxProducts]"));
	}
}
