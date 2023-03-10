/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195656 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Northwind_BackEndSqlEntities.Entities;
using Northwind_BackEndCommon.RequestHandlers;
namespace Northwind_BackEndDatabaseClient.Controllers;
[SwaggerTag(@"Controller Description: N/A")]
[RequireHttps]
public class Northwind_dbo_Categories_Controller : ControllerBase
{
	private readonly INorthwind_dbo_Categories_RequestHandler _requestHandler;
	public Northwind_dbo_Categories_Controller(INorthwind_dbo_Categories_RequestHandler requestHandler)
	{
		_requestHandler = requestHandler;
	}
	/// <summary>
	/// Get All records of Categories table
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Categories/GetAll")]
	public async Task<IEnumerable<Northwind_dbo_Categories>?> GetAll()
	{
		return await _requestHandler.HandleGetAll();
	}
	/// <summary>
	/// Get record of Categories table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Categories/GetByCategoryName")]
	public async Task<IEnumerable<Northwind_dbo_Categories>?> GetByCategoryName(String categoryName)
	{
		return await _requestHandler.HandleGetByCategoryName(categoryName);
	}
	/// <summary>
	/// Get record of Categories table by indexed selector(s)
	/// </summary>
	[HttpGet, Route("Northwind_dbo_Categories/GetByCategoryID")]
	public async Task<IEnumerable<Northwind_dbo_Categories>?> GetByCategoryID(Int32 categoryID)
	{
		return await _requestHandler.HandleGetByCategoryID(categoryID);
	}
	/// <summary>
	/// Create and return record of Categories table
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPost, Route("Northwind_dbo_Categories/Create")]
	public async Task<Northwind_dbo_Categories?> Create([FromBody]Northwind_dbo_Categories input)
	{
		return await _requestHandler.HandleCreate(input);
	}
	/// <summary>
	/// Update record of Categories table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Categories/UpdateByCategoryName")]
	public async Task UpdateByCategoryName(String categoryName, [FromBody]Northwind_dbo_Categories input)
	{
		await _requestHandler.HandleUpdateByCategoryName(categoryName, input);
	}
	/// <summary>
	/// Update record of Categories table by indexed selector(s)
	/// Note: Any foreign key data referenced by or referencing these records should not be included in the body payload
	/// </summary>
	[HttpPut, Route("Northwind_dbo_Categories/UpdateByCategoryID")]
	public async Task UpdateByCategoryID(Int32 categoryID, [FromBody]Northwind_dbo_Categories input)
	{
		await _requestHandler.HandleUpdateByCategoryID(categoryID, input);
	}
	/// <summary>
	/// Delete record of Categories table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Categories/DeleteByCategoryName")]
	public async Task DeleteByCategoryName(String categoryName)
	{
		await _requestHandler.HandleDeleteByCategoryName(categoryName);
	}
	/// <summary>
	/// Delete record of Categories table by indexed selector(s)
	/// </summary>
	[HttpDelete, Route("Northwind_dbo_Categories/DeleteByCategoryID")]
	public async Task DeleteByCategoryID(Int32 categoryID)
	{
		await _requestHandler.HandleDeleteByCategoryID(categoryID);
	}
}
