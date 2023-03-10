/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Northwind_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Indirect Referenced Model Description: N/A
/// </summary>
public class Northwind_dbo_Order_Details_IR
{
	public Northwind_dbo_Order_Details_IR() 
	{
	} 
	public Northwind_dbo_Order_Details_IR(
		String? orderID_IR_,
		String? productID_IR_,
		Decimal? unitPrice_,
		Int16? quantity_,
		Single? discount_
	)
	{
		_orderID_IR = orderID_IR_;
		OrderID_IR_OriginalValue = orderID_IR_;
		_productID_IR = productID_IR_;
		ProductID_IR_OriginalValue = productID_IR_;
		_unitPrice = unitPrice_;
		UnitPrice_OriginalValue = unitPrice_;
		_quantity = quantity_;
		Quantity_OriginalValue = quantity_;
		_discount = discount_;
		Discount_OriginalValue = discount_;
		PrimaryKeyEncryptedForUpdateDeleteIdentification = orderID_IR_ + (Char)27 + productID_IR_;
	}
	[JsonConstructor]
	public Northwind_dbo_Order_Details_IR(
		String? OrderID_IR,
		String? OrderID_IR_OriginalValue,
		Boolean OrderID_IR_HasBeenChanged,
		String? ProductID_IR,
		String? ProductID_IR_OriginalValue,
		Boolean ProductID_IR_HasBeenChanged,
		Decimal UnitPrice,
		Decimal UnitPrice_OriginalValue,
		Boolean UnitPrice_HasBeenChanged,
		Int16 Quantity,
		Int16 Quantity_OriginalValue,
		Boolean Quantity_HasBeenChanged,
		Single Discount,
		Single Discount_OriginalValue,
		Boolean Discount_HasBeenChanged,
		String? PrimaryKeyEncryptedForUpdateDeleteIdentification,
		String? PrimaryKeyHashedForUniqueObjectComparison
	)
	{
		this.OrderID_IR = OrderID_IR;
		this.OrderID_IR_OriginalValue = OrderID_IR_OriginalValue;
		this.OrderID_IR_HasBeenChanged = OrderID_IR_HasBeenChanged;
		this.ProductID_IR = ProductID_IR;
		this.ProductID_IR_OriginalValue = ProductID_IR_OriginalValue;
		this.ProductID_IR_HasBeenChanged = ProductID_IR_HasBeenChanged;
		this.UnitPrice = UnitPrice;
		this.UnitPrice_OriginalValue = UnitPrice_OriginalValue;
		this.UnitPrice_HasBeenChanged = UnitPrice_HasBeenChanged;
		this.Quantity = Quantity;
		this.Quantity_OriginalValue = Quantity_OriginalValue;
		this.Quantity_HasBeenChanged = Quantity_HasBeenChanged;
		this.Discount = Discount;
		this.Discount_OriginalValue = Discount_OriginalValue;
		this.Discount_HasBeenChanged = Discount_HasBeenChanged;
		this.PrimaryKeyEncryptedForUpdateDeleteIdentification = PrimaryKeyEncryptedForUpdateDeleteIdentification;
		this.PrimaryKeyHashedForUniqueObjectComparison = PrimaryKeyHashedForUniqueObjectComparison;
	}
	/// <summary>
	/// SQL Column Description: Primary key encrypted value for update and delete identification purposes
	/// </summary>
	public String? PrimaryKeyEncryptedForUpdateDeleteIdentification { get; set; }
	/// <summary>
	/// SQL Column Description: Primary key hashed value for uniue object comparison purposes
	/// </summary>
	public String? PrimaryKeyHashedForUniqueObjectComparison { get; set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? OrderID_IR
	{
		get => _orderID_IR;
		set
		{
			_orderID_IR = value;
			OrderID_IR_HasBeenChanged = _orderID_IR == OrderID_IR_OriginalValue ? false : true;
		}
	}
	private String? _orderID_IR;
	public String? OrderID_IR_OriginalValue { get; private set; }
	public Boolean OrderID_IR_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? ProductID_IR
	{
		get => _productID_IR;
		set
		{
			_productID_IR = value;
			ProductID_IR_HasBeenChanged = _productID_IR == ProductID_IR_OriginalValue ? false : true;
		}
	}
	private String? _productID_IR;
	public String? ProductID_IR_OriginalValue { get; private set; }
	public Boolean ProductID_IR_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Decimal? UnitPrice
	{
		get => _unitPrice;
		set
		{
			_unitPrice = value;
			UnitPrice_HasBeenChanged = _unitPrice == UnitPrice_OriginalValue ? false : true;
		}
	}
	private Decimal? _unitPrice;
	public Decimal? UnitPrice_OriginalValue  { get; private set; }
	public Boolean UnitPrice_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Int16? Quantity
	{
		get => _quantity;
		set
		{
			_quantity = value;
			Quantity_HasBeenChanged = _quantity == Quantity_OriginalValue ? false : true;
		}
	}
	private Int16? _quantity;
	public Int16? Quantity_OriginalValue  { get; private set; }
	public Boolean Quantity_HasBeenChanged  { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Single? Discount
	{
		get => _discount;
		set
		{
			_discount = value;
			Discount_HasBeenChanged = _discount == Discount_OriginalValue ? false : true;
		}
	}
	private Single? _discount;
	public Single? Discount_OriginalValue  { get; private set; }
	public Boolean Discount_HasBeenChanged  { get; private set; }
	// Foreign key entities
	public virtual Northwind_dbo_Orders_IR? FK_Order_Details_Orders_Ref_IR { get; set; }
	public virtual Northwind_dbo_Products_IR? FK_Order_Details_Products_Ref_IR { get; set; }
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
}
