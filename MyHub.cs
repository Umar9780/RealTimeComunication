namespace DemoApp
{
    using DemoApp.Models;
    using Microsoft.AspNetCore.SignalR;
    using System.Threading.Tasks;

    public class MyHub : Hub
    {
        public async Task SendMessage(User user)
        {

            await Clients.Client(user.Id.ToString()).SendAsync("Notification", user);
        }
    }

}
