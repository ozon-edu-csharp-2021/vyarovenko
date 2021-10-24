﻿using OzonEdu.MerchandiseService.Models;
using System.Threading;
using System.Threading.Tasks;

namespace OzonEdu.MerchandiseService.ConsoleHttpClient
{
    public interface IMerchHttpClient
    {
        Task<string> GetLive(CancellationToken token);
        Task<GetMerchResponseModel> GetMerch(CancellationToken token);
        Task<bool> GetMerchIsIssued(CancellationToken token);
        Task<string> GetReady(CancellationToken token);
        Task<string> GetVersion(CancellationToken token);
    }
}