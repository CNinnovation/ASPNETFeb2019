using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySignalRSample.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync() => base.OnConnectedAsync();

        public async Task Send(string name, string message)
        {
            await base.Clients.All.SendAsync("BroadcastMessage", name, message);
        }
    }
}
