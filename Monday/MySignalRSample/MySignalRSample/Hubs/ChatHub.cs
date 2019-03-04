using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace MySignalRSample.Hubs
{
    public class ChatHub : Hub
    {
        public override Task OnConnectedAsync() => base.OnConnectedAsync();

        public async Task Send(string name, string message)
        {
            string encodedName = HtmlEncoder.Default.Encode(name);
            string encodedMessage = HtmlEncoder.Default.Encode(message);
            await base.Clients.All.SendAsync("BroadcastMessage", encodedName, encodedMessage);
        }
    }
}
