using Microsoft.AspNetCore.SignalR;
using System.Diagnostics;

namespace WebSocketExample.Hubs
{
    public class Chathub : Hub
    {
        public override Task OnConnectedAsync()
        {
            Debug.WriteLine($"Client connected: {Context.ConnectionId}"); 
            return base.OnConnectedAsync();
        }

        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
