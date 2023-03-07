/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Northwind_Common.IndirectReferenceTransformerModels;
namespace Northwind_FrontEndHttpClient.HttpClients;
public class Northwind_dbo_Customers_HttpClient : HttpClientBase, INorthwind_dbo_Customers_HttpClient
{
	public Northwind_dbo_Customers_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByBestMatchedQueryPattern(Northwind_dbo_Customers_IR input)
	{
		if (input == null) return null;
		IEnumerable<Northwind_dbo_Customers_IR>? retData;
		if (input.City_HasBeenChanged) retData = await GetByCity(input.City);
		else if (input.CompanyName_HasBeenChanged) retData = await GetByCompanyName(input.CompanyName ?? String.Empty);
		else if (input.CustomerID_HasBeenChanged) retData = await GetByCustomerID(input.CustomerID ?? String.Empty);
		else if (input.PostalCode_HasBeenChanged) retData = await GetByPostalCode(input.PostalCode);
		else if (input.Region_HasBeenChanged) retData = await GetByRegion(input.Region);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(Northwind_dbo_Customers_IR record, Northwind_dbo_Customers_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.CompanyName_HasBeenChanged || record.CompanyName == filter.CompanyName) &&
			(!filter.ContactName_HasBeenChanged || record.ContactName == filter.ContactName) &&
			(!filter.ContactTitle_HasBeenChanged || record.ContactTitle == filter.ContactTitle) &&
			(!filter.Address_HasBeenChanged || record.Address == filter.Address) &&
			(!filter.City_HasBeenChanged || record.City == filter.City) &&
			(!filter.Region_HasBeenChanged || record.Region == filter.Region) &&
			(!filter.PostalCode_HasBeenChanged || record.PostalCode == filter.PostalCode) &&
			(!filter.Country_HasBeenChanged || record.Country == filter.Country) &&
			(!filter.Phone_HasBeenChanged || record.Phone == filter.Phone) &&
			(!filter.Fax_HasBeenChanged || record.Fax == filter.Fax);
	}
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Customers/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Customers_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCity(String? city)
	{
		var uri = GetUriForParamsCity("Northwind_dbo_Customers/GetByCity", city);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Customers_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCompanyName(String companyName)
	{
		var uri = GetUriForParamsCompanyName("Northwind_dbo_Customers/GetByCompanyName", companyName);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Customers_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByCustomerID(String customerID)
	{
		var uri = GetUriForParamsCustomerID("Northwind_dbo_Customers/GetByCustomerID", customerID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Customers_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByPostalCode(String? postalCode)
	{
		var uri = GetUriForParamsPostalCode("Northwind_dbo_Customers/GetByPostalCode", postalCode);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Customers_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<Northwind_dbo_Customers_IR>?> GetByRegion(String? region)
	{
		var uri = GetUriForParamsRegion("Northwind_dbo_Customers/GetByRegion", region);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<Northwind_dbo_Customers_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<Northwind_dbo_Customers_IR?> Create(Northwind_dbo_Customers_IR input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "Northwind_dbo_Customers/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<Northwind_dbo_Customers_IR?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, Northwind_dbo_Customers_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByCustomerID(inputSplits[0], updateModel);
	}
	public async Task UpdateByCity(String? city, Northwind_dbo_Customers_IR input)
	{
		var uri = GetUriForParamsCity("Northwind_dbo_Customers/UpdateByCity", city);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByCompanyName(String companyName, Northwind_dbo_Customers_IR input)
	{
		var uri = GetUriForParamsCompanyName("Northwind_dbo_Customers/UpdateByCompanyName", companyName);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByCustomerID(String customerID, Northwind_dbo_Customers_IR input)
	{
		var uri = GetUriForParamsCustomerID("Northwind_dbo_Customers/UpdateByCustomerID", customerID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByPostalCode(String? postalCode, Northwind_dbo_Customers_IR input)
	{
		var uri = GetUriForParamsPostalCode("Northwind_dbo_Customers/UpdateByPostalCode", postalCode);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByRegion(String? region, Northwind_dbo_Customers_IR input)
	{
		var uri = GetUriForParamsRegion("Northwind_dbo_Customers/UpdateByRegion", region);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByCustomerID(inputSplits[0]);
	}
	public async Task DeleteByCity(String? city)
	{
		var uri = GetUriForParamsCity("Northwind_dbo_Customers/DeleteByCity", city);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByCompanyName(String companyName)
	{
		var uri = GetUriForParamsCompanyName("Northwind_dbo_Customers/DeleteByCompanyName", companyName);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByCustomerID(String customerID)
	{
		var uri = GetUriForParamsCustomerID("Northwind_dbo_Customers/DeleteByCustomerID", customerID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByPostalCode(String? postalCode)
	{
		var uri = GetUriForParamsPostalCode("Northwind_dbo_Customers/DeleteByPostalCode", postalCode);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByRegion(String? region)
	{
		var uri = GetUriForParamsRegion("Northwind_dbo_Customers/DeleteByRegion", region);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsCity(String path, String? city)
	{
		var query = new Dictionary<String,String>();
		query["city"] = city ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsCompanyName(String path, String companyName)
	{
		var query = new Dictionary<String,String>();
		query["companyName"] = companyName;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsCustomerID(String path, String customerID)
	{
		var query = new Dictionary<String,String>();
		query["customerID"] = customerID;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsPostalCode(String path, String? postalCode)
	{
		var query = new Dictionary<String,String>();
		query["postalCode"] = postalCode ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsRegion(String path, String? region)
	{
		var query = new Dictionary<String,String>();
		query["region"] = region ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}