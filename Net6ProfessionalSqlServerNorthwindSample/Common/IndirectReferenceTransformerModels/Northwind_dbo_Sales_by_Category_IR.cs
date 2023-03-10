/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
// For reads only
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Northwind_Common.IndirectReferenceTransformerModels;
/// <summary>
/// Sql Entity Description: Indirect Referenced Model Description: N/A
/// </summary>
public class Northwind_dbo_Sales_by_Category_IR
{
	public Northwind_dbo_Sales_by_Category_IR() 
	{
	} 
	public Northwind_dbo_Sales_by_Category_IR(
		String? categoryID_IR_,
		String? categoryName_,
		String? productName_,
		Decimal? productSales_
	)
	{
		_categoryID_IR = categoryID_IR_;
		CategoryID_IR_OriginalValue = categoryID_IR_;
		_categoryName = categoryName_;
		CategoryName_OriginalValue = categoryName_;
		_productName = productName_;
		ProductName_OriginalValue = productName_;
		_productSales = productSales_;
		ProductSales_OriginalValue = productSales_;
	}
	[JsonConstructor]
	public Northwind_dbo_Sales_by_Category_IR(
		String? CategoryID_IR,
		String? CategoryID_IR_OriginalValue,
		Boolean CategoryID_IR_HasBeenChanged,
		String? CategoryName,
		String? CategoryName_OriginalValue,
		Boolean CategoryName_HasBeenChanged,
		String? ProductName,
		String? ProductName_OriginalValue,
		Boolean ProductName_HasBeenChanged,
		Decimal? ProductSales,
		Decimal? ProductSales_OriginalValue,
		Boolean ProductSales_HasBeenChanged
	)
	{
		this.CategoryID_IR = CategoryID_IR;
		this.CategoryID_IR_OriginalValue = CategoryID_IR_OriginalValue;
		this.CategoryID_IR_HasBeenChanged = CategoryID_IR_HasBeenChanged;
		this.CategoryName = CategoryName;
		this.CategoryName_OriginalValue = CategoryName_OriginalValue;
		this.CategoryName_HasBeenChanged = CategoryName_HasBeenChanged;
		this.ProductName = ProductName;
		this.ProductName_OriginalValue = ProductName_OriginalValue;
		this.ProductName_HasBeenChanged = ProductName_HasBeenChanged;
		this.ProductSales = ProductSales;
		this.ProductSales_OriginalValue = ProductSales_OriginalValue;
		this.ProductSales_HasBeenChanged = ProductSales_HasBeenChanged;
	}
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CategoryID_IR
	{
		get => _categoryID_IR;
		set
		{
			_categoryID_IR = value;
			CategoryID_IR_HasBeenChanged = _categoryID_IR == CategoryID_IR_OriginalValue ? false : true;
		}
	}
	private String? _categoryID_IR;
	public String? CategoryID_IR_OriginalValue { get; private set; }
	public Boolean CategoryID_IR_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? CategoryName
	{
		get => _categoryName;
		set
		{
			_categoryName = value;
			CategoryName_HasBeenChanged = _categoryName == CategoryName_OriginalValue ? false : true;
		}
	}
	private String? _categoryName;
	public String? CategoryName_OriginalValue { get; private set; }
	public Boolean CategoryName_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public String? ProductName
	{
		get => _productName;
		set
		{
			_productName = value;
			ProductName_HasBeenChanged = _productName == ProductName_OriginalValue ? false : true;
		}
	}
	private String? _productName;
	public String? ProductName_OriginalValue { get; private set; }
	public Boolean ProductName_HasBeenChanged { get; private set; }
	/// <summary>
	/// SQL Column Description: N/A
	/// </summary>
	public Decimal? ProductSales
	{
		get => _productSales;
		set
		{
			_productSales = value;
			ProductSales_HasBeenChanged = _productSales == ProductSales_OriginalValue ? false : true;
		}
	}
	private Decimal? _productSales;
	public Decimal? ProductSales_OriginalValue { get; private set; }
	public Boolean ProductSales_HasBeenChanged { get; private set; }
}
