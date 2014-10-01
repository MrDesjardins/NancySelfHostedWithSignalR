using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace NancySelfHostedWithSignalR.SignalRHub
{
    public class ExchangeHub : Hub
    {
        public void Init(string urlHere)
        {
            Console.WriteLine(urlHere);
        }

        public void SendDataToClients(string data)
        {
            Clients.All.UpdateContent(data);
        }
    }
}
