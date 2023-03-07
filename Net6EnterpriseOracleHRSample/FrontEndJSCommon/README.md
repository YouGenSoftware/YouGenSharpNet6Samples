# XE_HR_FrontEndJSCommon
This contains Javascript/JSON analogies for indirect reference models/entities and their corresponding restful HTTP and realtime websocket clients.
# Concepts Employed
* Class Models are Javascript classes using constructors to emulate c# Indirect Reference Model classes
* HTTP Clients are javascript functions that transact with the XE_HR_BackEndHttpServer RESTful HTTP endpoint methods.
* SignalR Websocket Clients are javascript functions that transact with the @@_BackEndSignalRWebsocketServer realtime websocket API endpoints.
# 3rd Party Functionalities/Technologies/Libraries Employed
* [Axios Http Client](https://axios-http.com/)
# Additional Notes
* Using the HTTP clients which implement Axios Http Client requires adding a link reference to the Axios Http Client resources. Instructions can be found at [Axios Http Client Getting Started](https://axios-http.com/docs/intro).
* Using SignalR Core clients requires adding a link reference to the SignalR Core resources. Instructions can be foudn at [ASP.NET Core SignalR Javascript Client](https://learn.microsoft.com/en-us/aspnet/core/signalr/javascript-client).
