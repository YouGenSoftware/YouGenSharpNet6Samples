/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307202507 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Serialization;
using XE_HR_FrontEndSignalRWebsocketClient;
using XE_HR_FrontEndSignalRWebsocketClient.SignalRWebsocketClients;
namespace XE_HR_FrontEndSignalRWebsocketClientTests;
public class SignalRWebsocketClientTestBase
{
    protected String? _hubUriBase;
	[TestInitialize()]
    public virtual async Task Init()
    {
		_hubUriBase = "https://localhost:53181";       
	}
}
