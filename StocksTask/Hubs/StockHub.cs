using BL.Repos.Interface;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace StocksTask.Hubs
{
    public class StockHub : Hub
    {
        private readonly IStockRepo _stockRepo;

        public StockHub(IStockRepo stockRepo)
        {
            _stockRepo = stockRepo;
        }
        public async Task UpdateStocks()
        {
            while(true)
            {
                Thread.Sleep(500);
                await Clients.All.SendAsync("UpdateStocks", "test");

            }
        }
    }
}
