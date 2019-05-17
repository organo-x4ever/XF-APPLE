
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Organo.Solutions.XF3.X4Ever.MobileAppService.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessageAsync(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
