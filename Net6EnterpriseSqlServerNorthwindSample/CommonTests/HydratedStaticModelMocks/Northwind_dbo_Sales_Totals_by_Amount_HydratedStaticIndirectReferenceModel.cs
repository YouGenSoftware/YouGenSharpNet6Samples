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
	public Northwind_dbo_Sales_Totals_by_Amount_IR GetHydratedStaticNorthwind_dbo_Sales_Totals_by_Amount_IR(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Sales_Totals_by_Amount_IR();
		retObj.SaleAmount = (0.5235266646925696M);
		retObj.OrderID_IR = (fillPrimaryKey ? _encryptionDecryptionService!.EncInt32(Convert.ToInt32(1)) : String.Empty);
		retObj.CompanyName = "A7gETRJbhkmn5bYEtfUHy4HhygbhvwJUtQo0Dylz";
		retObj.ShippedDate = DateTime.Parse("6/1/2012 12:00:00 AM");
		return retObj;
	}
}
