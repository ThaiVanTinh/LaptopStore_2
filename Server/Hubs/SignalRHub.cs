﻿using LaptopStore.Shared.Constants.Application;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace LaptopStore.Server.Hubs
{
    public class SignalRHub : Hub
    {
        public async Task OnConnectAsync(string userId)
        {
            await Clients.All.SendAsync(ApplicationConstants.SignalR.ConnectUser, userId);
        }

        public async Task OnDisconnectAsync(string userId)
        {
            await Clients.All.SendAsync(ApplicationConstants.SignalR.DisconnectUser, userId);
        }

        public async Task OnChangeRolePermissions(string userId, string roleId)
        {
            await Clients.All.SendAsync(ApplicationConstants.SignalR.LogoutUsersByRole, userId, roleId);
        }

       
        public async Task ChatNotificationAsync(string message, string receiverUserId, string senderUserId)
        {
            await Clients.All.SendAsync(ApplicationConstants.SignalR.ReceiveChatNotification, message, receiverUserId, senderUserId);
        }

        public async Task UpdateDashboardAsync()
        {
            await Clients.All.SendAsync(ApplicationConstants.SignalR.ReceiveUpdateDashboard);
        }

        public async Task RegenerateTokensAsync()
        {
            await Clients.All.SendAsync(ApplicationConstants.SignalR.ReceiveRegenerateTokens);
        }
    }
}