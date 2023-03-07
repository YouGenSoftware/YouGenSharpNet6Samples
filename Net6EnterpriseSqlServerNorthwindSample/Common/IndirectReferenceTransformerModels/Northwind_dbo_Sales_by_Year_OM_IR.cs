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
/// Sql Entity Description: Model Description: Stored Procedure Output Model
/// </summary>
public class Northwind_dbo_Sales_by_Year_OM_IR
{
	public Northwind_dbo_Sales_by_Year_OM_IR() 
	{
	} 
	public Northwind_dbo_Sales_by_Year_OM_IR(
		DateTime? shippedDate_,
		String? orderID_IR_,
		Decimal? subtotal_,
		String? year_
	)
	{
		ShippedDate = shippedDate_;
		OrderID_IR = orderID_IR_;
		Subtotal = subtotal_;
		Year = year_;
	}
	[JsonConstructor]
	public Northwind_dbo_Sales_by_Year_OM_IR(
		DateTime? ShippedDate,
		DateTime? ShippedDate_OriginalValue,
		Boolean ShippedDate_HasBeenChanged,
		String? OrderID_IR,
		String? OrderID_IR_OriginalValue,
		Boolean OrderID_IR_HasBeenChanged,
		Decimal? Subtotal,
		Decimal? Subtotal_OriginalValue,
		Boolean Subtotal_HasBeenChanged,
		String? Year,
		String? Year_OriginalValue,
		Boolean Year_HasBeenChanged
	)
	{
		this.ShippedDate = ShippedDate;
		this.ShippedDate_OriginalValue = ShippedDate_OriginalValue;
		this.ShippedDate_HasBeenChanged = ShippedDate_HasBeenChanged;
		this.OrderID_IR = OrderID_IR;
		this.OrderID_IR_OriginalValue = OrderID_IR_OriginalValue;
		this.OrderID_IR_HasBeenChanged = OrderID_IR_HasBeenChanged;
		this.Subtotal = Subtotal;
		this.Subtotal_OriginalValue = Subtotal_OriginalValue;
		this.Subtotal_HasBeenChanged = Subtotal_HasBeenChanged;
		this.Year = Year;
		this.Year_OriginalValue = Year_OriginalValue;
		this.Year_HasBeenChanged = Year_HasBeenChanged;
	}
	public DateTime? ShippedDate
	{
		get => _shippedDate;
		set
		{
			_shippedDate = value;
			ShippedDate_HasBeenChanged = _shippedDate == ShippedDate_OriginalValue ? false : true;
		}
	}
	private DateTime? _shippedDate;
	public DateTime? ShippedDate_OriginalValue { get; private set; }
	public Boolean ShippedDate_HasBeenChanged { get; private set; }
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
	public Decimal? Subtotal
	{
		get => _subtotal;
		set
		{
			_subtotal = value;
			Subtotal_HasBeenChanged = _subtotal == Subtotal_OriginalValue ? false : true;
		}
	}
	private Decimal? _subtotal;
	public Decimal? Subtotal_OriginalValue { get; private set; }
	public Boolean Subtotal_HasBeenChanged { get; private set; }
	public String? Year
	{
		get => _year;
		set
		{
			_year = value;
			Year_HasBeenChanged = _year == Year_OriginalValue ? false : true;
		}
	}
	private String? _year;
	public String? Year_OriginalValue { get; private set; }
	public Boolean Year_HasBeenChanged { get; private set; }
}