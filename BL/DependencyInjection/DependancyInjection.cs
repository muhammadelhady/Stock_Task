
using BL.Repos.Implementation;
using BL.Repos.Interface;
using DAL.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BL.DependencyInjection
{
    public static class DependancyInjection
    {
        public static void BL_DI(this IServiceCollection services, IConfiguration configuration)
        {

            services.DAL_DI(configuration);
            services.AddScoped<IStockRepo, StockRepo>();
            services.AddScoped<IHangFireRepo, HangFireRepo>();


        }
    }
}
