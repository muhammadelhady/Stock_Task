using BL.Repos.Interface;
using DAL.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StocksTask.Controllers
{
    public class StocksController : Controller
    {
        private readonly IStockRepo _stockRepo;

        public StocksController(IStockRepo stockRepo)
        {
            _stockRepo = stockRepo;
        }
      
    }
}
