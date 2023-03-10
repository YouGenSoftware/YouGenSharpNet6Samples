/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202431 on behalf of: ****
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
using XE_HR_BackEndSqlEntities.Entities;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public class XE_HR_LOCATIONS_HttpClient : HttpClientBase, IXE_HR_LOCATIONS_HttpClient
{
	public XE_HR_LOCATIONS_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_LOCATIONS/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_LOCATIONS>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> GetByCITY(String cITY)
	{
		var uri = GetUriForParamsCITY("XE_HR_LOCATIONS/GetByCITY", cITY);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_LOCATIONS>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> GetByCOUNTRY_ID(String? cOUNTRY_ID)
	{
		var uri = GetUriForParamsCOUNTRY_ID("XE_HR_LOCATIONS/GetByCOUNTRY_ID", cOUNTRY_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_LOCATIONS>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> GetByLOCATION_ID(Int32 lOCATION_ID)
	{
		var uri = GetUriForParamsLOCATION_ID("XE_HR_LOCATIONS/GetByLOCATION_ID", lOCATION_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_LOCATIONS>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_LOCATIONS>?> GetBySTATE_PROVINCE(String? sTATE_PROVINCE)
	{
		var uri = GetUriForParamsSTATE_PROVINCE("XE_HR_LOCATIONS/GetBySTATE_PROVINCE", sTATE_PROVINCE);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_LOCATIONS>?>(content, _jsonSerializationSettings);
	}
	public async Task<XE_HR_LOCATIONS?> Create(XE_HR_LOCATIONS input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_LOCATIONS/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<XE_HR_LOCATIONS?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, XE_HR_LOCATIONS updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByLOCATION_ID(Convert.ToInt32(inputSplits[0]), updateModel);
	}
	public async Task UpdateByCITY(String cITY, XE_HR_LOCATIONS input)
	{
		var uri = GetUriForParamsCITY("XE_HR_LOCATIONS/UpdateByCITY", cITY);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByCOUNTRY_ID(String? cOUNTRY_ID, XE_HR_LOCATIONS input)
	{
		var uri = GetUriForParamsCOUNTRY_ID("XE_HR_LOCATIONS/UpdateByCOUNTRY_ID", cOUNTRY_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByLOCATION_ID(Int32 lOCATION_ID, XE_HR_LOCATIONS input)
	{
		var uri = GetUriForParamsLOCATION_ID("XE_HR_LOCATIONS/UpdateByLOCATION_ID", lOCATION_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateBySTATE_PROVINCE(String? sTATE_PROVINCE, XE_HR_LOCATIONS input)
	{
		var uri = GetUriForParamsSTATE_PROVINCE("XE_HR_LOCATIONS/UpdateBySTATE_PROVINCE", sTATE_PROVINCE);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByLOCATION_ID(Convert.ToInt32(inputSplits[0]));
	}
	public async Task DeleteByCITY(String cITY)
	{
		var uri = GetUriForParamsCITY("XE_HR_LOCATIONS/DeleteByCITY", cITY);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByCOUNTRY_ID(String? cOUNTRY_ID)
	{
		var uri = GetUriForParamsCOUNTRY_ID("XE_HR_LOCATIONS/DeleteByCOUNTRY_ID", cOUNTRY_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByLOCATION_ID(Int32 lOCATION_ID)
	{
		var uri = GetUriForParamsLOCATION_ID("XE_HR_LOCATIONS/DeleteByLOCATION_ID", lOCATION_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteBySTATE_PROVINCE(String? sTATE_PROVINCE)
	{
		var uri = GetUriForParamsSTATE_PROVINCE("XE_HR_LOCATIONS/DeleteBySTATE_PROVINCE", sTATE_PROVINCE);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsCITY(String path, String cITY)
	{
		var query = new Dictionary<String,String>();
		query["cITY"] = cITY;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsCOUNTRY_ID(String path, String? cOUNTRY_ID)
	{
		var query = new Dictionary<String,String>();
		query["cOUNTRY_ID"] = cOUNTRY_ID ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsLOCATION_ID(String path, Int32 lOCATION_ID)
	{
		var query = new Dictionary<String,String>();
		query["lOCATION_ID"] = lOCATION_ID.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsSTATE_PROVINCE(String path, String? sTATE_PROVINCE)
	{
		var query = new Dictionary<String,String>();
		query["sTATE_PROVINCE"] = sTATE_PROVINCE ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}
