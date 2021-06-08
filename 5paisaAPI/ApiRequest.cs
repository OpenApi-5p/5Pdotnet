using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;

namespace _5paisaAPI
{
    public class ApiRequest
    {
        public static string SendApiRequest(string url, string Request)
        {
            string strresponse = "";
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";

                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    if (!string.IsNullOrEmpty(Request))
                        streamWriter.Write(Request);
                }
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        strresponse = streamReader.ReadToEnd();
                    }

                    if (httpResponse.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception(string.Format("Server error (HTTP {0}: {1}).", httpResponse.StatusCode, httpResponse.StatusDescription));
                    }

                    string[] reponseURI = httpResponse.Headers.AllKeys;
                    string CookieName = httpResponse.Headers.Get("Set-Cookie");

                    SetCookies(CookieName);
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }

            return strresponse;

        }

        public static string SendApiRequestCookies(string url, string Request, string Type = "Openapi")
        {
            string strresponse = "";
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.ContentType = "application/json";

                httpWebRequest.Method = "POST";

                if (Type.Equals("Openapi"))
                {
                    httpWebRequest.Headers.Add("Cookie", GetCookiesByName("5paisacookie"));
                }
                else if (Type.Equals("Socket"))
                {
                    httpWebRequest.Headers.Add("Cookie", GetCookiesByName("ASPXAUTH"));
                }


                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    if (!string.IsNullOrEmpty(Request))
                        streamWriter.Write(Request);
                }
                using (var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    {
                        strresponse = streamReader.ReadToEnd();
                    }

                    if (httpResponse.StatusCode != HttpStatusCode.OK)
                    {
                        throw new Exception(string.Format("Server error (HTTP {0}: {1}).", httpResponse.StatusCode, httpResponse.StatusDescription));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strresponse;

        }

        public static void SetCookies(string CookieName)
        {
            var value = CookieName.Split(';');

            string Fivepaisacookieres = Array.Find(value, ele => ele.Contains("5paisacookie", StringComparison.Ordinal));
           
            if (!string.IsNullOrEmpty(Fivepaisacookieres))
            {
                var Fivepaisacookiefinal = Fivepaisacookieres.Split('=');
                string FivepaisacookieCookieValue = "5paisacookie=" + Fivepaisacookiefinal[1];
                AddDataToXML("5paisacookie", FivepaisacookieCookieValue);
            }

            string JwtTokencookieres = Array.Find(value, ele => ele.Contains("JwtToken", StringComparison.Ordinal));
           
            if (!string.IsNullOrEmpty(JwtTokencookieres))
            {
                var JwtTokencookiefinal = JwtTokencookieres.Split('=');
                string JwtTokenCookieValue = JwtTokencookiefinal[1];
                AddDataToXML("JwtToken", JwtTokenCookieValue);
            }

            string ASPXAUTHcookieres = Array.Find(value, ele => ele.Contains(".ASPXAUTH", StringComparison.Ordinal));

            if (!string.IsNullOrEmpty(ASPXAUTHcookieres))
            {
                var ASPXAUTHcookiefinal = ASPXAUTHcookieres.Split('=');
                string ASPXAUTHCookieValue = ASPXAUTHcookiefinal[1];
                AddDataToXML("ASPXAUTH", ASPXAUTHCookieValue);
            }
        }

        public static void AddDataToXML(string Name, string Value)
        {
            string xmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "CookiesFile.xml");
            XmlTextReader xmlreader = new XmlTextReader(xmlFilePath);
            DataSet ds = new DataSet();
            ds.ReadXml(xmlreader);

            DataRow row = ds.Tables[0].Select("Name = '"+ Name + "'").FirstOrDefault();

            int xmlRow = ds.Tables[0].Rows.IndexOf(row);
            ds.Tables[0].Rows[xmlRow]["Value"] = Value;
            xmlreader.Close();

            ds.WriteXml(xmlFilePath);

        }

        public static string GetCookiesByName(string Name)
        {
            string value = string.Empty;

            string xmlFilePath = Path.Combine(Directory.GetCurrentDirectory(), "CookiesFile.xml");
            XmlTextReader xmlreader = new XmlTextReader(xmlFilePath);
            DataSet ds = new DataSet();
            ds.ReadXml(xmlreader);

            DataRow row = ds.Tables[0].Select("Name = '" + Name + "'").FirstOrDefault();

            int xmlRow = ds.Tables[0].Rows.IndexOf(row);
            value = Convert.ToString(ds.Tables[0].Rows[xmlRow]["Value"]);
            xmlreader.Close();

            return value;
        }

    }
}
