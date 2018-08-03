using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaintWithFriends
{
    public class PaintHub : Hub
    {
        /*public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }*/

        public async Task MoveMouse(int x, int y, bool isPainting)
        {
            await Clients.All.SendAsync("MoveMouse", x, y, isPainting);
        }

        public async Task MouseDown()
        {
            await Clients.All.SendAsync("MouseDown");
        }

        public async Task MouseUp()
        {
            await Clients.All.SendAsync("MouseUp");
        }

        public async Task ChangeColor(string color)
        {
            await Clients.All.SendAsync("ChangeColor", color);
        }

        public async Task ChangeBrushSize(int size)
        {
            await Clients.All.SendAsync("ChangeBrushSize", size);
        }

        public async Task ChangeMode(string mode)
        {
            await Clients.All.SendAsync("ChangeMode", mode);
        }
    }
}
