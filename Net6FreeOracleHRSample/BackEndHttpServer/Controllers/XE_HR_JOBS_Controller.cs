/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307201813 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using XE_HR_BackEndSqlEntities.Entities;
using XE_HR_BackEndCommon.RequestHandlers;
namespace XE_HR_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: jobs table with job titles and salary ranges. Contains 19 rows.References with employees and job_history table.")]
[RequireHttps]
public class XE_HR_JOBS_Controller : ControllerBase
{
	private readonly IXE_HR_JOBS_RequestHandler _requestHandler;
	public XE_HR_JOBS_Controller(IXE_HR_JOBS_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of JOBS table
	/// </summary>
	[HttpGet, Route("XE_HR_JOBS/GetAll")]
	public async Task<IEnumerable<XE_HR_JOBS>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of JOBS table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("XE_HR_JOBS/GetByJOB_ID")]
	public async Task<IEnumerable<XE_HR_JOBS>?> GetByJOB_ID(String jOB_ID)
	{
		return await _requestHandler.HandleGetByJOB_ID(jOB_ID);
	}
	/// <summary>
	/// Create and return record of JOBS table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("XE_HR_JOBS/Create")]
	public async Task<XE_HR_JOBS?> Create([FromBody]XE_HR_JOBS input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of JOBS table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("XE_HR_JOBS/UpdateByJOB_ID")]
	public async Task UpdateByJOB_ID(String jOB_ID, [FromBody]XE_HR_JOBS input)
	{
		await _requestHandler.HandleUpdateByJOB_ID(jOB_ID, input);
	}
	/// <summary>
	/// Delete record of JOBS table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("XE_HR_JOBS/DeleteByJOB_ID")]
	public async Task DeleteByJOB_ID(String jOB_ID)
	{
		await _requestHandler.HandleDeleteByJOB_ID(jOB_ID);
	}
}
