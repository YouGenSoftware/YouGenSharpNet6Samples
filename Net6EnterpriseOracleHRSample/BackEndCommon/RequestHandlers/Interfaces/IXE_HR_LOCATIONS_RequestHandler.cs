/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_BackEndCommon.RequestHandlers;
public interface IXE_HR_LOCATIONS_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<XE_HR_LOCATIONS_IR>?> HandleGetAll();
	Task<IEnumerable<XE_HR_LOCATIONS_IR>?> HandleGetByCITY(String cITY);
	Task<IEnumerable<XE_HR_LOCATIONS_IR>?> HandleGetByCOUNTRY_ID(String? cOUNTRY_ID);
	Task<IEnumerable<XE_HR_LOCATIONS_IR>?> HandleGetByLOCATION_ID(String? lOCATION_ID_IR);
	Task<IEnumerable<XE_HR_LOCATIONS_IR>?> HandleGetBySTATE_PROVINCE(String? sTATE_PROVINCE);
	Task<XE_HR_LOCATIONS_IR?> HandleCreate<T>(T irModel) where T : XE_HR_LOCATIONS_IR;
	Task HandleUpdateByCITY<T>(String cITY, T irModel) where T: XE_HR_LOCATIONS_IR;
	Task HandleUpdateByCOUNTRY_ID<T>(String? cOUNTRY_ID, T irModel) where T: XE_HR_LOCATIONS_IR;
	Task HandleUpdateByLOCATION_ID<T>(String? lOCATION_ID_IR, T irModel) where T: XE_HR_LOCATIONS_IR;
	Task HandleUpdateBySTATE_PROVINCE<T>(String? sTATE_PROVINCE, T irModel) where T: XE_HR_LOCATIONS_IR;
	Task HandleDeleteByCITY(String cITY);
	Task HandleDeleteByCOUNTRY_ID(String? cOUNTRY_ID);
	Task HandleDeleteByLOCATION_ID(String? lOCATION_ID_IR);
	Task HandleDeleteBySTATE_PROVINCE(String? sTATE_PROVINCE);
}