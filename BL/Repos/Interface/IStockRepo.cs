using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DAL.Entites;

namespace BL.Repos.Interface
{
    public interface IStockRepo
    {
        public Task<bool> New(Stock stock);
        public Task<bool> Update(Stock updatedStock);
        public Task<List<Stock>> AllStocks();
    }
}
