/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_BackEndCommon.RequestHandlers;
public interface INorthwind_dbo_Order_Details_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> HandleGetAll();
	Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> HandleGetByOrderIDAndProductID(String? orderID_IR, String? productID_IR);
	Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> HandleGetByOrderID(String? orderID_IR);
	Task<IEnumerable<Northwind_dbo_Order_Details_IR>?> HandleGetByProductID(String? productID_IR);
	Task<Northwind_dbo_Order_Details_IR?> HandleCreate<T>(T irModel) where T : Northwind_dbo_Order_Details_IR;
	Task HandleUpdateByOrderIDAndProductID<T>(String? orderID_IR, String? productID_IR, T irModel) where T: Northwind_dbo_Order_Details_IR;
	Task HandleUpdateByOrderID<T>(String? orderID_IR, T irModel) where T: Northwind_dbo_Order_Details_IR;
	Task HandleUpdateByProductID<T>(String? productID_IR, T irModel) where T: Northwind_dbo_Order_Details_IR;
	Task HandleDeleteByOrderIDAndProductID(String? orderID_IR, String? productID_IR);
	Task HandleDeleteByOrderID(String? orderID_IR);
	Task HandleDeleteByProductID(String? productID_IR);
}
