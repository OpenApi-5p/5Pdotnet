# 5paisa Market Trading APIs

## Project Requirement

1) Visual Studio 2019 (.net core 3.1)



## Ones project dependency is installed, follow following step to run the program

1) run the project
this will run in (https://localhost:44361) portal

2) in first "https://localhost:44361/api/FivepaisaAPI/LoginRequestMobileNewbyEmail" will run as it is set as start URL

3) then all API can be run by there Route Name eg.(NetPositionNetWise, Holding, OrderStatus, TradeInformation, TradeBook, OrderBook, Margin, MarketFeed, OrderRequest, SMOOrderRequest, ModifySMOOrder, WebsocketAPi)

3) In APICredentials.json files will get the user credentials eg. (Key, RequestCode, head, LoginRequestMobileNewbyEmail ...)



## location of main files

1) Controllers/FivepaisaAPIController.cs -> All API Request
2) APICredentials.json -> API Json model
3) ApiRequest.cs -> API call method
4) appsettings.json -> URLs
5) CommonMethod.cs -> Encryption method
6) CookiesFile.xml -> after login Cookies will be saved
7) Request.cs -> Request model
8) Response.cs -> Response model
9) WebsocketServer.cs -> Websocket method

## Websocket

websocket response wll be found in the output window of the visual studio
