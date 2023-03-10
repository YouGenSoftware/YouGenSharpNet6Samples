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
public interface INorthwind_dbo_CustomerCustomerDemo_Service
{
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_CustomerCustomerDemo_IR>?> GetAll();
	[OperationContract]
	Task<IEnumerable<Northwind_dbo_CustomerCustomerDemo_IR>?> GetByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID);
	[OperationContract]
	Task<Northwind_dbo_CustomerCustomerDemo_IR?> Create(Northwind_dbo_CustomerCustomerDemo_IR input);
	[OperationContract]
	Task UpdateByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID, Northwind_dbo_CustomerCustomerDemo_IR input);
	[OperationContract]
	Task DeleteByCustomerIDAndCustomerTypeID(String customerID, String customerTypeID);
}
