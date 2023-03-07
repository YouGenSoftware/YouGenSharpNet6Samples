/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202605 on behalf of: ****
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
using XE_HR_Common.IndirectReferenceTransformerModels;
namespace XE_HR_FrontEndHttpClient.HttpClients;
public class XE_HR_JOB_HISTORY_HttpClient : HttpClientBase, IXE_HR_JOB_HISTORY_HttpClient
{
	public XE_HR_JOB_HISTORY_HttpClient(HttpClient httpClient) : base(httpClient)
    {            
    }
	public async Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByBestMatchedQueryPattern(XE_HR_JOB_HISTORY_IR input)
	{
		if (input == null) return null;
		IEnumerable<XE_HR_JOB_HISTORY_IR>? retData;
		if (input.EMPLOYEE_ID_IR_HasBeenChanged && input.START_DATE_HasBeenChanged) retData = await GetByEMPLOYEE_IDAndSTART_DATE(input.EMPLOYEE_ID_IR ?? default, input.START_DATE ?? default);
		else if (input.DEPARTMENT_ID_IR_HasBeenChanged) retData = await GetByDEPARTMENT_ID(input.DEPARTMENT_ID_IR);
		else if (input.EMPLOYEE_ID_IR_HasBeenChanged) retData = await GetByEMPLOYEE_ID(input.EMPLOYEE_ID_IR ?? default);
		else if (input.JOB_ID_HasBeenChanged) retData = await GetByJOB_ID(input.JOB_ID ?? String.Empty);
		else retData = await GetAll();
		return retData == null ? null : retData.Where(x => WhereAllFilledFields(x, input));
	}
	private static Boolean WhereAllFilledFields(XE_HR_JOB_HISTORY_IR record, XE_HR_JOB_HISTORY_IR filter)
	{
		 // unencrypted properties only
		return			(!filter.END_DATE_HasBeenChanged || record.END_DATE == filter.END_DATE);
	}
	public async Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetAll()
	{
		var result = await _httpClient.GetAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_JOB_HISTORY/GetAll");
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_JOB_HISTORY_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByEMPLOYEE_IDAndSTART_DATE(String? eMPLOYEE_ID_IR, DateTime sTART_DATE)
	{
		var uri = GetUriForParamsEMPLOYEE_IDAndSTART_DATE("XE_HR_JOB_HISTORY/GetByEMPLOYEE_IDAndSTART_DATE", eMPLOYEE_ID_IR, sTART_DATE);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_JOB_HISTORY_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByDEPARTMENT_ID(String? dEPARTMENT_ID_IR)
	{
		var uri = GetUriForParamsDEPARTMENT_ID("XE_HR_JOB_HISTORY/GetByDEPARTMENT_ID", dEPARTMENT_ID_IR);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_JOB_HISTORY_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByEMPLOYEE_ID(String? eMPLOYEE_ID_IR)
	{
		var uri = GetUriForParamsEMPLOYEE_ID("XE_HR_JOB_HISTORY/GetByEMPLOYEE_ID", eMPLOYEE_ID_IR);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_JOB_HISTORY_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<IEnumerable<XE_HR_JOB_HISTORY_IR>?> GetByJOB_ID(String jOB_ID)
	{
		var uri = GetUriForParamsJOB_ID("XE_HR_JOB_HISTORY/GetByJOB_ID", jOB_ID);
		var result = await _httpClient.GetAsync(uri);
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<IEnumerable<XE_HR_JOB_HISTORY_IR>?>(content, _jsonSerializationSettings);
	}
	public async Task<XE_HR_JOB_HISTORY_IR?> Create(XE_HR_JOB_HISTORY_IR input)
	{
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PostAsync(_httpClient.BaseAddress!.ToString() + "XE_HR_JOB_HISTORY/Create", new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
		var content = await result.Content.ReadAsStringAsync();
		return content == String.Empty ? null : JsonConvert.DeserializeObject<XE_HR_JOB_HISTORY_IR?>(content, _jsonSerializationSettings);
	}
	public async Task UpdateByEncodedPrimaryKey(String? encodedPrimaryKey, XE_HR_JOB_HISTORY_IR updateModel)
	{
		if (encodedPrimaryKey == null || updateModel == null) return;
		var inputSplits = encodedPrimaryKey.Split((Char)27);
		await UpdateByEMPLOYEE_IDAndSTART_DATE(inputSplits[0], DateTime.Parse(inputSplits[1]), updateModel);
	}
	public async Task UpdateByEMPLOYEE_IDAndSTART_DATE(String? eMPLOYEE_ID_IR, DateTime sTART_DATE, XE_HR_JOB_HISTORY_IR input)
	{
		var uri = GetUriForParamsEMPLOYEE_IDAndSTART_DATE("XE_HR_JOB_HISTORY/UpdateByEMPLOYEE_IDAndSTART_DATE", eMPLOYEE_ID_IR, sTART_DATE);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByDEPARTMENT_ID(String? dEPARTMENT_ID_IR, XE_HR_JOB_HISTORY_IR input)
	{
		var uri = GetUriForParamsDEPARTMENT_ID("XE_HR_JOB_HISTORY/UpdateByDEPARTMENT_ID", dEPARTMENT_ID_IR);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByEMPLOYEE_ID(String? eMPLOYEE_ID_IR, XE_HR_JOB_HISTORY_IR input)
	{
		var uri = GetUriForParamsEMPLOYEE_ID("XE_HR_JOB_HISTORY/UpdateByEMPLOYEE_ID", eMPLOYEE_ID_IR);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task UpdateByJOB_ID(String jOB_ID, XE_HR_JOB_HISTORY_IR input)
	{
		var uri = GetUriForParamsJOB_ID("XE_HR_JOB_HISTORY/UpdateByJOB_ID", jOB_ID);
		var serializedInput = JsonConvert.SerializeObject(input, _jsonSerializationSettings);
		var result = await _httpClient.PutAsync(uri, new StringContent(serializedInput, Encoding.UTF8, "application/json"));
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEncodedPrimaryKey(String? input)
	{
		if (input == null) return;
		var inputSplits = input.Split((Char)27);
		await DeleteByEMPLOYEE_IDAndSTART_DATE(inputSplits[0], DateTime.Parse(inputSplits[1]));
	}
	public async Task DeleteByEMPLOYEE_IDAndSTART_DATE(String? eMPLOYEE_ID_IR, DateTime sTART_DATE)
	{
		var uri = GetUriForParamsEMPLOYEE_IDAndSTART_DATE("XE_HR_JOB_HISTORY/DeleteByEMPLOYEE_IDAndSTART_DATE", eMPLOYEE_ID_IR, sTART_DATE);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByDEPARTMENT_ID(String? dEPARTMENT_ID_IR)
	{
		var uri = GetUriForParamsDEPARTMENT_ID("XE_HR_JOB_HISTORY/DeleteByDEPARTMENT_ID", dEPARTMENT_ID_IR);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByEMPLOYEE_ID(String? eMPLOYEE_ID_IR)
	{
		var uri = GetUriForParamsEMPLOYEE_ID("XE_HR_JOB_HISTORY/DeleteByEMPLOYEE_ID", eMPLOYEE_ID_IR);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	public async Task DeleteByJOB_ID(String jOB_ID)
	{
		var uri = GetUriForParamsJOB_ID("XE_HR_JOB_HISTORY/DeleteByJOB_ID", jOB_ID);
		var result = await _httpClient.DeleteAsync(uri);
		result.EnsureSuccessStatusCode();
	}
	private String GetUriForParamsEMPLOYEE_IDAndSTART_DATE(String path, String? eMPLOYEE_ID_IR, DateTime sTART_DATE)
	{
		var query = new Dictionary<String,String>();
		query["eMPLOYEE_ID_IR"] = eMPLOYEE_ID_IR ?? String.Empty;
		query["sTART_DATE"] = sTART_DATE.ToString();
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsDEPARTMENT_ID(String path, String? dEPARTMENT_ID_IR)
	{
		var query = new Dictionary<String,String>();
		query["dEPARTMENT_ID_IR"] = dEPARTMENT_ID_IR ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsEMPLOYEE_ID(String path, String? eMPLOYEE_ID_IR)
	{
		var query = new Dictionary<String,String>();
		query["eMPLOYEE_ID_IR"] = eMPLOYEE_ID_IR ?? String.Empty;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
	private String GetUriForParamsJOB_ID(String path, String jOB_ID)
	{
		var query = new Dictionary<String,String>();
		query["jOB_ID"] = jOB_ID;
		return QueryHelpers.AddQueryString(_uriBuilder.Uri.ToString() + path, query);
	}
}