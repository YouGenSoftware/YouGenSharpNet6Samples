/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using XE_HR_BackEndDatabaseClient.Repositories;
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_BackEndCommon.RequestHandlers;
public interface IXE_HR_DEPARTMENTS_RequestHandler
{
	//Main Handlers
	Task<IEnumerable<XE_HR_DEPARTMENTS_IR>?> HandleGetAll();
	Task<IEnumerable<XE_HR_DEPARTMENTS_IR>?> HandleGetByDEPARTMENT_ID(String? dEPARTMENT_ID_IR);
	Task<IEnumerable<XE_HR_DEPARTMENTS_IR>?> HandleGetByLOCATION_ID(String? lOCATION_ID_IR);
	Task<XE_HR_DEPARTMENTS_IR?> HandleCreate<T>(T irModel) where T : XE_HR_DEPARTMENTS_IR;
	Task HandleUpdateByDEPARTMENT_ID<T>(String? dEPARTMENT_ID_IR, T irModel) where T: XE_HR_DEPARTMENTS_IR;
	Task HandleUpdateByLOCATION_ID<T>(String? lOCATION_ID_IR, T irModel) where T: XE_HR_DEPARTMENTS_IR;
	Task HandleDeleteByDEPARTMENT_ID(String? dEPARTMENT_ID_IR);
	Task HandleDeleteByLOCATION_ID(String? lOCATION_ID_IR);
}
