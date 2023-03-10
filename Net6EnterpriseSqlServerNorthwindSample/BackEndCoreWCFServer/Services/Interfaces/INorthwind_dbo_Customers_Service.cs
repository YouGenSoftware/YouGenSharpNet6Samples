/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCoreWCFServer.Services;
[ServiceContract]
public interface INorthwind_dbo_Customers_Service
{
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetAll();
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCity(String? city);
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCompanyName(String companyName);
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCustomerID(String customerID);
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByPostalCode(String? postalCode);
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByRegion(String? region);
	[OperationContract]
	Task<Northwind_dbo_Customers_IR?> Create(Northwind_dbo_Customers_IR input);
	[OperationContract]
	Task UpdateByCity(String? city, Northwind_dbo_Customers_IR input);
	[OperationContract]
	Task UpdateByCompanyName(String companyName, Northwind_dbo_Customers_IR input);
	[OperationContract]
	Task UpdateByCustomerID(String customerID, Northwind_dbo_Customers_IR input);
	[OperationContract]
	Task UpdateByPostalCode(String? postalCode, Northwind_dbo_Customers_IR input);
	[OperationContract]
	Task UpdateByRegion(String? region, Northwind_dbo_Customers_IR input);
	[OperationContract]
	Task DeleteByCity(String? city);
	[OperationContract]
	Task DeleteByCompanyName(String companyName);
	[OperationContract]
	Task DeleteByCustomerID(String customerID);
	[OperationContract]
	Task DeleteByPostalCode(String? postalCode);
	[OperationContract]
	Task DeleteByRegion(String? region);
}
