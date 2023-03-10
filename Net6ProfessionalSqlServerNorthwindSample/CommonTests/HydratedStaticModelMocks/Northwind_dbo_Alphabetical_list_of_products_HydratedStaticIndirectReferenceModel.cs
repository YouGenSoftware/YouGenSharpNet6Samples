/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
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
	public Northwind_dbo_Alphabetical_list_of_products_IR GetHydratedStaticNorthwind_dbo_Alphabetical_list_of_products_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Alphabetical_list_of_products_IR();
		retObj.ProductID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.ProductName = "hbvqoo9vT0BP53DNYiIgCGNyhYyW8 3cIm2vbag5";
		retObj.SupplierID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1)) : String.Empty);
		retObj.CategoryID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1)) : String.Empty);
		retObj.QuantityPerUnit = "b10DVlePHJ2P ui8IQRA";
		retObj.UnitPrice = (0.4252918837976385M);
		retObj.UnitsInStock = (-10880);
		retObj.UnitsOnOrder = (28210);
		retObj.ReorderLevel = (6548);
		retObj.Discontinued = (true);
		retObj.CategoryName = "D4t0wUaSF7Cr1f ";
		return retObj;
	}
}
