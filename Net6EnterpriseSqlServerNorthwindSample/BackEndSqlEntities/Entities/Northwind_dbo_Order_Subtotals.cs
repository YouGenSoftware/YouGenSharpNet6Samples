/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
// For reads only
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: View Description: N/A
/// </summary>
public class Northwind_dbo_Order_Subtotals 
{
	public Northwind_dbo_Order_Subtotals()
	{
	} 
	public Northwind_dbo_Order_Subtotals(
		Int32 orderID_,
		Decimal? subtotal_
	)
	{
		OrderID = orderID_;
		Subtotal = subtotal_;
	}
	/// <summary>
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32 OrderID { get; set; }
	/// <summary>
	/// SQL Data Type: money Precision: 19 Scale: 4 
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Decimal? Subtotal { get; set; }
}
