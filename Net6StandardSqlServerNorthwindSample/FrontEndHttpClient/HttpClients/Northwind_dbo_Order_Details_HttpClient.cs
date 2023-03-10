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
public class Northwind_dbo_Order_Details_HttpClient : HttpClientBase, INorthwind_dbo_Order_Details_HttpClient
{
	public Northwind_dbo_Order_Details_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_Order_Details>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Order_Details/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Order_Details>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details>?> GetByOrderIDAndProductID(Int32 orderID, Int32 productID)
	{
		var uri = GetUriForParamsOrderIDAndProductID("Northwind_dbo_Order_Details/GetByOrderIDAndProductID", orderID, productID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Order_Details>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details>?> GetByOrderID(Int32 orderID)
	{
		var uri = GetUriForParamsOrderID("Northwind_dbo_Order_Details/GetByOrderID", orderID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Order_Details>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Order_Details>?> GetByProductID(Int32 productID)
	{
		var uri = GetUriForParamsProductID("Northwind_dbo_Order_Details/GetByProductID", productID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Order_Details>?>(content, _jsonSerializationSettings);
	}
	public async Task<Northwind_dbo_Order_Details?> Create(Northwind_dbo_Order_Details input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Order_Details/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<Northwind_dbo_Order_Details?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_Order_Details updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByOrderIDAndProductID(Convert.ToInt32(inputSplits[0]), Convert.ToInt32(inputSplits[1]), updateModel);
	}
	public async Task UpdateByOrderIDAndProductID(Int32 orderID, Int32 productID, Northwind_dbo_Order_Details input)
	{
		var uri = GetUriForParamsOrderIDAndProductID("Northwind_dbo_Order_Details/UpdateByOrderIDAndProductID", orderID, productID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByOrderID(Int32 orderID, Northwind_dbo_Order_Details input)
	{
		var uri = GetUriForParamsOrderID("Northwind_dbo_Order_Details/UpdateByOrderID", orderID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByProductID(Int32 productID, Northwind_dbo_Order_Details input)
	{
		var uri = GetUriForParamsProductID("Northwind_dbo_Order_Details/UpdateByProductID", productID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByOrderIDAndProductID(Convert.ToInt32(inputSplits[0]), Convert.ToInt32(inputSplits[1]));
	}
	public async Task DeleteByOrderIDAndProductID(Int32 orderID, Int32 productID)
	{
		var uri = GetUriForParamsOrderIDAndProductID("Northwind_dbo_Order_Details/DeleteByOrderIDAndProductID", orderID, productID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByOrderID(Int32 orderID)
	{
		var uri = GetUriForParamsOrderID("Northwind_dbo_Order_Details/DeleteByOrderID", orderID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByProductID(Int32 productID)
	{
		var uri = GetUriForParamsProductID("Northwind_dbo_Order_Details/DeleteByProductID", productID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsOrderIDAndProductID(String path, Int32 orderID, Int32 productID)
	{
		var query = new Dictionary<String,String>();
		query["orderID"] = orderID.ToString();
		query["productID"] = productID.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsOrderID(String path, Int32 orderID)
	{
		var query = new Dictionary<String,String>();
		query["orderID"] = orderID.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsProductID(String path, Int32 productID)
	{
		var query = new Dictionary<String,String>();
		query["productID"] = productID.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
