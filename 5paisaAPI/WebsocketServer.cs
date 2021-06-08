using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp;

namespace _5paisaAPI
{
    class WebsocketServer
    {
        public static void Connect(string uri, string cookies, string stringtoSend)
        {

            using (WebSocket ws = new WebSocket(uri))
            {
                ws.SetCookie(new WebSocketSharp.Net.Cookie(".ASPXAUTH", cookies));

                ws.OnMessage += WS_OnMessgae;

                ws.Connect();

                ws.Send(stringtoSend);

                Console.ReadKey();
            }
        }

        private static void WS_OnMessgae(object sender, MessageEventArgs e)
        {
            //Program.logRun.LogInformation("WebSocket: Response:" + e.Data);
            System.Diagnostics.Debug.WriteLine("WebSocket: Response:" + e.Data);
        }

    }
}
