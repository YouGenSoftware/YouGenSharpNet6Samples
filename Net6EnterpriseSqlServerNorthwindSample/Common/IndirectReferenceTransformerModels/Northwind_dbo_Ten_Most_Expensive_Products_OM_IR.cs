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
public class Northwind_dbo_Ten_Most_Expensive_Products_OM_IR
{
	public Northwind_dbo_Ten_Most_Expensive_Products_OM_IR() 
	{
	} 
	public Northwind_dbo_Ten_Most_Expensive_Products_OM_IR(
		String? tenMostExpensiveProducts_,
		Decimal? unitPrice_
	)
	{
		TenMostExpensiveProducts = tenMostExpensiveProducts_;
		UnitPrice = unitPrice_;
	}
	[JsonConstructor]
	public Northwind_dbo_Ten_Most_Expensive_Products_OM_IR(
		String? TenMostExpensiveProducts,
		String? TenMostExpensiveProducts_OriginalValue,
		Boolean TenMostExpensiveProducts_HasBeenChanged,
		Decimal? UnitPrice,
		Decimal? UnitPrice_OriginalValue,
		Boolean UnitPrice_HasBeenChanged
	)
	{
		this.TenMostExpensiveProducts = TenMostExpensiveProducts;
		this.TenMostExpensiveProducts_OriginalValue = TenMostExpensiveProducts_OriginalValue;
		this.TenMostExpensiveProducts_HasBeenChanged = TenMostExpensiveProducts_HasBeenChanged;
		this.UnitPrice = UnitPrice;
		this.UnitPrice_OriginalValue = UnitPrice_OriginalValue;
		this.UnitPrice_HasBeenChanged = UnitPrice_HasBeenChanged;
	}
	public String? TenMostExpensiveProducts
	{
		get => _tenMostExpensiveProducts;
		set
		{
			_tenMostExpensiveProducts = value;
			TenMostExpensiveProducts_HasBeenChanged = _tenMostExpensiveProducts == TenMostExpensiveProducts_OriginalValue ? false : true;
		}
	}
	private String? _tenMostExpensiveProducts;
	public String? TenMostExpensiveProducts_OriginalValue { get; private set; }
	public Boolean TenMostExpensiveProducts_HasBeenChanged { get; private set; }
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
	public Decimal? UnitPrice_OriginalValue { get; private set; }
	public Boolean UnitPrice_HasBeenChanged { get; private set; }
}