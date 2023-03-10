/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
// For reads only
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: View Description: N/A
/// </summary>
public class Northwind_dbo_Quarterly_Orders 
{
	public Northwind_dbo_Quarterly_Orders()
	{
	} 
	public Northwind_dbo_Quarterly_Orders(
		String? customerID_,
		String? companyName_,
		String? city_,
		String? country_
	)
	{
		CustomerID = customerID_;
		CompanyName = companyName_;
		City = city_;
		Country = country_;
	}
	/// <summary>
	/// SQL Data Type: nchar Chars: 5 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? CustomerID { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 40 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? CompanyName { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? City { get; set; }
	/// <summary>
	/// SQL Data Type: nvarchar Chars: 15 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String? Country { get; set; }
}
