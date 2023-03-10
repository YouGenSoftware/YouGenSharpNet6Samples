/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202431 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public interface IXE_HR_JOBS_HttpClient
{
	Task<IEnumerable<XE_HR_JOBS>?> GetAll();
	Task<IEnumerable<XE_HR_JOBS>?> GetByJOB_ID(String jOB_ID);
	Task<XE_HR_JOBS?> Create(XE_HR_JOBS input);
	Task UpdateByJOB_ID(String jOB_ID, XE_HR_JOBS input);
	Task DeleteByJOB_ID(String jOB_ID);
}
