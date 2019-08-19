using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChatApplication.Services;
using Microsoft.AspNet.SignalR;

namespace ChatApplication.Hubs
{
    public class LiveChatHub : Hub
    {
        public void Send(string name, string message, string time)
        {
            Clients.All.broadcastMessage(name, message, time);
            DbLogService.LogData(name, message, time);
        }
    }
}