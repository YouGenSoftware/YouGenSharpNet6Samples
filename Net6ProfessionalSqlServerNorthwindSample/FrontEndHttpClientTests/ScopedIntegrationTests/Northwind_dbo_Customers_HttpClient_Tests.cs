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
using Northwind_FrontEndHttpClient.HttpClients;
using Northwind_FrontEndHttpClientTests;
using Northwind_CommonTests.HydratedDynamicIndirectReferenceTransformerModels;
using Northwind_CommonTests.HydratedStaticIndirectReferenceTransformerModels;
namespace Northwind_FrontEndHttpClientTests.ScopedIntegrationTests;
[TestClass()]
public class Northwind_dbo_Customers_HttpClient_Tests : HttpClientTestBase
{
	protected INorthwind_dbo_Customers_HttpClient? _specificHttpClient;
	private Northwind_HydratedDynamicIndirectReferenceTransformerModels? _dynamicIRModels;
	private Northwind_HydratedStaticIndirectReferenceTransformerModels? _staticIRModels;
	[TestInitialize()]
    public override void Init()
    {
        base.Init();
		_dynamicIRModels = new Northwind_HydratedDynamicIndirectReferenceTransformerModels();
		_staticIRModels = new Northwind_HydratedStaticIndirectReferenceTransformerModels();
        _specificHttpClient = new Northwind_dbo_Customers_HttpClient(_httpClient!);
    }
	[TestMethod()]
	public async Task GetAllTest()
	{
		// When
		var retData = await _specificHttpClient!.GetAll();
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		var retData = await _specificHttpClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task CreateStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		var retData = await _specificHttpClient!.Create(input);
		// Then
		Assert.IsTrue(retData != null);
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCityDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		var retData = await _specificHttpClient!.GetByCity(input.City);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCityStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		var retData = await _specificHttpClient!.GetByCity(input.City);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCompanyNameDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		var retData = await _specificHttpClient!.GetByCompanyName(input.CompanyName ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCompanyNameStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		var retData = await _specificHttpClient!.GetByCompanyName(input.CompanyName ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCustomerIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		var retData = await _specificHttpClient!.GetByCustomerID(input.CustomerID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByCustomerIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		var retData = await _specificHttpClient!.GetByCustomerID(input.CustomerID ?? String.Empty);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		var retData = await _specificHttpClient!.GetByPostalCode(input.PostalCode);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		var retData = await _specificHttpClient!.GetByPostalCode(input.PostalCode);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByRegionDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		var retData = await _specificHttpClient!.GetByRegion(input.Region);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task GetByRegionStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		var retData = await _specificHttpClient!.GetByRegion(input.Region);
		// Then
		Assert.IsTrue(retData != null && retData.Any());
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCityDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.UpdateByCity(input.City, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCityStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.UpdateByCity(input.City, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCompanyNameDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.UpdateByCompanyName(input.CompanyName ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCompanyNameStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.UpdateByCompanyName(input.CompanyName ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCustomerIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.UpdateByCustomerID(input.CustomerID ?? String.Empty, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByCustomerIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.UpdateByCustomerID(input.CustomerID ?? String.Empty, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.UpdateByPostalCode(input.PostalCode, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.UpdateByPostalCode(input.PostalCode, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByRegionDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		var input2 = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.UpdateByRegion(input.Region, input2);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task UpdateByRegionStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.UpdateByRegion(input.Region, input);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCityDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.DeleteByCity(input.City);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCityStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.DeleteByCity(input.City);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCompanyNameDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.DeleteByCompanyName(input.CompanyName ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCompanyNameStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.DeleteByCompanyName(input.CompanyName ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerIDDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.DeleteByCustomerID(input.CustomerID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByCustomerIDStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.DeleteByCustomerID(input.CustomerID ?? String.Empty);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByPostalCodeDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.DeleteByPostalCode(input.PostalCode);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByPostalCodeStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.DeleteByPostalCode(input.PostalCode);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByRegionDynamicTest()
	{
		// Given
		var input = _dynamicIRModels!.GetHydratedDynamicNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.DeleteByRegion(input.Region);
		// Then
		// TODO: Add test cases
	}
	[TestMethod()]
	public async Task DeleteByRegionStaticTest()
	{
		// Given
		var input = _staticIRModels!.GetHydratedStaticNorthwind_dbo_Customers_IR();
		// When
		await _specificHttpClient!.DeleteByRegion(input.Region);
		// Then
		// TODO: Add test cases
	}
}
