﻿using Chat_test.Models;
using Microsoft.AspNetCore.SignalR;

namespace Chat_test.Hub
{
    public class ChatHub : Microsoft.AspNetCore.SignalR.Hub
    {
        public const string ReveiveMessage = "ReceiveMessage";
        public async Task SendMessage(ChatMessage msg)
        {
            //TODO: save msg to database
            await Clients.All.SendAsync(ReveiveMessage, msg);
        }
    }
}
