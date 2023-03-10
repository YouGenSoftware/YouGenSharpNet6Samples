/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public interface IXE_HR_LOCATIONS_HttpClient
{
	Task<IEnumerable<XE_HR_LOCATIONS_IR>?> GetAll();
	Task<IEnumerable<XE_HR_LOCATIONS_IR>?> GetByBestMatchedQueryPattern(XE_HR_LOCATIONS_IR input);
	Task<IEnumerable<XE_HR_LOCATIONS_IR>?> GetByCITY(String cITY);
	Task<IEnumerable<XE_HR_LOCATIONS_IR>?> GetByCOUNTRY_ID(String? cOUNTRY_ID);
	Task<IEnumerable<XE_HR_LOCATIONS_IR>?> GetByLOCATION_ID(String? lOCATION_ID_IR);
	Task<IEnumerable<XE_HR_LOCATIONS_IR>?> GetBySTATE_PROVINCE(String? sTATE_PROVINCE);
	Task<XE_HR_LOCATIONS_IR?> Create(XE_HR_LOCATIONS_IR input);
	Task UpdateByCITY(String cITY, XE_HR_LOCATIONS_IR input);
	Task UpdateByCOUNTRY_ID(String? cOUNTRY_ID, XE_HR_LOCATIONS_IR input);
	Task UpdateByLOCATION_ID(String? lOCATION_ID_IR, XE_HR_LOCATIONS_IR input);
	Task UpdateBySTATE_PROVINCE(String? sTATE_PROVINCE, XE_HR_LOCATIONS_IR input);
	Task DeleteByCITY(String cITY);
	Task DeleteByCOUNTRY_ID(String? cOUNTRY_ID);
	Task DeleteByLOCATION_ID(String? lOCATION_ID_IR);
	Task DeleteBySTATE_PROVINCE(String? sTATE_PROVINCE);
}
