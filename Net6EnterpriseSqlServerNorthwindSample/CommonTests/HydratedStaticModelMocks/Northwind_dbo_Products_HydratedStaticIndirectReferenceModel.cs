/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.Services;
namespace Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
public partial class Northwind_HydratedStaticIndirectReferenceTransformerModels : Northwind_HydratedStaticIndirectReferenceTransformerModelsBase
{
	public Northwind_dbo_Products_IR GetHydratedStaticNorthwind_dbo_Products_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Products_IR();
		retObj.ProductID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.ProductName = "PWdPYMcPjkA4kqib rSbt3pPdmJuc1SWVldNDPE ";
		retObj.SupplierID_IR = _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1));
		retObj.CategoryID_IR = _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1));
		retObj.QuantityPerUnit = "9kflhKdGbIUnVd hrrEX";
		retObj.UnitPrice = (0.32569764042915983M);
		retObj.UnitsInStock = (-23109);
		retObj.UnitsOnOrder = (-10559);
		retObj.ReorderLevel = (4170);
		retObj.Discontinued = (true);
		// Foreign key entities
		retObj.FK_Products_Categories_Ref_IR = GetHydratedStaticNorthwind_dbo_Categories_IR();
		retObj.FK_Products_Suppliers_Ref_IR = GetHydratedStaticNorthwind_dbo_Suppliers_IR();
		return retObj;
	}
}
