/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClientTests.HydratedStaticEntities;
public partial class Northwind_HydratedStaticEntities 
{
	public Northwind_dbo_Customers GetHydratedStaticNorthwind_dbo_Customers(Boolean fillPrimaryKey = false)
	{
		var retObj = new Northwind_dbo_Customers();
		retObj.CustomerID = (fillPrimaryKey ? "wYqYe" : String.Empty);
		retObj.CompanyName = "FqLvPxsbMdzpBTI71Q00Cqqh1NHTZ6  3SxLhKHq";
		retObj.ContactName = "y1rmbw xasB3nNbvmzOdXHOGcf2SGA";
		retObj.ContactTitle = "ZQiBlpTCdA1lMJgwqc7Od jtaHdCQP";
		retObj.Address = "kj8qcfu1kd39QJa12C4UvtI9YpzSGnzdprvMq0daBOig3xnAs3FllPdlpsjw";
		retObj.City = "RXdDtvxCjL89oMj";
		retObj.Region = "Lef5tmIARw9o ZQ";
		retObj.PostalCode = "wJY3G0vXyW";
		retObj.Country = "f4yhHp0T oCYUD7";
		retObj.Phone = "QpMrJXqdu8kz7hyREKtVFPY1";
		retObj.Fax = "wkFLW2SVtwYMk8IBCGdpBHit";
		return retObj;
	}
}
