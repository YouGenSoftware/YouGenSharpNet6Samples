/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195656 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Standard Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Northwind_BackEndSqlEntities.Entities;
namespace Northwind_FrontEndHttpClient.HttpClients;
public class Northwind_dbo_Suppliers_HttpClient : HttpClientBase, INorthwind_dbo_Suppliers_HttpClient
{
	public Northwind_dbo_Suppliers_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_Suppliers>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Suppliers/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Suppliers>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Suppliers>?> GetByCompanyName(String companyName)
	{
		var uri = GetUriForParamsCompanyName("Northwind_dbo_Suppliers/GetByCompanyName", companyName);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Suppliers>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Suppliers>?> GetBySupplierID(Int32 supplierID)
	{
		var uri = GetUriForParamsSupplierID("Northwind_dbo_Suppliers/GetBySupplierID", supplierID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Suppliers>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Suppliers>?> GetByPostalCode(String? postalCode)
	{
		var uri = GetUriForParamsPostalCode("Northwind_dbo_Suppliers/GetByPostalCode", postalCode);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Suppliers>?>(content, _jsonSerializationSettings);
	}
	public async Task<Northwind_dbo_Suppliers?> Create(Northwind_dbo_Suppliers input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Suppliers/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<Northwind_dbo_Suppliers?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_Suppliers updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateBySupplierID(Convert.ToInt32(inputSplits[0]), updateModel);
	}
	public async Task UpdateByCompanyName(String companyName, Northwind_dbo_Suppliers input)
	{
		var uri = GetUriForParamsCompanyName("Northwind_dbo_Suppliers/UpdateByCompanyName", companyName);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateBySupplierID(Int32 supplierID, Northwind_dbo_Suppliers input)
	{
		var uri = GetUriForParamsSupplierID("Northwind_dbo_Suppliers/UpdateBySupplierID", supplierID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByPostalCode(String? postalCode, Northwind_dbo_Suppliers input)
	{
		var uri = GetUriForParamsPostalCode("Northwind_dbo_Suppliers/UpdateByPostalCode", postalCode);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteBySupplierID(Convert.ToInt32(inputSplits[0]));
	}
	public async Task DeleteByCompanyName(String companyName)
	{
		var uri = GetUriForParamsCompanyName("Northwind_dbo_Suppliers/DeleteByCompanyName", companyName);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteBySupplierID(Int32 supplierID)
	{
		var uri = GetUriForParamsSupplierID("Northwind_dbo_Suppliers/DeleteBySupplierID", supplierID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByPostalCode(String? postalCode)
	{
		var uri = GetUriForParamsPostalCode("Northwind_dbo_Suppliers/DeleteByPostalCode", postalCode);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsCompanyName(String path, String companyName)
	{
		var query = new Dictionary<String,String>();
		query["companyName"] = companyName;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsSupplierID(String path, Int32 supplierID)
	{
		var query = new Dictionary<String,String>();
		query["supplierID"] = supplierID.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsPostalCode(String path, String? postalCode)
	{
		var query = new Dictionary<String,String>();
		query["postalCode"] = postalCode ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
