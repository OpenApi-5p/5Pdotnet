using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;
using System.Data;

namespace _5paisaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FivepaisaAPIController : ControllerBase
    {
        private readonly JsonData _JsonData;
        private readonly string _MyKey, _OpenAPIURL, _LoginRequestMobileNewbyEmail,
            _NetPositionNetWise, _Holding, _OrderStatus, _TradeInformation, _OrderBook,
            _TradeBook, _Margin, _MarketFeed, _OrderRequest, _SMOOrderRequest, _ModifySMOOrder, _OpenAPIFeedURL, _LoginCheck, _WbSocketURl;

        public FivepaisaAPIController(IConfiguration _iConfig)
        {
            var folderDetails = Path.Combine(Directory.GetCurrentDirectory(), "APICredentials.json");
            var JSON = System.IO.File.ReadAllText(folderDetails);

            _JsonData = JsonConvert.DeserializeObject<JsonData>(JSON);

            _OpenAPIURL = _iConfig.GetValue<string>("APIDetails:OpenAPIURL");

            _LoginRequestMobileNewbyEmail = _OpenAPIURL + _iConfig.GetValue<string>("APIDetails:LoginRequestMobileNewbyEmail");
            _NetPositionNetWise = _OpenAPIURL + _iConfig.GetValue<string>("APIDetails:NetPositionNetWise");
            _Holding = _OpenAPIURL + _iConfig.GetValue<string>("APIDetails:Holding");
            _OrderStatus = _OpenAPIURL + _iConfig.GetValue<string>("APIDetails:OrderStatus");
            _TradeInformation = _OpenAPIURL + _iConfig.GetValue<string>("APIDetails:TradeInformation");
            _OrderBook = _OpenAPIURL + _iConfig.GetValue<string>("APIDetails:OrderBook");
            _TradeBook = _OpenAPIURL + _iConfig.GetValue<string>("APIDetails:TradeBook");
            _Margin = _OpenAPIURL + _iConfig.GetValue<string>("APIDetails:Margin");
            _MarketFeed = _OpenAPIURL + _iConfig.GetValue<string>("APIDetails:MarketFeed");
            _OrderRequest = _OpenAPIURL + _iConfig.GetValue<string>("APIDetails:OrderRequest");
            _SMOOrderRequest = _OpenAPIURL + _iConfig.GetValue<string>("APIDetails:SMOOrderRequest");
            _ModifySMOOrder = _OpenAPIURL + _iConfig.GetValue<string>("APIDetails:SMOOrderRequest");

            _OpenAPIFeedURL = _iConfig.GetValue<string>("APIDetails:OpenAPIFeedURL");
            _LoginCheck = _OpenAPIFeedURL + _iConfig.GetValue<string>("APIDetails:LoginCheck");
            _WbSocketURl = _iConfig.GetValue<string>("APIDetails:WbSocketURl");

        }

        [HttpGet]
        [Route("LoginRequestMobileNewbyEmail")]
        public ResponseModel LoginRequestMobileNewbyEmail()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                CommonMethod commonMethod = new CommonMethod(_JsonData.Key);

                _JsonData.Head.requestCode = _JsonData.RequestCode.LoginRequestMobileNewbyEmail;

                LoginRequestMobileNewbyEmailRequest Request = new LoginRequestMobileNewbyEmailRequest
                {
                    head = _JsonData.Head,
                    body = _JsonData.LoginRequestMobileNewbyEmail
                };

                string response = ApiRequest.SendApiRequest(_LoginRequestMobileNewbyEmail, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<LoginRequestMobileNewbyEmailResponse>>(response);

            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }

        [HttpGet]
        [Route("NetPositionNetWise")]
        public ResponseModel NetPositionNetWise()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                _JsonData.Head.requestCode = _JsonData.RequestCode.NetPositionNetWise;

                CommonReuqest Request = new CommonReuqest
                {
                    head = _JsonData.Head,
                    body = _JsonData.Common
                };

                string response = ApiRequest.SendApiRequestCookies(_NetPositionNetWise, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<NetPositionDetailResponse>>(response);
            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }

        [HttpGet]
        [Route("Holding")]
        public ResponseModel Holding()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                _JsonData.Head.requestCode = _JsonData.RequestCode.Holding;

                CommonReuqest Request = new CommonReuqest
                {
                    head = _JsonData.Head,
                    body = _JsonData.Common
                };

                string response = ApiRequest.SendApiRequestCookies(_Holding, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<object>>(response);
            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }

        [HttpGet]
        [Route("OrderStatus")]
        public ResponseModel OrderStatus()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                _JsonData.Head.requestCode = _JsonData.RequestCode.OrderStatus;
                _JsonData.OrderStatus.ClientCode = _JsonData.Common.ClientCode;

                OrderStatusRequest Request = new OrderStatusRequest
                {
                    head = _JsonData.Head,
                    body = _JsonData.OrderStatus
                };

                string response = ApiRequest.SendApiRequestCookies(_OrderStatus, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<OrdStatusResponse>>(response);
            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }

        [HttpGet]
        [Route("TradeInformation")]// Remaining the response
        public ResponseModel TradeInformation()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                _JsonData.Head.requestCode = _JsonData.RequestCode.TradeInformation;
                _JsonData.TradeInformation.ClientCode = _JsonData.Common.ClientCode;

                TradeInformationRequest Request = new TradeInformationRequest
                {
                    head = _JsonData.Head,
                    body = _JsonData.TradeInformation
                };

                string response = ApiRequest.SendApiRequestCookies(_TradeInformation, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<object>>(response);
            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }

        [HttpGet]
        [Route("TradeBook")]
        public ResponseModel TradeBook()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                _JsonData.Head.requestCode = _JsonData.RequestCode.TradeBook;

                CommonReuqest Request = new CommonReuqest
                {
                    head = _JsonData.Head,
                    body = _JsonData.Common
                };

                string response = ApiRequest.SendApiRequestCookies(_TradeBook, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<TradeBookResponse>>(response);
            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }

        [HttpGet]
        [Route("OrderBook")]
        public ResponseModel OrderBook()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                _JsonData.Head.requestCode = _JsonData.RequestCode.OrderBook;

                CommonReuqest Request = new CommonReuqest
                {
                    head = _JsonData.Head,
                    body = _JsonData.Common
                };

                string response = ApiRequest.SendApiRequestCookies(_OrderBook, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<OrderBookResponse>>(response);
            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }

        [HttpGet]
        [Route("Margin")]
        public ResponseModel Margin()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                _JsonData.Head.requestCode = _JsonData.RequestCode.Margin;

                CommonReuqest Request = new CommonReuqest
                {
                    head = _JsonData.Head,
                    body = _JsonData.Common
                };

                string response = ApiRequest.SendApiRequestCookies(_Margin, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<MarginResponse>>(response);
            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }

        [HttpGet]
        [Route("MarketFeed")]
        public ResponseModel MarketFeed()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                _JsonData.Head.requestCode = _JsonData.RequestCode.MarketFeed;

                MarketFeedRequest Request = new MarketFeedRequest
                {
                    head = _JsonData.Head,
                    body = _JsonData.MarketFeed
                };

                string response = ApiRequest.SendApiRequestCookies(_MarketFeed, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<MarketFeedResponse>>(response);
            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }

        [HttpGet]
        [Route("OrderRequest")]
        public ResponseModel OrderRequest()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                _JsonData.Head.requestCode = _JsonData.RequestCode.OrderRequest;
                _JsonData.OrderRequest.ClientCode = _JsonData.Common.ClientCode;
                _JsonData.OrderRequest.OrderRequesterCode = _JsonData.Common.ClientCode;

                OrderRequestData Request = new OrderRequestData
                {
                    head = _JsonData.Head,
                    body = _JsonData.OrderRequest
                };

                string response = ApiRequest.SendApiRequestCookies(_OrderRequest, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<OrderRequestResponse>>(response);
            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }

        [HttpGet]
        [Route("SMOOrderRequest")]
        public ResponseModel SMOOrderRequest()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                _JsonData.Head.requestCode = _JsonData.RequestCode.SMOOrderRequest;
                _JsonData.SMOOrderRequest.ClientCode = _JsonData.Common.ClientCode;
                _JsonData.SMOOrderRequest.OrderRequesterCode = _JsonData.Common.ClientCode;

                SMOOrderRequestData Request = new SMOOrderRequestData
                {
                    head = _JsonData.Head,
                    body = _JsonData.SMOOrderRequest
                };

                string response = ApiRequest.SendApiRequestCookies(_SMOOrderRequest, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<SMOOrderRequestResponse>>(response);
            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }

        [HttpGet]
        [Route("ModifySMOOrder")]
        public ResponseModel ModifySMOOrder()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                _JsonData.Head.requestCode = _JsonData.RequestCode.ModifySMOOrder;
                _JsonData.ModifySMOOrder.ClientCode = _JsonData.Common.ClientCode;
                _JsonData.ModifySMOOrder.OrderRequesterCode = _JsonData.Common.ClientCode;

                ModifySMOOrderRequest Request = new ModifySMOOrderRequest
                {
                    head = _JsonData.Head,
                    body = _JsonData.ModifySMOOrder
                };

                string response = ApiRequest.SendApiRequestCookies(_ModifySMOOrder, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<ModifySMOOrderResponse>>(response);
            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }


        [HttpGet]
        [Route("WebsocketAPi")]
        public ResponseModel WebsocketAPi()
        {
            ResponseModel objResponseModel = new ResponseModel();
            try
            {
                _JsonData.LoginCheckhead.requestCode = _JsonData.RequestCode.LoginCheck;
                _JsonData.LoginCheckhead.LoginId = _JsonData.Common.ClientCode;
                _JsonData.LoginCheckBody.RegistrationID = ApiRequest.GetCookiesByName("JwtToken");


                LoginCheckRequest Request = new LoginCheckRequest
                {
                    head = _JsonData.LoginCheckhead,
                    body = _JsonData.LoginCheckBody
                };

                string response = ApiRequest.SendApiRequest(_LoginCheck, JsonConvert.SerializeObject(Request));

                objResponseModel.ResponseData = JsonConvert.DeserializeObject<Response<LoginCheckResponse>>(response);

                //Program.logRun.LogInformation("WebSocket: reuquestBody:" + JsonConvert.SerializeObject(_JsonData.SocketRequest));
                System.Diagnostics.Debug.WriteLine("WebSocket: reuquestBody:" + JsonConvert.SerializeObject(_JsonData.SocketRequest));

                WebsocketServer.Connect(_WbSocketURl + ApiRequest.GetCookiesByName("JwtToken") + "|" + _JsonData.Common.ClientCode,
                    ApiRequest.GetCookiesByName("ASPXAUTH"), JsonConvert.SerializeObject(_JsonData.SocketRequest));

            }
            catch (Exception)
            {
                throw;
            }

            return objResponseModel;
        }

    }
}
