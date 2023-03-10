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
	public Northwind_dbo_Orders_IR GetHydratedStaticNorthwind_dbo_Orders_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Orders_IR();
		retObj.OrderID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.CustomerID = "IwWjD";
		retObj.EmployeeID_IR = _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1));
		retObj.OrderDate = DateTime.Parse("8/21/2016 12:00:00 AM");
		retObj.RequiredDate = DateTime.Parse("7/9/2018 12:00:00 AM");
		retObj.ShippedDate = DateTime.Parse("7/2/2012 12:00:00 AM");
		retObj.ShipVia_IR = _encryptionDecryptionService!.EncInt32Nullable(Convert.ToInt32(1));
		retObj.Freight = (0.552959463639031M);
		retObj.ShipName = "4T4NS5UZZQ7XDk5wdIa0Lg 4 8NMbXU0RcA7 QGp";
		retObj.ShipAddress = "gmvFf4VQ3pOCNZSrjIgiHc0cv94oDRX8OVXM4Q0xaLjfv7TK Q25wYc7v AG";
		retObj.ShipCity = "8ktP8wLK9uZ Hge";
		retObj.ShipRegion = "pId7UpE9hlktEdg";
		retObj.ShipPostalCode = "OSzL3Tj0WA";
		retObj.ShipCountry = "riU8FX7FoTIW5OQ";
		// Foreign key entities
		retObj.FK_Orders_Customers_Ref_IR = GetHydratedStaticNorthwind_dbo_Customers_IR();
		retObj.FK_Orders_Employees_Ref_IR = GetHydratedStaticNorthwind_dbo_Employees_IR();
		retObj.FK_Orders_Shippers_Ref_IR = GetHydratedStaticNorthwind_dbo_Shippers_IR();
		return retObj;
	}
}
