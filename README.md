# Introduction
This repository contains .NET 6 solutions and projects that have been generated using tooling licensed by [YouGen Software, LLC](https://yougensoft.com). These projects are intended as example generation outputs from the YouGen Sharp procedural generation engine.

# General Steps
Each solution sample (for SQL Server or Oracle Database Server) requires the corresponding database to be hosted and running in order to debug/run the solution and evaluate its runtime. 
The database creation scripts can executed against a local or remote database server to create the corresponding database/schema objects. 
You will need administrative permissions on the target database server in order to create the database and create the required SQL grants to access its schema objects (read/write access, etc).
Once you have done so, you may open up Visual Studio 2022 (any edition) and open the solution file found at the root of each sample folder.

# Additional Notes	
You will need to modify the appSettings.*.json files to properly target your running database instance with your correct credentials (YouGen Sharp does not create nor maintain these sensitive values for you)
* BackEndDatabaseClientTests/appSettings.Test.json value of: DbConnection
* BackEndCommonTests/appSettings.Test.json value of: DbConnection
* BackEndCoreWCFServer/appSettings.Development.json value of: DbConnection
* BackEndHttpServer/appSettings.Development.json value of: DbConnection
* BackEndSignalRWebsocketServer/appSettings.Development.json value of: DbConnection
* CommonTests/appSettings.Test.json value of: DbConnection
* FrontEndCoreWCFClientTests/appSettings.Test.json value of: DbConnection
* FrontEndHttpClientTests/appSettings.Test.json value of: DbConnection
* FrontEndSignalRWebsocketClientTests/appSettings.Test.json value of: DbConnection

You will need to modify the appSettings.*.json files to customize the EncryptDecryptKey value (Each matching runtime instance of your servers/clients should employ a unique EncryptDecryptKey kept secret by you and/or your organization)
* BackEndDatabaseClientTests/appSettings.Test.json value of: EncryptDecryptKey
* BackEndCommonTests/appSettings.Test.json value of: EncryptDecryptKey
* BackEndCoreWCFServer/appSettings.Development.json value of: EncryptDecryptKey
* BackEndHttpServer/appSettings.Development.json value of: EncryptDecryptKey
* BackEndSignalRWebsocketServer/appSettings.Development.json value of: EncryptDecryptKey
* CommonTests/appSettings.Test.json value of: EncryptDecryptKey
* FrontEndCoreWCFClientTests/appSettings.Test.json value of: EncryptDecryptKey
* FrontEndHttpClientTests/appSettings.Test.json value of: EncryptDecryptKey
* FrontEndSignalRWebsocketClientTests/appSettings.Test.json value of: DbConnection

You will need to debug the HTTP/SignalR/CoreWCF server projects, discover the debug runtime port number and copy that number into the corresponding client-caller configuration to match them. The relative paths are as follows:
* FrontEndHostedWebClient/Program.cs values of: httpClientBaseAddress and websocketBaseAddress 
* FrontEndMauiClient/MauiProgram.cs values of: httpClientBaseAddress and websocketBaseAddress
* FrontEndJSCommon/HttpClientConstants.js value of: baseUrl_*_*
* FrontEndJSCommon/SignalRWebsocketClientConstants.js value of: baseUrlSignalR_*_*
* FrontEndCoreWCFClientTests/CoreWCFServiceClientTestBase.cs value of: _baseAddress
* FrontEndHttpClientTests/HttpClientTestBase.cs value of: _baseAddress
* FrontEndSignalRWebsocketClientTests/SignalRWebsocketClientTestBase.cs value of: __hubUriBase

The FrontEndCoreWCFClientTests, FrontEndHttpClientTests, and FrontEndSignalRWebsocketClientTests scoped integration/automation test projects assume you have a server already running somewhere and the above port values configured. 
If you need to run these tests locally in debug, you will need to open the solution twice in separate instances of Visual Studio 2022 and start the corresponding server project in debug, then run the test(s) desired in debug on the second instance.

	

