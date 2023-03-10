/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195435 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Free Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use for evaluation purposes only. ****
**** This comment block must not be removed. ****
 */
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Z.EntityFramework.Plus;
using Northwind_BackEndDatabaseClient;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_BackEndDatabaseClient.Repositories;
public class Northwind_dbo_Order_Details_Repository : GenericTableRepository<Northwind_dbo_Order_Details>, INorthwind_dbo_Order_Details_Repository
{
    private readonly ILogger<Northwind_dbo_Order_Details_Repository> _logger;    
    public Northwind_dbo_Order_Details_Repository
    (
        ILogger<Northwind_dbo_Order_Details_Repository> logger
        ,Northwind_Context dbContext
    ) : base(dbContext)
    {
        _logger = logger;
    }
	public async Task<IEnumerable<Northwind_dbo_Order_Details>?> GetByOrderIDAndProductID(Int32 orderID_, Int32 productID_)
	{
		return await _dbContext.Northwind_dbo_Order_Details!
			.Where(x => x.OrderID == orderID_ && x.ProductID == productID_)
			.Include(x => x.FK_Order_Details_Orders_Ref)
			.Include(x => x.FK_Order_Details_Products_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details>?> GetByOrderID(Int32 orderID_)
	{
		return await _dbContext.Northwind_dbo_Order_Details!
			.Where(x => x.OrderID == orderID_)
			.Include(x => x.FK_Order_Details_Orders_Ref)
			.Include(x => x.FK_Order_Details_Products_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details>?> GetByProductID(Int32 productID_)
	{
		return await _dbContext.Northwind_dbo_Order_Details!
			.Where(x => x.ProductID == productID_)
			.Include(x => x.FK_Order_Details_Orders_Ref)
			.Include(x => x.FK_Order_Details_Products_Ref)
			.AsNoTracking()
			.ToListAsync();
	}
	public async Task UpdateByOrderIDAndProductID(Int32 orderID_, Int32 productID_, Northwind_dbo_Order_Details entity)
	{
		await _dbContext.Northwind_dbo_Order_Details!
			.Where(x => x.OrderID == orderID_ && x.ProductID == productID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Order_Details(){ UnitPrice = entity.UnitPrice, Quantity = entity.Quantity, Discount = entity.Discount });
	}
	public async Task UpdateByOrderID(Int32 orderID_, Northwind_dbo_Order_Details entity)
	{
		await _dbContext.Northwind_dbo_Order_Details!
			.Where(x => x.OrderID == orderID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Order_Details(){ UnitPrice = entity.UnitPrice, Quantity = entity.Quantity, Discount = entity.Discount });
	}
	public async Task UpdateByProductID(Int32 productID_, Northwind_dbo_Order_Details entity)
	{
		await _dbContext.Northwind_dbo_Order_Details!
			.Where(x => x.ProductID == productID_)
			.UpdateFromQueryAsync(x => new Northwind_dbo_Order_Details(){ UnitPrice = entity.UnitPrice, Quantity = entity.Quantity, Discount = entity.Discount });
	}
	public async Task DeleteByOrderIDAndProductID(Int32 orderID_, Int32 productID_)
	{
		await _dbContext.Northwind_dbo_Order_Details!
			.Where(x => x.OrderID == orderID_ && x.ProductID == productID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByOrderID(Int32 orderID_)
	{
		await _dbContext.Northwind_dbo_Order_Details!
			.Where(x => x.OrderID == orderID_)
			.DeleteFromQueryAsync();
	}
	public async Task DeleteByProductID(Int32 productID_)
	{
		await _dbContext.Northwind_dbo_Order_Details!
			.Where(x => x.ProductID == productID_)
			.DeleteFromQueryAsync();
	}
}
