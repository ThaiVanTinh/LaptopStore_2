using LaptopStore_2.Application.Interfaces.Services;
using System;

namespace LaptopStore_2.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}