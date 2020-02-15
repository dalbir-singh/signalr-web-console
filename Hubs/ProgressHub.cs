using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalR.WebConsole.Hubs
{
    public class ProgressHub : Hub
    {
        public string msg = "";

        public static void SendMessage(string msg, string connectionId = null)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<ProgressHub>();

            if (!string.IsNullOrEmpty(connectionId))
            {
                hubContext.Clients.Client(connectionId).sendMessage(string.Format(msg));
            }
            else
            {
                // if no connectionId specified, send to all listeners
                hubContext.Clients.All.sendMessage(string.Format(msg));
            }
        }

        public void Hello()
        {
            Clients.Caller.sendMessage("Hello from signalR!\n\n");
        }
    }
}