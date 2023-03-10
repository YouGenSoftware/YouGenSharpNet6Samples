/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195803 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Professional Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_Northwind_dbo_Products_Above_Average_Price = baseUrlSignalR_Northwind + '/Northwind_dbo_Products_Above_Average_Price_Hub';
const connection_Northwind_dbo_Products_Above_Average_Price = new signalR.HubConnectionBuilder()
	.withUrl(url_Northwind_dbo_Products_Above_Average_Price)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_Northwind_dbo_Products_Above_Average_Price() {
	try {
		await connection_Northwind_dbo_Products_Above_Average_Price.start();
		console.log('SignalR Connected to url:  ' + url_Northwind_dbo_Products_Above_Average_Price);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_Northwind_dbo_Products_Above_Average_Price(), 5000);
	}
}
async function Stop_connection_Northwind_dbo_Products_Above_Average_Price() {
	try {
		await connection_Northwind_dbo_Products_Above_Average_Price.stop();
		console.log('SignalR Disconnected from url:  ' + url_Northwind_dbo_Products_Above_Average_Price);
	} catch (error) {
		console.log(error);
	}
}
async function Northwind_dbo_Products_Above_Average_Price_IR_GetAll() {
	try {
		let response = await connection_Northwind_dbo_Products_Above_Average_Price.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
