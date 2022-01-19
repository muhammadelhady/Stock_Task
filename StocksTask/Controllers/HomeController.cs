using BL.Repos.Interface;
using DAL.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StocksTask.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StocksTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStockRepo _stockRepo;

        public HomeController(ILogger<HomeController> logger, IStockRepo stockRepo)
        {
            _logger = logger;
            _stockRepo = stockRepo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        public async Task<List<Stock>> getStocks()
        {
            return await _stockRepo.AllStocks();
        }
    }
}
