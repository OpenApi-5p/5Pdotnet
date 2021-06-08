using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5paisaAPI
{
   
    public class LoginRequestMobileNewbyEmailResponse
    {
        public string AllowBseCash { get; set; }
        public string AllowBseDeriv { get; set; }
        public string AllowBseMF { get; set; }
        public string AllowMCXComm { get; set; }
        public string AllowMcxSx { get; set; }
        public string AllowNSECurrency { get; set; }
        public string AllowNSEL { get; set; }
        public string AllowNseCash { get; set; }
        public string AllowNseComm { get; set; }
        public string AllowNseDeriv { get; set; }
        public string AllowNseMF { get; set; }
        public int BulkOrderAllowed { get; set; }
        public DateTime CleareDt { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public int ClientType { get; set; }
        public string DemoTrial { get; set; }
        public string EmailId { get; set; }
        public string InteractiveLocalIP { get; set; }
        public int InteractivePort { get; set; }
        public string InteractivePublicIP { get; set; }
        public int IsIDBound { get; set; }
        public int IsIDBound2 { get; set; }
        public string IsOnlyMF { get; set; }
        public int IsPLM { get; set; }
        public int IsPLMDefined { get; set; }
        public DateTime LastAccessedTime { get; set; }
        public string LastLogin { get; set; }
        public DateTime LastPasswordModify { get; set; }
        public string Message { get; set; }
        public string OTPCredentialID { get; set; }
        public int PLMsAllowed { get; set; }
        public string POAStatus { get; set; }
        public int PasswordChangeFlag { get; set; }
        public string PasswordChangeMessage { get; set; }
        public int RunningAuthorization { get; set; }
        public DateTime ServerDt { get; set; }
        public int Status { get; set; }
        public int TCPBCastPort { get; set; }
        public string TCPBcastLocalIP { get; set; }
        public string TCPBcastPublicIP { get; set; }
        public int UDPBCastPort { get; set; }
        public string UDPBcastIP { get; set; }
        public int VersionChanged { get; set; }
    }

    public class NetPositionDetail
    {
        public int BodQty { get; set; }
        public double BookedPL { get; set; }
        public double BuyAvgRate { get; set; }
        public int BuyQty { get; set; }
        public double BuyValue { get; set; }
        public string Exch { get; set; }
        public string ExchType { get; set; }
        public double LTP { get; set; }
        public int MTOM { get; set; }
        public int Multiplier { get; set; }
        public int NetQty { get; set; }
        public string OrderFor { get; set; }
        public double PreviousClose { get; set; }
        public int ScripCode { get; set; }
        public string ScripName { get; set; }
        public double SellAvgRate { get; set; }
        public int SellQty { get; set; }
        public double SellValue { get; set; }
    }

    public class NetPositionDetailResponse
    {
        public string Message { get; set; }
        public List<NetPositionDetail> NetPositionDetail { get; set; }
        public int Status { get; set; }
    }

    public class Holding
    {
        public int BseCode { get; set; }
        public double CurrentPrice { get; set; }
        public int DPQty { get; set; }
        public string Exch { get; set; }
        public string ExchType { get; set; }
        public string FullName { get; set; }
        public int NseCode { get; set; }
        public string POASigned { get; set; }
        public int PoolQty { get; set; }
        public int Quantity { get; set; }
        public int ScripMultiplier { get; set; }
        public string Symbol { get; set; }
    }

    public class OrdStatusResList
    {
        public string Exch { get; set; }
        public int ExchOrderID { get; set; }
        public DateTime ExchOrderTime { get; set; }
        public string ExchType { get; set; }
        public int OrderQty { get; set; }
        public double OrderRate { get; set; }
        public int PendingQty { get; set; }
        public int ScripCode { get; set; }
        public string Status { get; set; }
        public string Symbol { get; set; }
        public int TradedQty { get; set; }
    }

    public class OrdStatusResponse
    {
        public string Message { get; set; }
        public List<OrdStatusResList> OrdStatusReqList { get; set; }
        public int Status { get; set; }
    }

    public class HoldingRequest 
    {
        public int CacheTime { get; set; }
        public List<Holding> Data { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
    }


    public class OrderBookDetail
    {
        public string AHProcess { get; set; }
        public string AfterHours { get; set; }
        public string AtMarket { get; set; }
        public int BrokerOrderId { get; set; }
        public DateTime BrokerOrderTime { get; set; }
        public string BuySell { get; set; }
        public string DelvIntra { get; set; }
        public int DisClosedQty { get; set; }
        public string Exch { get; set; }
        public string ExchOrderID { get; set; }
        public DateTime ExchOrderTime { get; set; }
        public string ExchType { get; set; }
        public int MarketLot { get; set; }
        public int OldorderQty { get; set; }
        public string OrderRequesterCode { get; set; }
        public string OrderStatus { get; set; }
        public string OrderValidUpto { get; set; }
        public int OrderValidity { get; set; }
        public int PendingQty { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public string Reason { get; set; }
        public string RequestType { get; set; }
        public string SLTriggerRate { get; set; }
        public string SLTriggered { get; set; }
        public int SMOProfitRate { get; set; }
        public int SMOSLLimitRate { get; set; }
        public int SMOSLTriggerRate { get; set; }
        public int SMOTrailingSL { get; set; }
        public int ScripCode { get; set; }
        public string ScripName { get; set; }
        public int TerminalId { get; set; }
        public int TradedQty { get; set; }
        public string WithSL { get; set; }
    }

    public class Body
    {
        public string Message { get; set; }
        public List<OrderBookDetail> OrderBookDetail { get; set; }
        public int Status { get; set; }
    }

    public class OrderBookResponse
    {
        public string Message { get; set; }
        public List<OrderBookDetail> OrderBookDetail { get; set; }
        public int Status { get; set; }
    }

    public class EquityMargin
    {
        public double ALB { get; set; }
        public int Adhoc { get; set; }
        public double AvailableMargin { get; set; }
        public double GHV { get; set; }
        public int GHVPer { get; set; }
        public double GrossMargin { get; set; }
        public int Mgn4PendOrd { get; set; }
        public double Mgn4Position { get; set; }
        public int OptionsMtoMLoss { get; set; }
        public double PDHV { get; set; }
        public int Payments { get; set; }
        public int Receipts { get; set; }
        public double THV { get; set; }
    }

    public class MarginResponse
    {
        public string ClientCode { get; set; }
        public List<EquityMargin> EquityMargin { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public DateTime TimeStamp { get; set; }
    }


    public class TradeBookDetail
    {
        public string BuySell { get; set; }
        public string DelvIntra { get; set; }
        public string Exch { get; set; }
        public string ExchOrderID { get; set; }
        public string ExchType { get; set; }
        public string ExchangeTradeID { get; set; }
        public DateTime ExchangeTradeTime { get; set; }
        public int Multiplier { get; set; }
        public int OrgQty { get; set; }
        public int PendingQty { get; set; }
        public int Qty { get; set; }
        public double Rate { get; set; }
        public int ScripCode { get; set; }
        public string ScripName { get; set; }
        public string TradeType { get; set; }
    }

    public class TradeBookResponse
    {
        public string Message { get; set; }
        public int Status { get; set; }
        public List<TradeBookDetail> TradeBookDetail { get; set; }
    }

    public class MarketData
    {
        public string Exch { get; set; }
        public string ExchType { get; set; }
        public double High { get; set; }
        public double LastRate { get; set; }
        public double Low { get; set; }
        public double PClose { get; set; }
        public DateTime TickDt { get; set; }
        public int Time { get; set; }
        public int Token { get; set; }
        public int TotalQty { get; set; }
    }

    public class MarketFeedResponse
    {
        public int CacheTime { get; set; }
        public List<MarketData> Data { get; set; }
        public string Message { get; set; }
        public int Status { get; set; }
        public DateTime TimeStamp { get; set; }
    }


    public class OrderRequestResponse
    {
        public int BrokerOrderID { get; set; }
        public string ClientCode { get; set; }
        public string Exch { get; set; }
        public string ExchOrderID { get; set; }
        public string ExchType { get; set; }
        public int LocalOrderID { get; set; }
        public string Message { get; set; }
        public int RMSResponseCode { get; set; }
        public int ScripCode { get; set; }
        public int Status { get; set; }
        public DateTime Time { get; set; }
    }

    public class SMOOrderRequestResponse
    {
        public int AddReqMgn { get; set; }
        public int AvlbMgn { get; set; }
        public int BrokerOrderIDNormal { get; set; }
        public int BrokerOrderIDProfit { get; set; }
        public int BrokerOrderIDSL { get; set; }
        public string ClientCode { get; set; }
        public string Exch { get; set; }
        public int ExchOrderID { get; set; }
        public string ExchType { get; set; }
        public int FirstOrderPrice { get; set; }
        public int FirstOrderTriggerPrice { get; set; }
        public int LocalOrderIDNormal { get; set; }
        public int LocalOrderIDProfit { get; set; }
        public int LocalOrderIDSL { get; set; }
        public string Message { get; set; }
        public int ProfitPrice { get; set; }
        public int RMSResponseCode { get; set; }
        public int RMSStatus { get; set; }
        public int SLOrderPrice { get; set; }
        public int SLOrderTriggerPrice { get; set; }
        public int Time { get; set; }
        public int TrailingSL { get; set; }
    }

    public class ModifySMOOrderResponse
    {
        public int AddReqMgn { get; set; }
        public int AvlbMgn { get; set; }
        public int BrokerOrderID { get; set; }
        public string ClientCode { get; set; }
        public object Exch { get; set; }
        public int ExchOrderID { get; set; }
        public object ExchType { get; set; }
        public int LocalOrderID { get; set; }
        public string Message { get; set; }
        public int RMSResponseCode { get; set; }
        public int ScripCode { get; set; }
        public int Status { get; set; }
        public DateTime Time { get; set; }
    }

    public class LoginCheckResponse
    {
        public string Message { get; set; }
        public int Status { get; set; }
    }

    public class ResponseHead
    {
        public string responseCode { get; set; }
        public string status { get; set; }
        public string statusDescription { get; set; }
    }

    public class Response<T>
    {
        public T body { get; set; }
        public ResponseHead head { get; set; }
    }
}
