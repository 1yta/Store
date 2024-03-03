using Application.Services.Implemention;
using Application.Services.Interface;
using Barnamenevisan.Localizing.IOC;
using Domain.Interfaces;
using Infra.Data.Context;
using Infra.Data.Implemention;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Ioc
{
    public class DependencyContainer
    {
        public static void RegisterDependencies(IServiceCollection services, string connectionString)
        {
            #region Localizing

            RegisterLocalizingDependencies.Register(services, typeof(StoreContext));

            #endregion

            #region Database

            services.AddDbContext<StoreContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            #endregion

            #region Repositories
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            #endregion

            #region Services
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>(); 
            #endregion

        }
    }
}
