/* **** This file and its contents were generated by YouGen Sharp on (UTC) 20230307195906 on behalf of: ****
**** You Gen Software LLC ****
**** 5961 BeaconPark St ****
**** Lithia Florida 33547 United States of America ****
**** whose account is uniquely identified by: 716881407 ****
**** This file and its contents are subject to the conditions of use for the Enterprise Tier License as specified at: https://www.yougensoft.com/en/conditions-of-use. ****
**** This comment block must not be removed. ****
 */
const url_Northwind_dbo_Alphabetical_list_of_products = baseUrlSignalR_Northwind + '/Northwind_dbo_Alphabetical_list_of_products_Hub';
const connection_Northwind_dbo_Alphabetical_list_of_products = new signalR.HubConnectionBuilder()
	.withUrl(url_Northwind_dbo_Alphabetical_list_of_products)
	.configureLogging(signalR.LogLevel.Information)
	.build();
async function Start_connection_Northwind_dbo_Alphabetical_list_of_products() {
	try {
		await connection_Northwind_dbo_Alphabetical_list_of_products.start();
		console.log('SignalR Connected to url:  ' + url_Northwind_dbo_Alphabetical_list_of_products);
	} catch (error) {
		console.log(error);
		setTimeout(start_connection_Northwind_dbo_Alphabetical_list_of_products(), 5000);
	}
}
async function Stop_connection_Northwind_dbo_Alphabetical_list_of_products() {
	try {
		await connection_Northwind_dbo_Alphabetical_list_of_products.stop();
		console.log('SignalR Disconnected from url:  ' + url_Northwind_dbo_Alphabetical_list_of_products);
	} catch (error) {
		console.log(error);
	}
}
async function Northwind_dbo_Alphabetical_list_of_products_IR_GetAll() {
	try {
		let response = await connection_Northwind_dbo_Alphabetical_list_of_products.invoke('GetAll');
		// console.log(response);
		// process response
	} catch (error) {
		// console.log(error);
	}
}
