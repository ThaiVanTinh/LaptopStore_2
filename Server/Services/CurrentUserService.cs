using LaptopStore.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace LaptopStore.Server.Services
{
    public class CurrentUserService : ICurrentUserService
    {
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            var user = httpContextAccessor.HttpContext?.User;
            UserId = user?.FindFirstValue(ClaimTypes.NameIdentifier);
            Claims = user?.Claims.Select(item => new KeyValuePair<string, string>(item.Type, item.Value)).ToList() ?? new List<KeyValuePair<string, string>>(); // Lấy Claims của người dùng
        }

        public string UserId { get; }
        public List<KeyValuePair<string, string>> Claims { get; set; }
    }
}
