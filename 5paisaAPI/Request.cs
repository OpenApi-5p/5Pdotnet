using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5paisaAPI
{

    public class ResponseModel
    {
        // public object RequestData { set; get; }
        public object ResponseData { set; get; }
    }

    public class RequestCode
    {
        public string LoginRequestMobileNewbyEmail { get; set; }
        public string NetPositionNetWise { get; set; }
        public string Holding { get; set; }
        public string OrderStatus { get; set; }
        public string TradeInformation { get; set; }
        public string TradeBook { get; set; }
        public string OrderBook { get; set; }
        public string Margin { get; set; }
        public string MarketFeed { get; set; }
        public string OrderRequest { get; set; }
        public string SMOOrderRequest { get; set; }
        public string ModifySMOOrder { get; set; }
        public string LoginCheck { get; set; }
    }
    public class Head
    {
        public string appName { get; set; }
        public string appVer { get; set; }
        public string key { get; set; }
        public string osName { get; set; }
        public string requestCode { get; set; }
        public string userId { get; set; }
        public string password { get; set; }
    }

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
    public class LoginRequestMobileNewbyEmail
    {
        private string _Email_id;
        //public string Emailid { set; get ; }
        public string Email_id { set { _Email_id = value; } get { return CommonMethod.Encrypt_Vendor(_Email_id); } }
        private string _Password;
        public string Password { set { _Password = value; } get { return CommonMethod.Encrypt_Vendor(_Password); } }
        public string LocalIP { get; set; }
        public string PublicIP { get; set; }
        public string HDSerailNumber { get; set; }
        public string MACAddress { get; set; }
        public string MachineID { get; set; }
        public string VersionNo { get; set; }
        public string RequestNo { get; set; }
        private string _My2PIN;
        public string My2PIN { set { _My2PIN = value; } get { return CommonMethod.Encrypt_Vendor(_My2PIN); } }
        public string ConnectionType { get; set; }
    }

    public class LoginRequestMobileNewbyEmailRequest
    {
        public LoginRequestMobileNewbyEmail body { get; set; }
        public Head head { get; set; }
    }

    public class Common
    {
        public string ClientCode { get; set; }
    }

    /*Request for NetPositionNetWise, Holding, OrderStatus, OrderBook, Margin*/
    public class CommonReuqest
    {
        public Head head { get; set; }
        public Common body { get; set; }
    }
    /*Request for NetPositionNetWise, Holding, OrderStatus, OrderBook, Margin*/
    public class OrdStatusReqList
    {
        public string Exch { get; set; }
        public string ExchType { get; set; }
        public int ScripCode { get; set; }
        public string RemoteOrderID { get; set; }
    }

    public class OrderStatus
    {
        public string ClientCode { get; set; }
        public List<OrdStatusReqList> OrdStatusReqList { get; set; }
    }
    public class OrderStatusRequest
    {
        public Head head { get; set; }
        public OrderStatus body { get; set; }
    }
    public class TradeInformationList
    {
        public string Exch { get; set; }
        public string ExchType { get; set; }
        public int ScripCode { get; set; }
        public string RemoteOrderID { get; set; }
    }

    public class TradeInformation
    {
        public string ClientCode { get; set; }
        public List<TradeInformationList> TradeInformationList { get; set; }
    }

    public class TradeInformationRequest
    {
        public Head head { get; set; }
        public TradeInformation body { get; set; }
    }

    public class MarketFeedData
    {
        public string Exch { get; set; }
        public string ExchType { get; set; }
        public string Symbol { get; set; }
        public string Expiry { get; set; }
        public string StrikePrice { get; set; }
        public string OptionType { get; set; }
    }

    public class MarketFeed
    {
        public int Count { get; set; }
        public List<MarketFeedData> MarketFeedData { get; set; }
        public int ClientLoginType { get; set; }
        public string LastRequestTime { get; set; }
        public string RefreshRate { get; set; }
    }

    public class MarketFeedRequest
    {
        public Head head { get; set; }
        public MarketFeed body { get; set; }
    }

    public class OrderRequest
    {
        public string ClientCode { get; set; }
        public string OrderFor { get; set; }
        public string Exchange { get; set; }
        public string ExchangeType { get; set; }
        public double Price { get; set; }
        public int OrderID { get; set; }
        public string OrderType { get; set; }
        public int Qty { get; set; }
        public string OrderDateTime { get; set; }
        public int ScripCode { get; set; }
        public bool AtMarket { get; set; }
        public string RemoteOrderID { get; set; }
        public int ExchOrderID { get; set; }
        public int DisQty { get; set; }
        public bool IsStopLossOrder { get; set; }
        public int StopLossPrice { get; set; }
        public bool IsVTD { get; set; }
        public bool IOCOrder { get; set; }
        public bool IsIntraday { get; set; }
        public string PublicIP { get; set; }
        public string AHPlaced { get; set; }
        public string ValidTillDate { get; set; }
        public int iOrderValidity { get; set; }
        public int TradedQty { get; set; }
        public string OrderRequesterCode { get; set; }
        public int AppSource { get; set; }
    }

    public class OrderRequestData
    {
        public Head head { get; set; }
        public OrderRequest body { get; set; }
    }

    public class SMOOrderRequest
    {
        public string ClientCode { get; set; }
        public string OrderRequesterCode { get; set; }
        public string RequestType { get; set; }
        public string BuySell { get; set; }
        public int Qty { get; set; }
        public string Exch { get; set; }
        public string ExchType { get; set; }
        public int DisQty { get; set; }
        public bool AtMarket { get; set; }
        public int ExchOrderId { get; set; }
        public string LimitPriceForSL { get; set; }
        public double LimitPriceInitialOrder { get; set; }
        public string TriggerPriceInitialOrder { get; set; }
        public int LimitPriceProfitOrder { get; set; }
        public double TriggerPriceForSL { get; set; }
        public int TrailingSL { get; set; }
        public int StopLoss { get; set; }
        public int ScripCode { get; set; }
        public string OrderFor { get; set; }
        public string UniqueOrderIDNormal { get; set; }
        public int UniqueOrderIDSL { get; set; }
        public int UniqueOrderIDLimit { get; set; }
        public int LocalOrderIDNormal { get; set; }
        public int LocalOrderIDSL { get; set; }
        public int LocalOrderIDLimit { get; set; }
        public string PublicIP { get; set; }
        public int TradedQty { get; set; }
        public int AppSource { get; set; }
    }

    public class SMOOrderRequestData
    {
        public Head head { get; set; }
        public SMOOrderRequest body { get; set; }
    }

    public class ModifySMOOrder
    {
        public string ClientCode { get; set; }
        public string OrderFor { get; set; }
        public string Exchange { get; set; }
        public string ExchangeType { get; set; }
        public double Price { get; set; }
        public int OrderID { get; set; }
        public string OrderType { get; set; }
        public int Qty { get; set; }
        public string OrderDateTime { get; set; }
        public int ScripCode { get; set; }
        public bool AtMarket { get; set; }
        public string RemoteOrderID { get; set; }
        public long ExchOrderID { get; set; }
        public int DisQty { get; set; }
        public int TriggerPriceForSL { get; set; }
        public bool IsStopLossOrder { get; set; }
        public bool IOCOrder { get; set; }
        public bool IsIntraday { get; set; }
        public bool IsVTD { get; set; }
        public string AHPlaced { get; set; }
        public string PublicIP { get; set; }
        public int iOrderValidity { get; set; }
        public int TradedQty { get; set; }
        public string OrderRequesterCode { get; set; }
        public int TrailingSL { get; set; }
        public int LegType { get; set; }
        public int TMOPartnerOrderID { get; set; }
        public int AppSource { get; set; }
    }

    public class ModifySMOOrderRequest
    {
        public Head head { get; set; }
        public ModifySMOOrder body { get; set; }
    }


    public class LoginCheckHead
    {
        public string requestCode { get; set; }
        public string appName { get; set; }
        public string appVer { get; set; }
        public string key { get; set; }
        public string osName { get; set; }
        public string LoginId { get; set; }
    }

    public class LoginCheckBody
    {
        public string RegistrationID { get; set; }
    }

    public class LoginCheckRequest
    {
        public LoginCheckHead head { get; set; }
        public LoginCheckBody body { get; set; }
    }


    public class SocketMarketFeedData
    {
        public string Exch { get; set; }
        public string ExchType { get; set; }
        public int ScripCode { get; set; }
    }

    public class SocketRequest
    {
        public string Method { get; set; }
        public string Operation { get; set; }
        public string ClientCode { get; set; }
        public List<SocketMarketFeedData> MarketFeedData { get; set; }
    }


    public class JsonData
    {
        public string Key { get; set; }
        public RequestCode RequestCode { get; set; }
        public Head Head { get; set; }
        public LoginRequestMobileNewbyEmail LoginRequestMobileNewbyEmail { get; set; }
        public Common Common { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public TradeInformation TradeInformation { get; set; }
        public MarketFeed MarketFeed { get; set; }
        public OrderRequest OrderRequest { get; set; }
        public SMOOrderRequest SMOOrderRequest { get; set; }
        public ModifySMOOrder ModifySMOOrder { get; set; }
        public LoginCheckHead LoginCheckhead { get; set; }
        public LoginCheckBody LoginCheckBody { get; set; }
        public SocketRequest SocketRequest { get; set; }
    }




}
