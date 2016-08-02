using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace signalT
{
    public class SignalRChat:Hub
    {
        public void NewContosoChatMessage(string name, string message)
        {
            Clients.All.addContosoChatMessageToPage(name, message);
        }
    }
}