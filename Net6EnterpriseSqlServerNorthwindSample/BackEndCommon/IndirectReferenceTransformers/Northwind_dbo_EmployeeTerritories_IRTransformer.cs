/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCommon.IndirectReferenceTransformers;
public partial class IRTransformers : IIRTransformers
{
	public Northwind_dbo_EmployeeTerritories_IR ToIndirectModel(Northwind_dbo_EmployeeTerritories input, Boolean isSecondaryLookup = false)
	{
		var retData = new Northwind_dbo_EmployeeTerritories_IR(
			employeeID_IR_ : _encryptionDecryptionService!.EncInt32(input.EmployeeID),
			territoryID_ : input.TerritoryID
			);
		if (input.FK_EmployeeTerritories_Employees_Ref != null) retData.FK_EmployeeTerritories_Employees_Ref_IR = ToIndirectModel(input.FK_EmployeeTerritories_Employees_Ref!, true);
		if (input.FK_EmployeeTerritories_Territories_Ref != null) retData.FK_EmployeeTerritories_Territories_Ref_IR = ToIndirectModel(input.FK_EmployeeTerritories_Territories_Ref!, true);
			retData.PrimaryKeyHashedForUniqueObjectComparison = _encryptionDecryptionService!.CreateHash(retData.EmployeeID_IR + (Char)27 + retData.TerritoryID);
		return retData;
	}
	public Northwind_dbo_EmployeeTerritories ToEntity(Northwind_dbo_EmployeeTerritories_IR input, Boolean isSecondaryLookup = false)
	{
		var retData = new Northwind_dbo_EmployeeTerritories(		
			employeeID_ : _encryptionDecryptionService.DecInt32(input.EmployeeID_IR),
			territoryID_ : input.TerritoryID ?? String.Empty
			);
		if (input.FK_EmployeeTerritories_Employees_Ref_IR != null) retData.FK_EmployeeTerritories_Employees_Ref = ToEntity(input.FK_EmployeeTerritories_Employees_Ref_IR!, true);
		if (input.FK_EmployeeTerritories_Territories_Ref_IR != null) retData.FK_EmployeeTerritories_Territories_Ref = ToEntity(input.FK_EmployeeTerritories_Territories_Ref_IR!, true);
		return retData;
	}
}
