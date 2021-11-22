using SIDCSupplyChain.Application.Interfaces.Shared;
using System;

namespace SIDCSupplyChain.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}