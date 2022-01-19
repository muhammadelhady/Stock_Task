using BL.Repos.Interface;
using DAL.Entites;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Repos.Implementation
{
    class HangFireRepo : IHangFireRepo
    {
        private readonly IStockRepo _stockRepo;
      

        public HangFireRepo(IStockRepo stockRepo)
        {
            _stockRepo = stockRepo;
           
        }
        public async Task Generate()
        {
            try
            {
                Stock stock = new Stock();
                Random r = new Random();
                stock.StockCode = r.Next(111111, 999999).ToString();
                stock.LastPrice = r.Next(1, 100);
                stock.IsDelted = false;
                stock.OldPrice = 0;
                 await _stockRepo.New(stock);
            }
            catch (Exception)
            {

                throw;
            }
          

        }

        public async Task GenerateDummyData()
        {
            try
            {
                for (int i = 0; i < 10; i++)
                   await Generate();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task Update()
        {
            try
            {
                Random random = new Random();
                var stocks = await _stockRepo.AllStocks();
                foreach(Stock s in stocks)
                {
                    s.OldPrice = s.LastPrice;
                    s.LastPrice = random.Next(1, 100);
                    await _stockRepo.Update(s);
                }
              
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}
