/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195656 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel.DataAnnotations.Schema;
namespace Northwind_BackEndSqlEntities.Entities;
/// <summary>
/// SQL Entity Description: Table Description: N/A
/// </summary>
public class Northwind_dbo_EmployeeTerritories 
{
	public Northwind_dbo_EmployeeTerritories()
	{
	} 
	/// <summary>
	/// Primary Key Column
	/// Foreign Key Column
	/// SQL Data Type: int Precision: 10 Scale: 0 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual Int32 EmployeeID { get; set; }
	/// <summary>
	/// Primary Key Column
	/// Foreign Key Column
	/// SQL Data Type: nvarchar Chars: 20 
	/// SQL Default Value: N/A
	/// SQL Column Description: N/A
	/// </summary>
	public virtual String TerritoryID { get; set; } = null!;
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	public virtual Northwind_dbo_Employees? FK_EmployeeTerritories_Employees_Ref { get; set; }
	/// <summary>
	/// Foreign key entity
	/// </summary>
	/// <example>null</example>
	public virtual Northwind_dbo_Territories? FK_EmployeeTerritories_Territories_Ref { get; set; }
}
