using BL.Repos.Interface;
using DAL.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNet.SignalR;

namespace BL.Repos.Implementation
{
    class StockRepo : IStockRepo
    {
        private readonly DatabaseContext _context;

        public StockRepo(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Stock>> AllStocks()
        {
            return await _context.Stocks.ToListAsync();
        }

        public async Task<bool> New(Stock stock)
        {
            try
            {
                stock.CreatedAt = DateTime.UtcNow;
                await _context.Stocks.AddAsync(stock);
            }
            catch (Exception)
            {

                throw;
            }
            bool result = await _context.SaveChangesAsync()>0;
            var context = GlobalHost.ConnectionManager.GetHubContext<GameHub>();
            context.Clients.All.addGame(game);
            return result;
        }

        public async Task<bool> Update(Stock updatedStock)
        {
            try
            {
                Stock current = await _context.Stocks.FirstOrDefaultAsync(x => x.Id == updatedStock.Id);
                if (current == null)
                    return false;

                updatedStock.ModifiedAt = DateTime.UtcNow;
                _context.Entry(current).CurrentValues.SetValues(updatedStock);
                

            }
            catch (Exception)
            {

                throw;
            }
            bool result = await _context.SaveChangesAsync() > 0;
            return result;
        }
    }
}
