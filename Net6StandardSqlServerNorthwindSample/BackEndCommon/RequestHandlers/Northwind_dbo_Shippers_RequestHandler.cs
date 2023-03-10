/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195656 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Northwind_BackEndDatabaseClient.Repositories;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndCommon.RequestHandlers;
public class Northwind_dbo_Shippers_RequestHandler : INorthwind_dbo_Shippers_RequestHandler
{
    private readonly ILogger<Northwind_dbo_Shippers_RequestHandler> _logger;
    private readonly INorthwind_dbo_Shippers_Repository _repository;
    public Northwind_dbo_Shippers_RequestHandler(
    ILogger<Northwind_dbo_Shippers_RequestHandler> logger
    ,INorthwind_dbo_Shippers_Repository repository)
    {
        _logger = logger;
        _repository = repository;
    }
	//Main Handlers
	public async Task<IEnumerable<Northwind_dbo_Shippers>?> HandleGetAll()
	{
		var retData = await _repository.GetAll();
		return retData;
	}
	public async Task<IEnumerable<Northwind_dbo_Shippers>?> HandleGetByShipperID(Int32 shipperID)
	{
		var retData = await _repository.GetByShipperID(shipperID);
		return retData;
	}
	public async Task<Northwind_dbo_Shippers?> HandleCreate(Northwind_dbo_Shippers input)
	{
		var results = await _repository.Create(input);
		return results;
	}
	public async Task HandleUpdateByShipperID(Int32 shipperID, Northwind_dbo_Shippers entity)
	{
		await _repository.UpdateByShipperID(shipperID, entity);
	}
	public async Task HandleDeleteByShipperID(Int32 shipperID)
	{
		await _repository.DeleteByShipperID(shipperID);
	}
}
