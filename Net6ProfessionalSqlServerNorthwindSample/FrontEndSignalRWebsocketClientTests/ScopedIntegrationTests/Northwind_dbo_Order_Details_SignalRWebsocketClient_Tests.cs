/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Northwind_Common.IndirectReferenceTransformerModels;
using Northwind_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
using Northwind_FrontEndSignalRWebsocketClientTests;
using Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
using Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
namespace Northwind_FrontEndSignalRWebsocketClientTests.ScopedIntegrationTests;
[TestClass()]
public class Northwind_dbo_Order_Details_SignalRWebsocketClient_Tests : SignalRWebsocketClientTestBase
{   
	protected INorthwind_dbo_Order_Details_SignalRWebsocketClient? _signalRWebsocketClient;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override async Task Init()
    {
        await base.Init();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
        _signalRWebsocketClient = new Northwind_dbo_Order_Details_SignalRWebsocketClient(_hubUriBase + "/Northwind_dbo_Order_Details_Hub");
        await _signalRWebsocketClient.InitializeAsync();
    }
    [TestCleanup()]
    public virtual async Task TestCleanup()
    {
        await _signalRWebsocketClient!.DisposeAsync();
    }
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await _signalRWebsocketClient!.GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _signalRWebsocketClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _signalRWebsocketClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByOrderIDAndProductIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByOrderIDAndProductID(input.OrderID_IR ?? String.Empty, input.ProductID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByOrderIDAndProductIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByOrderIDAndProductID(input.OrderID_IR ?? String.Empty, input.ProductID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByOrderIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByOrderIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByProductIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByProductID(input.ProductID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByProductIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		var retData = await _signalRWebsocketClient!.GetByProductID(input.ProductID_IR ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByOrderIDAndProductIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		await _signalRWebsocketClient!.UpdateByOrderIDAndProductID(input.OrderID_IR ?? String.Empty, input.ProductID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByOrderIDAndProductIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		await _signalRWebsocketClient!.UpdateByOrderIDAndProductID(input.OrderID_IR ?? String.Empty, input.ProductID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByOrderIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		await _signalRWebsocketClient!.UpdateByOrderID(input.OrderID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByOrderIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		await _signalRWebsocketClient!.UpdateByOrderID(input.OrderID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByProductIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		await _signalRWebsocketClient!.UpdateByProductID(input.ProductID_IR ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByProductIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		await _signalRWebsocketClient!.UpdateByProductID(input.ProductID_IR ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderIDAndProductIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		await _signalRWebsocketClient!.DeleteByOrderIDAndProductID(input.OrderID_IR ?? String.Empty, input.ProductID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderIDAndProductIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		await _signalRWebsocketClient!.DeleteByOrderIDAndProductID(input.OrderID_IR ?? String.Empty, input.ProductID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		await _signalRWebsocketClient!.DeleteByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByOrderIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		await _signalRWebsocketClient!.DeleteByOrderID(input.OrderID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByProductIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Order_Details_IR();
		// When
		await _signalRWebsocketClient!.DeleteByProductID(input.ProductID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByProductIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Order_Details_IR();
		// When
		await _signalRWebsocketClient!.DeleteByProductID(input.ProductID_IR ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
}
